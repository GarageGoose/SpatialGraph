using System.Numerics;
using GG.SpatialGraph.Metadata;
namespace GG.SpatialGraph.Spatial;

public class QuadTreeNodes : GraphMetadata<Node2D>
{
    QuadTreeCell<Node2D> parentCell;
    Dictionary<uint, QuadTreeCell<Node2D>> cellOfNodes = new();
    public IReadOnlyQuadTreeCell<Node2D> CellOfNode(uint NodeID) => cellOfNodes[NodeID];
    public IReadOnlyQuadTreeCell<Node2D> ParentCell => parentCell;

    public QuadTreeNodes(IReadOnlyTrackedGraph<Node2D> baseGraph, Vector2 origin, float width = 100f, float height = 100f, uint nodeCapacity = 1) : base(baseGraph)
    {
        parentCell = new(nodeCapacity, origin, width, height);
        foreach(Node2D node in Nodes.Values)
        {
            CheckAndGrowCellToBounds(node.Loc);
            AddNode(node, parentCell);
        }
    }

    protected override void OnGraphUpdate(IReadOnlyModificationLog<Node2D> modLog)
    {
        foreach (ElementModificationLog<Node2D> node in modLog.NodeMods.Values)
        {
            switch (node.ModType)
            {
                case ModificationType.Add:
                    CheckAndGrowCellToBounds(node.NewElement!.Value.Loc);
                    AddNode(node.NewElement!.Value, parentCell);
                break;

                case ModificationType.Modify:
                    RemoveNode(node.NewElement!.Value.ID);
                    CheckAndGrowCellToBounds(node.NewElement!.Value.Loc);
                    AddNode(node.NewElement!.Value, parentCell);
                break;

                case ModificationType.Remove:
                    RemoveNode(node.NewElement!.Value.ID);
                break;
            }
        }
    }

    void AddNode(Node2D node, QuadTreeCell<Node2D> currCell)
    {
        if (currCell.Elements.Count >= currCell.ElementCapacity && !currCell.Subdivided)
        {
            currCell.Subdivide();
            foreach(Node2D nodeInCell in currCell.elements.Values)
            {
                cellOfNodes[nodeInCell.ID] = NodeToChildren(currCell, nodeInCell);
            }
            currCell.elements.Clear();
        }
        else if (currCell.Subdivided)
        {
            NodeToChildren(currCell, node);
            return;
        }
        currCell.elements.Add(node.ID, node);
        cellOfNodes[node.ID] = currCell;
    }

    void RemoveNode(uint ID)
    {
        cellOfNodes[ID].elements.Remove(ID);
        cellOfNodes.Remove(ID);
    }

    QuadTreeCell<Node2D> NodeToChildren(QuadTreeCell<Node2D> currCell, Node2D node)
    {
        if(node.Loc.X < currCell.Center.X)
        {
            if(node.Loc.Y < currCell.Center.Y)
            {
                AddNode(node, currCell.SouthWest!);
                return currCell.SouthWest!;
            }
            AddNode(node, currCell.NorthWest!);
            return currCell.NorthWest!;
        }
        if(node.Loc.Y < currCell.Center.Y)
        {
            AddNode(node, currCell.SouthEast!);
            return currCell.SouthEast!;
        }
        AddNode(node, currCell.NorthEast!);
        return currCell.NorthEast!;
    }
    void CheckAndGrowCellToBounds(Vector2 loc)
    {
        QuadTreeCell<Node2D> newParent;

        bool newCellToTheLeftOfTheParent = loc.X < parentCell.TopLeftCorner.X;
        bool newCellToTheRightOfTheParent = loc.X > parentCell.BottomRightCorner.X;
        bool newCellAboveParent = loc.Y > parentCell.TopLeftCorner.Y;
        bool newCellBelowParent = loc.Y < parentCell.BottomRightCorner.Y;

        //Do nothing if the loc is inside the parent cell
        if(!newCellAboveParent && !newCellBelowParent && !newCellToTheLeftOfTheParent && !newCellToTheRightOfTheParent)
        {
            return;
        }

        //Place the position of the hypothetical new cell the same as the current cell.
        Vector2 newCellPos = parentCell.TopLeftCorner;

        //Shift the X position of the new cell one cell to the left or to the right depending on loc
        newCellPos.X += newCellToTheLeftOfTheParent ? - parentCell.Width : newCellToTheRightOfTheParent ? parentCell.Width : 0f;

        //Shift the Y position of the new cell one cell up or down depending on loc
        newCellPos.Y += newCellAboveParent ? parentCell.Height : newCellBelowParent ? - parentCell.Height : 0f;

        //Determine the position of the new parent cell. This cell should store the new cell and the parent cell at one of its quadrants.
        //For the X position, the minimum value of either the new cell or the parent cell is used since the origin X coods of the cell is to the left.
        //For the Y position, the maximum value of either the new cell or the parent cell is used since the origin Y coods of the cell is to the top.
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
            else
            {
                // |P    N|P
                //N|  or  |
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
            else
            {
                //P|     P|N
                // |N or  |
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
                //P|     PN|  < Both new and old parent cell occupying the same quadrant
                //N|  or   |
                newParent.Subdivide(parentCell, null, null, null);
            }
        }
        
        parentCell = newParent;

        //Recursively check again untill the new parent cell now encompasses the given location
        CheckAndGrowCellToBounds(loc);
    }
}