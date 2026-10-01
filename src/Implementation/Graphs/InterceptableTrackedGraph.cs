namespace SpatialGraph;

/// <summary>
/// Graph which tracks and can modifiy incoming changes within it.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public class InterceptableTrackedGraph<TNode> : Graph<TNode>, IInterceptableTrackedGraph<TNode> where TNode : struct, INode
{
    /// <inheritdoc/>
    public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphModified;

    /// <inheritdoc/>
    public event EventHandler<GraphChangeLog<TNode>>? OnGraphModificationInit;

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

    /// <inheritdoc/>
    public override void ApplyChangeSet(GraphChangeSet<TNode> mods) => applyBatchedModifications(new(this, mods));

    private void applyBatchedModifications(GraphChangeLog<TNode> log)
    {
        OnGraphModificationInit?.Invoke(this, log);
        
        foreach(TNode node in log.NodeUpserts())
        {
            nodes[node.ID] = node;
        }
        
        foreach(Edge edge in log.EdgeUpserts())
        {
            edges[edge.ID] = edge;
        }

        foreach(uint nodeID in log.NodeRemovals())
        {
            //Undo log if operation failed
            if (!nodes.Remove(nodeID))
            {
                log.UnlogNode(nodeID);
            }
        }

        foreach(uint edgeID in log.EdgeRemovals())
        {
            //Undo log if operation failed
            if (!edges.Remove(edgeID))
            {
                log.UnlogEdge(edgeID);
            }
        }

        OnGraphModified?.Invoke(this, log);
    }

    /// <inheritdoc/>
    public override bool RemoveEdge(uint ID)
    {
        bool IsEdgeRemoved = edges.ContainsKey(ID);
        GraphChangeLog<TNode> log = new(this);
        log.EdgeRemoval(ID);
        ApplyChangeSet(log);
        return IsEdgeRemoved == true ? edges.ContainsKey(ID) ? false : true : false; 
    }

    /// <inheritdoc/>
    public override bool RemoveNode(uint ID)
    {
        bool IsNodeRemoved = edges.ContainsKey(ID);
        GraphChangeLog<TNode> log = new(this);
        log.NodeRemoval(ID);
        ApplyChangeSet(log);
        return IsNodeRemoved == true ? edges.ContainsKey(ID) ? false : true : false; 
    }

    /// <inheritdoc/>
    public override void UpsertEdge(Edge edge)
    {
        GraphChangeLog<TNode> log = new(this);
        log.EdgeUpsert(edge);
        ApplyChangeSet(log);
    }

    /// <inheritdoc/>
    public override void UpsertNode(TNode Node)
    {
        GraphChangeLog<TNode> log = new(this);
        log.NodeUpsert(Node);
        ApplyChangeSet(log);
    }
}