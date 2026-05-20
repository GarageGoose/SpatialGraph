using GG.NodeGraph.Implementation;

namespace GG.NodeGraph.Implementation;
/// <summary>
/// Depth-First Search
/// </summary>
/// <typeparam name="TNode"></typeparam>
public static class DFS<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Find shortest unweighted path from node to node.
    /// </summary>
    /// <param name="nodeIDStart">ID of the node to begin pathfinding.</param>
    /// <param name="nodeIDTarget">ID of the target node to pathfind.</param>
    /// <param name="baseGraph">Graph which the nodes are stored in. Should be with node relations.</param>
    /// <returns></returns>
    public static List<ElementID>? Pathfind(uint nodeIDStart, uint nodeIDTarget, NodeAdjacency<TNode> baseGraph)
    {
        HashSet<uint> visitedNodeIDs = [nodeIDStart];

        List<uint> nodeQueue = [nodeIDStart];

        //Track which edge got to the node (k: node, v: edge)
        Dictionary<uint, uint> nodeFromEdge = new();

        //Track which node led to another node (k: target node, v: source of target node)
        Dictionary<uint, uint> nodeFromNode = new();

        //Declare variables here to avoid expensive gc
        uint connectingNodeID = 0;
        while(nodeQueue.Count > 0)
        {
            uint currNodeID = nodeQueue[nodeQueue.Count - 1];
            nodeQueue.RemoveAt(nodeQueue.Count - 1);

            foreach(uint connectingEdgeID in baseGraph.ConnectedEdges(currNodeID))
            {
                connectingNodeID = baseGraph.BaseGraph.Edges[connectingEdgeID].GetConnectingNode(currNodeID);
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
                    nodeQueue.Add(connectingNodeID);
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
    public static bool NodeConnection(uint nodeID1, uint nodeID2, NodeAdjacency<TNode> baseGraph)
    {
        HashSet<uint> visitedNodeIDs = [nodeID1];

        List<uint> nodeQueue = [nodeID1];

        //Declare variables here to avoid expensive gc
        uint connectingNodeID = 0;
        while(nodeQueue.Count > 0)
        {
            uint currNodeID = nodeQueue[nodeQueue.Count - 1];
            nodeQueue.RemoveAt(nodeQueue.Count - 1);

            foreach(uint connectingEdgeID in baseGraph.ConnectedEdges(currNodeID))
            {
                connectingNodeID = baseGraph.BaseGraph.Edges[connectingEdgeID].GetConnectingNode(currNodeID);
                if (visitedNodeIDs.Add(connectingNodeID))
                {
                    if(connectingNodeID == nodeID2)
                    {
                        return true;
                    }
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
    public static void Floodfill<TGraph>(NodeAdjacency<TNode> baseGraph, TGraph outputGraph, uint nodeIDStart, uint limitNodes = 0) where TGraph : IGraph<TNode>
    {
        HashSet<uint> visitedNodeIDs = [nodeIDStart];
        outputGraph.UpsertNode(baseGraph.BaseGraph.Nodes[nodeIDStart]);

        List<uint> nodeQueue = [nodeIDStart];

        //Declare variables here to avoid expensive gc
        uint connectingNodeID = 0;
        while(nodeQueue.Count > 0)
        {
            uint currNodeID = nodeQueue[nodeQueue.Count - 1];
            nodeQueue.RemoveAt(nodeQueue.Count - 1);

            foreach(uint connectingEdgeID in baseGraph.ConnectedEdges(currNodeID))
            {
                connectingNodeID = baseGraph.BaseGraph.Edges[connectingEdgeID].GetConnectingNode(currNodeID);
                if (visitedNodeIDs.Add(connectingNodeID))
                {
                    nodeQueue.Add(connectingNodeID);
                    outputGraph.UpsertNode(baseGraph.BaseGraph.Nodes[connectingNodeID]);
                    outputGraph.UpsertEdge(baseGraph.BaseGraph.Edges[connectingEdgeID]);
                }
            }
        }
    }
}