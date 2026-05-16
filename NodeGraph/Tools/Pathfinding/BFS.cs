namespace GG.NodeGraph.Tools;
/// <summary>
/// Breadth-First Search
/// </summary>
/// <typeparam name="TNode"></typeparam>
public static class BFS<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Find shortest unweighted path from node to node.
    /// </summary>
    /// <param name="nodeIDStart">ID of the node to begin pathfinding.</param>
    /// <param name="nodeIDTarget">ID of the target node to pathfind.</param>
    /// <param name="baseGraph">Graph which the nodes are stored in. Should be with node relations.</param>
    /// <returns></returns>
    public static List<ElementID>? Pathfind(uint nodeIDStart, uint nodeIDTarget, IReadOnlyGraphWithMetadata<TNode> baseGraph)
    {
        HashSet<uint> visitedNodeIDs = [nodeIDStart];

        Queue<uint> nodeQueue = new();
        nodeQueue.Enqueue(nodeIDStart);

        //Track which edge got to the node (k: node, v: edge)
        Dictionary<uint, uint> nodeFromEdge = new();

        //Track which node led to another node (k: target node, v: source of target node)
        Dictionary<uint, uint> nodeFromNode = new();

        //Declare variables here to avoid expensive gc
        uint connectingNodeID = 0;
        while(nodeQueue.Count > 0)
        {
            uint currNodeID = nodeQueue.Dequeue();

            foreach(uint connectingEdgeID in baseGraph.Get<ConnectedEdges>(ElementType.Node, currNodeID).EdgeIDs)
            {
                connectingNodeID = baseGraph.Edges[connectingEdgeID].GetConnectingNode(currNodeID);
                if (visitedNodeIDs.Add(connectingNodeID))
                {
                    nodeFromNode.Add(connectingNodeID, currNodeID);
                    nodeFromEdge.Add(connectingNodeID, connectingEdgeID);

                    if(connectingNodeID == nodeIDTarget)
                    {
                        List<ElementID> graphPath = new();

                        uint currBacktrackNode = nodeIDTarget;
                        while(currBacktrackNode != nodeIDStart)
                        {
                            graphPath.Add(new(ElementType.Node, currBacktrackNode));
                            graphPath.Add(new(ElementType.Edge, nodeFromEdge[currBacktrackNode]));
                            currBacktrackNode = nodeFromNode[currBacktrackNode];
                        }
                        graphPath.Add(new (ElementType.Node, nodeIDStart));

                        graphPath.Reverse();

                        return new(graphPath);
                    }
                    nodeQueue.Enqueue(connectingNodeID);
                }
            }
        }
        return null;
    }

    /// <summary>
    /// Check if two nodes are connected to each other.
    /// </summary>
    /// <param name="nodeID1">ID of the first node.</param>
    /// <param name="nodeID2">ID of the second node.</param>
    /// <param name="baseGraph">Graph which the nodes are stored in. Should be with node relations.</param>
    public static bool NodeConnection(uint nodeID1, uint nodeID2, IReadOnlyGraphWithMetadata<TNode> baseGraph)
    {
        HashSet<uint> visitedNodeIDs = [nodeID1];

        Queue<uint> nodeQueue = new();
        nodeQueue.Enqueue(nodeID1);

        //Declare variables here to avoid expensive gc
        uint connectingNodeID = 0;
        while(nodeQueue.Count > 0)
        {
            uint currNodeID = nodeQueue.Dequeue();

            foreach(uint connectingEdgeID in baseGraph.Get<ConnectedEdges>(ElementType.Node, currNodeID).EdgeIDs)
            {
                connectingNodeID = baseGraph.Edges[connectingEdgeID].GetConnectingNode(currNodeID);
                if (visitedNodeIDs.Add(connectingNodeID))
                {
                    if(connectingNodeID == nodeID2)
                    {
                        return true;
                    }
                    nodeQueue.Enqueue(connectingNodeID);
                }
            }
        }
        return false;
    }

    /// <summary>
    /// Record nodes connected to a starting node.
    /// </summary>
    /// <typeparam name="TGraph">Graph to return the result.</typeparam>
    /// <param name="baseGraph">Graph to flood fill.</param>
    /// <param name="outputGraph">Graph to return the result.</param>
    /// <param name="nodeIDStart">Starting node to floodfill.</param>
    /// <param name="limitNodes">Limit nodes when floodfilling.</param>
    public static void Floodfill<TGraph>(IReadOnlyGraphWithMetadata<TNode> baseGraph, TGraph outputGraph, uint nodeIDStart, uint limitNodes = 0) where TGraph : IGraph<TNode>
    {
        HashSet<uint> visitedNodeIDs = [nodeIDStart];
        outputGraph.UpsertNode(baseGraph.Nodes[nodeIDStart]);

        Queue<uint> nodeQueue = new();
        nodeQueue.Enqueue(nodeIDStart);

        //Declare variables here to avoid expensive gc
        uint connectingNodeID = 0;
        while(nodeQueue.Count > 0)
        {
            uint currNodeID = nodeQueue.Dequeue();

            foreach(uint connectingEdgeID in baseGraph.Get<ConnectedEdges>(ElementType.Node, currNodeID).EdgeIDs)
            {
                connectingNodeID = baseGraph.Edges[connectingEdgeID].GetConnectingNode(currNodeID);
                if (visitedNodeIDs.Add(connectingNodeID))
                {
                    nodeQueue.Enqueue(connectingNodeID);

                    outputGraph.UpsertNode(baseGraph.Nodes[connectingNodeID]);
                    outputGraph.UpsertEdge(baseGraph.Edges[connectingEdgeID]);
                }
            }
        }
    }
}