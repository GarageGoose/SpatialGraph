using System.Numerics;
namespace SpatialGraph.Extensions;

/// <summary>
/// Basic operations for a <see cref="IGraph{TNode}"/>, involving individual <see cref="IElement"/>s.
/// </summary>
public static class BasicGraphOperations
{
    /// <summary>
    /// Add or replace an existing <see cref="Node2D"/> with the same ID in a 2D <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="graph">Graph to upsert a node.</param>
    /// <param name="ID">ID of the node to add/replace.</param>
    /// <param name="X">X position of the node.</param>
    /// <param name="Y">Y position of the node.</param>
    public static void UpsertNode(this IGraph<Node2D> graph, uint ID, float X, float Y) => graph.UpsertNode(new(ID, new(X, Y)));

    /// <summary>
    /// Add or replace an existing <see cref="Node2D"/> with the same ID in a 2D <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="graph">Graph to upsert a node.</param>
    /// <param name="ID">ID of the node to add/replace.</param>
    /// <param name="Loc">Location of the node.</param>
    public static void UpsertNode(this IGraph<Node2D> graph, uint ID, Vector2 Loc) => graph.UpsertNode(new(ID, Loc));
    
    /// <summary>
    /// Add a <see cref="Node2D"/> in a 2D <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="graph">Graph to add a node.</param>
    /// <param name="X">X position of the node.</param>
    /// <param name="Y">Y position of the node.</param>
    /// <returns>ID of the new node.</returns>
    public static uint AddNode(this IGraph<Node2D> graph, float X, float Y)
    {
        uint ID = graph.GenerateID();
        graph.UpsertNode(new(ID, new(X, Y)));
        return ID;
    }

    /// <summary>
    /// Add a <see cref="Node2D"/> in a 2D <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="graph">Graph to add a node.</param>
    /// <param name="Loc">Location of the node.</param>
    /// <returns>ID of the new node.</returns>
    public static uint AddNode(this IGraph<Node2D> graph, Vector2 Loc)
    {
        uint ID = graph.GenerateID();
        graph.UpsertNode(new(ID, Loc));
        return ID;
    }

    /// <summary>
    /// Add or replace an existing <see cref="Node3D"/> with the same ID in a 3D <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="graph">Graph to upsert a node.</param>
    /// <param name="ID">ID of the node to add/replace.</param>
    /// <param name="X">X position of the node.</param>
    /// <param name="Y">Y position of the node.</param>
    /// <param name="Z">Z position of the node.</param>
    public static void UpsertNode(this IGraph<Node3D> graph, uint ID, float X, float Y, float Z) => graph.UpsertNode(new(ID, new(X, Y, Z)));

    /// <summary>
    /// Add or replace an existing <see cref="Node3D"/> with the same ID in a 3D <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="graph">Graph to upsert a node.</param>
    /// <param name="ID">ID of the node to add/replace.</param>
    /// <param name="Loc">Location of the node.</param>
    public static void UpsertNode(this IGraph<Node3D> graph, uint ID, Vector3 Loc) => graph.UpsertNode(new(ID, Loc));

    /// <summary>
    /// Add a <see cref="Node3D"/> in a 3D <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="graph">Graph to add a node.</param>
    /// <param name="X">X position of the new node.</param>
    /// <param name="Y">Y position of the new node.</param>
    /// <param name="Z">Z position of the new node.</param>
    /// <returns>ID of the new node.</returns>
    public static uint AddNode(this IGraph<Node3D> graph, float X, float Y, float Z)
    {
        uint ID = graph.GenerateID();
        graph.UpsertNode(new(ID, new(X, Y, Z)));
        return ID;
    }

    /// <summary>
    /// Add a <see cref="Node3D"/> in a 3D <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="graph">Graph to add a node.</param>
    /// <param name="Loc">Location of the node.</param>
    /// <returns>ID of the new node.</returns>
    public static uint AddNode(this IGraph<Node3D> graph, Vector3 Loc)
    {
        uint ID = graph.GenerateID();
        graph.UpsertNode(new(ID, Loc));
        return ID;
    }

    /// <summary>
    /// Add an <see cref="Edge"/> in a <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <typeparam name="TNode">Type of node the graph has.</typeparam>
    /// <param name="graph">Graph to add an edge.</param>
    /// <param name="NodeID1">The first node in an edge.</param>
    /// <param name="NodeID2">The second node in an edge.</param>
    /// <returns>ID of the new edge.</returns>
    public static uint AddEdge<TNode>(this IGraph<TNode> graph, uint NodeID1, uint NodeID2) where TNode : struct, INode
    {
        uint ID = graph.GenerateID();
        graph.UpsertEdge(new(ID, NodeID1, NodeID2));
        return ID;
    }

    /// <summary>
    /// Replace the ID of a <see cref="Node2D"/> with a new ID. Existing <see cref="Node2D"/> with the same ID as the new ID will be replaced. 
    /// </summary>
    /// <remarks>
    /// Does an upsert then removes the node with the old ID. Anything that references the old node ID is not updated by this method.
    /// </remarks>
    /// <param name="graph">Graph where to replace a node ID.</param>
    /// <param name="NodeID">Current ID of the node to be replaced with a new ID.</param>
    /// <param name="NewNodeID">New ID of the node.</param>
    public static void ReplaceNodeID(this IGraph<Node2D> graph, uint NodeID, uint NewNodeID)
    {
        graph.UpsertNode(graph.Nodes[NodeID].WithID(NewNodeID));
        if(NodeID != NewNodeID)
        {
            graph.RemoveNode(NodeID);
        }
    }

    /// <summary>
    /// Replace the ID of a <see cref="Node3D"/> with a new ID. Existing <see cref="Node3D"/> with the same ID as the new ID will be replaced. 
    /// </summary>
    /// <remarks>
    /// Does an upsert then removes the node with the old ID. Anything that references the old node ID is not updated by this method.
    /// </remarks>
    /// <param name="graph">Graph where to replace a node ID.</param>
    /// <param name="NodeID">Current ID of the node to be replaced with a new ID.</param>
    /// <param name="NewNodeID">New ID of the node.</param>
    public static void ReplaceNodeID(this IGraph<Node3D> graph, uint NodeID, uint NewNodeID)
    {
        graph.UpsertNode(graph.Nodes[NodeID].WithID(NewNodeID));
        if(NodeID != NewNodeID)
        {
            graph.RemoveNode(NodeID);
        }
    }

    /// <summary>
    /// Replace the ID of an <see cref="Edge"/> with a new ID. An existing <see cref="Edge"/> with the same ID as the new ID will be replaced.
    /// </summary>
    /// <remarks>
    /// Does an upsert then removes the edge with the old ID. Anything that references the old edge ID is not updated by this method.
    /// </remarks>
    /// <typeparam name="TNode">Type of node the graph is using.</typeparam>
    /// <param name="graph">Graph where to replace an edge ID.</param>
    /// <param name="EdgeID">Current ID of the edge to be replaced with a new ID.</param>
    /// <param name="NewEdgeID">New ID of the edge.</param>
    public static void ReplaceEdgeID<TNode>(this IGraph<TNode> graph, uint EdgeID, uint NewEdgeID) where TNode : struct, INode
    {
        graph.UpsertEdge(graph.Edges[EdgeID].WithID(NewEdgeID));
        if(EdgeID != NewEdgeID)
        {
            graph.RemoveEdge(EdgeID);
        }
    }

    /// <summary>
    /// Replace the first <see cref="INode"/> (<see cref="Edge.NodeID1"/>) in an <see cref="Edge"/> to a new one in a <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <typeparam name="TNode">Type of node the graph is using.</typeparam>
    /// <param name="graph">Graph where to replace the first node of an edge.</param>
    /// <param name="EdgeID">ID of the edge to replace its first node.</param>
    /// <param name="NewNodeID">ID of the node to replace the first node of the edge.</param>
    public static void ReplaceFirstNodeInEdge<TNode>(this IGraph<TNode> graph, uint EdgeID, uint NewNodeID) where TNode : struct, INode => graph.UpsertEdge(graph.Edges[EdgeID].WithNodeID1(NewNodeID));

    /// <summary>
    /// Replace the second <see cref="INode"/> (<see cref="Edge.NodeID2"/>) in an <see cref="Edge"/> to a new one in a <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <typeparam name="TNode">Type of node the graph is using.</typeparam>
    /// <param name="graph">Graph where to replace the second node of an edge.</param>
    /// <param name="EdgeID">ID of the edge to replace its second node.</param>
    /// <param name="NewNodeID">ID of the node to replace the second node of the edge.</param>
    public static void ReplaceSecondNodeInEdge<TNode>(this IGraph<TNode> graph, uint EdgeID, uint NewNodeID) where TNode : struct, INode => graph.UpsertEdge(graph.Edges[EdgeID].WithNodeID2(NewNodeID));

    /// <summary>
    /// Replace both <see cref="INode"/>s in an <see cref="Edge"/> with new ones in a <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <typeparam name="TNode">Type of node the graph is using.</typeparam>
    /// <param name="graph">Graph where to replace the nodes of an edge.</param>
    /// <param name="EdgeID">ID of the edge to replace its nodes.</param>
    /// <param name="NewNodeID1">ID of the node to replace the first node of the edge.</param>
    /// <param name="NewNodeID2">ID of the node to replace the second node of the edge.</param>
    public static void ReplaceNodesInEdge<TNode>(this IGraph<TNode> graph, uint EdgeID, uint NewNodeID1, uint NewNodeID2) where TNode : struct, INode => graph.UpsertEdge(graph.Edges[EdgeID].WithNodeIDs(NewNodeID1, NewNodeID2));

    /// <summary>
    /// Replace the location of a <see cref="Node2D"/> in a <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="graph">Graph with the node to replace its location.</param>
    /// <param name="NodeID">ID of the node to replace its location.</param>
    /// <param name="NewLoc">New location of the node.</param>
    public static void ReplaceLocationOfNode(this IGraph<Node2D> graph, uint NodeID, Vector2 NewLoc) => graph.UpsertNode(graph.Nodes[NodeID].WithLoc(NewLoc));

    /// <summary>
    /// Replace the location of a <see cref="Node3D"/> in a <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="graph">Graph with the node to replace its location.</param>
    /// <param name="NodeID">ID of the node to replace its location.</param>
    /// <param name="NewLoc">New location of the node.</param>
    public static void ReplaceLocationOfNode(this IGraph<Node3D> graph, uint NodeID, Vector3 NewLoc) => graph.UpsertNode(graph.Nodes[NodeID].WithLoc(NewLoc));

    /// <summary>
    /// Replace the X location of a <see cref="Node2D"/> in a <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="graph">Graph with the node to replace its X location.</param>
    /// <param name="NodeID">ID of the node to replace its X location.</param>
    /// <param name="NewXPos">New X location of the node.</param>
    public static void ReplaceXPosOfNode(this IGraph<Node2D> graph, uint NodeID, float NewXPos) => graph.UpsertNode(graph.Nodes[NodeID].WithX(NewXPos));

    /// <summary>
    /// Replace the X location of a <see cref="Node3D"/> in a <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="graph">Graph with the node to replace its X location.</param>
    /// <param name="NodeID">ID of the node to replace its X location.</param>
    /// <param name="NewXPos">New X location of the node.</param>
    public static void ReplaceXPosOfNode(this IGraph<Node3D> graph, uint NodeID, float NewXPos) => graph.UpsertNode(graph.Nodes[NodeID].WithX(NewXPos));

    /// <summary>
    /// Replace the Y location of a <see cref="Node2D"/> in a <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="graph">Graph with the node to replace its Y location.</param>
    /// <param name="NodeID">ID of the node to replace its Y location.</param>
    /// <param name="NewYPos">New Y location of the node.</param>
    public static void ReplaceYPosOfNode(this IGraph<Node2D> graph, uint NodeID, float NewYPos) => graph.UpsertNode(graph.Nodes[NodeID].WithY(NewYPos));

    /// <summary>
    /// Replace the Y location of a <see cref="Node3D"/> in a <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="graph">Graph with the node to replace its Y location.</param>
    /// <param name="NodeID">ID of the node to replace its Y location.</param>
    /// <param name="NewYPos">New Y location of the node.</param>
    public static void ReplaceYPosOfNode(this IGraph<Node3D> graph, uint NodeID, float NewYPos) => graph.UpsertNode(graph.Nodes[NodeID].WithY(NewYPos));

    /// <summary>
    /// Replace the Z location of a <see cref="Node3D"/> in a <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="graph">Graph with the node to replace its Z location.</param>
    /// <param name="NodeID">ID of the node to replace its Z location.</param>
    /// <param name="NewZPos">New Z location of the node.</param>
    public static void ReplaceZPosOfNode(this IGraph<Node3D> graph, uint NodeID, float NewZPos) => graph.UpsertNode(graph.Nodes[NodeID].WithZ(NewZPos));
}