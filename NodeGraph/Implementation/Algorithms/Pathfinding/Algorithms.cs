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
                if (visitedNodeIDs.Add(connectingNodeID))
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
                if (visitedNodeIDs.Add(connectingNodeID))
                {
                    nodesToSearch.Add(connectingNodeID);
                }
            }

            yield return baseGraph.BaseGraph.Nodes[currNodeID];
        }
    }
}
    