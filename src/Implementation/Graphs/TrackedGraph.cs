namespace SpatialGraph;

/// <summary>
/// Graph which track changes within it. A graph stores <see cref="INode"/> and <see cref="Edge"/> within it, identified by their IDs.
/// Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public class TrackedGraph<TNode> : Graph<TNode>, ITrackedGraph<TNode> where TNode : struct, INode
{
    /// <inheritdoc/>
    public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphModified;

    /// <summary>
    /// Start an empty graph.
    /// </summary>
    public TrackedGraph() : base()
    {
    }

    /// <summary>
    /// Start graph from a pre-existing graph.
    /// </summary>
    /// <param name="graph">Graph to replicate from.</param>
    public TrackedGraph(IReadOnlyGraph<TNode> graph) : base(graph)
    {
    }

    /// <summary>
    /// Start a graph from pre-existing dictionaries of nodes and edges.
    /// </summary>
    public TrackedGraph(Dictionary<uint, TNode> nodes, Dictionary<uint, Edge> edges) : base(nodes, edges)
    {
    }
    
    /// <inheritdoc/>
    public override void ApplyChangeSet(GraphChangeSet<TNode> mods)
    {
        GraphChangeLog<TNode> log = new(this);

        foreach(TNode node in mods.NodeUpserts())
        {
            log.NodeUpsert(node);
            _Nodes[node.ID] = node;
        }
        
        foreach(Edge edge in mods.EdgeUpserts())
        {
            log.EdgeUpsert(edge);
            _Edges[edge.ID] = edge;
        }

        foreach(uint nodeID in mods.NodeRemovals())
        {
            log.NodeRemoval(nodeID);

            //Undo log if operation failed
            if (!_Nodes.Remove(nodeID))
            {
                log.UnlogNode(nodeID);
            }
        }

        foreach(uint edgeID in mods.EdgeRemovals())
        {
            log.EdgeRemoval(edgeID);

            //Undo log if operation failed
            if (!_Edges.Remove(edgeID))
            {
                log.UnlogEdge(edgeID);
            }
        }

        OnGraphModified?.Invoke(this, log);
    }

    /// <inheritdoc/>
    public override bool RemoveEdge(uint ID)
    {
        GraphChangeLog<TNode> log = new(this);
        log.EdgeRemoval(ID);
        if (base.RemoveEdge(ID))
        {
            OnGraphModified?.Invoke(this, log);
            return true;
        }
        return false;
    }

    /// <inheritdoc/>
    public override bool RemoveNode(uint ID)
    {
        GraphChangeLog<TNode> log = new(this);
        log.NodeRemoval(ID);
        if (base.RemoveNode(ID))
        {
            OnGraphModified?.Invoke(this, log);
            return true;
        }
        return false;
    }

    /// <inheritdoc/>
    public override void UpsertEdge(Edge edge)
    {
        GraphChangeLog<TNode> log = new(this);
        log.EdgeUpsert(edge);
        base.UpsertEdge(edge);
        OnGraphModified?.Invoke(this, log);
    }

    /// <inheritdoc/>
    public override void UpsertNode(TNode Node)
    {
        GraphChangeLog<TNode> log = new(this);
        log.NodeUpsert(Node);
        base.UpsertNode(Node);
        OnGraphModified?.Invoke(this, log);
    }
}