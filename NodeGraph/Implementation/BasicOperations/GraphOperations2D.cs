using System.Numerics;

namespace GG.NodeGraph.Implementation;

public static class GraphOp2D
{
    /// <summary>
    /// Copy specified elements from one graph to another.
    /// </summary>
    /// <param name="copyFrom">Source graph to copy from.</param>
    /// <param name="elementsToCopy">Elements to copy.</param>
    /// <param name="pasteTo">Target graph to paste the elements to.</param>
    /// <param name="preserveID">Preserves the id of the elements from the source graph. If false, new ids will be generated for the elements in the target graph.</param>
    public static void CopyElementsToGraph(this IGraph<Node2D> copyFrom, IEnumerable<ElementID> elementsToCopy, IGraph<Node2D> pasteTo, bool preserveID)
    {
        BatchedModifications<Node2D> mods = new();
        if (preserveID)
        {
            foreach(ElementID element in elementsToCopy)
            {
                if(element.Type == ElementType.Node)
                {
                    mods.Nodes.Add(element.ID, copyFrom.Nodes[element.ID]);
                    continue;
                }
                mods.Edges.Add(element.ID, copyFrom.Edges[element.ID]);
            }
        }
        else
        {
            //Sort nodes and edges for modification.
            //Necessary since nodes have to be assigned a new id first before the edges reference the new ids.
            HashSet<Node2D> nodes = new();
            HashSet<Edge> edges = new();
            foreach(ElementID element in elementsToCopy)
            {
                if(element.Type == ElementType.Node)
                {
                    nodes.Add(copyFrom.Nodes[element.ID]);
                    continue;
                }
                edges.Add(copyFrom.Edges[element.ID]);
            }

            //Change node ids while logging its old id.
            Dictionary<uint, uint> oldToNewNodeID = new();
            foreach(Node2D node in nodes)
            {
                uint newID = pasteTo.GenerateID();
                oldToNewNodeID.Add(node.ID, newID);
                mods.Nodes.Add(newID, node.UpdateID(newID));
            }

            //change the edge node references to the new node ids.
            foreach(Edge edge in edges)
            {
                uint newEdgeID = pasteTo.GenerateID();
                uint nodeID1 = oldToNewNodeID.ContainsKey(edge.NodeID1) ? oldToNewNodeID[edge.NodeID1] : edge.NodeID1;
                uint nodeID2 = oldToNewNodeID.ContainsKey(edge.NodeID2) ? oldToNewNodeID[edge.NodeID2] : edge.NodeID2;
                mods.Edges.Add(newEdgeID, edge.UpdateNodeIDs(nodeID1, nodeID2));
            }
        }

        //Apply changes.
        pasteTo.ApplyBatchedModifications(mods);
    }

    /// <summary>
    /// Copy entire graph to another graph.
    /// </summary>
    /// <param name="copyFrom">Source graph to copy.</param>
    /// <param name="pasteTo">Target graph to paste the source graph to.</param>
    public static void CopyGraph(this IGraph<Node2D> copyFrom, IGraph<Node2D> pasteTo, bool preserveID)
    {
        BatchedModifications<Node2D> mods = new();
        if (preserveID)
        {
            foreach(Node2D node in copyFrom.Nodes.Values)
            {
                mods.Nodes.Add(node.ID, node);
            }
            foreach(Edge edge in copyFrom.Edges.Values)
            {
                mods.Edges.Add(edge.ID, edge);
            }
        }
        else
        {
            Dictionary<uint, uint> oldToNewNodeID = new();
            foreach(Node2D node in copyFrom.Nodes.Values)
            {
                uint newID = pasteTo.GenerateID();
                oldToNewNodeID.Add(node.ID, newID);
                mods.Nodes.Add(newID, node.UpdateID(newID));
            }
            foreach(Edge edge in copyFrom.Edges.Values)
            {
                uint newEdgeID = pasteTo.GenerateID();
                uint nodeID1 = oldToNewNodeID.ContainsKey(edge.NodeID1) ? oldToNewNodeID[edge.NodeID1] : edge.NodeID1;
                uint nodeID2 = oldToNewNodeID.ContainsKey(edge.NodeID2) ? oldToNewNodeID[edge.NodeID2] : edge.NodeID2;
                mods.Edges.Add(newEdgeID, edge.UpdateNodeIDs(nodeID1, nodeID2));
            }
        }
        pasteTo.ApplyBatchedModifications(mods);
    }

    /// <summary>
    /// Insert a new node in between an edge.
    /// </summary>
    /// <param name="baseGraph">Graph to perform the operation.</param>
    /// <param name="edgeID">ID of target edge.</param>
    /// <param name="newNode">Node to insert.</param>
    public static void InsertNode(this IGraph<Node2D> baseGraph, uint edgeID, Node2D newNode)
    {
        BatchedModifications<Node2D> mods = new();

        Edge edgeToInsert = baseGraph.Edges[edgeID];
        Edge newEdge = new(baseGraph.GenerateID(), newNode.ID, edgeToInsert.NodeID2);
        edgeToInsert = edgeToInsert.UpdateNodeID2(newNode.ID);

        mods.Nodes.Add(newNode.ID, newNode);
        mods.Edges.Add(edgeToInsert.ID, edgeToInsert);
        mods.Edges.Add(newEdge.ID, newEdge);

        baseGraph.ApplyBatchedModifications(mods);
    }

    /// <summary>
    /// Combine multiple nodes into a single one.
    /// </summary>
    /// <param name="baseGraph"></param>
    /// <param name="nodeIDsToCollapse"></param>
    public static void CollapseNode(this IGraph<Node2D> baseGraph, NodeAdjacency<Node2D> adjacency, params uint[] nodeIDsToCollapse)
    {
        if(nodeIDsToCollapse.Length <= 1)
        {
            return;
        }
        BatchedModifications<Node2D> mods = new();

        //Get new average coord
        Vector2 AverageCoord = Vector2.Zero;
        foreach(uint nodeID in nodeIDsToCollapse)
        {
            AverageCoord += baseGraph.Nodes[nodeID].Loc;
        }
        AverageCoord /= nodeIDsToCollapse.Length;

        //Make the first node the new collapsed node
        uint collapsedNodeID = nodeIDsToCollapse[0];
        Node2D collapsedNode = new(collapsedNodeID, AverageCoord);
        mods.Nodes.Add(collapsedNodeID, collapsedNode);

        //Record collapsed node to a hashset
        HashSet<uint> collapsedNodes = nodeIDsToCollapse.ToHashSet();
        collapsedNodes.Remove(nodeIDsToCollapse[0]);

        //Made the edges connecting to other nodes connect to the new node
        foreach(uint nodeID in nodeIDsToCollapse)
        {
            Edge edge = default;
            foreach(uint edgeID in adjacency.ConnectedEdges(nodeID))
            {
                edge = baseGraph.Edges[edgeID];
                uint newNodeID1 = collapsedNodes.Contains(edge.NodeID1) ? collapsedNodeID : edge.NodeID1;
                uint newNodeID2 = collapsedNodes.Contains(edge.NodeID1) ? collapsedNodeID : edge.NodeID2;
                mods.Edges.Add(edge.ID, edge.UpdateNodeIDs(newNodeID1, newNodeID2));
            }
        }

        //Remove the collapsed nodes
        foreach(uint nodeID in collapsedNodes)
        {
            mods.Nodes.Add(nodeID, null);
        }

        //Apply changes
        baseGraph.ApplyBatchedModifications(mods);
    }

    /*
    WIP
    public static void SplitNode(this IGraph<Node2D> baseGraph, uint edgeID, Node2D[] newNodes)
    {
        
    }

    public static Node2D SplitEdge(this IGraph<Node2D> baseGraph, uint edgeID, float splitPos = 0.5f)
    {
        
    }

    public static IEnumerable<Node2D> SplitEdgeMultiple(this IGraph<Node2D> baseGraph, uint edgeID, uint SplitAmount)
    {
        
    }

    public static bool IsEdgeIntersecting(this IGraph<Node2D> baseGraph, uint edgeID1, uint edgeID2)
    {
        return false;
    }

    public static bool TryGetEdgeIntersectionLoc(this IGraph<Node2D> baseGraph, uint edgeID1, uint edgeID2, out Vector2 intersection)
    {
        
    }*/
}