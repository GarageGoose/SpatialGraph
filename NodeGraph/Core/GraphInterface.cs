namespace GG.NodeGraph;

/// <summary>
/// Read only interface of the graph.
/// </summary>
/// <typeparam name="TNode">Vertices to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
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
/// Read only interface of a tracked graph. Tracked graphs returns modification logs when it is modified.
/// </summary>
/// <typeparam name="TNode">Vertices to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public interface IReadOnlyTrackedGraph<TNode> : IReadOnlyGraph<TNode> where TNode : struct, INode
{
    event EventHandler<IReadOnlyModificationLog<TNode>>? GraphModified;
}

/// <summary>
/// Read only interface of a graph that keeps records of connected edges on nodes.
/// </summary>
/// <typeparam name="TNode">Vertices to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
/// <typeparam name="TEdgeStorage">A readonly collection on where to store multiple edges connected on a common node.</typeparam>
public interface IReadOnlyGraphNodeRelations<TNode, TEdgeStorage> : IReadOnlyGraph<TNode> where TNode : struct, INode where TEdgeStorage : ICollection<uint>
{
    IReadOnlyDictionary<uint, TEdgeStorage> EdgesOnNode {get;}
}

/// <summary>
/// Read only interface of a graph that keeps records of connected edges on nodes and returns modification logs when it is modified.
/// </summary>
/// <typeparam name="TNode">Vertices to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
/// <typeparam name="TEdgeStorage">A collection on where to store multiple edges connected on a common node.</typeparam>
public interface IReadOnlyTrackedGraphNodeRelations<TNode, TEdgeStorage> : IReadOnlyGraphNodeRelations<TNode, TEdgeStorage>, IReadOnlyTrackedGraph<TNode> where TNode : struct, INode where TEdgeStorage : ICollection<uint> {}

/// <summary>
/// Base interface for all graphs.
/// </summary>
/// <typeparam name="TNode">Vertices to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
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
/// Base interface for all tracked graphs. Tracked graphs returns modification logs when it is modified.
/// </summary>
/// <typeparam name="TNode">Vertices to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public interface ITrackedGraph<TNode> : IReadOnlyTrackedGraph<TNode>, IGraph<TNode> where TNode : struct, INode {}

/// <summary>
/// Graph that keeps records of connected edges on nodes.
/// </summary>
/// <typeparam name="TNode">Vertices to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
/// <typeparam name="TEdgeStorage">A collection on where to store multiple edges connected on a common node.</typeparam>
public interface IGraphNodeRelations<TNode, TEdgeStorage> : IGraph<TNode>, IReadOnlyGraphNodeRelations<TNode, TEdgeStorage> where TNode : struct, INode where TEdgeStorage : ICollection<uint> {}

/// <summary>
/// Graph that keeps records of connected edges on nodes and returns modification logs when it is modified.
/// </summary>
/// <typeparam name="TNode">Vertices to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
/// <typeparam name="TEdgeStorage">A collection on where to store multiple edges connected on a common node.</typeparam>
public interface ITrackedGraphNodeRelations<TNode, TEdgeStorage> : IGraphNodeRelations<TNode, TEdgeStorage>, ITrackedGraph<TNode> where TNode : struct, INode where TEdgeStorage : ICollection<uint>{}