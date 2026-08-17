using System.Numerics;
namespace GG.SpatialGraph;

public static class SpatialGraph2DOperations
{
    public static float EdgeAngle(this IReadOnlyGraph<Node2D> baseGraph, uint edgeID)
    {
        Vector2 Dir = new();
        Dir = baseGraph.GetSecondNodeOfEdge(edgeID).Loc - baseGraph.GetFirstNodeOfEdge(edgeID).Loc;
        return MathF.Atan2(Dir.X, Dir.Y);
    }

    public static float EdgeAngleOpposite(this IReadOnlyGraph<Node2D> baseGraph, uint edgeID)
    {
        Vector2 Dir = new();
        Dir = baseGraph.GetFirstNodeOfEdge(edgeID).Loc - baseGraph.GetSecondNodeOfEdge(edgeID).Loc;
        return MathF.Atan2(Dir.X, Dir.Y);
    }

    public static float EdgeAngleFromNode(this IReadOnlyGraph<Node2D> baseGraph, uint edgeID, uint nodeID)
    {
        if (baseGraph.Edges[edgeID].EdgeAssignmentOfNode(nodeID) == NodeEdgeAssignment.Node1)
        {
            return baseGraph.EdgeAngle(edgeID);
        }
        else if(baseGraph.Edges[edgeID].EdgeAssignmentOfNode(nodeID) == NodeEdgeAssignment.Node2)
        {
            return baseGraph.EdgeAngleOpposite(edgeID);
        }
        return 0;
    }

    public static float EdgeLengthSquared(this IReadOnlyGraph<Node2D> baseGraph, uint edgeID)
    {
        Edge edge = baseGraph.Edges[edgeID];
        Vector2 loc1 = baseGraph.Nodes[edge.NodeID1].Loc;
        Vector2 loc2 = baseGraph.Nodes[edge.NodeID2].Loc;
        float xLength = MathF.Abs(loc1.X - loc2.X);
        float yLength = MathF.Abs(loc1.Y - loc2.Y);
        return (xLength * xLength) + (yLength * yLength);
    }

    public static float EdgeLength(this IReadOnlyGraph<Node2D> baseGraph, uint edgeID)
    {
        Edge edge = baseGraph.Edges[edgeID];
        Vector2 loc1 = baseGraph.Nodes[edge.NodeID1].Loc;
        Vector2 loc2 = baseGraph.Nodes[edge.NodeID2].Loc;
        float xLength = MathF.Abs(loc1.X - loc2.X);
        float yLength = MathF.Abs(loc1.Y - loc2.Y);
        return MathF.Sqrt(xLength * xLength) + (yLength * yLength);
    }
}