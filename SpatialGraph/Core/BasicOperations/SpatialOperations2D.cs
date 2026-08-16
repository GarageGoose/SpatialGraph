using System.Numerics;
namespace GG.SpatialGraph;

public static class SpatialGraph2DOperations
{
    public static float EdgeAngle(this IGraph<Node2D> baseGraph, uint edgeID)
    {
        return 0;
    }

    public static float EdgeAngleFromNode(this IGraph<Node2D> baseGraph, uint edgeID, uint nodeID)
    {
        return 0;
    }

    public static float EdgeLengthSquared(this IGraph<Node2D> baseGraph, uint edgeID)
    {
        Edge edge = baseGraph.Edges[edgeID];
        Vector2 loc1 = baseGraph.Nodes[edge.NodeID1].Loc;
        Vector2 loc2 = baseGraph.Nodes[edge.NodeID2].Loc;
        float xLength = MathF.Abs(loc1.X - loc2.X);
        float yLength = MathF.Abs(loc1.Y - loc2.Y);
        return (xLength * xLength) + (yLength * yLength);
    }

    public static float EdgeLength(this IGraph<Node2D> baseGraph, uint edgeID)
    {
        Edge edge = baseGraph.Edges[edgeID];
        Vector2 loc1 = baseGraph.Nodes[edge.NodeID1].Loc;
        Vector2 loc2 = baseGraph.Nodes[edge.NodeID2].Loc;
        float xLength = MathF.Abs(loc1.X - loc2.X);
        float yLength = MathF.Abs(loc1.Y - loc2.Y);
        return MathF.Sqrt(xLength * xLength) + (yLength * yLength);
    }
}