using System.Numerics;

namespace GG.SpatialGraph;

/// <summary>
/// 3D Graph which tracks changes within it.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public class TrackedGraph3D : TrackedGraph<Node3D>, IGraph<Node3D>, IGraph3D
{
    /// <summary>
    /// Start an empty graph.
    /// </summary>
    public TrackedGraph3D() : base()
    {
    }

    /// <summary>
    /// Start graph from a pre-exisitng graph.
    /// </summary>
    /// <param name="graph">Graph to replicate from.</param>
    public TrackedGraph3D(IReadOnlyGraph<Node3D> graph) : base(graph)
    {
    }

    /// <summary>
    /// Start a graph from pre-exisiting dictionaries of nodes and edges.
    /// </summary>
    public TrackedGraph3D(Dictionary<uint, Node3D> nodes, Dictionary<uint, Edge> edges) : base(nodes, edges)
    {
    }

    /// <summary>
    /// Add a new node.
    /// </summary>
    /// <param name="Loc">Location of the new node.</param>
    /// <returns>ID of the new node.</returns>
    public virtual uint AddNode(Vector3 Loc)
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
    /// <param name="Z">Z position of the new node.</param>
    /// <returns>ID of the new node.</returns>
    public virtual uint AddNode(float X, float Y, float Z) => AddNode(new(X, Y, Z));
}