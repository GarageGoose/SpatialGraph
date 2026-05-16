namespace GG.NodeGraph;

/// <summary>
/// Read only interface of the graph.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public interface IReadOnlyGraph<TNode> where TNode : struct, INode
{
    IReadOnlyDictionary<uint, TNode> Nodes {get;}
    IReadOnlyDictionary<uint, Edge> Edges {get;}

    /// <summary>
    /// Generate unique IDs for the elements of the graph.
    /// </summary>
    uint GenerateID(out uint ID);
}

/// <summary>
/// Support for element metadatas.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public interface IReadOnlyGraphWithMetadata<TNode> : IReadOnlyGraph<TNode> where TNode : struct, INode
{
    bool Has<TMetadata>(ElementType typeOfElement, uint NodeID);
    TMetadata Get<TMetadata>(ElementType typeOfElement, uint NodeID);
    bool TryGet<TMetadata>(ElementType typeOfElement, uint NodeID, out TMetadata? Data);
}

/// <summary>
/// Read only interface of a tracked graph. Tracked graphs returns modification logs when it is modified.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public interface IReadOnlyTrackedGraph<TNode> : IReadOnlyGraph<TNode> where TNode : struct, INode
{
    event EventHandler<IReadOnlyModificationLog<TNode>>? GraphModified;
}

/// <summary>
/// Read only interface of a tracked graph with metadatas. Tracked graphs returns modification logs when it is modified.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public interface IReadOnlyTrackedGraphWithMetadata<TNode> : IReadOnlyGraphWithMetadata<TNode>, IReadOnlyTrackedGraph<TNode> where TNode : struct, INode;

/// <summary>
/// Base interface for all graphs.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public interface IGraph<TNode> : IReadOnlyGraph<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Add or modify a node with their corresponding ID.
    /// </summary>
    void UpsertNode(TNode Node);

    /// <summary>
    /// Remove a node in the graph using their correspinding IDs.
    /// </summary>
    bool RemoveNode(uint ID);

    /// <summary>
    /// Add or modify an edge with its corresponding ID.
    /// </summary>
    void UpsertEdge(Edge edge);

    /// <summary>
    /// Remove an edge in the graph using its corresponding ID.
    /// </summary>
    bool RemoveEdge(uint ID);

    /// <summary>
    /// Perform multiple operations at once.
    /// </summary>
    void ApplyBatchedModifications(BatchedModifications<TNode> modifications);
}

/// <summary>
/// Base interface for all graphs with element metadatas.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public interface IGraphWithMetadata<TNode> : IGraph<TNode>, IReadOnlyGraphWithMetadata<TNode> where TNode : struct, INode;

/// <summary>
/// Base interface for all tracked graphs. Tracked graphs returns modification logs when it is modified.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public interface ITrackedGraph<TNode> : IReadOnlyTrackedGraph<TNode>, IGraph<TNode> where TNode : struct, INode {}

/// <summary>
/// Base interface for all tracked graphs with element metadatas. Tracked graphs returns modification logs when it is modified.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public interface ITrackedGraphWithMetadata<TNode> : ITrackedGraph<TNode>, IReadOnlyGraphWithMetadata<TNode> where TNode : struct, INode;