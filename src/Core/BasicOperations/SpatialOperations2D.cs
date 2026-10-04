using System.Numerics;
namespace SpatialGraph.Extensions;

/// <summary>
/// Get spatial information in <see cref="IGraph{Node2D}"/>s.
/// </summary>
public static class SpatialGraph2DOperations
{
    /// <summary>
    /// Get the angle of an <see cref="Edge"/> in radians.
    /// </summary>
    /// <param name="baseGraph">Graph where the edge resides from.</param>
    /// <param name="edgeID">ID of the target edge.</param>
    /// <returns>Angle of the edge in radians.</returns>
    /// <seealso cref="EdgeAngleOpposite"/>
    public static float EdgeAngle(this IReadOnlyGraph<Node2D> baseGraph, uint edgeID)
    {
        Vector2 Dir = baseGraph.GetSecondNodeOfEdge(edgeID).Loc - baseGraph.GetFirstNodeOfEdge(edgeID).Loc;
        return MathF.Atan2(Dir.X, Dir.Y);
    }
    
    /// <summary>
    /// Get the angle of an <see cref="Edge"/>, flipped 180 degrees, in radians.
    /// </summary>
    /// <param name="baseGraph">Graph where the edge resides from.</param>
    /// <param name="edgeID">ID of the target edge.</param>
    /// <returns>Angle of the edge, flipped 180 degrees, in radians.</returns>
    /// <seealso cref="EdgeAngle"/>
    public static float EdgeAngleOpposite(this IReadOnlyGraph<Node2D> baseGraph, uint edgeID)
    {
        Vector2 Dir = baseGraph.GetFirstNodeOfEdge(edgeID).Loc - baseGraph.GetSecondNodeOfEdge(edgeID).Loc;
        return MathF.Atan2(Dir.X, Dir.Y);
    }

    /// <summary>
    /// Get the angle of an <see cref="Edge"/> (in radians) relative to one of its endpoints.
    /// </summary>
    /// <param name="baseGraph">Graph where the edge resides from.</param>
    /// <param name="edgeID">ID of the edge get its angle.</param>
    /// <param name="nodeID">ID of the node to get the angle of the edge from.</param>
    /// <returns>Angle of the edge (in radians) relative to the node.</returns>
    public static float EdgeAngleFromNode(this IReadOnlyGraph<Node2D> baseGraph, uint edgeID, uint nodeID)
    {
        if (baseGraph.Edges[edgeID].EdgeAssignmentOfNode(nodeID) == NodeInEdge.First)
        {
            return baseGraph.EdgeAngle(edgeID);
        }
        else if(baseGraph.Edges[edgeID].EdgeAssignmentOfNode(nodeID) == NodeInEdge.Second)
        {
            return baseGraph.EdgeAngleOpposite(edgeID);
        }
        return 0;
    }

    /// <summary>
    /// Get the squared length of an <see cref="Edge"/>.
    /// </summary>
    /// <param name="baseGraph">Graph where the edge resides from.</param>
    /// <param name="edgeID">ID of the edge get its length.</param>
    /// <returns>Length of the edge.</returns>
    /// <seealso cref="EdgeLength"/>
    public static float EdgeLengthSquared(this IReadOnlyGraph<Node2D> baseGraph, uint edgeID)
    {
        Edge edge = baseGraph.Edges[edgeID];
        Vector2 loc1 = baseGraph.Nodes[edge.NodeID1].Loc;
        Vector2 loc2 = baseGraph.Nodes[edge.NodeID2].Loc;
        float xLength = MathF.Abs(loc1.X - loc2.X);
        float yLength = MathF.Abs(loc1.Y - loc2.Y);
        return (xLength * xLength) + (yLength * yLength);
    }

    /// <summary>
    /// Get length of an <see cref="Edge"/>.
    /// </summary>
    /// <param name="baseGraph">Graph where the edge resides from.</param>
    /// <param name="edgeID">ID of the edge get its length.</param>
    /// <returns>Length of the edge.</returns>
    /// <seealso cref="EdgeLengthSquared"/>
    public static float EdgeLength(this IReadOnlyGraph<Node2D> baseGraph, uint edgeID)
    {
        Edge edge = baseGraph.Edges[edgeID];
        Vector2 loc1 = baseGraph.Nodes[edge.NodeID1].Loc;
        Vector2 loc2 = baseGraph.Nodes[edge.NodeID2].Loc;
        float xLength = MathF.Abs(loc1.X - loc2.X);
        float yLength = MathF.Abs(loc1.Y - loc2.Y);
        return MathF.Sqrt(xLength * xLength) + MathF.Sqrt(yLength * yLength);
    }

    /// <summary>
    /// Checks if a <see cref="INode"/> is within the radius
    /// </summary>
    /// <param name="node">Node to check.</param>
    /// <param name="loc">Location of the radius.</param>
    /// <param name="radius">Size of the radius.</param>
    /// <returns>True of the node is within radius, else false.</returns>
    public static bool IsNodeWithinRadius(this Node2D node, Vector2 loc, float radius)
    {
        return false;
    }

    /// <summary>
    /// Check if a <see cref="INode"/> is within an axis aligned bounding box.
    /// </summary>
    /// <param name="node">Node to check.</param>
    /// <param name="topLeftCorner">Upper left bounds of the AABB.</param>
    /// <param name="width">Width of the AABB.</param>
    /// <param name="height">Height of the AABB.</param>
    /// <returns>True if the node is within AABB, else false.</returns>
    public static bool IsNodeWithinAABB(this Node2D node, Vector2 topLeftCorner, float width, float height)
    {
        return false;
    }
}