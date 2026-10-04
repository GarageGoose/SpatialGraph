using System.Numerics;
namespace SpatialGraph.Extensions;

/// <summary>
/// Basic operation for creating modified copies of <see cref="IElement"/>s
/// and retrieving <see cref="IElement"/> related information.
/// </summary>
public static class BasicElementOperations
{
    /// <summary>
    /// Create a new copy of an <see cref="Edge"/> with a different ID.
    /// </summary>
    /// <param name="edge">Edge to copy.</param>
    /// <param name="newID">ID for the new edge.</param>
    /// <returns>Edge with new ID.</returns>
    public static Edge WithID(this Edge edge, uint newID) => new(newID, edge.NodeID1, edge.NodeID2);

    /// <summary>
    /// Creates a new copy of an <see cref="Edge"/> with different endpoint IDs.
    /// </summary>
    /// <param name="edge">Edge to copy.</param>
    /// <param name="newNodeID1">New node ID for the first endpoint.</param>
    /// <param name="newNodeID2">New node ID for the second endpoint.</param>
    /// <returns>Edge with new connecting nodes.</returns>
    public static Edge WithNodeIDs(this Edge edge, uint newNodeID1, uint newNodeID2) => new(edge.ID, newNodeID1, newNodeID2);

    /// <summary>
    /// Creates a new copy of an <see cref="Edge"/> with different <see cref="Edge.NodeID1"/>.
    /// </summary>
    /// <param name="edge">Edge to copy.</param>
    /// <param name="newNodeID1">New node ID for the first endpoint.</param>
    /// <returns>Edge with new connecting node.</returns>
    public static Edge WithNodeID1(this Edge edge, uint newNodeID1) => new(edge.ID, newNodeID1, edge.NodeID2);

    /// <summary>
    /// Creates a new copy of an <see cref="Edge"/> with different <see cref="Edge.NodeID2"/>.
    /// </summary>
    /// <param name="edge">Edge to copy.</param>
    /// <param name="newNodeID2">New node ID for the second endpoint.</param>
    /// <returns>Edge with new connecting node.</returns>
    public static Edge WithNodeID2(this Edge edge, uint newNodeID2) => new(edge.ID, edge.NodeID1, newNodeID2);

    /// <summary>
    /// Creates a new copy of a <see cref="Node2D"/> with a different ID.
    /// </summary>
    /// <param name="node">Node to copy.</param>
    /// <param name="newID">ID for the new node.</param>
    /// <returns>Node with new ID.</returns>
    public static Node2D WithID(this Node2D node, uint newID) => new(newID, node.Loc);

    /// <summary>
    /// Creates a new copy of a <see cref="Node2D"/> with a different node location.
    /// </summary>
    /// <param name="node">Node to copy.</param>
    /// <param name="newLoc">New location of the node.</param>
    /// <returns>Node with new location.</returns>
    public static Node2D WithLoc(this Node2D node, Vector2 newLoc) => new(node.ID, newLoc);

    /// <summary>
    /// Creates a new copy of a <see cref="Node2D"/> with a different X location.
    /// </summary>
    /// <param name="node">Node to copy.</param>
    /// <param name="newX">New X location of the node.</param>
    /// <returns>Node with new X location.</returns>
    public static Node2D WithX(this Node2D node, float newX) => new(node.ID, new(newX, node.Loc.Y));

    /// <summary>
    /// Creates a new copy of a <see cref="Node2D"/> with a different Y location.
    /// </summary>
    /// <param name="node">Node to copy.</param>
    /// <param name="newY">New Y location of the node.</param>
    /// <returns>Node with new Y location.</returns>
    public static Node2D WithY(this Node2D node, float newY) => new(node.ID, new(node.Loc.X, newY));

    /// <summary>
    /// Creates a new copy of a <see cref="Node3D"/> with a different ID.
    /// </summary>
    /// <param name="node">Node to copy.</param>
    /// <param name="newID">ID for the new node.</param>
    /// <returns>Node with new ID.</returns>
    public static Node3D WithID(this Node3D node, uint newID) => new(newID, node.Loc);

    /// <summary>
    /// Creates a new copy of a <see cref="Node3D"/> with a different node location.
    /// </summary>
    /// <param name="node">Node to copy.</param>
    /// <param name="newLoc">New location of the node.</param>
    /// <returns>Node with new location.</returns>
    public static Node3D WithLoc(this Node3D node, Vector3 newLoc) => new(node.ID, newLoc);

    /// <summary>
    /// Creates a new copy of a <see cref="Node3D"/> with a different X location.
    /// </summary>
    /// <param name="node">Node to copy.</param>
    /// <param name="newX">New X location of the node.</param>
    /// <returns>Node with new X location.</returns>
    public static Node3D WithX(this Node3D node, float newX) => new(node.ID, new(newX, node.Loc.Y, node.Loc.Z));

    /// <summary>
    /// Creates a new copy of a <see cref="Node3D"/> with a different Y location.
    /// </summary>
    /// <param name="node">Node to copy.</param>
    /// <param name="newY">New Y location of the node.</param>
    /// <returns>Node with new Y location.</returns>
    public static Node3D WithY(this Node3D node, float newY) => new(node.ID, new(node.Loc.X, newY, node.Loc.Z));

    /// <summary>
    /// Creates a new copy of a <see cref="Node3D"/> with a different Z location.
    /// </summary>
    /// <param name="node">Node to copy.</param>
    /// <param name="newZ">New Z location of the node.</param>
    /// <returns>Node with new Z location.</returns>
    public static Node3D WithZ(this Node3D node, float newZ) => new(node.ID, new(node.Loc.X, node.Loc.Y, newZ));

    /// <summary>
    /// Get the <see cref="INode"/> that is referenced from <see cref="Edge.NodeID1"/> of an <see cref="Edge"/>.
    /// </summary>
    /// <typeparam name="TNode">Type of node used in the graph.</typeparam>
    /// <param name="graph">Graph where the edge resides.</param>
    /// <param name="edgeID">ID of the edge.</param>
    /// <returns>First connecting node of the edge.</returns>
    public static TNode GetFirstNodeOfEdge<TNode>(this IReadOnlyGraph<TNode> graph, uint edgeID) where TNode : struct, INode => graph.Nodes[graph.Edges[edgeID].NodeID1];

    /// <summary>
    /// Get the <see cref="INode"/> that is referenced from <see cref="Edge.NodeID2"/> of an <see cref="Edge"/>.
    /// </summary>
    /// <typeparam name="TNode">Type of node used in the graph.</typeparam>
    /// <param name="graph">Graph where the edge resides.</param>
    /// <param name="edgeID">ID of the edge.</param>
    /// <returns>Second connecting node of the edge.</returns>
    public static TNode GetSecondNodeOfEdge<TNode>(this IReadOnlyGraph<TNode> graph, uint edgeID) where TNode : struct, INode => graph.Nodes[graph.Edges[edgeID].NodeID2];

    /// <summary>
    /// Determine if a <see cref="INode"/> is assigned as <see cref="Edge.NodeID1"/> or <see cref="Edge.NodeID2"/> in an <see cref="Edge"/>.
    /// </summary>
    /// <param name="edge">Edge to check.</param>
    /// <param name="nodeID">ID of the node to check.</param>
    /// <returns>Assignment of the node in the edge, <see cref="NodeInEdge.None"/> if not in edge.</returns>
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

    /// <summary>
    /// Check if an <see cref="Edge"/> connect to a <see cref="INode"/> with a specific ID.
    /// </summary>
    /// <param name="edge">Edge to check.</param>
    /// <param name="nodeID">ID of the node to check.</param>
    /// <returns>True if the edge connects to the specific node ID, else false.</returns>
    public static bool EdgeHasNodeID(this Edge edge, uint nodeID) => edge.NodeID1 == nodeID ? true : edge.NodeID2 == nodeID ? true : false;

    /// <summary>
    /// Get the opposing endpoint from an <see cref="Edge"/>.
    /// </summary>
    /// <param name="edge">Edge to check.</param>
    /// <param name="sourceNodeID">ID of the node to get the opposing endpoint.</param>
    /// <returns>Connecting node from the node.</returns>
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