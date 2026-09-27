using System.Numerics;
namespace GG.SpatialGraph;

public static class BasicElementOperations
{
    public static Edge WithID(this Edge edge, uint newID) => new(newID, edge.NodeID1, edge.NodeID2);
    public static Edge WithNodeIDs(this Edge edge, uint newNodeID1, uint newNodeID2) => new(edge.ID, newNodeID1, newNodeID2);
    public static Edge WithNodeID1(this Edge edge, uint newNodeID1) => new(edge.ID, newNodeID1, edge.NodeID2);
    public static Edge WithNodeID2(this Edge edge, uint newNodeID2) => new(edge.ID, edge.NodeID1, newNodeID2);

    public static Node2D WithID(this Node2D node, uint newID) => new(newID, node.Loc);
    public static Node2D WithLoc(this Node2D node, Vector2 newLoc) => new(node.ID, newLoc);
    public static Node2D WithX(this Node2D node, float newX) => new(node.ID, new(newX, node.Loc.Y));
    public static Node2D WithY(this Node2D node, float newY) => new(node.ID, new(node.Loc.X, newY));

    public static Node3D WithID(this Node3D node, uint newID) => new(newID, node.Loc);
    public static Node3D WithLoc(this Node3D node, Vector3 newLoc) => new(node.ID, newLoc);
    public static Node3D WithX(this Node3D node, float newX) => new(node.ID, new(newX, node.Loc.Y, node.Loc.Z));
    public static Node3D WithY(this Node3D node, float newY) => new(node.ID, new(node.Loc.X, newY, node.Loc.Z));
    public static Node3D WithZ(this Node3D node, float newZ) => new(node.ID, new(node.Loc.X, node.Loc.Y, newZ));

    public static TNode GetFirstNodeOfEdge<TNode>(this IReadOnlyGraph<TNode> graph, uint edgeID) where TNode : struct, INode => graph.Nodes[graph.Edges[edgeID].NodeID1];
    public static TNode GetSecondNodeOfEdge<TNode>(this IReadOnlyGraph<TNode> graph, uint edgeID) where TNode : struct, INode => graph.Nodes[graph.Edges[edgeID].NodeID2];

    /// <summary>
    /// Determine if a node is assigned as Node 1 or Node 2 in an edge.
    /// </summary>
    public static NodeInEdge EdgeAssignmentOfNode(this Edge edge, uint nodeID)
    {
        if(edge.NodeID1 == nodeID)
        {
            return NodeInEdge.First;
        }
        else if (edge.NodeID2 == nodeID)
        {
            return NodeInEdge.Second;
        }
        return NodeInEdge.None;
    }

    public static bool EdgeHasNodeID(this Edge edge, uint nodeID) => edge.NodeID1 == nodeID ? true : edge.NodeID2 == nodeID ? true : false;

    /// <summary>
    /// Get the other connecting node from node in an edge.
    /// </summary>
    /// <param name="edge"></param>
    /// <param name="sourceNodeID"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static uint GetConnectingNode(this Edge edge, uint sourceNodeID)
    {
        if(edge.NodeID1 == sourceNodeID)
        {
            return edge.NodeID2;
        }
        else if (edge.NodeID2 == sourceNodeID)
        {
            return edge.NodeID1;
        }
        throw new Exception(); //Setup later WIP!!
    }
}