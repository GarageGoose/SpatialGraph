namespace GG.SpatialGraph.Traversal;

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

    public static List<uint> FloodfillNodes<TNode>(this GraphTraversal<TNode> graphTraversal, uint? limitNodes = null) where TNode : struct, INode
    {
        List<uint> nodeIDs = new();

        if(limitNodes == null)
        {
            foreach(TraversalInfo<TNode> traversal in graphTraversal.Traverse)
            {
                nodeIDs.Add(traversal.NodeID);
            }
            return nodeIDs;
        }

        foreach(TraversalInfo<TNode> traversal in graphTraversal.Traverse.Take((int)limitNodes))
        {
            nodeIDs.Add(traversal.NodeID);
        }
        return nodeIDs;
    }

    public static List<uint> FloodfillEdgesOnTraversal<TNode>(this GraphTraversal<TNode> graphTraversal, uint? limitEdges = null) where TNode : struct, INode
    {
        List<uint> EdgeIDs = new();

        if(limitEdges == null)
        {
            foreach(TraversalInfo<TNode> traversal in graphTraversal.Traverse.Skip(1))
            {
                EdgeIDs.Add((uint)traversal.EdgeUsedForTraversal!);
            }
            return EdgeIDs;
        }

        foreach(TraversalInfo<TNode> traversal in graphTraversal.Traverse.Skip(1).Take((int)limitEdges))
        {
            EdgeIDs.Add(traversal.NodeID);
        }
        return EdgeIDs;
    }

    public static List<uint> FloodfillEdgesFull<TNode>(this GraphTraversal<TNode> graphTraversal, uint? limitEdges = null) where TNode : struct, INode
    {
        HashSet<uint> nodeIDs = new();

        foreach(TraversalInfo<TNode> traversal in graphTraversal.Traverse)
        {
            nodeIDs.Add(traversal.NodeID);
        }

        List<uint> edgeIDs = new();
        if(limitEdges == null)
        {
            foreach(uint nodeID in nodeIDs)
            {
                foreach(uint edgeID in graphTraversal.BaseGraph.ConnectedEdges(nodeID))
                {
                    Edge edge = graphTraversal.BaseGraph.Edges[edgeID];
                    if(nodeIDs.Contains(edge.NodeID1) && nodeIDs.Contains(edge.NodeID2))
                    {
                        edgeIDs.Add(edgeID);
                    }
                }
            }
            return edgeIDs;
        }

        foreach(uint nodeID in nodeIDs)
        {
            foreach(uint edgeID in graphTraversal.BaseGraph.ConnectedEdges(nodeID))
            {
                Edge edge = graphTraversal.BaseGraph.Edges[edgeID];
                if(nodeIDs.Contains(edge.NodeID1) && nodeIDs.Contains(edge.NodeID2))
                {
                    edgeIDs.Add(edgeID);
                }
                if(edgeIDs.Count == limitEdges)
                {
                    return edgeIDs;
                }
            }
        }
        return edgeIDs;
    }

    public static void FloodfillOnTraversal<TGraph, TNode>(this GraphTraversal<TNode> graphTraversal, out List<uint> nodeIDs, out List<uint> edgeIDs) where TNode : struct, INode
    {
        edgeIDs = new();
        foreach(TraversalInfo<TNode> traversal in graphTraversal.Traverse.Skip(1))
        {
            edgeIDs.Add((uint)traversal.EdgeUsedForTraversal!);
        }

        nodeIDs = new();
        foreach(TraversalInfo<TNode> traversal in graphTraversal.Traverse)
        {
            nodeIDs.Add(traversal.NodeID);
        }
    }
    public static void FloodfillFull<TGraph, TNode>(this GraphTraversal<TNode> graphTraversal, out List<uint> nodeIDs, out List<uint> edgeIDs) where TNode : struct, INode
    {
        HashSet<uint> nodeIDHash = new();
        nodeIDs = new();
        foreach(TraversalInfo<TNode> traversal in graphTraversal.Traverse)
        {
            nodeIDs.Add(traversal.NodeID);
            nodeIDHash.Add(traversal.NodeID);
        }

        edgeIDs = new();
        foreach(uint nodeID in nodeIDs)
        {
            foreach(uint edgeID in graphTraversal.BaseGraph.ConnectedEdges(nodeID))
            {
                Edge edge = graphTraversal.BaseGraph.Edges[edgeID];
                if(nodeIDs.Contains(edge.NodeID1) && nodeIDs.Contains(edge.NodeID2))
                {
                    edgeIDs.Add(edgeID);
                }
            }
        }
    }
}