using System.Numerics;
using SpatialGraph.Metadata;
using SpatialGraph.Internal;

namespace SpatialGraph.Spatial;

/// <summary>
/// Quadtree implementation for nodes in a graph. Enables spatial indexing for nodes.
/// </summary>
public class QuadTreeNode : GraphReadOnlyPlugin<Node2D>
{
    QuadTreeNodeCell _ParentCell;

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public IReadOnlyQuadTreeNodeCell ParentCell() => _ParentCell;

    internal Dictionary<uint, QuadTreeNodeCell> nodeCurrCell = new();

    public QuadTreeNode(ITrackedGraph<Node2D> graph, int cellCapacity, Vector2 originTopLeft, float width, float height) : base(graph)
    {
        _ParentCell = new(this, cellCapacity, originTopLeft, width, height);
    }

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
        //The new node is outside of the parent cell if the condition within the if statement is false.
        //If so, create new cell and add the current parent cell as its child.
        if (!_ParentCell.AddPoint(node)) 
        {
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
            QuadTreeNodeCell newCell = new(this, _ParentCell.CellCapacity, NewCellPosition, _ParentCell.Width * 2, _ParentCell.Height * 2);
            newCell.Subdivide();
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