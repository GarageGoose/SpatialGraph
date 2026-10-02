namespace SpatialGraph;

/// <summary>
/// Read only interface of a graph. A graph stores nodes and edges within it, identified by their IDs.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public interface IReadOnlyGraph<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Nodes stored in this graph. Elements such as nodes are referenced be their unique ID.
    /// Nodes and edges can share the same ID.
    /// </summary>
    IReadOnlyDictionary<uint, TNode> Nodes {get;}

    /// <summary>
    /// Edges stored in this graph. Elements such as edges are referenced be their unique ID.
    /// Nodes and edges can share the same ID.
    /// </summary>
    IReadOnlyDictionary<uint, Edge> Edges {get;}

    /// <summary>
    /// Generate unique ID for the elements of the graph.
    /// Nodes and edges can share the same ID.
    /// </summary>
    uint GenerateID();
}

/// <summary>
/// Read only interface of a tracked graph. Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public interface IReadOnlyTrackedGraph<TNode> : IReadOnlyGraph<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Event for changes applied. Invokes with an IReadOnlyModificationLog, which contains the changes in the graph after it is modified.
    /// </summary>
    event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphModified;
}

/// <summary>
/// Base interface for all graphs. A graph stores nodes and edges within it, identified by their IDs.
/// Nodes and edges can share the same ID.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public interface IGraph<TNode> : IReadOnlyGraph<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Add a new node or modify one with their corresponding ID.
    /// Nodes and edges can share the same ID.
    /// </summary>
    /// <param name="Node">Node to upsert, identified by its ID.</param>
    void UpsertNode(TNode Node);

    /// <summary>
    /// Remove a node in the graph using its correspinding ID. Connecting edges referencing this node will not be removed.
    /// Nodes and edges can share the same ID, this will remove only the node with the corresponding ID.
    /// </summary>
    /// <param name="ID">ID of the node to be removed.</param>
    /// <returns>Node is removed.</returns>
    bool RemoveNode(uint ID);

    /// <summary>
    /// Add a new edge or modify an edge with its corresponding ID.
    /// </summary>
    /// <param name="edge">Edge to upsert, identified by its ID.</param>
    void UpsertEdge(Edge edge);

    /// <summary>
    /// Remove an edge in the graph using its corresponding ID.
    /// Nodes and edges can share the same ID, this will remove only the edge with the corresponding ID.
    /// </summary>
    /// <param name="ID">ID of the edge to be removed.</param>
    /// <returns>Edge is removed.</returns>
    bool RemoveEdge(uint ID);

    /// <summary>
    /// Perform multiple operations at once with a GraphChangeSet. Existing nodes or edges with
    /// a corresponding ID in the graph will be replaced.
    /// Nodes and edges can share the same ID.
    /// </summary>
    /// <param name="modifications">Contains operations to perform.</param>
    void ApplyChangeSet(GraphChangeSet<TNode> modifications);
}

/// <summary>
/// Base interface for all tracked graphs. A graph stores nodes and edges within it, identified by their IDs.
/// Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public interface ITrackedGraph<TNode> : IReadOnlyTrackedGraph<TNode>, IGraph<TNode> where TNode : struct, INode;

/// <summary>
/// Base interface for all tracked graphs which can modify incoming changes. A graph stores nodes and edges within it, identified by their IDs.
/// Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public interface IInterceptableTrackedGraph<TNode> : ITrackedGraph<TNode>, IGraph<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Event for incoming changes. Invokes with a GraphChangeLog which contains the modifications being performed.
    /// Modifications can be changed via the GraphChangeLog before being applied to the graph.
    /// </summary>
    event EventHandler<GraphChangeLog<TNode>>? OnGraphModificationInit;
}