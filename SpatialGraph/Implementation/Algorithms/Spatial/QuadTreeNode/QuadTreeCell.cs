using System.IO.Compression;
using System.Numerics;

namespace GG.SpatialGraph.Spatial;

public class QuadTreeNodeCell : IReadOnlyQuadTreeNodeCell
{
    public QuadTreeNodeCell(int cellCapacity, Vector2 originTopLeft, float width, float height)
    {
        CellCapacity = cellCapacity;
        Nodes = new(cellCapacity);
        ULCorner = originTopLeft;
        LRCorner = new(originTopLeft.X + width, originTopLeft.Y - height);
        Center = new(originTopLeft.X + (width / 2), originTopLeft.Y - (height / 2));
    }

    public QuadTreeNodeCell(int cellCapacity, List<Node2D> nodes, Vector2 originTopLeft, float width, float height)
    {
        CellCapacity = cellCapacity;
        Nodes = [.. nodes];
        ULCorner = originTopLeft;
        LRCorner = new(originTopLeft.X + width, originTopLeft.Y - height);
        Center = new(originTopLeft.X + (width / 2), originTopLeft.Y - (height / 2));
    }

    public bool Subdivided {get; private set;} = false;
    public int CellCapacity;

    public QuadTreeNodeCell? UL; //Upper left children
    public QuadTreeNodeCell? UR; //Upper right children
    public QuadTreeNodeCell? LL; //Lower left children
    public QuadTreeNodeCell? LR; //Lower right children
    public List<Node2D> Nodes;

    public Vector2 ULCorner; //Upper left corner boundary
    public Vector2 LRCorner; //Lower right corner boundary
    public Vector2 Center;
    public float Width;
    public float Height;

    public bool AddPoint(Node2D point)
    {
        if (Subdivided || Nodes.Count - 1 >= CellCapacity)
        {
            return TransferNodeToSubCell(point);
        }
        if(!point.NodesWithinAABB(ULCorner, Width, Height))
        {
            return false;
        }
        Nodes.Add(point);
        return true;
    }

    public void Subdivide()
    {
        UL = new(CellCapacity, ULCorner, Width / 2, Height / 2);
        LL = new(CellCapacity, new(ULCorner.X, Center.Y), Width / 2, Height / 2);
        UR = new(CellCapacity, new(Center.X, ULCorner.Y), Width / 2, Height / 2);
        LL = new(CellCapacity, Center, Width / 2, Height / 2);
        foreach(Node2D node in Nodes)
        {
            TransferNodeToSubCell(node);
        }
    }

    public void QueryRadius(Vector2 location, float radius)
    {
        
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
        if(point.NodesWithinAABB(UL!.ULCorner, UL!.Width, UL!.Height))
        {
            return UL!.AddPoint(point); 
        }
        if(point.NodesWithinAABB(LL!.ULCorner, LL!.Width, LL!.Height))
        {
            return LL!.AddPoint(point);
        }
        if(point.NodesWithinAABB(UR!.ULCorner, UR!.Width, UR!.Height))
        {
            return UR!.AddPoint(point);
        }
        if(point.NodesWithinAABB(LR!.ULCorner, LR!.Width, LR!.Height))
        {
            return LR!.AddPoint(point);
        }
        return false;
    }
}

public interface IReadOnlyQuadTreeNodeCell
{
    
}