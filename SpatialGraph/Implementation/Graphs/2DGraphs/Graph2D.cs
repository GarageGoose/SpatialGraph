using System.Numerics;

namespace GG.SpatialGraph;

/// <summary>
/// Base class for 2D graphs, can be built upon.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public class Graph2D : Graph<Node2D>, IGraph<Node2D>, IGraph2D
{
    /// <summary>
    /// Start an empty graph.
    /// </summary>
    public Graph2D() : base()
    {
    }

    /// <summary>
    /// Start graph from a pre-exisitng graph.
    /// </summary>
    /// <param name="graph">Graph to replicate from.</param>
    public Graph2D(IReadOnlyGraph<Node2D> graph) : base(graph)
    {
    }

    /// <summary>
    /// Start a graph from pre-exisiting dictionaries of nodes and edges.
    /// </summary>
    public Graph2D(Dictionary<uint, Node2D> nodes, Dictionary<uint, Edge> edges) : base(nodes, edges)
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