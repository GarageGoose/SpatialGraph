using System.Numerics;
using GG.SpatialGraph.Metadata;
using GG.SpatialGraph.Internal;

namespace GG.SpatialGraph.Spatial;

public class QuadTreeNode : GraphReadOnlyPlugin<Node2D>
{
    QuadTreeNodeCell _ParentCell;
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
        if (!_ParentCell.AddPoint(node)) //Outside of the parent cell boundary if false.
        {
            //Create new cell and add the current parent cell as its child.
            //What the fuck is happening here??
            bool OutsideLeft = _ParentCell.West > node.Loc.X;
            bool OutsideUp = _ParentCell.North < node.Loc.Y;
            
            float newCellPosX = _ParentCell.West;
            newCellPosX -= OutsideLeft ? - _ParentCell.Width : 0;

            float newCellPosY = _ParentCell.North;
            newCellPosY += OutsideUp ? _ParentCell.Height : 0;
            
            QuadTreeNodeCell newCell = new(this, _ParentCell.CellCapacity, new(newCellPosX, newCellPosY), _ParentCell.Width * 2, _ParentCell.Height * 2);
            newCell.Subdivide();

            //Huh?????!?!?!?!?!??!
            if (OutsideLeft)
            {
                if (OutsideUp)
                {
                    newCell._LowerRight = _ParentCell;
                }
                else
                {
                    newCell._UpperRight = _ParentCell;
                }
            }
            else
            {
                if (OutsideUp)
                {
                    newCell._LowerLeft = _ParentCell;
                }
                else
                {
                    newCell._UpperLeft = _ParentCell;
                }
            }
            _ParentCell = newCell;
            AddPoint(node); //Recursively try again
            return;
        }
    }
}