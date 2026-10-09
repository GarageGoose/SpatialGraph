using System.Numerics;
namespace SpatialGraph.Metadata;

internal class QuadTreeNodeCell : IReadOnlyQuadTreeNodeCell
{
    public QuadTreeNodeCell(QuadTreeNode parent, int cellCapacity, Vector2 originTopLeft, float width, float height, int depth, QuadTreeNodeCell? parentCell = null)
    {
        Parent = parent;
        _ParentCell = parentCell;
        CellCapacity = cellCapacity;
        _Nodes = new(cellCapacity);
        Nodes = _Nodes;
        Depth = depth;

        //Setup cell bounds
        North = originTopLeft.Y;
        West = originTopLeft.X;
        East = originTopLeft.X + width;
        South = originTopLeft.Y - height;
        Center = new(originTopLeft.X + (width / 2), originTopLeft.Y - (height / 2));
        Width = width;
        Height = height;
        _HalfHeight = height / 2;
        _HalfWidth = width / 2;
    }

    //Parent plugin of cell
    readonly QuadTreeNode Parent;

    //Cell state
    public bool Subdivided {get; private set;} = false;
    public int CellCapacity {get;}
    public int Depth {get;}

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

    readonly Dictionary<uint, Node2D> _Nodes;
    public IReadOnlyDictionary<uint, Node2D> Nodes {get;}

    //Cell bounds
    public float North {get;}
    public float West {get;} //West is on the LEFT, just like the western hemisphere is on the left.
    public float East {get;}
    public float South {get;}
    public Vector2 Center {get;}
    public float Width {get;}
    public float Height {get;}
    float _HalfWidth;
    float _HalfHeight;

    internal bool AddPoint(Node2D point)
    {
        if (Subdivided)
        {
            TransferNodeToSubCell(point);
            return true;
        }
        else if (_Nodes.Count >= CellCapacity && Depth < Parent.MaxDepth)
        {
            Subdivide();
            TransferNodeToSubCell(point);
            return true;
        }

        _Nodes[point.ID] = point;
        Parent.nodeCurrCell[point.ID] = this;

        return true;
    }

    //Assumes the point exists
    internal void RemovePoint(uint iD)
    {
        _Nodes.Remove(iD);
        Parent.nodeCurrCell.Remove(iD);
        return;
    }

    void Subdivide()
    {
        Subdivided = true;
        foreach(Node2D node in _Nodes.Values)
        {
            TransferNodeToSubCell(node);
        }
        _Nodes.Clear();
    }

    void TransferNodeToSubCell(Node2D point)
    {
        if(point.Loc.X < Center.X)
        {
            if(point.Loc.Y > Center.Y)
            {
                _UpperLeft ??= new(Parent, CellCapacity, new(West, North), _HalfWidth, _HalfHeight, Depth + 1, this);
                _UpperLeft.AddPoint(point); 
            }
            else
            {
                _LowerLeft ??= new(Parent, CellCapacity, new(West, Center.Y), _HalfWidth, _HalfHeight, Depth + 1, this);
                _LowerLeft.AddPoint(point);
            }
        }
        else
        {
            if(point.Loc.Y > Center.Y)
            {
                _UpperRight ??= new(Parent, CellCapacity, new(Center.X, North), _HalfWidth, _HalfHeight, Depth + 1, this);
                _UpperRight.AddPoint(point);
            }
            else
            {
                _LowerRight ??= new(Parent, CellCapacity, Center, _HalfWidth, _HalfHeight, Depth + 1, this);
                _LowerRight.AddPoint(point);
            }
        }
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
    /// Note that Child cells are created lazily when a node is inserted into that quadrant.
    /// Else it contains nodes in it.
    /// </summary>
    bool Subdivided {get;}

    /// <summary>
    /// Maximum amount of nodes allowed in this cell before being subdivied.
    /// </summary>
    int CellCapacity {get;}

    /// <summary>
    /// Depth of the cell, relative to the depth of the original parent cell (0). Subdivision increases depth.
    /// </summary>
    int Depth {get;}

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
    /// Parent of the cell.
    /// </summary>
    /// <returns>Quad tree cell, null if the current cell is the root parent cell.</returns>
    IReadOnlyQuadTreeNodeCell? ParentCell();

    /// <summary>
    /// Nodes stored in this cell. Set is empty if the cell is subdivided.
    /// </summary>
    IReadOnlyDictionary<uint, Node2D> Nodes {get;}

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