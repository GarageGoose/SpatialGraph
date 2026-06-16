using System.Numerics;
using GG.SpatialGraph.Metadata;
namespace GG.SpatialGraph.Spatial;

public class QuadTreeNodes : GraphMetadata<Node2D>
{
    QuadTreeCell<Node2D> parentCell;

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
                    CheckAndGrowCellToBounds(node.NewElement!.Value.Loc);
                    parentCell.AddElement(node.NewElement!.Value);
                break;

                case ModificationType.Modify:
                break;

                case ModificationType.Remove:
                break;
            }
        }
    }
    void CheckAndGrowCellToBounds(Vector2 loc)
    {
        QuadTreeCell<Node2D> newParent;

        bool newCellToTheLeftOfTheParent = loc.X < parentCell.TopLeftCorner.X;
        bool newCellToTheRightOfTheParent = loc.X > parentCell.BottomRightCorner.X;
        bool newCellAboveParent = loc.Y > parentCell.TopLeftCorner.Y;
        bool newCellBelowParent = loc.Y < parentCell.BottomRightCorner.Y;

        if(!newCellAboveParent && !newCellBelowParent && !newCellToTheLeftOfTheParent && !newCellToTheLeftOfTheParent && !newCellToTheRightOfTheParent)
        {
            return;
        }

        Vector2 newCellPos = parentCell.TopLeftCorner;
        newCellPos.X += newCellToTheLeftOfTheParent ? - parentCell.Width : newCellToTheRightOfTheParent ? parentCell.Width : 0f;
        newCellPos.Y += newCellAboveParent ? parentCell.Height : newCellBelowParent ? - parentCell.Height : 0f;

        Vector2 newParentCellPos = new(MathF.Min(newCellPos.X, parentCell.TopLeftCorner.X), MathF.Max(newCellPos.Y, parentCell.TopLeftCorner.Y));

        newParent = new(parentCell.ElementCapacity, newParentCellPos, parentCell.Width * 2, parentCell.Height * 2);

        //Ill come back to this when I know better.
        //N = New cell
        //P = Old parent cell
        if (newCellToTheLeftOfTheParent)
        {
            if (newCellAboveParent)
            {
                //N|
                // |P
                newParent.Subdivide(null, null, null, parentCell);
            }
            else if (newCellBelowParent)
            {
                // |P
                //N|
                newParent.Subdivide(null, parentCell, null, null);
            }
            else
            {
                //N|P
                // |
                newParent.Subdivide(null, parentCell, null, null);
            }
        }
        else if (newCellToTheRightOfTheParent)
        {
            if (newCellAboveParent)
            {
                // |N
                //P|
                newParent.Subdivide(null, null, parentCell, null);
            }
            else if (newCellBelowParent)
            {
                //P|
                // |N
                newParent.Subdivide(parentCell, null, null, null);
            }
            else
            {
                //P|N
                // |
                newParent.Subdivide(parentCell, null, null, null);
            }
        }
        else
        {
            if (newCellAboveParent)
            {
                //N|
                //P|
                newParent.Subdivide(null, null, parentCell, null);
            }
            else if (newCellBelowParent)
            {
                //P|
                //N|
                newParent.Subdivide(parentCell, null, null, null);
            }
            else
            {
                //PN| < Both new and old parent cell occupying the same quadrant
                //  |
                newParent.Subdivide(null, null, null, null);
            }
        }
        
        parentCell = newParent;

        //Recursively check again untill the new parent cell now encompasses the given location
        CheckAndGrowCellToBounds(loc);
    }
}