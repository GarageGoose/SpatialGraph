namespace GG.NodeGraph.Implementation;

public static class GraphOp2D
{
    public static void CopyElementsToGraph(IGraph<Node2D> copyFrom, IEnumerable<ElementID> elementsToCopy, IGraph<Node2D> pasteTo, bool preserveID = false)
    {
        
    }

    public static void CopyGraph(IGraph<Node2D> copyFrom, IGraph<Node2D> pasteTo)
    {
        
    }

    public static void InsertNode(IGraph<Node2D> baseGraph, uint edgeID, Node2D newNode)
    {
        
    }

    public static void CollapseNode(IGraph<Node2D> baseGraph, params uint[] nodeIDsToCollapse)
    {
        
    }

    public static void BypassRemoveNode(IGraph<Node2D> baseGraph, uint nodeID)
    {
        
    }

    public static void SplitNode(IGraph<Node2D> baseGraph, uint edgeID, Node2D[] newNodes)
    {
        
    }

    public static Node2D SplitEdge(IGraph<Node2D> baseGraph, uint edgeID, float splitPos = 0.5f)
    {
        
    }

    public static IEnumerable<Node2D> SplitEdgeMultiple(IGraph<Node2D> baseGraph, uint edgeID, uint SplitAmount)
    {
        
    }

    public static bool EdgeIntersect(IGraph<Node2D> baseGraph, uint edgeID1, uint edgeID2)
    {
        return false;
    }
}