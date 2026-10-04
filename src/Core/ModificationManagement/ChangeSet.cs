namespace SpatialGraph;

/// <summary>
/// Set of changes in a <see cref="IGraph{TNode}"/>.
/// </summary>
/// <typeparam name="TNode">Node which the base graph uses.</typeparam>
public interface GraphChangeSet<TNode> where TNode : struct, INode
{
    /// <summary>
    /// <see cref="INode"/>s to be either added or modified if it has the same ID as a <see cref="INode"/> in a graph.
    /// </summary>
    /// <returns>Set of nodes to be either added or replaced.</returns>
    IEnumerable<TNode> NodeUpserts();

    /// <summary>
    /// <see cref="Edge"/>s to be either added or modified if it has the same ID as an <see cref="Edge"/> in a graph.
    /// </summary>
    /// <returns>Set of edges to be either added or replaced.</returns>
    IEnumerable<Edge> EdgeUpserts();

    /// <summary>
    /// IDs of the <see cref="INode"/>s to be removed in a graph.
    /// </summary>
    /// <returns>Set of nodes to be either added or replaced.</returns>
    IEnumerable<uint> NodeRemovals();

    /// <summary>
    /// IDs of the <see cref="Edge"/>s to be removed in a graph.
    /// </summary>
    /// <returns>Set of edges to be either added or replaced.</returns>
    IEnumerable<uint> EdgeRemovals();
}