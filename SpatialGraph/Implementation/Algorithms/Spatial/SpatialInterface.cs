using System.Numerics;
namespace GG.SpatialGraph.Spatial;

public interface IGraphSpatialNode2D
{
    uint QueryNodeNearestNeighbor(uint nodeIDSource);
    uint QueryNodeNearestNeighbors(uint nodeIDSource, int count);
    IEnumerable<uint> QueryNodesRadius(Vector2 location, float radius);
    IEnumerable<uint> QueryNodesAABB(Vector2 topLeftCorner, float width, float height);
}

public interface IGraphSpatialEdge2D
{
    uint QueryEdgeNearestNeighbor(uint edgeIDSource);
    uint QueryEdgeNearestNeighbors(uint edgeIDSource, int count);
    IEnumerable<uint> QueryEdgeRadius(Vector2 location, float radius);
    IEnumerable<uint> QueryEdgeAABB(Vector2 topLeftCorner, float width, float height);
    IEnumerable<uint> QueryEdgeIntersection(uint edgeIDTarget);
    IEnumerable<uint> QueryLineSegmentIntersection(Vector2 origin, Vector2 destination);
    IEnumerable<uint> QueryLineIntersection(Vector2 location, float angle);
}