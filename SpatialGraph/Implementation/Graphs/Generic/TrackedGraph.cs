namespace GG.SpatialGraph;

/// <summary>
/// Graph which tracks changes within it.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public class TrackedGraph<TNode> : Graph<TNode>, ITrackedGraph<TNode> where TNode : struct, INode
{
    public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphModified;

    /// <summary>
    /// Start an empty graph.
    /// </summary>
    public TrackedGraph() : base()
    {
    }

    /// <summary>
    /// Start graph from a pre-exisitng graph.
    /// </summary>
    /// <param name="graph">Graph to replicate from.</param>
    public TrackedGraph(IReadOnlyGraph<TNode> graph) : base(graph)
    {
    }

    /// <summary>
    /// Start a graph from pre-exisiting dictionaries of nodes and edges.
    /// </summary>
    public TrackedGraph(Dictionary<uint, TNode> nodes, Dictionary<uint, Edge> edges) : base(nodes, edges)
    {
    }

    /// <summary>
    /// Apply multiple modifications at once with BatchedMods.
    /// </summary>
    /// <param name="mods">BatchedMods containing the modifications.</param>
    public override void ApplyBatchedModifications(IReadOnlyBatchedMods<TNode> mods)
    {
        ModificationLog<TNode> log = new(this);

        foreach(TNode node in mods.GetNodeUpserts())
        {
            log.NodeUpsert(node);
            nodes[node.ID] = node;
        }
        
        foreach(Edge edge in mods.GetEdgeUpserts())
        {
            log.EdgeUpsert(edge);
            edges[edge.ID] = edge;
        }

        foreach(uint nodeID in mods.GetNodeRemovalIDs())
        {
            log.NodeRemoval(nodeID);

            //Undo log if operation failed
            if (!nodes.Remove(nodeID))
            {
                log.UnlogNode(nodeID);
            }
        }

        foreach(uint edgeID in mods.GetEdgeRemovalIDs())
        {
            log.EdgeRemoval(edgeID);

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
        if (base.RemoveEdge(ID))
        {
            OnGraphModified?.Invoke(this, log);
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
            OnGraphModified?.Invoke(this, log);
            return true;
        }
        return false;
    }

    public override void UpsertEdge(Edge edge)
    {
        ModificationLog<TNode> log = new(this);
        log.EdgeUpsert(edge);
        base.UpsertEdge(edge);
        OnGraphModified?.Invoke(this, log);
    }

    public override void UpsertNode(TNode Node)
    {
        ModificationLog<TNode> log = new(this);
        log.NodeUpsert(Node);
        base.UpsertNode(Node);
        OnGraphModified?.Invoke(this, log);
    }
}