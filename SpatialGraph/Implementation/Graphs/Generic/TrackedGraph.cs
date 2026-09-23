namespace GG.SpatialGraph;

/// <summary>
/// Graph which tracked changes within it.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class TrackedGraph<TNode> : Graph<TNode>, ITrackedGraph<TNode> where TNode : struct, INode
{
    public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphModified;

    public TrackedGraph() : base()
    {
    }

    public TrackedGraph(IReadOnlyGraph<TNode> graph) : base(graph)
    {
    }

    public TrackedGraph(Dictionary<uint, TNode> nodes, Dictionary<uint, Edge> edges) : base(nodes, edges)
    {
    }

    public override void ApplyBatchedModifications(IReadOnlyBatchedMods<TNode> mods)
    {
        ModificationLog<TNode> log = new(this);

        foreach(TNode node in mods.GetUpsertedNodes())
        {
            log.NodeUpsert(node);
            nodes[node.ID] = node;
        }
        
        foreach(Edge edge in mods.GetUpsertedEdges())
        {
            log.EdgeUpsert(edge);
            edges[edge.ID] = edge;
        }

        foreach(uint nodeID in mods.GetNodeRemovalID())
        {
            log.NodeRemoval(nodeID);

            //Undo log if operation failed
            if (!nodes.Remove(nodeID))
            {
                log.UnlogNode(nodeID);
            }
        }

        foreach(uint edgeID in mods.GetEdgeRemovalID())
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