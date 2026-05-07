using System.Collections.ObjectModel;
using System.Collections.Specialized;
namespace GG.NodeGraph.Plugin;

//Don't let perfect be the enemy of the good.
//TODO: refactor this giant class

/// <summary>
/// Add plugin support for the base graph.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class GraphExtendable<TNode> : IGraph<TNode> where TNode : struct, Node
{
    readonly IGraph<TNode> BaseGraph;

    /// <param name="baseGraph">Base graph to extend from. Modifying the base graph directly is not recommended and should
    /// only be done through this graph as changes may not be reflected through the plugins.</param>
    /// <param name="modificationsOnBaseGraph">Determine if the base graph does its own modification on its graph when modifying it.
    /// This applies additional checks on the base graph after modifying it to make sure that it is recorded.
    /// Do note that it may be expensive depeding on the size of the graph.</param>
    public GraphExtendable(IGraph<TNode> baseGraph, bool modificationsOnBaseGraph)
    {
        BaseGraph = baseGraph;
        plugins.CollectionChanged += CollectionChanged;
        Plugins = plugins;
    }

    /// <summary>
    /// Plugins connected to this graph. The order of plugins here is used when updating plugins of events. Plugins may be connected through their constructors. 
    /// </summary>
    public readonly IReadOnlyList<GraphPlugin<TNode>> Plugins;
    internal ObservableCollection<GraphPlugin<TNode>> plugins = new();

    public IReadOnlyDictionary<uint, TNode> Nodes => BaseGraph.Nodes;
    public IReadOnlyDictionary<uint, Edge> Edges => BaseGraph.Edges;

    public void RearrangePlugin(int oldIndex, int newIndex) => plugins.Move(oldIndex, newIndex);
    public bool DisconnectPlugin(GraphPlugin<TNode> plugin) => plugins.Remove(plugin);

    bool IsModificationsOnHold = false;
    ModificationAggregator<TNode> ModificationsOnHold = new();

    /// <summary>
    /// Hold any incoming modifications on a graph. Used for single processing of modifications in bulk which could save on performance.
    /// Use ReleaseModifications() to apply incoming modifications. 
    /// </summary>
    public void HoldModifications() => IsModificationsOnHold = true;

    /// <summary>
    /// Applies pending modifications on a graph. Use HoldModifications() to hold incoming modifications on the graph.
    /// Used for single processing of modifications in bulk which could save on performance.
    /// </summary>
    public void ReleaseModifications()
    {
        IsModificationsOnHold = false;
        ModificationLog<TNode> Modifications = new(BaseGraph, ModificationsOnHold);
        ModificationInitiate(Modifications);
        ModificationsOnHold = new();
    }

    public bool ModificationOnHold() => IsModificationsOnHold;

    //Update plugins when it's added or removed.
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

    public void SetNode(TNode Node)
    {
        if (IsModificationsOnHold)
        {
            ModificationsOnHold.Nodes[Node.ID] = Node;
        }
        else
        {
            ModificationLog<TNode> Modification = new(BaseGraph);
            Modification.Nodes[Node.ID] = Node;
            ModificationInitiate(Modification);
        }
    }

    public void SetNode(IEnumerable<TNode> Vertices)
    {
        if (IsModificationsOnHold)
        {
            foreach(TNode Node in Vertices)
            {
                ModificationsOnHold.Nodes[Node.ID] = Node;
            }
        }
        else
        {
            ModificationLog<TNode> Modification = new(BaseGraph);
            foreach(TNode Node in Vertices)
            {
                Modification.Nodes[Node.ID] = Node;
            }
            ModificationInitiate(Modification);
        }
    }

    public bool RemoveNode(uint ID)
    {
        if (IsModificationsOnHold)
        {
            ModificationsOnHold.Nodes[ID] = null;
            return true;
        }
        else
        {
            ModificationLog<TNode> Modification = new(BaseGraph);
            Modification.Nodes[ID] = null;
            ModificationInitiate(Modification);
            return true;
        }
    }

    public void RemoveNode(IEnumerable<uint> IDs)
    {
        if(IsModificationsOnHold)
        {
            foreach(uint ID in IDs)
            {
                ModificationsOnHold.Nodes[ID] = null;
            }
        }
        else
        {
            ModificationLog<TNode> Modification = new(BaseGraph);
            foreach(uint ID in IDs)
            {
                Modification.Nodes[ID] = null;
            }
            ModificationInitiate(Modification);
        }
    }

    public void SetEdge(Edge Edge)
    {
        if (IsModificationsOnHold)
        {
            ModificationsOnHold.Edges[Edge.ID] = Edge;
        }
        else
        {
            ModificationLog<TNode> Modification = new(BaseGraph);
            Modification.Edges[Edge.ID] = Edge;
            ModificationInitiate(Modification);
        }
    }

    public void SetEdge(IEnumerable<Edge> Edges)
    {
        if (IsModificationsOnHold)
        {
            foreach(Edge Edge in Edges)
            {
                ModificationsOnHold.Edges[Edge.ID] = Edge;
            }
        }
        else
        {
            ModificationLog<TNode> Modification = new(BaseGraph);
            foreach(Edge Edge in Edges)
            {
                Modification.Edges[Edge.ID] = Edge;
            }
            ModificationInitiate(Modification);
        }
    }

    public bool RemoveEdge(uint ID)
    {
        if (IsModificationsOnHold)
        {
            ModificationsOnHold.Edges[ID] = null;
            return true;
        }
        else
        {
            ModificationLog<TNode> Modification = new(BaseGraph);
            Modification.Edges[ID] = null;
            ModificationInitiate(Modification);
            return true;
        }
    }

    public void RemoveEdge(IEnumerable<uint> IDs)
    {
        if (IsModificationsOnHold)
        {
            foreach(uint ID in IDs)
            {
                ModificationsOnHold.Edges[ID] = null;
            }
        }
        else
        {
            ModificationLog<TNode> Modification = new(BaseGraph);
            foreach(uint ID in IDs)
            {
                Modification.Edges[ID] = null;
            }
            ModificationInitiate(Modification);
            BaseGraph.RemoveEdge(IDs);
        }
    }

    internal void ModificationInitiatePlugin(ModificationAggregator<TNode> Modification)
    {
        if (IsModificationsOnHold)
        {
            ModificationsOnHold.Nodes.Union(Modification.Nodes);
            ModificationsOnHold.Edges.Union(Modification.Edges);
        }
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
    public uint GenerateID() => BaseGraph.GenerateID();
}