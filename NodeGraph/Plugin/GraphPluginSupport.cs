using System.Collections.ObjectModel;
using System.Collections.Specialized;
namespace GG.NodeGraph.Plugin;

public class GraphExtendable<TNode> : Graph<TNode> where TNode : Node
{
    public GraphExtendable()
    {
        Plugins.CollectionChanged += CollectionChanged;
    }
    public readonly ObservableCollection<GraphPlugin<TNode>> Plugins = new();
    private void CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        if(e.NewItems != null)
        {
            foreach(GraphPlugin<TNode> NewPlugins in e.NewItems)
            {
                NewPlugins.InvokeOnConnection(this);
            }
        }
        if(e.OldItems != null)
        {
            foreach(GraphPlugin<TNode> NewPlugins in e.OldItems)
            {
                NewPlugins.InvokeOnDisconnection();
            }
        }
    }

    public override void SetNode(TNode Node)
    {
        ModificationLog<TNode> Modification = new();
        Modification.Nodes[Node.ID] = Node;
        ModificationInitiate(Modification, null);
    }

    public override void SetNodes(IEnumerable<TNode> Vertices)
    {
        ModificationLog<TNode> Modification = new();
        foreach(TNode Node in Vertices)
        {
            Modification.Nodes[Node.ID] = Node;
        }
        ModificationInitiate(Modification, null);
    }

    public override void SetEdge(Edge Edge)
    {
        ModificationLog<TNode> Modification = new();
        Modification.Edges[Edge.ID] = Edge;
        ModificationInitiate(Modification, null);
    }

    public override void SetEdges(IEnumerable<Edge> Edges)
    {
        ModificationLog<TNode> Modification = new();
        foreach(Edge Edge in Edges)
        {
            Modification.Edges[Edge.ID] = Edge;
        }
        ModificationInitiate(Modification, null);
    }

    internal void ModificationInitiate(ModificationLog<TNode> Modification, GraphPlugin<TNode>? Initiator)
    {
        foreach(GraphPlugin<TNode> plugin in Plugins)
        {
            plugin.OnModificationInitialize(Initiator);
        }
        foreach(GraphPlugin<TNode> plugin in Plugins)
        {
            plugin.OnModification(Modification, Initiator);
        }
        foreach(GraphPlugin<TNode> plugin in Plugins)
        {
            plugin.OnModificationFinished(Modification, Initiator);
        }
        
        foreach(KeyValuePair<uint, TNode?> vertices in Modification.Nodes)
        {
            if(vertices.Value != null)
            {
                base.SetNode(vertices.Value);
            }
            base.RemoveNode(vertices.Key);
        }
        foreach(KeyValuePair<uint, Edge?> edge in Modification.Edges)
        {
            if(edge.Value != null)
            {
                base.SetEdge((Edge)edge.Value);
            }
            base.RemoveNode(edge.Key);
        }
    }
}