namespace GG.SpatialGraph;

/// <summary>
/// Set of changes in a graph.
/// </summary>
/// <typeparam name="TNode">Node which the base graph uses.</typeparam>
public interface GraphChangeSet<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Nodes to be upserted in a graph.
    /// </summary>
    /// <returns></returns>
    IEnumerable<TNode> NodeUpserts();
    IEnumerable<Edge> EdgeUpserts();
    IEnumerable<uint> NodeRemovals();
    IEnumerable<uint> EdgeRemovals();
}