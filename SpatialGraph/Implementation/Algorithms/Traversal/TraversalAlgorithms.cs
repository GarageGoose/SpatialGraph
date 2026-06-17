using System.Numerics;
using GG.SpatialGraph.Metadata;

namespace GG.SpatialGraph.Traversal;

/// <summary>
/// Provides traversal info for a specific node.
/// </summary>
/// <typeparam name="TNode">Node type.</typeparam>
/// <param name="NodeID">Current node ID traversed.</param>
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

public static class Pathfinding
{
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
    