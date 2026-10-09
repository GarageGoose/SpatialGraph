using System.Numerics;

namespace SpatialGraph.Metadata;

/// <summary>
/// Spatial indexing operations for a 2D node quadtree.
/// </summary>
/// <seealso cref="QuadTreeNode"/>
public static class QuadTreeNodeOperations
{
    /// <summary>
    /// Find nearest node from a node.
    /// </summary>
    /// <param name="Quadtree">Quadtree where the node resides.</param>
    /// <param name="SourceNodeID">ID of the node to find its nearest neighbor.</param>
    /// <returns>ID of the nearest neighbor of a node. Returns the ID of the current node if the quadtree only has one node.</returns>
    public static uint FindNearest(this QuadTreeNode Quadtree, uint SourceNodeID)
    {
        return 0;
    }

    /// <summary>
    /// Find K nearest node from a node.
    /// </summary>
    /// <param name="Quadtree">Quadtree where the nodes resides.</param>
    /// <param name="SourceNodeID">ID of the node to find its nearest neighbor.</param>
    /// <param name="KNodes">Amount of neighbors to find.</param>
    /// <returns>ID of the nearest K neighbors of a node. Returns the ID of the current node if the quadtree only has one node.</returns>
    public static IEnumerable<uint> FindKNearest(this QuadTreeNode Quadtree, uint SourceNodeID, uint KNodes)
    {
        yield return 0;
    }

    /// <summary>
    /// Find nodes within a circle in a quadtree.
    /// </summary>
    /// <param name="Quadtree">Quadtree where the nodes resides.</param>
    /// <param name="Location">Center point of the circle.</param>
    /// <param name="Radius">Radius of the circle</param>
    /// <returns>Nodes within a circle.</returns>
    public static IEnumerable<uint> QueryCircle(this QuadTreeNode Quadtree, Vector2 Location, float Radius)
    {
        yield return 0;
    }


    /// <summary>
    /// Find nodes withn an axis aligned bounding box in a 2D quadtree.
    /// </summary>
    /// <param name="Quadtree">Quadtree where the nodes resides.</param>
    /// <param name="TopLeftCorner">Top left boundary of the AABB.</param>
    /// <param name="Width">Width of the AABB.</param>
    /// <param name="Height">Height of the AABB.</param>
    /// <returns>Nodes within an AABB.</returns>
    public static IEnumerable<uint> QueryAABB(this QuadTreeNode Quadtree, Vector2 TopLeftCorner, float Width, float Height)
    {
        yield return 0;
    }
}