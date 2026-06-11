using System.Numerics;
namespace GG.NodeGraph.Implementation;

public static class ElemOp
{
    public static Edge UpdateID(this Edge edge, uint newID) => new(newID, edge.NodeID1, edge.NodeID2);
    public static Edge UpdateNodeIDs(this Edge edge, uint newNodeID1, uint newNodeID2) => new(edge.ID, newNodeID1, newNodeID2);
    public static Edge UpdateNodeID1(this Edge edge, uint newNodeID1) => new(edge.ID, newNodeID1, edge.NodeID2);
    public static Edge UpdateNodeID2(this Edge edge, uint newNodeID2) => new(edge.ID, edge.NodeID1, newNodeID2);

    public static Node2D UpdateID(this Node2D node, uint newID) => new(newID, node.Loc);
    public static Node2D UpdateLoc(this Node2D node, Vector2 newLoc) => new(node.ID, newLoc);
    public static Node2D UpdateX(this Node2D node, float newX) => new(node.ID, new(newX, node.Loc.Y));
    public static Node2D UpdateY(this Node2D node, float newY) => new(node.ID, new(node.Loc.X, newY));

    public static Node3D UpdateID(this Node3D node, uint newID) => new(newID, node.Loc);
    public static Node3D UpdateLoc(this Node3D node, Vector3 newLoc) => new(node.ID, newLoc);
    public static Node3D UpdateX(this Node3D node, float newX) => new(node.ID, new(newX, node.Loc.Y, node.Loc.Z));
    public static Node3D UpdateY(this Node3D node, float newY) => new(node.ID, new(node.Loc.X, newY, node.Loc.Z));
    public static Node3D UpdateZ(this Node3D node, float newZ) => new(node.ID, new(node.Loc.X, node.Loc.Y, newZ));

    public static NodeEdgeAssignment EdgeAssignmentOfNode(this Edge edge, uint nodeID)
    {
        if(edge.NodeID1 == nodeID)
        {
            return NodeEdgeAssignment.Node2;
        }
        else if (edge.NodeID2 == nodeID)
        {
            return NodeEdgeAssignment.Node1;
        }
        return NodeEdgeAssignment.None;
    }

    /// <summary>
    /// Get the other connecting node from node in an edge
    /// </summary>
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
        throw new Exception(); //Setup later
    }

    public static uint GetEdgeLength(this IGraph<Node2D> baseGraph, uint edgeID)
    {
        
    }
}