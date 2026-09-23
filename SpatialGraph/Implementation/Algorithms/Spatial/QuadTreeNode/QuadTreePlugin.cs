using System.Numerics;
using GG.SpatialGraph.Metadata;
using GG.SpatialGraph.Internal;

namespace GG.SpatialGraph.Spatial;

public class QuadTreeNode : GraphReadOnlyPlugin<Node2D>, IGraphSpatialNode2D
{
    QuadTreeNodeCell ParentCell;
    internal Dictionary<uint, QuadTreeNodeCell> nodeCurrCell = new();

    public QuadTreeNode(ITrackedGraph<Node2D> graph, int cellCapacity, Vector2 originTopLeft, float width, float height) : base(graph)
    {
        ParentCell = new(this, cellCapacity, originTopLeft, width, height);
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

    public void AddPoint(Node2D node)
    {
        if (!ParentCell.AddPoint(node)) //Outside of the parent cell boundary if false.
        {
            //Create new cell and add the current parent cell as its child.
            bool OutsideLeft = ParentCell.West > node.Loc.X;
            bool OutsideUp = ParentCell.North < node.Loc.Y;
            
            float newCellPosX = ParentCell.West;
            newCellPosX -= OutsideLeft ? - ParentCell.Width : 0;

            float newCellPosY = ParentCell.North;
            newCellPosY += OutsideUp ? ParentCell.Height : 0;
            
            QuadTreeNodeCell newCell = new(this, ParentCell.CellCapacity, new(newCellPosX, newCellPosY), ParentCell.Width * 2, ParentCell.Height * 2);
            newCell.Subdivide();

            if (OutsideLeft)
            {
                if (OutsideUp)
                {
                    newCell.LR = ParentCell;
                }
                else
                {
                    newCell.UR = ParentCell;
                }
            }
            else
            {
                if (OutsideUp)
                {
                    newCell.LL = ParentCell;
                }
                else
                {
                    newCell.UL = ParentCell;
                }
            }
            ParentCell = newCell;
            AddPoint(node); //Recursively try again
            return;
        }
    }

    public uint QueryNodeNearestNeighbor(uint nodeIDSource)
    {
        return 0;
    }

    public IEnumerable<uint> QueryNodeNearestNeighbors(uint nodeIDSource, int count)
    {
        yield return 0;
    }

    public IEnumerable<uint> QueryNodesAABB(Vector2 topLeftCorner, float width, float height)
    {
        yield return 0;
    }

    public IEnumerable<uint> QueryNodesRadius(Vector2 location, float radius)
    {
        yield return 0;
    }
}