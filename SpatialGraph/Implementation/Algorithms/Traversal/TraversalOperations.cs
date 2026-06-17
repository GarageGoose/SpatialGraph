namespace GG.SpatialGraph.Traversal;

public static class PathfindingOps
{
    /// <summary>
    /// Check if two nodes were connected through edges.
    /// </summary>
    /// <typeparam name="TNode">Node type.</typeparam>
    /// <param name="graphTraversal">Traversal algorithm to use.</param>
    /// <returns>If path between the two nodes were found.</returns>
    public static bool IsNodeConnected<TNode>(this GraphTraversal<TNode> graphTraversal) where TNode : struct, INode => graphTraversal.Traverse.Any(node => node.NodeID == graphTraversal.TagretNodeID);

    /// <summary>
    /// Find path between two nodes.
    /// </summary>
    /// <typeparam name="TNode">Node type.</typeparam>
    /// <param name="graphTraversal">Traversal algorithm to use.</param>
    /// <param name="nodeIDs">IDs of nodes connecting the source and target nodes.</param>
    /// <returns>If path between the two nodes were found.</returns>
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

    /// <summary>
    /// Find path between two nodes.
    /// </summary>
    /// <typeparam name="TNode">Node type.</typeparam>
    /// <param name="graphTraversal">Traversal algorithm to use.</param>
    /// <param name="edgeIDs">IDs of edges connecting the source and target nodes.</param>
    /// <returns>If path between the two nodes were found.</returns>
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

    /// <summary>
    /// Find path between two nodes.
    /// </summary>
    /// <typeparam name="TNode">Node type.</typeparam>
    /// <param name="graphTraversal">Traversal algorithm to use.</param>
    /// <param name="edgeIDs">IDs of edges connecting the source and target nodes.</param>
    /// <param name="nodeIDs">IDs of nodes connecting the source and target nodes.</param>
    /// <returns>If path between the two nodes were found.</returns>
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

    /// <summary>
    /// Get all the connected nodes connected from the source node.
    /// </summary>
    /// <typeparam name="TNode">Node type.</typeparam>
    /// <param name="graphTraversal">Traversal algorithm to use.</param>
    /// <param name="limitNodes">Limit discovered nodes to a specific amount.</param>
    /// <returns>List of NodeIDs connected to the source node.</returns>
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

    /// <summary>
    /// Get all the connected edges from the source node.
    /// </summary>
    /// <typeparam name="TNode">Node type.</typeparam>
    /// <param name="graphTraversal">Traversal algorithm to use.</param>
    /// <param name="limitEdges">Limit discovered edges to set amount.</param>
    /// <returnsList of connected edges from the source node.></returns>
    public static List<uint> FloodfillEdges<TNode>(this GraphTraversal<TNode> graphTraversal, uint? limitEdges = null) where TNode : struct, INode
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

    /// <summary>
    /// Get connected elements from the source node.
    /// </summary>
    /// <typeparam name="TNode">Node type.</typeparam>
    /// <param name="graphTraversal">Travseral algorithm to use.</param>
    /// <param name="nodeIDs">IDs of node connected from the source node.</param>
    /// <param name="edgeIDs">IDs of edges connected from the source node.</param>
    public static void Floodfill<TNode>(this GraphTraversal<TNode> graphTraversal, out List<uint> nodeIDs, out List<uint> edgeIDs) where TNode : struct, INode
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

    /// <summary>
    /// Get the elements traversed.
    /// </summary>
    /// <typeparam name="TNode">Node type.</typeparam>
    /// <param name="graphTraversal">Traversal algorithm to use.</param>
    /// <param name="nodeIDs">IDs of nodes traversed.</param>
    /// <param name="edgeIDs">IDs of edges traversed.</param>
    public static void ElementsOnTraversal<TNode>(this GraphTraversal<TNode> graphTraversal, out List<uint> nodeIDs, out List<uint> edgeIDs) where TNode : struct, INode
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

    /// <summary>
    /// Get the edges traversed.
    /// </summary>
    /// <typeparam name="TNode">Node type.</typeparam>
    /// <param name="graphTraversal">Traversal algorithm to use.</param>
    /// <param name="limitEdges">Limit discovered edges to a specific amount.</param>
    /// <returns>List of edges traversed.</returns>
    public static List<uint> EdgesTraversed<TNode>(this GraphTraversal<TNode> graphTraversal, uint? limitEdges = null) where TNode : struct, INode
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
}