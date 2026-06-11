using System.Numerics;

namespace GG.NodeGraph.Implementation;

public static class Pathfinding
{
    public static IEnumerable<TNode> BFSTraversal<TNode>(this NodeAdjacency<TNode> baseGraph, uint nodeIDStart) where TNode : struct, INode
    {
        //For avoiding revisiting nodes
        HashSet<uint> visitedNodeIDs = [nodeIDStart];

        Queue<uint> nodesToSearch = new();
        nodesToSearch.Enqueue(nodeIDStart);

        while (nodesToSearch.Count > 0)
        {
            uint currNodeID = nodesToSearch.Dequeue();

            //Find new nodes from current node
            foreach (uint connectingNodeID in baseGraph.ConnectedNodes(currNodeID))
            {
                if (visitedNodeIDs.Add(connectingNodeID)) //if connectingNodeID isn't visited yet...
                {
                    nodesToSearch.Enqueue(connectingNodeID);
                }
            }

            yield return baseGraph.BaseGraph.Nodes[currNodeID];
        }
    }

    public static IEnumerable<TNode> DFSTraversal<TNode>(this NodeAdjacency<TNode> baseGraph, uint nodeIDStart) where TNode : struct, INode
    {
        //For avoiding revisiting nodes
        HashSet<uint> visitedNodeIDs = [nodeIDStart];

        List<uint> nodesToSearch = [nodeIDStart];

        while (nodesToSearch.Count > 0)
        {
            uint currNodeID = nodesToSearch[nodesToSearch.Count - 1];
            nodesToSearch.RemoveAt(nodesToSearch.Count - 1);

            //Find new nodes from current node
            foreach (uint connectingNodeID in baseGraph.ConnectedNodes(currNodeID))
            {
                if (visitedNodeIDs.Add(connectingNodeID)) //if connectingNodeID isn't visited yet...
                {
                    nodesToSearch.Add(connectingNodeID);
                }
            }

            yield return baseGraph.BaseGraph.Nodes[currNodeID];
        }
    }

    public static IEnumerable<TNode> WeightedTraversal<TNode, TScore>(this NodeAdjacency<TNode> baseGraph, Func<NodeAdjacency<TNode>, uint, TScore> nodeScore, uint nodeIDStart) where TNode : struct, INode where TScore : INumber<TScore>
    {
        //For avoiding revisiting nodes
        HashSet<uint> visitedNodeIDs = [nodeIDStart];

        SortedList<TScore, HashSet<uint>> nodesToSearch = new()
        {
            { nodeScore(baseGraph, nodeIDStart), [nodeIDStart] }
        };

        while (nodesToSearch.Count > 0)
        {
            uint currNodeID = nodesToSearch.GetValueAtIndex(0).First();
            nodesToSearch.GetValueAtIndex(0).Remove(currNodeID);

            //Find new nodes from current node
            foreach (uint connectingNodeID in baseGraph.ConnectedNodes(currNodeID))
            {
                if (visitedNodeIDs.Add(connectingNodeID)) //if connectingNodeID isn't visited yet...
                {
                    TScore score = nodeScore(baseGraph, connectingNodeID);
                    if(nodesToSearch.TryGetValue(score, out HashSet<uint>? nodeIDsAtScore))
                    {
                        nodeIDsAtScore.Add(connectingNodeID);
                        continue;
                    }
                    nodesToSearch.Add(score, [connectingNodeID]);
                }
            }

            yield return baseGraph.BaseGraph.Nodes[currNodeID];
        }
    }
}
    