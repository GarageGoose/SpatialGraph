using System.Numerics;
namespace GG.SpatialGraph.Spatial;

public class QuadTreeCell<TElement> : IReadOnlyQuadTreeCell<TElement> where TElement : IElement
{
    //Children
    public QuadTreeCell<TElement>? NorthWest {get; private set;}
    public QuadTreeCell<TElement>? NorthEast {get; private set;}
    public QuadTreeCell<TElement>? SouthEast {get; private set;}
    public QuadTreeCell<TElement>? SouthWest {get; private set;}

    public IReadOnlyQuadTreeCell<TElement>? NorthWestRO => NorthWest;
    public IReadOnlyQuadTreeCell<TElement>? NorthEastRO => NorthEast;
    public IReadOnlyQuadTreeCell<TElement>? SouthEastRO => SouthWest;
    public IReadOnlyQuadTreeCell<TElement>? SouthWestRO => SouthEast;
    

    //Cell properties
    public bool Subdivided {get; private set;} = false;

    public uint ElementCapacity {get; private set;}
    public Dictionary<uint, TElement> elements = new();
    public IReadOnlyDictionary<uint, TElement> Elements => elements;

    //Size and bounds
    public Vector2 TopLeftCorner {get; private set;}
    public Vector2 Center {get; private set;}
    public Vector2 BottomRightCorner {get; private set;}
    public float Width {get; private set;}
    public float Height {get; private set;}

    public QuadTreeCell(uint nodeCapacity, Vector2 originTopLeft, float width, float height)
    {
        ElementCapacity = nodeCapacity;
        TopLeftCorner = originTopLeft;
        Width = width;
        Height = height;
        Center = new(originTopLeft.X + (width / 2), originTopLeft.Y - (height - 2)); 
        BottomRightCorner = new(TopLeftCorner.X + width, TopLeftCorner.Y - Height);
    }

    public void Subdivide()
    {
        NorthEast = new(ElementCapacity, TopLeftCorner, Width / 2, Height / 2);
        NorthWest = new(ElementCapacity, new(Center.X, TopLeftCorner.Y), Width / 2, Height / 2);
        SouthEast = new(ElementCapacity, new(TopLeftCorner.X, Center.Y), Width / 2, Height / 2);
        SouthWest = new(ElementCapacity, Center, Width / 2, Height / 2);
        Subdivided = true;
    }

    public void Subdivide(QuadTreeCell<TElement>? northWest, QuadTreeCell<TElement>? northEast, QuadTreeCell<TElement>? southWest, QuadTreeCell<TElement>? southEast)
    {
        NorthEast = northEast == null ? new(ElementCapacity, TopLeftCorner, Width / 2, Height / 2) : northEast;
        NorthWest = northWest == null ? new(ElementCapacity, new(Center.X, TopLeftCorner.Y), Width / 2, Height / 2) : northWest;
        SouthEast = southEast == null ? new(ElementCapacity, new(TopLeftCorner.X, Center.Y), Width / 2, Height / 2) : southEast;
        SouthWest = southWest == null ? new(ElementCapacity, Center, Width / 2, Height / 2) : southWest;
        Subdivided = true;
    }

    public void RemoveElement(uint NodeID) => elements.Remove(NodeID);
}

public interface IReadOnlyQuadTreeCell<TElement> where TElement : IElement
{
    IReadOnlyQuadTreeCell<TElement>? NorthWestRO {get;}
    IReadOnlyQuadTreeCell<TElement>? NorthEastRO {get;}
    IReadOnlyQuadTreeCell<TElement>? SouthEastRO {get;}
    IReadOnlyQuadTreeCell<TElement>? SouthWestRO {get;}

    uint ElementCapacity {get;}
    IReadOnlyDictionary<uint, TElement> Elements {get;}

    Vector2 TopLeftCorner {get;}
    Vector2 Center {get;}
    Vector2 BottomRightCorner {get;}
    float Width {get;}
    float Height {get;}
}