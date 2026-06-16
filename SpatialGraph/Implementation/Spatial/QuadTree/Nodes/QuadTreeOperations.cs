using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace GG.SpatialGraph.Spatial;

public static class QuadTreeOps
{
    public static HashSet<uint> NodesWithinCircle(this QuadTreeNodes quadTree, Vector2 loc, float radius)
    {
        HashSet<uint> nodes = new();
        ProcessCell(quadTree.ParentCell, nodes);
        return nodes;

        void ProcessCell(IReadOnlyQuadTreeCell<Node2D> currCell, HashSet<uint> hashSet)
        {
            if(CircleCellCol(loc, radius, currCell))
            {
                if (currCell.Subdivided)
                {
                    ProcessCell(currCell.NorthEastRO!, hashSet);
                    ProcessCell(currCell.NorthWestRO!, hashSet);
                    ProcessCell(currCell.SouthEastRO!, hashSet);
                    ProcessCell(currCell.SouthWestRO!, hashSet);
                }
                else
                {
                    foreach(Node2D node in currCell.Elements.Values)
                    {
                        if(PointCircleCol(loc, radius, node.Loc))
                        {
                            hashSet.Add(node.ID);
                        }
                    }
                }
            }
        }

        bool CircleCellCol(Vector2 circle, float radius, IReadOnlyQuadTreeCell<Node2D> cell)
        {
            Vector2 circleAxisDist = new(MathF.Abs(circle.X - cell.Center.X), MathF.Abs(circle.Y - cell.Center.Y));

            if(circleAxisDist.X <= cell.HalfWidth || circleAxisDist.Y <= cell.HalfHeight)
            {
                return true;
            }

            if(circleAxisDist.X > cell.HalfWidth + radius || circleAxisDist.Y > cell.HalfHeight + radius)
            {
                return false;
            }

            float cornerDistSquared = MathF.Pow(circleAxisDist.X - cell.HalfWidth, 2) + MathF.Pow(circleAxisDist.Y - cell.HalfHeight, 2);
            return cornerDistSquared <= MathF.Pow(radius, 2);
        }

        bool PointCircleCol(Vector2 circle, float radius, Vector2 point) => MathF.Pow(circle.X + point.X, 2) + MathF.Pow(circle.Y + point.Y, 2) <= radius;
    }
}