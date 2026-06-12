using System.Numerics;

namespace GG.NodeGraph.Implementation;

public static class PathfindingOps
{
    public static bool IsNodeConnected<TNode>(this GraphTraversal<TNode> graphTraversal) where TNode : struct, INode
    {
        //WIP
    }

    public static TCollection<TNode> PathfindNodes<TCollection, TNode>(this GraphTraversal<TNode> graphTraversal) where TNode : struct, INode
    {
        //WIP
    }
    public static TCollection<TNode> PathfindEdges<TCollection, TNode>(this GraphTraversal<TNode> graphTraversal) where TNode : struct, INode
    {
        //WIP
    }
    public static TGraph<TNode> Pathfind<TGraph, TNode>(this GraphTraversal<TNode> graphTraversal) where TNode : struct, INode where TGraph : IGraph<TNode>
    {
        //WIP
    }

    public static TCollection<TNode> FloodfillNodes<TCollection, TNode>(this GraphTraversal<TNode> graphTraversal) where TNode : struct, INode
    {
        //WIP
    }
    public static TCollection<TNode> FloodfillEdges<TCollection, TNode>(this GraphTraversal<TNode> graphTraversal) where TNode : struct, INode
    {
        //WIP
    }
    public static TGraph<TNode> Floodfill<TGraph, TNode>(this GraphTraversal<TNode> graphTraversal) where TNode : struct, INode where TGraph : IGraph<TNode>
    {
        //WIP
    }
}