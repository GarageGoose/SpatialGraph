using System.Numerics;
namespace SpatialGraph;

/// <summary>
/// Basic operations for a graph.
/// </summary>
public static class BasicGraphOperations
{
    /// <summary>
    /// Add or replace a node with the same ID in a 2D graph.
    /// </summary>
    /// <param name="graph">Graph to upsert a node.</param>
    /// <param name="ID">ID of the node to add/replace.</param>
    /// <param name="X">X position of the node.</param>
    /// <param name="Y">Y position of the node.</param>
    public static void UpsertNode(this Graph<Node2D> graph, uint ID, float X, float Y) => graph.UpsertNode(new(ID, new(X, Y)));

    /// <summary>
    /// Add or replace a node with the same ID in a 2D graph.
    /// </summary>
    /// <param name="graph">Graph to upsert a node.</param>
    /// <param name="ID">ID of the node to add/replace.</param>
    /// <param name="Loc">Location of the node.</param>
    public static void UpsertNode(this Graph<Node2D> graph, uint ID, Vector2 Loc) => graph.UpsertNode(new(ID, Loc));
    
    /// <summary>
    /// Add a node in a 2D graph.
    /// </summary>
    /// <param name="graph">Graph to add a node.</param>
    /// <param name="X">X position of the node.</param>
    /// <param name="Y">Y position of the node.</param>
    /// <returns>ID of the new node.</returns>
    public static uint AddNode(this Graph<Node2D> graph, float X, float Y)
    {
        uint ID = graph.GenerateID();
        graph.UpsertNode(new(ID, new(X, Y)));
        return ID;
    }

    /// <summary>
    /// Add a node in a 2D graph.
    /// </summary>
    /// <param name="graph">Graph to add a node.</param>
    /// <param name="Loc">Location of the node.</param>
    /// <returns>ID of the new node.</returns>
    public static uint AddNode(this Graph<Node2D> graph, Vector2 Loc)
    {
        uint ID = graph.GenerateID();
        graph.UpsertNode(new(ID, Loc));
        return ID;
    }

    /// <summary>
    /// Add or replace a node with the same ID in a 3D graph.
    /// </summary>
    /// <param name="graph">Graph to add a node.</param>
    /// <param name="ID">ID of the node to add/replace.</param>
    /// <param name="X">X position of the node.</param>
    /// <param name="Y">Y position of the node.</param>
    /// <param name="Z">Z position of the node.</param>
    public static void UpsertNode(this Graph<Node3D> graph, uint ID, float X, float Y, float Z) => graph.UpsertNode(new(ID, new(X, Y, Z)));

    /// <summary>
    /// Add or replace a node with the same ID in a 3D graph.
    /// </summary>
    /// <param name="graph">Graph to add a node.</param>
    /// <param name="ID">ID of the node to add/replace.</param>
    /// <param name="Loc">Location of the node.</param>
    public static void UpsertNode(this Graph<Node3D> graph, uint ID, Vector3 Loc) => graph.UpsertNode(new(ID, Loc));

    /// <summary>
    /// Add a node in a 3D graph.
    /// </summary>
    /// <param name="graph">Graph to add a node.</param>
    /// <param name="X">X position of the new node.</param>
    /// <param name="Y">Y position of the new node.</param>
    /// <param name="Z">Z position of the new node.</param>
    /// <returns>ID of the new node.</returns>
    public static uint AddNode(this Graph<Node3D> graph, float X, float Y, float Z)
    {
        uint ID = graph.GenerateID();
        graph.UpsertNode(new(ID, new(X, Y, Z)));
        return ID;
    }

    /// <summary>
    /// Add a node in a 3D graph.
    /// </summary>
    /// <param name="graph">Graph to add a node.</param>
    /// <param name="Loc">Location of the node.</param>
    /// <returns>ID of the new node.</returns>
    public static uint AddNode(this Graph<Node3D> graph, Vector3 Loc)
    {
        uint ID = graph.GenerateID();
        graph.UpsertNode(new(ID, Loc));
        return ID;
    }

    /// <summary>
    /// Add an edge in a graph.
    /// </summary>
    /// <typeparam name="TNode">Type of node the graph have.</typeparam>
    /// <param name="graph">Graph to add an edge.</param>
    /// <param name="NodeID1">The first node in an edge.</param>
    /// <param name="NodeID2">The second node in an edge.</param>
    /// <returns></returns>
    public static uint AddEdge<TNode>(this Graph<TNode> graph, uint NodeID1, uint NodeID2) where TNode : struct, INode
    {
        uint ID = graph.GenerateID();
        graph.UpsertEdge(new(ID, NodeID1, NodeID2));
        return ID;
    }

    /// <summary>
    /// Replace the ID of a node with a new ID. Existing node with the same ID as the new ID will be replaced. 
    /// </summary>
    /// <param name="graph">Graph where to replace a node ID.</param>
    /// <param name="NodeID">Current ID of the node to be replaced with a new ID.</param>
    /// <param name="NewNodeID">New ID of the node.</param>
    public static void ReplaceNodeID(this Graph<Node2D> graph, uint NodeID, uint NewNodeID)
    {
        graph.UpsertNode(graph.Nodes[NodeID].WithID(NewNodeID));
        graph.RemoveNode(NodeID);
    }

    /// <summary>
    /// Replace the ID of a node with a new ID. Existing node with the same ID as the new ID will be replaced. 
    /// </summary>
    /// <param name="graph">Graph where to replace a node ID.</param>
    /// <param name="NodeID">Current ID of the node to be replaced with a new ID.</param>
    /// <param name="NewNodeID">New ID of the node.</param>
    public static void ReplaceNodeID(this Graph<Node3D> graph, uint NodeID, uint NewNodeID)
    {
        graph.UpsertNode(graph.Nodes[NodeID].WithID(NewNodeID));
        graph.RemoveNode(NodeID);
    }

    /// <summary>
    /// Replace the ID of an edge with a new ID. An existing edge with the same ID as the new ID will be replaced.
    /// </summary>
    /// <param name="graph">Graph where to replace an edge ID.</param>
    /// <param name="EdgeID">Current ID of the edge to be replaced with a new ID.</param>
    /// <param name="NewEdgeID">New ID of the edge.</param>
    public static void ReplaceEdgeID<TNode>(this Graph<TNode> graph, uint EdgeID, uint NewEdgeID) where TNode : struct, INode
    {
        graph.UpsertEdge(graph.Edges[EdgeID].WithID(NewEdgeID));
        graph.RemoveEdge(EdgeID);
    }

    /// <summary>
    /// Replace the first node (NodeID1) in an edge to a new one in a graph.
    /// </summary>
    /// <typeparam name="TNode">Type of node the graph is using.</typeparam>
    /// <param name="graph">Graph where to replace the first node of an edge.</param>
    /// <param name="EdgeID">ID of the edge to replace its first node.</param>
    /// <param name="NewNodeID">ID of the node to replace the first node of the edge.</param>
    public static void ReplaceFirstNodeInEdge<TNode>(this Graph<TNode> graph, uint EdgeID, uint NewNodeID) where TNode : struct, INode => graph.UpsertEdge(graph.Edges[EdgeID].WithNodeID1(NewNodeID));

    /// <summary>
    /// Replace the second node (NodeID2) in an edge to a new one in a graph.
    /// </summary>
    /// <typeparam name="TNode">Type of node the graph is using.</typeparam>
    /// <param name="graph">Graph where to replace the second node of an edge.</param>
    /// <param name="EdgeID">ID of the edge to replace its second node.</param>
    /// <param name="NewNodeID">ID of the node to replace the second node of the edge.</param>
    public static void ReplaceSecondNodeInEdge<TNode>(this Graph<TNode> graph, uint EdgeID, uint NewNodeID) where TNode : struct, INode => graph.UpsertEdge(graph.Edges[EdgeID].WithNodeID2(NewNodeID));

    /// <summary>
    /// Replace both nodes in an edge to a new one in a graph.
    /// </summary>
    /// <typeparam name="TNode">Type of node the graph is using.</typeparam>
    /// <param name="graph">Graph where to replace the second node of an edge.</param>
    /// <param name="EdgeID">ID of the edge to replace its second node.</param>
    /// <param name="NewNodeID1">ID of the node to replace the first node of the edge.</param>
    /// <param name="NewNodeID2">ID of the node to replace the second node of the edge.</param>
    public static void ReplaceNodesInEdge<TNode>(this Graph<TNode> graph, uint EdgeID, uint NewNodeID1, uint NewNodeID2) where TNode : struct, INode => graph.UpsertEdge(graph.Edges[EdgeID].WithNodeIDs(NewNodeID1, NewNodeID2));

    /// <summary>
    /// Replace the location of a node in a graph.
    /// </summary>
    /// <param name="graph">Graph with the node to replace its location.</param>
    /// <param name="NodeID">ID of the node to replace its location.</param>
    /// <param name="NewLoc">New location of the node.</param>
    public static void ReplaceLocationOfNode(this Graph<Node2D> graph, uint NodeID, Vector2 NewLoc) => graph.UpsertNode(graph.Nodes[NodeID].WithLoc(NewLoc));

    /// <summary>
    /// Replace the location of a node in a graph.
    /// </summary>
    /// <param name="graph">Graph with the node to replace its location.</param>
    /// <param name="NodeID">ID of the node to replace its location.</param>
    /// <param name="NewLoc">New location of the node.</param>
    public static void ReplaceLocationOfNode(this Graph<Node3D> graph, uint NodeID, Vector3 NewLoc) => graph.UpsertNode(graph.Nodes[NodeID].WithLoc(NewLoc));

    /// <summary>
    /// Replace the X location of a node in a graph.
    /// </summary>
    /// <param name="graph">Graph with the node to replace its X location.</param>
    /// <param name="NodeID">ID of the node to replace its X location.</param>
    /// <param name="NewXPos">New X location of the node.</param>
    public static void ReplaceXPosOfNode(this Graph<Node2D> graph, uint NodeID, float NewXPos) => graph.UpsertNode(graph.Nodes[NodeID].WithX(NewXPos));

    /// <summary>
    /// Replace the X location of a node in a graph.
    /// </summary>
    /// <param name="graph">Graph with the node to replace its X location.</param>
    /// <param name="NodeID">ID of the node to replace its X location.</param>
    /// <param name="NewXPos">New X location of the node.</param>
    public static void ReplaceXPosOfNode(this Graph<Node3D> graph, uint NodeID, float NewXPos) => graph.UpsertNode(graph.Nodes[NodeID].WithX(NewXPos));

    /// <summary>
    /// Replace the Y location of a node in a graph.
    /// </summary>
    /// <param name="graph">Graph with the node to replace its Y location.</param>
    /// <param name="NodeID">ID of the node to replace its Y location.</param>
    /// <param name="NewYPos">New Y location of the node.</param>
    public static void ReplaceYPosOfNode(this Graph<Node2D> graph, uint NodeID, float NewYPos) => graph.UpsertNode(graph.Nodes[NodeID].WithY(NewYPos));

    /// <summary>
    /// Replace the Y location of a node in a graph.
    /// </summary>
    /// <param name="graph">Graph with the node to replace its Y location.</param>
    /// <param name="NodeID">ID of the node to replace its Y location.</param>
    /// <param name="NewYPos">New Y location of the node.</param>
    public static void ReplaceYPosOfNode(this Graph<Node3D> graph, uint NodeID, float NewYPos) => graph.UpsertNode(graph.Nodes[NodeID].WithY(NewYPos));

    /// <summary>
    /// Replace the Z location of a node in a graph.
    /// </summary>
    /// <param name="graph">Graph with the node to replace its Z location.</param>
    /// <param name="NodeID">ID of the node to replace its Z location.</param>
    /// <param name="NewZPos">New Z location of the node.</param>
    public static void ReplaceZPosOfNode(this Graph<Node3D> graph, uint NodeID, float NewZPos) => graph.UpsertNode(graph.Nodes[NodeID].WithZ(NewZPos));
}