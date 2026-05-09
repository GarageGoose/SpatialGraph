using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
namespace GG.NodeGraph.Plugin;

/// <summary>
/// Adds plugin support for the base graph.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class GraphExtendable<TNode> : IGraph<TNode> where TNode : struct, INode
{
    /// <param name="baseGraph">Base graph to extend from. Modifying the base graph directly is not recommended and should
    /// only be done through this graph as changes may not be reflected through the plugins.</param>
    /// <param name="modificationsOnBaseGraph">Determine if the base graph does its own modification on its graph when modifying it.
    /// This applies additional checks on the base graph after modifying it to make sure that it is recorded.
    /// Do note that it may be expensive depeding on the size of the graph.</param>
    public GraphExtendable(ITrackedGraph<TNode> baseGraph, bool modificationsOnBaseGraph)
    {
        BaseGraph = baseGraph;
        Plugins = new(baseGraph);
        Modification = new(BaseGraph, Plugins);
    }

    readonly ITrackedGraph<TNode> BaseGraph;
    public IReadOnlyDictionary<uint, TNode> Nodes => BaseGraph.Nodes;
    public IReadOnlyDictionary<uint, Edge> Edges => BaseGraph.Edges;
    public uint GenerateID(out uint ID) => BaseGraph.GenerateID(out ID);


    //---Plugin stuff---
    private PluginHandler<TNode> Plugins;
    internal void AddPlugin(GraphPlugin<TNode> Plugin, int Index) => Plugins.AddPlugin(Plugin, Index);

    /// <summary>
    /// Plugins connected to this graph. The order of plugins here is used when updating plugins of events. Plugins may be connected through their constructors. 
    /// </summary>
    public IReadOnlyList<GraphPlugin<TNode>> GetPlugins() => Plugins.plugins;
    public void RearrangePlugin(int oldIndex, int newIndex) => Plugins.plugins.Move(oldIndex, newIndex);
    public bool DisconnectPlugin(GraphPlugin<TNode> plugin) => Plugins.plugins.Remove(plugin);


    //---Modification stuff---
    private ModificationHandler<TNode> Modification;
    /// <summary>
    /// Hold any incoming modifications on a graph. Used for aggregating modifications for single processing in bulk which could save on performance.
    /// Use ReleaseModifications() to apply incoming modifications. 
    /// </summary>
    public void HoldModifications() => Modification.HoldModifications();

    /// <summary>
    /// Applies pending modifications on a graph. Use HoldModifications() to hold incoming modifications on the graph.
    /// Used for aggregating modifications for single processing in bulk which could save on performance.
    /// </summary>
    public void ReleaseModifications() => Modification.ReleaseModifications();

    /// <summary>
    /// Check if modifications are on hold. False on default. 
    /// </summary>
    public void ModificationOnHold() => Modification.ModificationOnHold();
    public void AggregatedModifications(BatchedModifications<TNode> Modifications) => Modification.AggregatedModification(Modifications);
    public void UpsertNode(TNode Nodes) => Modification.UpsertNode(Nodes);
    public bool RemoveNode(uint IDs) => Modification.RemoveNode(IDs);
    public void UpsertEdge(Edge Edges) => Modification.UpsertEdge(Edges);
    public bool RemoveEdge(uint IDs) => Modification.RemoveEdge(IDs);
    public void ApplyBatchedModifications(BatchedModifications<TNode> batchedModifications) => Modification.AggregatedModification(batchedModifications);
}

internal class PluginHandler<TNode> where TNode : struct, INode
{
    internal ObservableCollection<GraphPlugin<TNode>> plugins = new();
    public PluginHandler(ITrackedGraph<TNode> baseGraph)
    {
        plugins.CollectionChanged += CollectionChanged;
        baseGraph.GraphModified += InvokeOnModificationApplied;
    }

    internal void AddPlugin(GraphPlugin<TNode> Plugin, int Index)
    {
        if(Index == -1)
        {
            plugins.Add(Plugin);
            return;
        }
        plugins.Insert(Index, Plugin);
    }

    private void CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        if(e.NewItems != null)
        {
            foreach(GraphPlugin<TNode> NewPlugins in e.NewItems)
            {
                NewPlugins.OnInitialize();
            }
        }
        if(e.OldItems != null)
        {
            foreach(GraphPlugin<TNode> NewPlugins in e.OldItems)
            {
                NewPlugins.OnDisconnection();
            }
        }
    }

    internal void InvokeOnModificationInitialize()
    {
        foreach(GraphPlugin<TNode> plugin in plugins)
        {
            plugin.OnModificationInitialize();
        }
    }

    internal void InvokeOnModification(ModificationLog<TNode> Modifications)
    {
        foreach(GraphPlugin<TNode> plugin in plugins)
        {
            plugin.OnModification(Modifications);
        }
    }

    internal void InvokeOnModificationApplied(object? sender, IReadOnlyModificationLog<TNode> Modifications)
    {
        foreach(GraphPlugin<TNode> plugin in plugins)
        {
            plugin.OnModificationApplied(Modifications);
        }
    }
}

internal class ModificationHandler<TNode> where TNode : struct, INode
{
    public ModificationHandler(IGraph<TNode> baseGraph, PluginHandler<TNode> plugins)
    {
        BaseGraph = baseGraph;
        this.plugins = plugins;
    }
    readonly IGraph<TNode> BaseGraph;
    internal PluginHandler<TNode> plugins;

    bool IsModificationsOnHold = false;
    
    BatchedModifications<TNode> ModificationsOnHold = new();

    public void HoldModifications() => IsModificationsOnHold = true;

    public void ReleaseModifications()
    {
        IsModificationsOnHold = false;
        ModificationLog<TNode> Modifications = new(BaseGraph, ModificationsOnHold);
        ModificationInitiate(Modifications);
        ModificationsOnHold = new();
    }

    public bool ModificationOnHold() => IsModificationsOnHold;

    public void UpsertNode(TNode Node)
    {
        if (IsModificationsOnHold)
        {
            ModificationsOnHold.Nodes[Node.ID] = Node;
            return;
        }
        ModificationLog<TNode> Modification = new(BaseGraph);
        Modification.Nodes[Node.ID] = Node;
        ModificationInitiate(Modification);
    }

    public bool RemoveNode(uint ID)
    {
        if (IsModificationsOnHold)
        {
            ModificationsOnHold.Nodes[ID] = null;
            return true;
        }
        ModificationLog<TNode> Modification = new(BaseGraph);
        Modification.Nodes[ID] = null;
        ModificationInitiate(Modification);
        return true;
    }

    public void UpsertEdge(Edge Edge)
    {
        if (IsModificationsOnHold)
        {
            ModificationsOnHold.Edges[Edge.ID] = Edge;
            return;
        }
        ModificationLog<TNode> Modification = new(BaseGraph);
        Modification.Edges[Edge.ID] = Edge;
        ModificationInitiate(Modification);
    }

    public bool RemoveEdge(uint ID)
    {
        if (IsModificationsOnHold)
        {
            ModificationsOnHold.Edges[ID] = null;
            return true;
        }
        ModificationLog<TNode> Modification = new(BaseGraph);
        Modification.Edges[ID] = null;
        ModificationInitiate(Modification);
        return true;
    }

    public void AggregatedModification(BatchedModifications<TNode> Modification)
    {
        if (IsModificationsOnHold)
        {
            ModificationsOnHold.Nodes.Union(Modification.Nodes);
            ModificationsOnHold.Edges.Union(Modification.Edges);
            return;
        }
        ModificationInitiate(new(BaseGraph, Modification));
    }

    //Handles event updates to the plugins and application of the modifications.
    void ModificationInitiate(ModificationLog<TNode> Modification)
    {
        //Notify all connected plugins before initiating a modification
        plugins.InvokeOnModificationInitialize();

        //Allows plugins to do their own modifications
        plugins.InvokeOnModification(Modification);
        
        //Apply the modifications to the base graph
        BaseGraph.ApplyBatchedModifications(Modification);
    }
}