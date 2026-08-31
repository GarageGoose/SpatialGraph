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
        ULCorner = originTopLeft;
        LRCorner = new(originTopLeft.X + width, originTopLeft.Y - height);
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
        ULCorner = originTopLeft;
        LRCorner = new(originTopLeft.X + width, originTopLeft.Y - height);
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
    public Vector2 ULCorner; //Upper left corner boundary
    public Vector2 LRCorner; //Lower right corner boundary
    public Vector2 Center;
    public float Width;
    public float Height;

    public bool AddPoint(Node2D point)
    {
        if (Subdivided || Nodes.Count >= CellCapacity)
        {
            return TransferNodeToSubCell(point);
        }
        if(!point.NodesWithinAABB(ULCorner, Width, Height))
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
        UL = new(Parent, CellCapacity, ULCorner, Width / 2, Height / 2);
        LL = new(Parent, CellCapacity, new(ULCorner.X, Center.Y), Width / 2, Height / 2);
        UR = new(Parent, CellCapacity, new(Center.X, ULCorner.Y), Width / 2, Height / 2);
        LR = new(Parent, CellCapacity, Center, Width / 2, Height / 2);
        foreach(Node2D node in Nodes)
        {
            TransferNodeToSubCell(node);
        }
        Nodes.Clear();
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