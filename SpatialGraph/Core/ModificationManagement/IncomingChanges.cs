namespace GG.SpatialGraph;

/// <summary>
/// Stores incoming changes for a graph.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class GraphIncomingChanges<TNode> : IReadOnlyBatchedMods<TNode> where TNode : struct, INode
{
    Dictionary<uint, TNode> nodesForUpsert = new();
    HashSet<uint> nodesForRemoval = new();
    Dictionary<uint, Edge> edgesForUpsert = new();
    HashSet<uint> edgesForRemoval = new();

    public IReadOnlyDictionary<uint, TNode> NodesForUpsert {get;}
    public IReadOnlySet<uint> NodesForRemoval {get;}
    public IReadOnlyDictionary<uint, Edge> EdgesForUpsert {get;}
    public IReadOnlySet<uint> EdgesForRemoval {get;}

        public GraphIncomingChanges()
    {
        edgesForUpsert = new();
        nodesForUpsert = new();
        nodesForRemoval = new();
        edgesForRemoval = new();
        NodesForUpsert = nodesForUpsert;
        NodesForRemoval = nodesForRemoval;
        EdgesForUpsert = edgesForUpsert;
        EdgesForRemoval = edgesForRemoval;
    }

    public GraphIncomingChanges(IReadOnlyBatchedMods<TNode> batchedMods)
    {
        edgesForUpsert = new(batchedMods.EdgesForUpsert);
        nodesForUpsert = new(batchedMods.NodesForUpsert);
        nodesForRemoval = [.. batchedMods.NodesForRemoval];
        edgesForRemoval = [.. batchedMods.EdgesForRemoval];
        NodesForUpsert = nodesForUpsert;
        NodesForRemoval = nodesForRemoval;
        EdgesForUpsert = edgesForUpsert;
        EdgesForRemoval = edgesForRemoval;
    }
    
    public void UpsertNode(TNode node)
    {
        nodesForUpsert.Add(node.ID, node);
        nodesForRemoval.Remove(node.ID);
    }
    public void RemoveNode(uint nodeID)
    {
        nodesForUpsert.Remove(nodeID);
        nodesForRemoval.Add(nodeID);
    }

    public void RemoveNodeMod(uint nodeID)
    {
        nodesForUpsert.Remove(nodeID);
        nodesForRemoval.Remove(nodeID);
    }

    public void UpsertEdge(Edge edge)
    {
        edgesForUpsert.Add(edge.ID, edge);
        edgesForRemoval.Remove(edge.ID);
    }
    public void RemoveEdge(uint edgeID)
    {
        edgesForUpsert.Remove(edgeID);
        edgesForRemoval.Add(edgeID);
    }
    public void RemoveEdgeMod(uint edgeID)
    {
        edgesForUpsert.Remove(edgeID);
        edgesForRemoval.Remove(edgeID);
    }

    public void Union(GraphIncomingChanges<TNode> batchedMods)
    {
        nodesForUpsert.Union(batchedMods.nodesForUpsert);
        nodesForRemoval.UnionWith(batchedMods.nodesForRemoval);
        edgesForUpsert.Union(batchedMods.edgesForUpsert);
        edgesForRemoval.UnionWith(batchedMods.edgesForRemoval);
    }

    public void Intersect(GraphIncomingChanges<TNode> batchedMods)
    {
        nodesForUpsert.Intersect(batchedMods.nodesForUpsert);
        nodesForRemoval.IntersectWith(batchedMods.nodesForRemoval);
        edgesForUpsert.Intersect(batchedMods.edgesForUpsert);
        edgesForRemoval.IntersectWith(batchedMods.edgesForRemoval);
    }

    public IEnumerable<TNode> NodeUpserts() => NodesForUpsert.Values;

    public IEnumerable<Edge> EdgeUpserts() => EdgesForUpsert.Values;

    public IEnumerable<uint> NodeRemovals() => NodesForRemoval;

    public IEnumerable<uint> EdgeRemovals() => EdgesForRemoval;
}

public interface IReadOnlyBatchedMods<TNode> : GraphChangeSet<TNode> where TNode : struct, INode
{
    IReadOnlyDictionary<uint, TNode> NodesForUpsert {get;}
    IReadOnlySet<uint> NodesForRemoval {get;}
    IReadOnlyDictionary<uint, Edge> EdgesForUpsert {get;}
    IReadOnlySet<uint> EdgesForRemoval {get;}
}