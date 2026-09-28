using System.Numerics;

namespace GG.SpatialGraph;

/// <summary>
/// Read only interface of the graph.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public interface IReadOnlyGraph<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Nodes stored in this graph. Elements such as nodes are referenced be their unique IDs.
    /// </summary>
    IReadOnlyDictionary<uint, TNode> Nodes {get;}

    /// <summary>
    /// Edges stored in this graph. Elements such as edges are referenced be their unique IDs.
    /// </summary>
    IReadOnlyDictionary<uint, Edge> Edges {get;}

    /// <summary>
    /// Generate unique IDs for the elements of the graph.
    /// </summary>
    uint GenerateID();
}

/// <summary>
/// Read only interface of a tracked graph. Tracked graphs returns read only modification logs when it is modified.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public interface IReadOnlyTrackedGraph<TNode> : IReadOnlyGraph<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Event for changes applied. Invokes after the graph is modified.
    /// </summary>
    event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphModified;
}

/// <summary>
/// Base interface for all graphs.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public interface IGraph<TNode> : IReadOnlyGraph<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Add or modify a node with their corresponding ID.
    /// </summary>
    /// <param name="Node">Node to upsert.</param>
    void UpsertNode(TNode Node);

    /// <summary>
    /// Remove a node in the graph using their correspinding IDs.
    /// </summary>
    /// <param name="ID">ID of the node to be removed.</param>
    /// <returns>If the node is removed.</returns>
    bool RemoveNode(uint ID);

    /// <summary>
    /// Add or modify an edge with its corresponding ID.
    /// </summary>
    /// <param name="edge">Edge to upsert.</param>
    void UpsertEdge(Edge edge);

    /// <summary>
    /// Remove an edge in the graph using its corresponding ID.
    /// </summary>
    /// <param name="ID">ID of the edge to be removed.</param>
    /// <returns>If the edge is removed.</returns>
    bool RemoveEdge(uint ID);

    /// <summary>
    /// Perform multiple operations at once.
    /// </summary>
    /// <param name="modifications">Contains operations to perform.</param>
    void ApplyBatchedModifications(GraphChangeSet<TNode> modifications);
}

/// <summary>
/// Base interface for all tracked graphs. Tracked graphs returns read only modification logs when it is modified.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public interface ITrackedGraph<TNode> : IReadOnlyTrackedGraph<TNode>, IGraph<TNode> where TNode : struct, INode;

/// <summary>
/// Base interface for all tracked graphs which can modifiy incoming changes. Tracked graphs returns read only modification logs when it is modified and a modification log for incoming mnodifications.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public interface IInterceptableTrackedGraph<TNode> : ITrackedGraph<TNode>, IGraph<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Event for incoming changes. Modifications can be changed before being applied to the graph.
    /// </summary>
    event EventHandler<GraphChangeLog<TNode>>? OnGraphModificationInit;
}