using System.Numerics;

namespace GG.SpatialGraph;

/// <summary>
/// 2D Graph which tracks changes within it.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public class TrackedGraph2D : TrackedGraph<Node2D>, IGraph<Node2D>, IGraph2D
{
    /// <summary>
    /// Start an empty graph.
    /// </summary>
    public TrackedGraph2D() : base()
    {
    }

    /// <summary>
    /// Start graph from a pre-exisitng graph.
    /// </summary>
    /// <param name="graph">Graph to replicate from.</param>
    public TrackedGraph2D(IReadOnlyGraph<Node2D> graph) : base(graph)
    {
    }

    /// <summary>
    /// Start a graph from pre-exisiting dictionaries of nodes and edges.
    /// </summary>
    public TrackedGraph2D(Dictionary<uint, Node2D> nodes, Dictionary<uint, Edge> edges) : base(nodes, edges)
    {
    }

    /// <summary>
    /// Add a new node.
    /// </summary>
    /// <param name="Loc">Location of the new node.</param>
    /// <returns>ID of the new node.</returns>
    public virtual uint AddNode(Vector2 Loc)
    {
        uint NodeID = GenerateID();
        UpsertNode(new(NodeID, Loc));
        return NodeID;
    }

    /// <summary>
    /// Add a new node.
    /// </summary>
    /// <param name="X">X position of the new node.</param>
    /// <param name="Y">Y position of the new node.</param>
    /// <returns>ID of the new node.</returns>
    public virtual uint AddNode(float X, float Y) => AddNode(new(X, Y));
}