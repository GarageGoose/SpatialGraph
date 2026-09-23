using System.Numerics;

namespace GG.SpatialGraph;

/// <summary>
/// Base class for graphs, can be built upon.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class TrackedGraphInterceptable3D : Graph<Node3D>, IGraph<Node3D>, IGraph3D
{
    public TrackedGraphInterceptable3D() : base()
    {
    }

    public TrackedGraphInterceptable3D(IReadOnlyGraph<Node3D> graph) : base(graph)
    {
    }

    public TrackedGraphInterceptable3D(Dictionary<uint, Node3D> nodes, Dictionary<uint, Edge> edges) : base(nodes, edges)
    {
    }

    public virtual uint AddNode(Vector3 Loc)
    {
        uint NodeID = GenerateID();
        UpsertNode(new(NodeID, Loc));
        return NodeID;
    }

    public virtual uint AddNode(float X, float Y, float Z) => AddNode(new(X, Y, Z));
}