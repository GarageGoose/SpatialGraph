using System.Numerics;
using GG.SpatialGraph.Metadata;
namespace GG.SpatialGraph.Spatial;

public class QuadTreeNodes : GraphMetadata<Node2D>
{
    QuadTreeNodeCell parentCell;

    public QuadTreeNodes(IReadOnlyTrackedGraph<Node2D> baseGraph, Vector2 origin, float width = 100f, float height = 100f, uint nodeCapacity = 1) : base(baseGraph)
    {
        parentCell = new(nodeCapacity, origin, width, height);
    }

    protected override void OnInitialize()
    {
        
    }

    protected override void OnGraphUpdate(object? sender, IReadOnlyModificationLog<Node2D> e)
    {
        foreach (ElementModificationLog<Node2D> node in e.NodeMods.Values)
        {
            switch (node.ModType)
            {
                case ModificationType.Add:
                    if(checkIfWithinBounds(node.NewElement!.Value.Loc))
                    {
                        parentCell.AddPoint(node.NewElement.Value);
                    }
                    else
                    {
                        
                    }
                break;

                case ModificationType.Modify:
                break;

                case ModificationType.Remove:
                break;
            }
        }
    }

    bool checkIfWithinBounds(Vector2 loc) => loc.X < parentCell.BottomRightCorner.X && loc.X > parentCell.TopLeftCorner.X && loc.Y < parentCell.TopLeftCorner.Y && loc.Y > parentCell.BottomRightCorner.Y;
    void growCellToBounds(Vector2 loc)
    {
        if(parentCell.Center.X < loc.X)
        {
            
        }
        else
        {
            
        }
    }
}