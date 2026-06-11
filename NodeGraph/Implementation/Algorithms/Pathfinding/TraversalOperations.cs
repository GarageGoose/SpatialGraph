using System.Numerics;

namespace GG.NodeGraph.Implementation;

public static class PathfindingOps
{
    public static bool IsNodeConnected<TNode>(this IEnumerable<TNode> traversal, uint sourceNodeID, uint targetNodeID) where TNode : struct, INode
    {
        bool sourceFound = false;
        bool targetFound = false;

        foreach(TNode nodeID in traversal)
        {
            sourceFound = sourceFound || nodeID.ID == sourceNodeID;
            targetFound = targetFound || nodeID.ID == targetNodeID;

            if(sourceFound && targetFound)
            {
                return true;
            }
        }

        return false;
    }
}