namespace GG.SpatialGraph;

/// <summary>
/// Graph which tracked changes within it.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class TrackedGraphInterceptable<TNode> : Graph<TNode>, ITrackedGraphInterceptable<TNode> where TNode : struct, INode
{
    public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphModified;
    public event EventHandler<ModificationLog<TNode>>? OnGraphModificationInit;

    public TrackedGraphInterceptable() : base()
    {
    }

    public TrackedGraphInterceptable(IReadOnlyGraph<TNode> graph) : base(graph)
    {
    }

    public TrackedGraphInterceptable(Dictionary<uint, TNode> nodes, Dictionary<uint, Edge> edges) : base(nodes, edges)
    {
    }

    public override void ApplyBatchedModifications(IReadOnlyBatchedMods<TNode> mods) => applyBatchedModifications(new(this, mods));

    private void applyBatchedModifications(ModificationLog<TNode> log)
    {
        OnGraphModificationInit?.Invoke(this, log);
        
        foreach(TNode node in log.GetUpsertedNodes())
        {
            nodes[node.ID] = node;
        }
        
        foreach(Edge edge in log.GetUpsertedEdges())
        {
            edges[edge.ID] = edge;
        }

        foreach(uint nodeID in log.GetNodeRemovalID())
        {
            //Undo log if operation failed
            if (!nodes.Remove(nodeID))
            {
                log.UnlogNode(nodeID);
            }
        }

        foreach(uint edgeID in log.GetEdgeRemovalID())
        {
            //Undo log if operation failed
            if (!edges.Remove(edgeID))
            {
                log.UnlogEdge(edgeID);
            }
        }

        OnGraphModified?.Invoke(this, log);
    }

    public override bool RemoveEdge(uint ID)
    {
        ModificationLog<TNode> log = new(this);
        log.EdgeRemoval(ID);
        ApplyBatchedModifications(log);
        return true; 
    }

    public override bool RemoveNode(uint ID)
    {
        ModificationLog<TNode> log = new(this);
        log.NodeRemoval(ID);
        ApplyBatchedModifications(log);
        return true;
    }

    public override void UpsertEdge(Edge edge)
    {
        ModificationLog<TNode> log = new(this);
        log.EdgeUpsert(edge);
        ApplyBatchedModifications(log);
    }

    public override void UpsertNode(TNode Node)
    {
        ModificationLog<TNode> log = new(this);
        log.NodeUpsert(Node);
        ApplyBatchedModifications(log);
    }
}