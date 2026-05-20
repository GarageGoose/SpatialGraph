namespace GG.NodeGraph;

/// <summary>
/// Stores modifications.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class BatchedModifications<TNode> where TNode : struct, INode
{
    public readonly Dictionary<uint, TNode?> Nodes = new();
    public readonly Dictionary<uint, Edge?> Edges = new();

    public HashSet<TNode> NodesForUpsert()
    {
        HashSet<TNode> nodes = new();
        foreach(TNode? node in Nodes.Values)
        {
            if(node != null)
            {
                nodes.Add(node.Value);
            }
        }
        return nodes;
    }

    public HashSet<uint> NodesForRemoval()
    {
        HashSet<uint> nodes = new();
        foreach(KeyValuePair<uint, TNode?> node in Nodes)
        {
            if(node.Value == null)
            {
                nodes.Add(node.Key);
            }
        }
        return nodes;
    }

    public HashSet<Edge> EdgesForUpsert()
    {
        HashSet<Edge> edges = new();
        foreach(Edge? edge in Edges.Values)
        {
            if(edge != null)
            {
                edges.Add(edge.Value);
            }
        }
        return edges;
    }

    public HashSet<uint> EdgesForRemoval()
    {
        HashSet<uint> edges = new();
        foreach(KeyValuePair<uint, Edge?> edge in Edges)
        {
            if(edge.Value == null)
            {
                edges.Add(edge.Key);
            }
        }
        return edges;
    }

    public ElementModificationsByType<Edge> SegregateEdgeModifications()
    {
        HashSet<Edge> upserts = new();
        HashSet<uint> removals = new();
        ElementModificationsByType<Edge> modifications = new(upserts, removals);

        foreach(KeyValuePair<uint, Edge?> edge in Edges)
        {
            if(edge.Value == null)
            {
                removals.Add(edge.Key);
                continue;
            }else
            upserts.Add((Edge)edge.Value);
        }
        return modifications;
    }

    public ElementModificationsByType<TNode> SegregateNodeModifications()
    {
        HashSet<TNode> upserts = new();
        HashSet<uint> removals = new();
        ElementModificationsByType<TNode> modifications = new(upserts, removals);

        foreach(KeyValuePair<uint, TNode?> node in Nodes)
        {
            if(node.Value == null)
            {
                removals.Add(node.Key);
                continue;
            }
            upserts.Add((TNode)node.Value);
        }
        return modifications;
    }
}

public readonly record struct ElementModificationsByType<TElement>(IReadOnlySet<TElement> Upsert, IReadOnlySet<uint> Removal) where TElement : struct;