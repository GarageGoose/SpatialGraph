using System.IO.Compression;
using System.Numerics;
using GG.SpatialGraph.Spatial;
namespace GG.SpatialGraph.Internal;

public class QuadTreeNodeCell : IReadOnlyQuadTreeNodeCell
{
    //Construct without nodes
    public QuadTreeNodeCell(QuadTreeNode parent, int cellCapacity, Vector2 originTopLeft, float width, float height)
    {
        Parent = parent;
        CellCapacity = cellCapacity;
        Nodes = new(cellCapacity);

        //Setup cell bounds
        North = originTopLeft.Y;
        East = originTopLeft.X;
        West = originTopLeft.X + width;
        South = originTopLeft.Y - height;
        Center = new(originTopLeft.X + (width / 2), originTopLeft.Y - (height / 2));
        Width = width;
        Height = height;
    }

    //Construct with nodes
    public QuadTreeNodeCell(QuadTreeNode parent, int cellCapacity, List<Node2D> nodes, Vector2 originTopLeft, float width, float height)
    {
        Parent = parent;
        CellCapacity = cellCapacity;
        Nodes = [.. nodes];

        //Setup cell bounds
        North = originTopLeft.Y;
        East = originTopLeft.X;
        West = originTopLeft.X + width;
        South = originTopLeft.Y - height;
        Center = new(originTopLeft.X + (width / 2), originTopLeft.Y - (height / 2));
        Width = width;
        Height = height;
    }

    //Cell parent plugin
    QuadTreeNode Parent;

    //Cell state
    public bool Subdivided {get; private set;} = false;
    public readonly int CellCapacity;

    //Cell contents
    public QuadTreeNodeCell? UL; //Upper left children
    public QuadTreeNodeCell? UR; //Upper right children
    public QuadTreeNodeCell? LL; //Lower left children
    public QuadTreeNodeCell? LR; //Lower right children
    public HashSet<Node2D> Nodes;

    //Cell bounds
    public readonly float North;
    public readonly float East;
    public readonly float West;
    public readonly float South;
    public Vector2 Center;
    public float Width;
    public float Height;

    public bool AddPoint(Node2D point)
    {
        if (Subdivided || Nodes.Count >= CellCapacity)
        {
            return TransferNodeToSubCell(point);
        }
        if(!point.IsNodeWithinAABB(new(West, North), Width, Height))
        {
            return false;
        }
        Nodes.Add(point);
        Parent.nodeCurrCell.Add(point.ID, this);
        return true;
    }

    public void RemovePoint(uint iD)
    {
        foreach(Node2D node in Nodes)
        {
            if(node.ID == iD)
            {
                Nodes.Remove(node);
                Parent.nodeCurrCell.Remove(iD);
                return;
            }
        }
    }

    public void Subdivide()
    {
        Subdivided = true;
        UL = new(Parent, CellCapacity, new(West, North), Width / 2, Height / 2);
        LL = new(Parent, CellCapacity, new(West, Center.Y), Width / 2, Height / 2);
        UR = new(Parent, CellCapacity, new(Center.X, West), Width / 2, Height / 2);
        LR = new(Parent, CellCapacity, Center, Width / 2, Height / 2);
        foreach(Node2D node in Nodes)
        {
            TransferNodeToSubCell(node);
        }
        Nodes.Clear();
    }

    public void QueryRadius(Vector2 location, float radius)
    {
        if (Subdivided)
        {
            
        }
    }

    public void QueryAABB(Vector2 topLeftCorner, float width, float height)
    {
        
    }

    public void QueryNearestNeighbor(uint nodeIDSource)
    {
        
    }

    public void QueryNearestNeighbors(uint nodeIDSource, int maxCount)
    {
        
    }

    bool TransferNodeToSubCell(Node2D point)
    {
        if(point.IsNodeWithinAABB(new(UL!.West, UL!.North), UL!.Width, UL!.Height))
        {
            return UL!.AddPoint(point); 
        }
        if(point.IsNodeWithinAABB(new(LL!.West, LL!.North), LL!.Width, LL!.Height))
        {
            return LL!.AddPoint(point);
        }
        if(point.IsNodeWithinAABB(new(UR!.West, UR!.North), UR!.Width, UR!.Height))
        {
            return UR!.AddPoint(point);
        }
        if(point.IsNodeWithinAABB(new(LR!.West, LR!.North), LR!.Width, LR!.Height))
        {
            return LR!.AddPoint(point);
        }
        return false;
    }
}

public interface IReadOnlyQuadTreeNodeCell
{
    
}