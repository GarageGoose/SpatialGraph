namespace SpatialGraph;

/// <summary>
/// Set of changes in a graph.
/// </summary>
/// <typeparam name="TNode">Node which the base graph uses.</typeparam>
public interface GraphChangeSet<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Nodes to be either added or replaced if it has the same ID as a node in a graph.
    /// </summary>
    /// <returns>Set of nodes to be either added or replaced.</returns>
    IEnumerable<TNode> NodeUpserts();

    /// <summary>
    /// Edges to be either added or replaced if it has the same ID as a node in a graph.
    /// </summary>
    /// <returns>Set of edges to be either added or replaced.</returns>
    IEnumerable<Edge> EdgeUpserts();

    /// <summary>
    /// IDs of the nodes to be removed in a graph.
    /// </summary>
    /// <returns>Set of nodes to be either added or replaced.</returns>
    IEnumerable<uint> NodeRemovals();

    /// <summary>
    /// IDs of the edges to be removed in a graph.
    /// </summary>
    /// <returns>Set of edges to be either added or replaced.</returns>
    IEnumerable<uint> EdgeRemovals();
}