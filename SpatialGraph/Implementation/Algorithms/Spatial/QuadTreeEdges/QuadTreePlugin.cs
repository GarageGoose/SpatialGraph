using System.Numerics;
using GG.SpatialGraph.Metadata;

namespace GG.SpatialGraph.Spatial;

public class QuadTreeEdge : GraphReadOnlyPlugin<Node2D>, IGraphSpatialEdge2D
{
    public QuadTreeEdge(ITrackedGraph<Node2D> graph) : base(graph)
    {
    }

    public IEnumerable<uint> QueryEdgeAABB(Vector2 topLeftCorner, float width, float height)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<uint> QueryEdgeIntersection(uint edgeIDTarget)
    {
        throw new NotImplementedException();
    }

    public uint QueryEdgeNearestNeighbor(uint edgeIDSource)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<uint> QueryEdgeNearestNeighbors(uint edgeIDSource, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<uint> QueryEdgeRadius(Vector2 location, float radius)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<uint> QueryLineIntersection(Vector2 location, float angle)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<uint> QueryLineSegmentIntersection(Vector2 origin, Vector2 destination)
    {
        throw new NotImplementedException();
    }

    protected override void OnGraphUpdate(object? sender, IReadOnlyModificationLog<Node2D> modLog)
    {
        
    }
}