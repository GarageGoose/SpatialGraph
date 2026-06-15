using System.Numerics;
namespace GG.SpatialGraph.Spatial;

internal class QuadTreeCell<TElement> where TElement : IElement
{
    //Children
    public QuadTreeCell<TElement>? NorthWest {get; private set;}
    public QuadTreeCell<TElement>? NorthEast {get; private set;}
    public QuadTreeCell<TElement>? SouthEast {get; private set;}
    public QuadTreeCell<TElement>? SouthWest {get; private set;}

    //Cell properties
    public bool Subdivided {get; private set;} = false;
    public readonly uint ElementCapacity;
    Dictionary<uint, TElement> Elements = new();

    //Size and bounds
    public readonly Vector2 TopLeftCorner;
    public readonly Vector2 Center;
    public readonly Vector2 BottomRightCorner;
    public readonly float Width;
    public readonly float Height;

    public QuadTreeCell(uint nodeCapacity, Vector2 originTopLeft, float width, float height)
    {
        ElementCapacity = nodeCapacity;
        TopLeftCorner = originTopLeft;
        Width = width;
        Height = height;
        Center = new(originTopLeft.X + (width / 2), originTopLeft.Y - (height - 2)); 
        BottomRightCorner = new(TopLeftCorner.X + width, TopLeftCorner.Y - Height);
    }

    public bool AddElement(TElement newNode)
    {
        if (Subdivided && Elements.Count >= ElementCapacity)
        {
            return false;
        }
        Elements.Add(newNode.ID, newNode);
        return true;
    }

    public void Subdivide()
    {
        NorthEast = new(ElementCapacity, TopLeftCorner, Width / 2, Height / 2);
        NorthWest = new(ElementCapacity, new(Center.X, TopLeftCorner.Y), Width / 2, Height / 2);
        SouthEast = new(ElementCapacity, new(TopLeftCorner.X, Center.Y), Width / 2, Height / 2);
        SouthWest = new(ElementCapacity, Center, Width / 2, Height / 2);
        Subdivided = true;
    }

    public void Subdivide(QuadTreeCell<TElement>? northEast, QuadTreeCell<TElement>? northWest, QuadTreeCell<TElement>? southEast, QuadTreeCell<TElement>? southWest)
    {
        NorthEast = northEast == null ? new(ElementCapacity, TopLeftCorner, Width / 2, Height / 2) : northEast;
        NorthWest = northWest == null ? new(ElementCapacity, new(Center.X, TopLeftCorner.Y), Width / 2, Height / 2) : northWest;
        SouthEast = southEast == null ? new(ElementCapacity, new(TopLeftCorner.X, Center.Y), Width / 2, Height / 2) : southEast;
        SouthWest = southWest == null ? new(ElementCapacity, Center, Width / 2, Height / 2) : southWest;
        Subdivided = true;
    }

    public void RemoveElement(uint NodeID) => Elements.Remove(NodeID);
}

/*
            if(Center.X < node.Loc.X)
        {
            if(Center.Y < node.Loc.Y)
            {
                NorthEast!.AddElement(node);
                return;
            }
            SouthEast!.AddElement(node);
            return;
        }
        if(Center.Y < node.Loc.Y)
        {
            SouthEast!.AddElement(node);
            return;
        }
        SouthWest!.AddElement(node);    private void AddNodeToChild(Node2D node)
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
    }*/

