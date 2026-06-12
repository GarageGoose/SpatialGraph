namespace GG.SpatialGraph;

/// <summary>
/// Graph which tracked changes within it.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class TrackedGraph<TNode> : Graph<TNode>, ITrackedGraph<TNode> where TNode : struct, INode
{
    public event EventHandler<IReadOnlyModificationLog<TNode>>? GraphModified;

    public TrackedGraph() : base()
    {
    }

    public TrackedGraph(IReadOnlyGraph<TNode> graph) : base(graph)
    {
    }

    public TrackedGraph(Dictionary<uint, TNode> nodes, Dictionary<uint, Edge> edges) : base(nodes, edges)
    {
    }

    public override void ApplyBatchedModifications(BatchedModifications<TNode> modifications)
    {
        ModificationLog<TNode> log = new(this);
        ElementModificationsByType<TNode> nodeMods = modifications.SegregateNodeModifications();
        ElementModificationsByType<Edge> edgeMods = modifications.SegregateEdgeModifications();

        foreach(TNode node in nodeMods.Upsert)
        {
            log.NodeUpsert(node);
            nodes[node.ID] = node;
        }
        
        foreach(Edge edge in edgeMods.Upsert)
        {
            log.EdgeUpsert(edge);
            edges[edge.ID] = edge;
        }

        foreach(uint nodeID in nodeMods.Removal)
        {
            log.NodeRemoval(nodeID);
            if (!nodes.Remove(nodeID))
            {
                log.RemoveNodeModification(nodeID);
            }
        }

        foreach(uint edgeID in edgeMods.Removal)
        {
            log.EdgeRemoval(edgeID);
            if (!edges.Remove(edgeID))
            {
                log.RemoveEdgeModification(edgeID);
            }
        }

        GraphModified?.Invoke(this, log);
    }

    public override bool RemoveEdge(uint ID)
    {
        ModificationLog<TNode> log = new(this);
        log.EdgeRemoval(ID);
        if (base.RemoveEdge(ID))
        {
            GraphModified?.Invoke(this, log);
            return true;
        }
        return false;
    }

    public override bool RemoveNode(uint ID)
    {
        ModificationLog<TNode> log = new(this);
        log.NodeRemoval(ID);
        if (base.RemoveNode(ID))
        {
            GraphModified?.Invoke(this, log);
            return true;
        }
        return false;
    }

    public override void UpsertEdge(Edge edge)
    {
        ModificationLog<TNode> log = new(this);
        log.EdgeUpsert(edge);
        base.UpsertEdge(edge);
        GraphModified?.Invoke(this, log);
    }

    public override void UpsertNode(TNode Node)
    {
        ModificationLog<TNode> log = new(this);
        log.NodeUpsert(Node);
        base.UpsertNode(Node);
        GraphModified?.Invoke(this, log);
    }
}