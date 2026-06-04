namespace GG.NodeGraph.Implementations;

public static class GraphOp3D
{
    public static void CopyElementsToGraph(IGraph<Node3D> copyFrom, IEnumerable<ElementID> elementsToCopy, IGraph<Node3D> pasteTo, bool preserveID = false)
    {
        
    }

    public static void CopyGraph(IGraph<Node3D> copyFrom, IGraph<Node3D> pasteTo)
    {
        
    }

    public static void InsertNode(IGraph<Node3D> baseGraph, uint edgeID, Node3D newNode)
    {
        
    }

    public static void CollapseNode(IGraph<Node3D> baseGraph, params uint[] nodeIDsToCollapse)
    {
        
    }

    public static void BypassRemoveNode(IGraph<Node3D> baseGraph, uint nodeID)
    {
        
    }

    public static void SplitNode(IGraph<Node3D> baseGraph, uint edgeID, Node3D[] newNodes)
    {
        
    }

    public static Node2D SplitEdge(IGraph<Node3D> baseGraph, uint edgeID, float splitPos = 0.5f)
    {
        
    }

    public static IEnumerable<Node2D> SplitEdgeMultiple(IGraph<Node3D> baseGraph, uint edgeID, uint SplitAmount)
    {
        
    }

    public static bool EdgeIntersect(IGraph<Node3D> baseGraph, uint edgeID1, uint edgeID2)
    {
        return false;
    }
}