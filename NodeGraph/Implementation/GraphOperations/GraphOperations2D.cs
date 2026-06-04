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
    public static void CopyElementsToGraph(IGraph<Node2D> copyFrom, IEnumerable<ElementID> elementsToCopy, IGraph<Node2D> pasteTo, bool preserveID)
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
            foreach(ElementID element in elementsToCopy)
            {
                uint newID = pasteTo.GenerateID();
                if(element.Type == ElementType.Node)
                {
                    mods.Nodes.Add(newID, new(newID, copyFrom.Nodes[element.ID].Loc));
                    continue;
                }
                mods.Edges.Add(newID, new(newID, copyFrom.Edges[element.ID].NodeID1, copyFrom.Edges[element.ID].NodeID2));
            }
        }
        pasteTo.ApplyBatchedModifications(mods);
    }

    /// <summary>
    /// Copy entire graph to another graph.
    /// </summary>
    /// <param name="copyFrom">Source graph to copy.</param>
    /// <param name="pasteTo">Target graph to paste the source graph to.</param>
    public static void CopyGraph(IGraph<Node2D> copyFrom, IGraph<Node2D> pasteTo, bool preserveID)
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
            foreach(Node2D node in copyFrom.Nodes.Values)
            {
                uint newID = pasteTo.GenerateID();
                mods.Nodes.Add(newID, new(newID, node.Loc));
            }
            foreach(Edge edge in copyFrom.Edges.Values)
            {
                uint newID = pasteTo.GenerateID();
                mods.Edges.Add(newID, new(newID, edge.NodeID1, edge.NodeID2));
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
    public static void InsertNode(IGraph<Node2D> baseGraph, uint edgeID, Node2D newNode)
    {
        Edge edgeToInsert = baseGraph.Edges[edgeID];
        Edge newEdge = new(edgeToInsert.ID, newNode.ID, edgeToInsert.NodeID2);
        edgeToInsert = new(edgeToInsert.ID, edgeToInsert.NodeID1, newNode.ID);

        baseGraph.UpsertNode(newNode);
        baseGraph.UpsertEdge(edgeToInsert);
        baseGraph.UpsertEdge(newEdge);
    }

    /// <summary>
    /// Combine multiple nodes into a single one.
    /// </summary>
    /// <param name="baseGraph"></param>
    /// <param name="nodeIDsToCollapse"></param>
    public static void CollapseNode(IGraph<Node2D> baseGraph, NodeAdjacency<Node2D> adjacency, params uint[] nodeIDsToCollapse)
    {
        if(nodeIDsToCollapse.Length == 0)
        {
            return;
        }

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
        baseGraph.UpsertNode(collapsedNode);
        
    }

    public static void BypassRemoveNode(IGraph<Node2D> baseGraph, uint nodeID)
    {
        
    }

    public static void SplitNode(IGraph<Node2D> baseGraph, uint edgeID, Node2D[] newNodes)
    {
        
    }

    public static Node2D SplitEdge(IGraph<Node2D> baseGraph, uint edgeID, float splitPos = 0.5f)
    {
        
    }

    public static IEnumerable<Node2D> SplitEdgeMultiple(IGraph<Node2D> baseGraph, uint edgeID, uint SplitAmount)
    {
        
    }

    public static bool EdgeIntersect(IGraph<Node2D> baseGraph, uint edgeID1, uint edgeID2)
    {
        return false;
    }
}