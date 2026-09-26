namespace GG.SpatialGraph;

/// <summary>
/// Graph which tracks and can modifiy incoming changes within it.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public class InterceptableTrackedGraph<TNode> : Graph<TNode>, IInterceptableTrackedGraph<TNode> where TNode : struct, INode
{
    public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphModified;
    public event EventHandler<ModificationLog<TNode>>? OnGraphModificationInit;

    /// <summary>
    /// Start an empty graph.
    /// </summary>
    public InterceptableTrackedGraph() : base()
    {
    }

    /// <summary>
    /// Start graph from a pre-exisitng graph.
    /// </summary>
    /// <param name="graph">Graph to replicate from.</param>
    public InterceptableTrackedGraph(IReadOnlyGraph<TNode> graph) : base(graph)
    {
    }

    /// <summary>
    /// Start a graph from pre-exisiting dictionaries of nodes and edges.
    /// </summary>
    public InterceptableTrackedGraph(Dictionary<uint, TNode> nodes, Dictionary<uint, Edge> edges) : base(nodes, edges)
    {
    }

    /// <summary>
    /// Apply multiple modifications at once with BatchedMods.
    /// </summary>
    /// <param name="mods">BatchedMods containing the modifications.</param>
    public override void ApplyBatchedModifications(IReadOnlyBatchedMods<TNode> mods) => applyBatchedModifications(new(this, mods));

    private void applyBatchedModifications(ModificationLog<TNode> log)
    {
        OnGraphModificationInit?.Invoke(this, log);
        
        foreach(TNode node in log.GetNodeUpserts())
        {
            nodes[node.ID] = node;
        }
        
        foreach(Edge edge in log.GetEdgeUpserts())
        {
            edges[edge.ID] = edge;
        }

        foreach(uint nodeID in log.GetNodeRemovalIDs())
        {
            //Undo log if operation failed
            if (!nodes.Remove(nodeID))
            {
                log.UnlogNode(nodeID);
            }
        }

        foreach(uint edgeID in log.GetEdgeRemovalIDs())
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