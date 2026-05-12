namespace GG.NodeGraph.Tools;
//WIP!!!
/// <summary>
///
/// </summary>
/// <typeparam name="TNode"></typeparam>
public static class BFS<TNode> where TNode : struct, INode
{
    public static GraphPath? Pathfind(uint nodeIDStart, uint nodeIDTarget, IReadOnlyGraphNodeRelations<TNode> baseGraph)
    {
        return null;
    }

    public static GraphPath? Floodfill(IReadOnlyGraphNodeRelations<TNode> baseGraph, uint limitNodes = 0)
    {
        return null;
    }
}