using System.Numerics;
namespace GG.NodeGraph.Implementation;

internal class QuadTreeNodeCell
{
    //Children
    public QuadTreeNodeCell? NorthWest;
    public QuadTreeNodeCell? NorthEast;
    public QuadTreeNodeCell? SouthEast;
    public QuadTreeNodeCell? SouthWest;

    //Cell properties
    public bool Subdivided {get; private set;} = false;
    public readonly uint NodeCapacity;
    public HashSet<Node2D> Nodes = new();

    //Size and bounds
    public readonly Vector2 TopLeftCorner;
    public readonly Vector2 Center;
    public readonly Vector2 BottomRightCorner;
    public readonly float Width;
    public readonly float Height;

    public QuadTreeNodeCell(uint nodeCapacity, Vector2 originTopLeft, float width, float height)
    {
        NodeCapacity = nodeCapacity;
        TopLeftCorner = originTopLeft;
        Width = width;
        Height = height;
        Center = new(originTopLeft.X + (width / 2), originTopLeft.Y - (height - 2)); 
        BottomRightCorner = new(TopLeftCorner.X + width, TopLeftCorner.Y - Height);
    }

    //Assumes the new node is within the bounds of this cell.
    public void AddPoint(Node2D newNode)
    {
        if (Subdivided)
        {
            AddNodeToChild(newNode);
            return;
        }
        else if(Nodes.Count !< NodeCapacity)
        {
            NorthEast = new(NodeCapacity, TopLeftCorner, Width / 2, Height / 2);
            NorthWest = new(NodeCapacity, new(Center.X, TopLeftCorner.Y), Width / 2, Height / 2);
            SouthEast = new(NodeCapacity, new(TopLeftCorner.X, Center.Y), Width / 2, Height / 2);
            SouthWest = new(NodeCapacity, Center, Width / 2, Height / 2);
            Subdivided = true;

            AddNodeToChild(newNode);
            foreach(Node2D node in Nodes)
            {
                AddNodeToChild(node);
            }
            return;
        }
        Nodes.Add(newNode);
    }

    public HashSet<Node2D> CollisionCircle(Vector2 loc, float radius)
    {
        HashSet<Node2D> collided = new();
        if (Subdivided)
        {
            if(CircleRectCol(loc, radius, NorthEast!.TopLeftCorner, NorthEast!.BottomRightCorner)) 
            {
                collided.UnionWith(NorthEast!.CollisionCircle(loc, radius));
            }
            if(CircleRectCol(loc, radius, NorthWest!.TopLeftCorner, NorthWest!.BottomRightCorner)) 
            {
                collided.UnionWith(NorthWest!.CollisionCircle(loc, radius));
            }
            if(CircleRectCol(loc, radius, SouthEast!.TopLeftCorner, SouthEast!.BottomRightCorner)) 
            {
                collided.UnionWith(SouthEast!.CollisionCircle(loc, radius));
            }
            if(CircleRectCol(loc, radius, SouthWest!.TopLeftCorner, SouthWest!.BottomRightCorner)) 
            {
                collided.UnionWith(SouthWest!.CollisionCircle(loc, radius));
            }
            return collided;
        }
        foreach(Node2D node in Nodes)
        {
            if(node.Loc.X >= TopLeftCorner.X && node.Loc.X <= BottomRightCorner.X && node.Loc.Y >= TopLeftCorner.Y && node.Loc.Y <= TopLeftCorner.Y && node.Loc.Y >= BottomRightCorner.Y)
            {
                collided.Add(node);
            }
        }
        return collided;
    }

    private void AddNodeToChild(Node2D node)
    {
        if(Center.X < node.Loc.X)
        {
            if(Center.Y < node.Loc.Y)
            {
                NorthEast!.AddPoint(node);
                return;
            }
            SouthEast!.AddPoint(node);
            return;
        }
        if(Center.Y < node.Loc.Y)
        {
            SouthEast!.AddPoint(node);
            return;
        }
        SouthWest!.AddPoint(node);
    }

    private bool CircleRectCol(Vector2 circleLoc, float circleRadius, Vector2 rectTopLeft, Vector2 rectBottomRight)
    {
        //Get either left or right edge of the rectangle whichever is the closest to the circle.
        float testX = circleLoc.X < rectTopLeft.X ? rectTopLeft.X : circleLoc.X > rectBottomRight.X ? rectBottomRight.X : circleLoc.X;

        //Get either left or right edge of the rectangle whichever is the closest to the circle.
        float testY = circleLoc.Y < rectTopLeft.Y ? rectTopLeft.Y : circleLoc.Y > rectBottomRight.Y ? rectBottomRight.Y : circleLoc.Y;

        float distX = circleLoc.X - testX;
        float distY = circleLoc.Y - testY;

        float dist = (distX * distX) + (distY * distY);
        return dist <= circleRadius * 2;
    }
}

