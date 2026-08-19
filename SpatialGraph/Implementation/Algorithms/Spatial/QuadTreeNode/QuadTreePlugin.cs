using System.Numerics;
using GG.SpatialGraph.Metadata;

namespace GG.SpatialGraph.Spatial;

public class QuadTreeNode : GraphReadOnlyPlugin<Node2D>, IGraphSpatialNode2D
{
    public QuadTreeNode(ITrackedGraph<Node2D> graph, int cellCapacity, Vector2 originTopLeft, float width, float height) : base(graph)
    {
        
    }

    protected override void OnGraphUpdate(object? sender, IReadOnlyModificationLog<Node2D> modLog)
    {
        
    }

    public uint QueryNodeNearestNeighbor(uint nodeIDSource)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<uint> QueryNodeNearestNeighbors(uint nodeIDSource, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<uint> QueryNodesAABB(Vector2 topLeftCorner, float width, float height)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<uint> QueryNodesRadius(Vector2 location, float radius)
    {
        throw new NotImplementedException();
    }
}