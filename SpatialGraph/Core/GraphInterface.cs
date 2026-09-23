using System.Numerics;

namespace GG.SpatialGraph;

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
    uint GenerateID();
}

/// <summary>
/// Read only interface of a tracked graph. Tracked graphs returns modification logs when it is modified.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public interface IReadOnlyTrackedGraph<TNode> : IReadOnlyGraph<TNode> where TNode : struct, INode
{
    event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphModified;
}

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
    /// Add an edge from two nodes.
    /// </summary>
    /// <returns>Unique edge ID</returns>
    uint AddEdge(uint NodePoint1, uint NodePoint2);

    /// <summary>
    /// Remove an edge in the graph using its corresponding ID.
    /// </summary>
    bool RemoveEdge(uint ID);

    /// <summary>
    /// Perform multiple operations at once.
    /// </summary>
    void ApplyBatchedModifications(IReadOnlyBatchedMods<TNode> modifications);
}

/// <summary>
/// Graph2D interface.
/// </summary>
public interface IGraph2D
{
    uint AddNode(float X, float Y);
    uint AddNode(Vector2 Loc);
}

/// <summary>
/// Graph3D interface.
/// </summary>
public interface IGraph3D
{
    uint AddNode(float X, float Y, float Z);
    uint AddNode(Vector3 Loc);
}

/// <summary>
/// Base interface for all tracked graphs. Tracked graphs returns modification logs when it is modified.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public interface ITrackedGraph<TNode> : IReadOnlyTrackedGraph<TNode>, IGraph<TNode> where TNode : struct, INode;

public interface ITrackedGraphInterceptable<TNode> : ITrackedGraph<TNode>, IGraph<TNode> where TNode : struct, INode
{
    event EventHandler<ModificationLog<TNode>>? OnGraphModificationInit;
}