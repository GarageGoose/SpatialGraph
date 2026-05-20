namespace GG.NodeGraph.Implementation;

public static class GraphOp<TNode> where TNode : struct, INode
{
    public static void CopyElementsToGraph(IGraph<TNode> copyFromGraph, IEnumerable<ElementID> elementsToCopy, IGraph<TNode> pasteToGraph)
    {
        
    }

    public static void SplitEdge(IGraph<TNode> baseGraph, uint edgeID, float splitPos = 0.5f)
    {
        
    }
}