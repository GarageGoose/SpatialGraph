namespace GG.NodeGraph;

public class ManagedTrackedGraph<TNode> : Graph<TNode>, ITrackedGraphNodeRelations<TNode> where TNode : struct, INode
{
    public event EventHandler<IReadOnlyModificationLog<TNode>>? GraphModified;

    public ManagedTrackedGraph() : base() {}

    public ManagedTrackedGraph(IReadOnlyGraph<TNode> graph) : base(graph) {}

    public ManagedTrackedGraph(Dictionary<uint, TNode> nodes, Dictionary<uint, Edge> edges) : base(nodes, edges) {}

    Dictionary<uint, HashSet<uint>> edgesOnNode = new();

    public IReadOnlyDictionary <uint, HashSet<uint>> EdgesOnNode => edgesOnNode;

    public override void UpsertNode(TNode Node)
    {
        ModificationLog<TNode> log = new(this);
        log.NodeUpsert(Node);
        if (!Nodes.ContainsKey(Node.ID))
        {
            edgesOnNode.Add(Node.ID, new());
        }
        base.UpsertNode(Node);
        GraphModified?.Invoke(this, log);
    }

    public override bool RemoveNode(uint ID)
    {
        if(InternalRemoveNode(Nodes[ID], out ModificationLog<TNode> log))
        {
            GraphModified?.Invoke(this, log);
            return true;
        }
        return false;
    }

    public override void UpsertEdge(Edge edge)
    {
        if(Nodes.ContainsKey(edge.NodeID1) && Nodes.ContainsKey(edge.NodeID2))
        {
            ModificationLog<TNode> log = new(this);
            log.EdgeUpsert(edge);
            if (Edges.ContainsKey(edge.ID))
            {
                InternalRemoveEdge(edges[edge.ID]);
            }
            edgesOnNode[edge.NodeID1].Add(edge.ID);
            edgesOnNode[edge.NodeID2].Add(edge.ID);
            base.UpsertEdge(edge);
            GraphModified?.Invoke(this, log);
        }
    }

    public override bool RemoveEdge(uint ID)
    {
        ModificationLog<TNode> log = new(this);
        log.EdgeRemoval(ID);
        Edge edge = Edges[ID];
        if (base.RemoveEdge(ID))
        {
            InternalRemoveEdge(edge);
            GraphModified?.Invoke(this, log);
            return true;
        }
        return false;
    }

    void InternalRemoveEdge(Edge edge)
    {
        edgesOnNode[edge.NodeID1].Remove(edge.ID);
        edgesOnNode[edge.NodeID2].Remove(edge.ID);
    }

    bool InternalRemoveNode(TNode node, out ModificationLog<TNode> log)
    {
        log = new(this);
        log.NodeRemoval(node.ID);
        if (base.RemoveNode(node.ID))
        {
            foreach(uint edgeID in edgesOnNode[node.ID])
            {
                log.EdgeRemoval(edgeID);
                base.RemoveEdge(edgeID);
            }
            edgesOnNode.Remove(node.ID);
            return true;
        }
        log = new(this);
        return false;
    }

    public override void ApplyBatchedModifications(BatchedModifications<TNode> modifications)
    {
        ModificationLog<TNode> log = new(this);
        ElementModificationsByType<TNode> nodeMods = modifications.SortedNodeModifications();
        ElementModificationsByType<Edge> edgeMods = modifications.SortedEdgeModifications();

        foreach(TNode node in nodeMods.Upsert)
        {
            log.NodeUpsert(node);
            bool graphContainsNodeWithSameID = Nodes.ContainsKey(node.ID);
            nodes[node.ID] = node;

            if (!graphContainsNodeWithSameID) 
            {
                edgesOnNode.Add(node.ID, new());
            }
        }
        
        foreach(Edge edge in edgeMods.Upsert)
        {
            if(Nodes.ContainsKey(edge.NodeID1) && Nodes.ContainsKey(edge.NodeID2))
            {
                log.EdgeUpsert(edge);
                if (Edges.ContainsKey(edge.ID))
                {
                    InternalRemoveEdge(edge);
                }
                edgesOnNode[edge.NodeID1].Add(edge.ID);
                edgesOnNode[edge.NodeID2].Add(edge.ID);
            }
        }

        foreach(uint nodeID in nodeMods.Removal)
        {
            if(InternalRemoveNode(Nodes[nodeID], out ModificationLog<TNode> nodeRemovalLog))
            {
                log.Union(nodeRemovalLog);
            }
        }

        foreach(uint edgeID in edgeMods.Removal)
        {
            log.EdgeRemoval(edgeID);
            if (!base.RemoveEdge(edgeID))
            {
                log.RemoveEdgeModification(edgeID);
            }
        }

        base.ApplyBatchedModifications(modifications);
        GraphModified?.Invoke(this, log);
    }

    public IReadOnlySet<uint> GetEdgesOnNode(uint nodeID) => edgesOnNode[nodeID];
}