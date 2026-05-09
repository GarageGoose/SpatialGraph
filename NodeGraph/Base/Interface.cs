using GG.NodeGraph.Plugin;

namespace GG.NodeGraph;

/// <summary>
/// Read only interface of the graph.
/// </summary>
/// <typeparam name="TNode">Vertices to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public interface IReadOnlyGraph<TNode> where TNode : struct, INode
{
    IReadOnlyDictionary<uint, TNode> Nodes {get;}
    IReadOnlyDictionary<uint, Edge> Edges {get;}
}

public interface IReadOnlyTrackedGraph<TNode> : IReadOnlyGraph<TNode> where TNode : struct, INode
{
    EventHandler<ModificationLog<TNode>> GraphModified {get; set;}
}

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

    /// <summary>
    /// Generate unique IDs for the elements of the graph.
    /// </summary>
    uint GenerateID(out uint ID);
}

public interface ITrackedGraph<TNode> : IReadOnlyTrackedGraph<TNode>, IGraph<TNode> where TNode : struct, INode {}