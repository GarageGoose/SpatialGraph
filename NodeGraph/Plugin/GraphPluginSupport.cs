using System.Collections.ObjectModel;
using System.Collections.Specialized;
namespace GG.NodeGraph.Plugin;

/// <summary>
/// Add plugin support for the base graph.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class GraphExtendable<TNode> : IGraph<TNode> where TNode : struct, INode
{
    /// <param name="baseGraph">Base graph to extend from. Modifying the base graph directly is not recommended and should
    /// only be done through this graph as changes may not be reflected through the plugins.</param>
    /// <param name="modificationsOnBaseGraph">Determine if the base graph does its own modification on its graph when modifying it.
    /// This applies additional checks on the base graph after modifying it to make sure that it is recorded.
    /// Do note that it may be expensive depeding on the size of the graph.</param>
    public GraphExtendable(IGraph<TNode> baseGraph, bool modificationsOnBaseGraph)
    {
        BaseGraph = baseGraph;
        Plugins = new();
        Modification = new(BaseGraph, Plugins.plugins);
    }

    readonly IGraph<TNode> BaseGraph;
    public IReadOnlyDictionary<uint, TNode> Nodes => BaseGraph.Nodes;
    public IReadOnlyDictionary<uint, Edge> Edges => BaseGraph.Edges;
    public uint GenerateID() => BaseGraph.GenerateID();


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
    public bool ModificationOnHold() => Modification.ModificationOnHold();
    public void AggregatedModifications(ModificationAggregator<TNode> Modifications) => Modification.AggregatedModification(Modifications);
    public void SetNode(TNode Vertex) => Modification.SetNode(Vertex);
    public void SetNode(IEnumerable<TNode> Nodes) => Modification.SetMultipleNodes(Nodes);
    public bool RemoveNode(uint ID) => Modification.RemoveNode(ID);
    public void RemoveNode(IEnumerable<uint> IDs) => Modification.RemoveMultipleNodes(IDs);
    public void SetEdge(Edge Edge) => Modification.SetEdge(Edge);
    public void SetEdge(IEnumerable<Edge> Edges) => Modification.SetMultipleEdges(Edges);
    public bool RemoveEdge(uint ID) => Modification.RemoveEdge(ID);
    public void RemoveEdge(IEnumerable<uint> IDs) => Modification.RemoveMultipleEdges(IDs);
}

internal class PluginHandler<TNode> where TNode : struct, INode
{
    internal ObservableCollection<GraphPlugin<TNode>> plugins = new();
    public PluginHandler()
    {
        plugins.CollectionChanged += CollectionChanged;
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
}

internal class ModificationHandler<TNode> where TNode : struct, INode
{
    public ModificationHandler(IGraph<TNode> baseGraph, ObservableCollection<GraphPlugin<TNode>> plugins)
    {
        BaseGraph = baseGraph;
        this.plugins = plugins;
    }
    readonly IGraph<TNode> BaseGraph;
    internal ObservableCollection<GraphPlugin<TNode>> plugins = new();

    bool IsModificationsOnHold = false;
    
    ModificationAggregator<TNode> ModificationsOnHold = new();

    public void HoldModifications() => IsModificationsOnHold = true;

    public void ReleaseModifications()
    {
        IsModificationsOnHold = false;
        ModificationLog<TNode> Modifications = new(BaseGraph, ModificationsOnHold);
        ModificationInitiate(Modifications);
        ModificationsOnHold = new();
    }

    public bool ModificationOnHold() => IsModificationsOnHold;

    public void SetNode(TNode Node)
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

    public void SetMultipleNodes(IEnumerable<TNode> Vertices)
    {
        if (IsModificationsOnHold)
        {
            foreach(TNode Node in Vertices)
            {
                ModificationsOnHold.Nodes[Node.ID] = Node;
            }
            return;
        }
        ModificationLog<TNode> Modification = new(BaseGraph);
        foreach(TNode Node in Vertices)
        {
            Modification.Nodes[Node.ID] = Node;
        }
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

    public void RemoveMultipleNodes(IEnumerable<uint> IDs)
    {
        if(IsModificationsOnHold)
        {
            foreach(uint ID in IDs)
            {
                ModificationsOnHold.Nodes[ID] = null;
            }
            return;
        }
        ModificationLog<TNode> Modification = new(BaseGraph);
        foreach(uint ID in IDs)
        {
            Modification.Nodes[ID] = null;
        }
        ModificationInitiate(Modification);
    }

    public void SetEdge(Edge Edge)
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

    public void SetMultipleEdges(IEnumerable<Edge> Edges)
    {
        if (IsModificationsOnHold)
        {
            foreach(Edge Edge in Edges)
            {
                ModificationsOnHold.Edges[Edge.ID] = Edge;
            }
            return;
        }
        ModificationLog<TNode> Modification = new(BaseGraph);
        foreach(Edge Edge in Edges)
        {
            Modification.Edges[Edge.ID] = Edge;
        }
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

    public void RemoveMultipleEdges(IEnumerable<uint> IDs)
    {
        if (IsModificationsOnHold)
        {
            foreach(uint ID in IDs)
            {
                ModificationsOnHold.Edges[ID] = null;
            }
            return;
        }
        ModificationLog<TNode> Modification = new(BaseGraph);
        foreach(uint ID in IDs)
        {
            Modification.Edges[ID] = null;
        }
        ModificationInitiate(Modification);
    }

    public void AggregatedModification(ModificationAggregator<TNode> Modification)
    {
        if (IsModificationsOnHold)
        {
            ModificationsOnHold.Nodes.Union(Modification.Nodes);
            ModificationsOnHold.Edges.Union(Modification.Edges);
            return;
        }
        ModificationInitiate(new(BaseGraph, Modification));
    }

    void ModificationInitiate(ModificationLog<TNode> Modification)
    {
        //Notify all connected plugins before initiating a modification
        foreach(GraphPlugin<TNode> plugin in plugins)
        {
            plugin.OnModificationInitialize();
        }

        //Allows plugins to do their own modifications
        foreach(GraphPlugin<TNode> plugin in plugins)
        {
            plugin.OnModification(Modification);
        }
        
        //Apply the modifications to the base graph
        HashSet<TNode> NodeSet = new();
        HashSet<uint> NodeDelete = new();
        foreach(KeyValuePair<uint, TNode?> vertices in Modification.Nodes)
        {
            if(vertices.Value != null)
            {
                NodeSet.Add((TNode)vertices.Value);
            }
            else
            {
                NodeDelete.Add(vertices.Key);
            }
        }
        BaseGraph.SetNode(NodeSet);
        BaseGraph.RemoveNode(NodeDelete);

        HashSet<Edge> EdgeSet = new();
        HashSet<uint> EdgeDelete = new();
        foreach(KeyValuePair<uint, Edge?> edge in Modification.Edges)
        {
            if(edge.Value != null)
            {
                EdgeSet.Add((Edge)edge.Value);
            }
            else
            {
                EdgeDelete.Add(edge.Key);
            }
            
        }
        BaseGraph.SetEdge(EdgeSet);
        BaseGraph.RemoveEdge(EdgeDelete);

        //Notify plugins after the modificaitions are complete.
        foreach(GraphPlugin<TNode> plugin in plugins)
        {
            plugin.OnModificationFinished(Modification);
        }
    }
}