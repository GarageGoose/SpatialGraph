using System.Numerics;

namespace GG.SpatialGraph.Implementation;

public static class PathfindingOps
{
    public static bool IsNodeConnected<TNode>(this GraphTraversal<TNode> graphTraversal) where TNode : struct, INode => graphTraversal.Traverse.Any(node => node.NodeID == graphTraversal.TagretNodeID);

    public static bool PathfindNodes<TNode>(this GraphTraversal<TNode> graphTraversal, out Stack<uint> nodeIDs) where TNode : struct, INode
    {
        nodeIDs = new();

        if(graphTraversal.TagretNodeID == null)
        {
            return false;
        }
        
        Dictionary<uint, uint?> nodeOrigin = new();
        
        uint backtracingCurrNode = (uint)graphTraversal.TagretNodeID;

        foreach(TraversalInfo<TNode> node in graphTraversal.Traverse)
        {
            nodeOrigin.Add(node.NodeID, node.OriginNodeID);
            if(node.NodeID == backtracingCurrNode)
            {
                while (backtracingCurrNode != graphTraversal.StartingNodeID)
                {
                    nodeIDs.Push(backtracingCurrNode);
                    backtracingCurrNode = (uint)nodeOrigin[backtracingCurrNode]!;
                }
                nodeIDs.Push(backtracingCurrNode);
                return true;
            }
        }
        return false;
    }
    public static bool PathfindEdges<TNode>(this GraphTraversal<TNode> graphTraversal, out Stack<uint> edgeIDs) where TNode : struct, INode
    {
        edgeIDs = new();

        if(graphTraversal.TagretNodeID == null)
        {
            return false;
        }
        
        Dictionary<uint, uint?> nodeOrigin = new();
        Dictionary<uint, uint?> edgeOrigin = new();
        
        uint backtracingCurrNode = (uint)graphTraversal.TagretNodeID;

        foreach(TraversalInfo<TNode> node in graphTraversal.Traverse)
        {
            nodeOrigin.Add(node.NodeID, node.OriginNodeID);
            edgeOrigin.Add(node.NodeID, node.EdgeUsedForTraversal);
            if(node.NodeID == backtracingCurrNode)
            {
                while (backtracingCurrNode != graphTraversal.StartingNodeID)
                {
                    edgeIDs.Push((uint)edgeOrigin[backtracingCurrNode]!);
                    backtracingCurrNode = (uint)nodeOrigin[backtracingCurrNode]!;
                }
                return true;
            }
        }
        return false;
    }
    public static bool Pathfind<TGraph, TNode>(this GraphTraversal<TNode> graphTraversal, out Stack<uint> edgeIDs, out Stack<uint> nodeIDs) where TNode : struct, INode
    {
        edgeIDs = new();
        nodeIDs = new();

        if(graphTraversal.TagretNodeID == null)
        {
            return false;
        }
        
        Dictionary<uint, uint?> nodeOrigin = new();
        Dictionary<uint, uint?> edgeOrigin = new();
        
        uint backtracingCurrNode = (uint)graphTraversal.TagretNodeID;

        foreach(TraversalInfo<TNode> node in graphTraversal.Traverse)
        {
            nodeOrigin.Add(node.NodeID, node.OriginNodeID);
            edgeOrigin.Add(node.NodeID, node.EdgeUsedForTraversal);
            if(node.NodeID == backtracingCurrNode)
            {
                while (backtracingCurrNode != graphTraversal.StartingNodeID)
                {
                    edgeIDs.Push((uint)edgeOrigin[backtracingCurrNode]!);
                    nodeIDs.Push(backtracingCurrNode);
                    backtracingCurrNode = (uint)nodeOrigin[backtracingCurrNode]!;
                }
                nodeIDs.Push(backtracingCurrNode);
                return true;
            }
        }
        return false;
    }
/*
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
    }*/
}