using System.Numerics;

namespace GG.SpatialGraph;

/// <summary>
/// Base class for graphs, can be built upon.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class TrackedGraphInterceptable2D : TrackedGraphInterceptable<Node2D>, IGraph<Node2D>, IGraph2D
{
    public TrackedGraphInterceptable2D() : base()
    {
    }

    public TrackedGraphInterceptable2D(IReadOnlyGraph<Node2D> graph) : base(graph)
    {
    }

    public TrackedGraphInterceptable2D(Dictionary<uint, Node2D> nodes, Dictionary<uint, Edge> edges) : base(nodes, edges)
    {
    }

    public virtual uint AddNode(Vector2 Loc)
    {
        uint NodeID = GenerateID();
        UpsertNode(new(NodeID, Loc));
        return NodeID;
    }

    public virtual uint AddNode(float X, float Y) => AddNode(new(X, Y));
}