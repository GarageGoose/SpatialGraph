using System.Numerics;
using SpatialGraph.Extensions;
namespace SpatialGraph.Metadata;

internal class QuadTreeNodeCell : IReadOnlyQuadTreeNodeCell
{
    public QuadTreeNodeCell(QuadTreeNode parent, int cellCapacity, Vector2 originTopLeft, float width, float height, QuadTreeNodeCell? parentCell = null)
    {
        Parent = parent;
        _ParentCell = parentCell;
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
    readonly QuadTreeNode Parent;

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
    internal QuadTreeNodeCell? _ParentCell;
    public IReadOnlyQuadTreeNodeCell? ParentCell() => _ParentCell;

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
        _UpperLeft = new(Parent, CellCapacity, new(East, North), Width / 2, Height / 2, this);
        _LowerLeft = new(Parent, CellCapacity, new(East, Center.Y), Width / 2, Height / 2, this);
        _UpperRight = new(Parent, CellCapacity, new(Center.X, East), Width / 2, Height / 2, this);
        _LowerRight = new(Parent, CellCapacity, Center, Width / 2, Height / 2, this);
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

/// <summary>
/// A specific region in a quadtree which holds nodes or if subdivided,
/// four sub quad trees each on the of the quadrant of the quadtree.
/// </summary>
public interface IReadOnlyQuadTreeNodeCell
{
    /// <summary>
    /// Indicated if a cell is subdivided.
    /// Subdivided cells contains four child cells on each of its quadrant.
    /// Else it contains nodes in it.
    /// </summary>
    bool Subdivided {get;}

    /// <summary>
    /// Maximum amount of nodes allowed in this cell before being subdivied.
    /// </summary>
    int CellCapacity {get;}

    /// <summary>
    /// Upper left (Northwest) quadrant of the cell.
    /// </summary>
    /// <returns>Quad tree cell, null if the cell isn't subdivided yet.</returns>
    IReadOnlyQuadTreeNodeCell? UpperLeft();

    /// <summary>
    /// Upper right (Northeast) quadrant of the cell.
    /// </summary>
    /// <returns>Quad tree cell, null if the cell isn't subdivided yet.</returns>
    IReadOnlyQuadTreeNodeCell? UpperRight();

    /// <summary>
    /// Lower left (Southwest) quadrant of the cell.
    /// </summary>
    /// <returns>Quad tree cell, null if the cell isn't subdivided yet.</returns>
    IReadOnlyQuadTreeNodeCell? LowerLeft();

    /// <summary>
    /// Lower right (Southeast) quadrant of the cell.
    /// </summary>
    /// <returns>Quad tree cell, null if the cell isn't subdivided yet.</returns>
    IReadOnlyQuadTreeNodeCell? LowerRight();

    /// <summary>
    /// Upper left (Northwest) quadrant of the cell.
    /// </summary>
    /// <returns>Quad tree cell, null if the current cell is the parent cell.</returns>
    IReadOnlyQuadTreeNodeCell? ParentCell();

    /// <summary>
    /// Nodes stored in this cell. Set is empty if the cell is subdivided.
    /// </summary>
    IReadOnlySet<Node2D> Nodes {get;}

    /// <summary>
    /// Upper border of the cell.
    /// </summary>
    float North {get;}

    /// <summary>
    /// Leftmost border of the cell.
    /// </summary>
    float West {get;}

    /// <summary>
    /// Rightmost border of the cell.
    /// </summary>
    float East {get;}

    /// <summary>
    /// Lower border of the cell.
    /// </summary>
    float South {get;}

    /// <summary>
    /// Center point of the cell.
    /// </summary>
    Vector2 Center {get;}

    /// <summary>
    /// Width of the cell.
    /// </summary>
    float Width {get;}

    /// <summary>
    /// Height of the cell.
    /// </summary>
    float Height {get;}
}