using System.Numerics;
namespace GG.SpatialGraph.Spatial;

public static class QuadTreeOps
{
    public static void Query(IReadOnlyQuadTreeCell<Node2D> currCell, IQuadTreeCollision<Node2D> collision, ICollection<uint> outputNodeIDs)
    {
        if(collision.CellCollision(currCell))
        {
            if (currCell.Subdivided)
            {
                Query(currCell.NorthEastRO!, collision, outputNodeIDs);
                Query(currCell.NorthWestRO!, collision, outputNodeIDs);
                Query(currCell.SouthEastRO!, collision, outputNodeIDs);
                Query(currCell.SouthWestRO!, collision, outputNodeIDs);
            }
            else
            {
                foreach(Node2D node in currCell.Elements.Values)
                {
                    if(collision.ElementCollision(node.Loc))
                    {
                        outputNodeIDs.Add(node.ID);
                    }
                }
            }
        }
    }
}

public class QuadTreeCircleCollition : IQuadTreeCollision<Node2D>
{
    public readonly Vector2 Loc;
    public readonly float Radius;
    public QuadTreeCircleCollition(Vector2 loc, float radius)
    {
        Loc = loc;
        Radius = radius;
    }
    
    public bool CellCollision(IReadOnlyQuadTreeCell<Node2D> cell)
    {
        Vector2 circleAxisDist = new(MathF.Abs(Loc.X - cell.Center.X), MathF.Abs(Loc.Y - cell.Center.Y));

        if(circleAxisDist.X <= cell.HalfWidth || circleAxisDist.Y <= cell.HalfHeight)
        {
            return true;
        }

        if(circleAxisDist.X > cell.HalfWidth + Radius || circleAxisDist.Y > cell.HalfHeight + Radius)
        {
            return false;
        }

        float cornerDistSquared = MathF.Pow(circleAxisDist.X - cell.HalfWidth, 2) + MathF.Pow(circleAxisDist.Y - cell.HalfHeight, 2);
        return cornerDistSquared <= MathF.Pow(Radius, 2);
    }

    public bool ElementCollision(Vector2 point) => MathF.Pow(Loc.X - point.X, 2) + MathF.Pow(Loc.Y - point.Y, 2) <= Radius;
}

public class QuadTreeAABBCollision : IQuadTreeCollision<Node2D>
{
    public readonly Vector2 TopLeft;
    public readonly Vector2 BottomRight;

    public QuadTreeAABBCollision(Vector2 TopLeft, Vector2 BottomRight)
    {
        this.TopLeft = TopLeft;
        this.BottomRight = BottomRight;
    }

    public bool CellCollision(IReadOnlyQuadTreeCell<Node2D> cell)
    {
        throw new NotImplementedException();
    }

    public bool ElementCollision(Vector2 point)
    {
        throw new NotImplementedException();
    }
}