using System.Numerics;
using SpatialGraph.Extensions;

namespace SpatialGraph.Metadata;

/// <summary>
/// Quadtree implementation for nodes in a graph. Enables spatial indexing for nodes.
/// </summary>
/// <seealso cref="QuadTreeNodeOperations"/>
public class QuadTreeNode : GraphReadOnlyPlugin<Node2D>
{
    QuadTreeNodeCell _ParentCell;

    /// <summary>
    /// Parent cell of the quadtree.
    /// </summary>
    /// <returns>Parent cell.</returns>
    public IReadOnlyQuadTreeNodeCell ParentCell() => _ParentCell;

    internal Dictionary<uint, QuadTreeNodeCell> nodeCurrCell = new();

    /// <summary>
    /// Maximum amount the cell is allowed to subdivide relative to the original depth. Does not affect creating new parent cells when enlarging the quadtree.
    /// </summary>
    public readonly int MaxDepth;

    /// <summary>
    /// Get the cell of a node.
    /// </summary>
    /// <param name="NodeID">ID of the node.</param>
    /// <returns>Cell which contains the node.</returns>
    public IReadOnlyQuadTreeNodeCell CurrentCellOfNode(uint NodeID) => nodeCurrCell[NodeID];

    /// <summary>
    /// New instance of a node quad tree.
    /// </summary>
    /// <param name="graph">Graph to record the nodes from.</param>
    /// <param name="cellCapacity">Maximum amount of nodes in a cell before subdividing.</param>
    /// <param name="originTopLeft">Top left corner of the parent cell.</param>
    /// <param name="width">Width of the cell.</param>
    /// <param name="height">Height of the cell.</param>
    /// <param name="cellMinBoundingBox">Generate minimum bounding box of the points contained in a cell. Optimizes operations for certain lookups but has performance penalty for point insertion/deletion.</param>
    /// <param name="maxDepth">Maximum amount the cell is allowed to subdivide relative to the original depth. Does not affect creating new parent cells when enlarging the quadtree.</param>
    public QuadTreeNode(IObservableGraph<Node2D> graph, int cellCapacity, Vector2 originTopLeft, float width, float height, bool cellMinBoundingBox = true, int maxDepth = 10) : base(graph)
    {
        MaxDepth = maxDepth;
        _ParentCell = new(this, cellCapacity, originTopLeft, width, height, 0);
    }

    /// <inheritdoc/>
    protected override void OnGraphUpdate(object? sender, IReadOnlyModificationLog<Node2D> modLog)
    {
        foreach(ElementAdded<Node2D> node in modLog.NewNodes.Values)
        {
            AddPoint(node.Element);
        }
        foreach(ElementModified<Node2D> node in modLog.ModifiedNodes.Values)
        {
            nodeCurrCell[node.ID].RemovePoint(node.ID);
            AddPoint(node.NewElement);
        }
        foreach(ElementRemoved<Node2D> node in modLog.RemovedNodes.Values)
        {
            nodeCurrCell[node.ID].RemovePoint(node.ID);
        }
    }

    void AddPoint(Node2D node)
    {
        if (node.IsNodeWithinAABB(new(_ParentCell.West, _ParentCell.North), _ParentCell.Width, _ParentCell.Height))
        {
            _ParentCell.AddPoint(node);
        }
        else
        {
            //Create new cell and add the current parent cell as its child.

            //X increases rightwards, Y upwards.
            //West is on the left, east on right.

            //Since the origin of a cell is in its top left, we only need to check if the new node
            //is to the left or right of the cells left (west) boundary. Note that the new parent cell is
            //2x bigger on the X and Y direction. If the new node is to the left of its west boundary
            //(OutsideLeft == true), let the new parent cell grow to the left of the current parent cell, covering both
            //the current parent cell and the new cell, else (new node on the right of the west bounds) let it grow on 
            //the same X axis, covering a large area on the right of the current parent cell. If the new cell is still
            //out of bounds, let it recursively grow again.

            bool OutsideLeft = _ParentCell.West > node.Loc.X;
            float newCellPosX = _ParentCell.West;
            if (OutsideLeft)
            {
                newCellPosX -= _ParentCell.Width;
            }

            //Same idea for this.
            bool OutsideUp = _ParentCell.North < node.Loc.Y;
            float newCellPosY = _ParentCell.North;
            if (OutsideUp)
            {
                newCellPosY += _ParentCell.Height;
            }

            Vector2 NewCellPosition = new(newCellPosX, newCellPosY);
            QuadTreeNodeCell newCell = new(this, _ParentCell.CellCapacity, NewCellPosition, _ParentCell.Width * 2, _ParentCell.Height * 2, _ParentCell.Depth - 1);
            _ParentCell._ParentCell = newCell;

            //Assign the old parent cell as a child of the new parent cell.
            if (OutsideLeft)
            {
                //The new node is to the left of the old parent cell, which would make the old parent cell on the lower or upper right.
                if (OutsideUp)
                {
                    //The new cell is on top of the old parent cell, which would make it on the lower left or right.
                    newCell._LowerRight = _ParentCell;
                }
                else
                {
                    //The new cell is on the bottom of the old parent cell, which would make it on the upper left or right.
                    newCell._UpperRight = _ParentCell;
                }
            }
            else
            {
                //The new node is to the right of the old parent cell, which would make the old parent cell on the lower or upper left.
                if (OutsideUp)
                {
                    //The new cell is on top of the old parent cell, which would make it on the lower left or right.
                    newCell._LowerLeft = _ParentCell;
                }
                else
                {
                    //The new cell is on the bottom of the old parent cell, which would make it on the upper left or right.
                    newCell._UpperLeft = _ParentCell;
                }
            }
            _ParentCell = newCell;

            AddPoint(node); //Recursively try again if the cell is still outside of the boundary.
            return;
        }
    }
}