using System.IO.Compression;
using System.Numerics;
using GG.SpatialGraph.Spatial;
namespace GG.SpatialGraph.Internal;

internal class QuadTreeNodeCell : IReadOnlyQuadTreeNodeCell
{
    //Construct without nodes
    public QuadTreeNodeCell(QuadTreeNode parent, int cellCapacity, Vector2 originTopLeft, float width, float height)
    {
        Parent = parent;
        CellCapacity = cellCapacity;
        _Nodes = new(cellCapacity);
        Nodes = _Nodes;

        //Setup cell bounds
        North = originTopLeft.Y;
        West = originTopLeft.X + width;
        East = originTopLeft.X;
        South = originTopLeft.Y - height;
        Center = new(originTopLeft.X + (width / 2), originTopLeft.Y - (height / 2));
        Width = width;
        Height = height;
    }

    //Parent plugin of cell
    QuadTreeNode Parent;

    //Cell state
    public bool Subdivided {get; private set;} = false;
    public int CellCapacity {get;}

    //Cell contents
    internal QuadTreeNodeCell? _UpperLeft;
    public IReadOnlyQuadTreeNodeCell? UpperLeft() => _UpperLeft;
    internal QuadTreeNodeCell? _UpperRight;
    public IReadOnlyQuadTreeNodeCell? UpperRight() => _UpperRight;
    internal QuadTreeNodeCell? _LowerLeft;
    public IReadOnlyQuadTreeNodeCell? LowerLeft() => _LowerLeft;
    internal QuadTreeNodeCell? _LowerRight;
    public IReadOnlyQuadTreeNodeCell? LowerRight() => _LowerRight;

    readonly HashSet<Node2D> _Nodes;
    public IReadOnlySet<Node2D> Nodes {get;}

    //Cell bounds
    public float North {get;}
    public float West {get;} //West is on the LEFT, just like the western hemisphere is on the left.
    public float East {get;}
    public float South {get;}
    public Vector2 Center {get;}
    public float Width {get;}
    public float Height {get;}

    internal bool AddPoint(Node2D point)
    {
        if (Subdivided || _Nodes.Count >= CellCapacity)
        {
            return TransferNodeToSubCell(point);
        }
        if(!point.IsNodeWithinAABB(new(East, North), Width, Height))
        {
            return false;
        }
        _Nodes.Add(point);
        Parent.nodeCurrCell.Add(point.ID, this);
        return true;
    }

    internal void RemovePoint(uint iD)
    {
        foreach(Node2D node in _Nodes)
        {
            if(node.ID == iD)
            {
                _Nodes.Remove(node);
                Parent.nodeCurrCell.Remove(iD);
                return;
            }
        }
    }

    internal void Subdivide()
    {
        Subdivided = true;
        _UpperLeft = new(Parent, CellCapacity, new(East, North), Width / 2, Height / 2);
        _LowerLeft = new(Parent, CellCapacity, new(East, Center.Y), Width / 2, Height / 2);
        _UpperRight = new(Parent, CellCapacity, new(Center.X, East), Width / 2, Height / 2);
        _LowerRight = new(Parent, CellCapacity, Center, Width / 2, Height / 2);
        foreach(Node2D node in _Nodes)
        {
            TransferNodeToSubCell(node);
        }
        _Nodes.Clear();
    }

    bool TransferNodeToSubCell(Node2D point)
    {
        if(point.IsNodeWithinAABB(new(_UpperLeft!.East, _UpperLeft!.North), _UpperLeft!.Width, _UpperLeft!.Height))
        {
            return _UpperLeft!.AddPoint(point); 
        }
        if(point.IsNodeWithinAABB(new(_LowerLeft!.East, _LowerLeft!.North), _LowerLeft!.Width, _LowerLeft!.Height))
        {
            return _LowerLeft!.AddPoint(point);
        }
        if(point.IsNodeWithinAABB(new(_UpperRight!.East, _UpperRight!.North), _UpperRight!.Width, _UpperRight!.Height))
        {
            return _UpperRight!.AddPoint(point);
        }
        if(point.IsNodeWithinAABB(new(_LowerRight!.East, _LowerRight!.North), _LowerRight!.Width, _LowerRight!.Height))
        {
            return _LowerRight!.AddPoint(point);
        }
        return false;
    }
}

public interface IReadOnlyQuadTreeNodeCell
{
    bool Subdivided {get;}
    int CellCapacity {get;}

    IReadOnlyQuadTreeNodeCell? UpperLeft();
    IReadOnlyQuadTreeNodeCell? UpperRight();
    IReadOnlyQuadTreeNodeCell? LowerLeft();
    IReadOnlyQuadTreeNodeCell? LowerRight();

    IReadOnlySet<Node2D> Nodes {get;}

    float North {get;}
    float West {get;}
    float East {get;}
    float South {get;}
    Vector2 Center {get;}
    float Width {get;}
    float Height {get;}
}