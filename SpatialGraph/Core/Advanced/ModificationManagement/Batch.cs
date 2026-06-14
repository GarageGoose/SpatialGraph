namespace GG.SpatialGraph;

/// <summary>
/// Stores modifications for a graph.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class BatchedModifications<TNode> where TNode : struct, INode
{
    Dictionary<uint, TNode> nodesForUpsert = new();
    public IReadOnlyDictionary<uint, TNode> NodesForUpsert => nodesForUpsert;

    HashSet<uint> nodesForRemoval = new();
    public IReadOnlySet<uint> NodesForRemoval => nodesForRemoval;

    Dictionary<uint, Edge> edgesForUpsert = new();
    public IReadOnlyDictionary<uint, Edge> EdgesForUpsert => edgesForUpsert;

    HashSet<uint> edgesForRemoval = new();
    public IReadOnlySet<uint> EdgesForRemoval => edgesForRemoval;

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
    

    public BatchedModifications()
    {
        edgesForUpsert = new();
        nodesForUpsert = new();
        nodesForRemoval = new();
        edgesForRemoval = new();
    }

    public BatchedModifications(BatchedModifications<TNode> batchedMods)
    {
        edgesForUpsert = batchedMods.edgesForUpsert;
        nodesForUpsert = batchedMods.nodesForUpsert;
        nodesForRemoval = batchedMods.nodesForRemoval;
        edgesForRemoval = batchedMods.edgesForRemoval;
    }

    public void Union(BatchedModifications<TNode> batchedMods)
    {
        nodesForUpsert.Union(batchedMods.nodesForUpsert);
        nodesForRemoval.UnionWith(batchedMods.nodesForRemoval);
        edgesForUpsert.Union(batchedMods.edgesForUpsert);
        edgesForRemoval.UnionWith(batchedMods.edgesForRemoval);
    }

    public void Intersect(BatchedModifications<TNode> batchedMods)
    {
        nodesForUpsert.Intersect(batchedMods.nodesForUpsert);
        nodesForRemoval.IntersectWith(batchedMods.nodesForRemoval);
        edgesForUpsert.Intersect(batchedMods.edgesForUpsert);
        edgesForRemoval.IntersectWith(batchedMods.edgesForRemoval);
    }
}