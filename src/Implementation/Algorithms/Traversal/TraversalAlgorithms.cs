using System.Numerics;
using SpatialGraph.Metadata;
using SpatialGraph.Extentions;

namespace SpatialGraph.Traversal;

/// <summary>
/// Provides traversal info for a specific node.
/// </summary>
/// <typeparam name="TNode">Node type.</typeparam>
/// <param name="NodeID">Current node ID.</param>
/// <param name="OriginNodeID">Node where the current node was found.</param>
/// <param name="EdgeUsedForTraversal">Edge where the current node was found.</param>
public readonly record struct TraversalInfo<TNode>(uint NodeID, uint? OriginNodeID, uint? EdgeUsedForTraversal) where TNode : struct, INode;

/// <summary>
/// Graph traversal algorithms.
/// </summary>
/// <typeparam name="TNode">Node type.</typeparam>
/// <param name="Traverse">Traverse the graph.</param>
/// <param name="BaseGraph">Graph to traverse.</param>
/// <param name="StartingNodeID">Node to start traversal.</param>
/// <param name="TagretNodeID">Node to find when travering.</param>
public readonly record struct GraphTraversal<TNode>(IEnumerable<TraversalInfo<TNode>> Traverse, NodeAdjacency<TNode> BaseGraph, uint StartingNodeID, uint? TagretNodeID) where TNode : struct, INode;

/// <summary>
/// Pathfinding algorithims for graphs.
/// </summary>
public static class Pathfinding
{
    /// <summary>
    /// Pathfinding algorithm wherein all edges at a node are explored first before proceding to the next node.
    /// </summary>
    /// <typeparam name="TNode">Type of nodes used in the base graph.</typeparam>
    /// <param name="baseGraph">Graph to perform the search.</param>
    /// <param name="nodeIDStart">ID of the node to start the search.</param>
    /// <param name="targetNodeID">ID of the node to search, if any.</param>
    /// <returns>Graph traversal algorithm.</returns>
    public static GraphTraversal<TNode> BreadthFirstTraversal<TNode>(this NodeAdjacency<TNode> baseGraph, uint nodeIDStart, uint? targetNodeID = null) where TNode : struct, INode
    {
        return new(traverse(), baseGraph, nodeIDStart, targetNodeID);
        
        IEnumerable<TraversalInfo<TNode>> traverse()
        {
            //For avoiding revisiting nodes
            HashSet<uint> visitedNodeIDs = [nodeIDStart];

            //For tracking where a node was discovered from (k: current node, v: node where it's discovered)
            Dictionary<uint, uint?> nodeDiscovery = new()
            {
                { nodeIDStart, null }
            };

            //For tracking where an edge was discovered from (k: current node, v: edge where it's discovered)
            Dictionary<uint, uint?> EdgeDiscovery = new()
            {
                { nodeIDStart, null }
            };

            Queue<uint> nodesToSearch = new();
            nodesToSearch.Enqueue(nodeIDStart);

            while (nodesToSearch.Count > 0)
            {
                uint currNodeID = nodesToSearch.Dequeue();

                //Find new nodes from current node
                foreach (uint connectingEdgeID in baseGraph.ConnectedEdges(currNodeID))
                {
                    uint connectingNodeID = baseGraph.Edges[connectingEdgeID].GetConnectingNode(currNodeID);
                    if (visitedNodeIDs.Add(connectingNodeID)) //if connectingNodeID isn't visited yet...
                    {
                        nodesToSearch.Enqueue(connectingNodeID);
                        nodeDiscovery.Add(connectingNodeID, currNodeID);
                        EdgeDiscovery.Add(connectingNodeID, connectingEdgeID);
                    }
                }

                yield return new(currNodeID, nodeDiscovery[currNodeID], EdgeDiscovery[currNodeID]);
            }
        }
    }

    /// <summary>
    /// Pathfinding algorithm wherein it explores a branch as deep as it can before backtracking.
    /// </summary>
    /// <typeparam name="TNode">Type of nodes used in the base graph.</typeparam>
    /// <param name="baseGraph">Graph to perform the search.</param>
    /// <param name="nodeIDStart">ID of the node to start the search.</param>
    /// <param name="targetNodeID">ID of the node to search, if any.</param>
    /// <returns>Graph traversal algorithm.</returns>
    public static GraphTraversal<TNode> DepthFirstTraversal<TNode>(this NodeAdjacency<TNode> baseGraph, uint nodeIDStart, uint? targetNodeID = null) where TNode : struct, INode
    {
        return new(traverse(), baseGraph, nodeIDStart, targetNodeID);
        
        IEnumerable<TraversalInfo<TNode>> traverse()
        {
            //For avoiding revisiting nodes
            HashSet<uint> visitedNodeIDs = [nodeIDStart];

            //For tracking where a node was discovered from (k: current node, v: node where it's discovered)
            Dictionary<uint, uint?> nodeDiscovery = new()
            {
            { nodeIDStart, null }
            };

            //For tracking where an edge was discovered from (k: current node, v: edge where it's discovered)
            Dictionary<uint, uint?> EdgeDiscovery = new()
            {
                { nodeIDStart, null }
            };

            List<uint> nodesToSearch = [nodeIDStart];

            while (nodesToSearch.Count > 0)
            {
                uint currNodeID = nodesToSearch[nodesToSearch.Count - 1];
                nodesToSearch.RemoveAt(nodesToSearch.Count - 1);

                //Find new nodes from current node
                foreach (uint connectingEdgeID in baseGraph.ConnectedEdges(currNodeID))
                {
                    uint connectingNodeID = baseGraph.Edges[connectingEdgeID].GetConnectingNode(currNodeID);
                    if (visitedNodeIDs.Add(connectingNodeID)) //if connectingNodeID isn't visited yet...
                    {
                        nodesToSearch.Add(connectingNodeID);
                        nodeDiscovery.Add(connectingNodeID, currNodeID);
                        EdgeDiscovery.Add(connectingNodeID, connectingEdgeID);
                    }
                }

                yield return new(currNodeID, nodeDiscovery[currNodeID], EdgeDiscovery[currNodeID]);
            }
        }
    }

    /// <summary>
    /// Pathfinding algorithm wherein each connected node to search from a node were weighted via a custom function.
    /// The highest scoring node will be traversed to, backtracking when theres no more unvisited node from a node.
    /// </summary>
    /// <typeparam name="TNode">Type of nodes used in the base graph.</typeparam>
    /// <typeparam name="TScore">Type of INumber used for scoring.</typeparam>
    /// <param name="baseGraph">Graph to perform the search.</param>
    /// <param name="nodeScore">Score of a connecting node from a node.</param>
    /// <param name="nodeIDStart">ID of the node to start the search.</param>
    /// <param name="targetNodeID">ID of the node to search, if any.</param>
    /// <returns>Graph traversal algorithm.</returns>
    public static GraphTraversal<TNode> WeightedTraversal<TNode, TScore>(this NodeAdjacency<TNode> baseGraph, Func<NodeAdjacency<TNode>, uint, TScore> nodeScore, uint nodeIDStart, uint? targetNodeID = null) where TNode : struct, INode where TScore : INumber<TScore>
    {
        return new(traverse(), baseGraph, nodeIDStart, targetNodeID);

        IEnumerable<TraversalInfo<TNode>> traverse()
        {
            //For avoiding revisiting nodes
            HashSet<uint> visitedNodeIDs = [nodeIDStart];

            //SortedList was used with a HashSet instead of a SortedSet to allow for multiple nodes of a sasme score.
            SortedList<TScore, HashSet<uint>> nodesToSearch = new()
            {
                { nodeScore(baseGraph, nodeIDStart), [nodeIDStart] }
            };

            //For tracking where a node was discovered from (k: current node, v: node where it's discovered)
            Dictionary<uint, uint?> nodeDiscovery = new()
            {
                { nodeIDStart, null }
            };

            //For tracking where an edge was discovered from (k: current node, v: edge where it's discovered)
            Dictionary<uint, uint?> EdgeDiscovery = new()
            {
                { nodeIDStart, null }
            };

            while (nodesToSearch.Count > 0)
            {
                //Get node with the highest score
                uint currNodeID = nodesToSearch.GetValueAtIndex(0).Max();
                nodesToSearch.GetValueAtIndex(0).Remove(currNodeID);

                //Find new nodes from current node
                foreach (uint connectingEdgeID in baseGraph.ConnectedEdges(currNodeID))
                {
                    uint connectingNodeID = baseGraph.Edges[connectingEdgeID].GetConnectingNode(currNodeID);

                    if (visitedNodeIDs.Add(connectingNodeID)) //if connectingNodeID isn't visited yet...
                    {
                        TScore score = nodeScore(baseGraph, connectingNodeID);
                        nodeDiscovery.Add(connectingNodeID, currNodeID);
                        EdgeDiscovery.Add(connectingNodeID, connectingEdgeID);

                        if(nodesToSearch.TryGetValue(score, out HashSet<uint>? nodeIDsAtScore))
                        {
                            nodeIDsAtScore.Add(connectingNodeID);
                            continue;
                        }
                        nodesToSearch.Add(score, [connectingNodeID]);
                    }
                }

                yield return new(currNodeID, nodeDiscovery[currNodeID], EdgeDiscovery[currNodeID]);
            }
        }
    }
}
    