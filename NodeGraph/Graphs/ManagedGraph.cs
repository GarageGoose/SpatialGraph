namespace GG.NodeGraph;

//WIP!!
/// <summary>
/// Graph with builtin checks and measures (like deleting connected edges to a deleted node) to prevent dangling references. Also tracks edges connected on nodes.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class ManagedGraph<TNode> : Graph<TNode> where TNode : struct, INode
{
    public ManagedGraph() : base() {}

    public ManagedGraph(IReadOnlyGraph<TNode> graph) : base(graph) {}

    public ManagedGraph(Dictionary<uint, TNode> nodes, Dictionary<uint, Edge> edges) : base(nodes, edges) {}

    Dictionary<uint, HashSet<uint>> edgesOnNode = new();

    public IReadOnlyDictionary <uint, HashSet<uint>> EdgesOnNode => edgesOnNode;

    public override void UpsertNode(TNode Node)
    {
        if (!Nodes.ContainsKey(Node.ID))
        {
            edgesOnNode.Add(Node.ID, new());
        }
        base.UpsertNode(Node);
    }

    public override bool RemoveNode(uint ID)
    {
        if (base.RemoveNode(ID))
        {
            foreach(uint edgeID in edgesOnNode[ID])
            {
                base.RemoveEdge(edgeID);
            }
            edgesOnNode.Remove(ID);
            return true;
        }
        return false;
    }

    public override void UpsertEdge(Edge edge)
    {
        if(Nodes.ContainsKey(edge.NodeID1) && Nodes.ContainsKey(edge.NodeID2))
        {
            if (Edges.ContainsKey(edge.ID))
            {
                InternalRemoveEdge(edge);
            }
            edgesOnNode[edge.NodeID1].Add(edge.ID);
            edgesOnNode[edge.NodeID2].Add(edge.ID);
            base.UpsertEdge(edge);
        }
    }

    public override bool RemoveEdge(uint ID)
    {
        Edge edge = Edges[ID];
        if (base.RemoveEdge(ID))
        {
            InternalRemoveEdge(edge);
            return true;
        }
        return false;
    }

    void InternalRemoveEdge(Edge edge)
    {
        edgesOnNode[edge.NodeID1].Remove(edge.ID);
        edgesOnNode[edge.NodeID2].Remove(edge.ID);
    }

    public override void ApplyBatchedModifications(BatchedModifications<TNode> modifications)
    {
        ElementModificationsByType<TNode> nodeMods = modifications.SortedNodeModifications();
        ElementModificationsByType<Edge> edgeMods = modifications.SortedEdgeModifications();

        foreach(TNode node in nodeMods.Upsert)
        {
            UpsertNode(node);
        }

        foreach(Edge edge in edgeMods.Upsert)
        {
            UpsertEdge(edge);
        }

        foreach(uint nodeID in nodeMods.Removal)
        {
            RemoveNode(nodeID);
        }

        foreach(uint edgeID in edgeMods.Removal)
        {
            RemoveEdge(edgeID);
        }
    }
}
