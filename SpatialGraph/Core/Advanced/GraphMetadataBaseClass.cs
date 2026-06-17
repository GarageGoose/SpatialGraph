namespace GG.SpatialGraph.Metadata;

/// <summary>
/// Base class for storing additional metadata in a graph.
/// </summary>
/// <typeparam name="TNode"></typeparam>
public abstract class GraphMetadata<TNode> : IReadOnlyTrackedGraph<TNode> where TNode : struct, INode
{
    //BaseGraph stuff
    IReadOnlyTrackedGraph<TNode> BaseGraph;
    public IReadOnlyDictionary<uint, TNode> Nodes => BaseGraph.Nodes;
    public IReadOnlyDictionary<uint, Edge> Edges => BaseGraph.Edges;
    public uint GenerateID() => BaseGraph.GenerateID();

    public GraphMetadata(IReadOnlyTrackedGraph<TNode> baseGraph)
    {
        BaseGraph = baseGraph;
        baseGraph.GraphModified += internalOnGraphUpdate;
    }
    
    /// <summary>
    /// Contains information about the changes in the BaseGraph. Invokes when the graph changes after the metadata is modified. Note that event this is separate from BaseGraph.GraphModified.
    /// </summary>
    public event EventHandler<IReadOnlyModificationLog<TNode>>? GraphModified
    {
        add
        {
            MetadataUpdated += value;
        }

        remove
        {
            MetadataUpdated -= value;
        }
    }
    event EventHandler<IReadOnlyModificationLog<TNode>>? MetadataUpdated;

    /// <summary>
    /// Contains information about the changes in the BaseGraph. Invokes when the graph changes before the metadata is modified. Note that this event is separate from BaseGraph.GraphModified.
    /// </summary>
    public event EventHandler<IReadOnlyModificationLog<TNode>>? BaseGraphModified
    {
        add
        {
            MetadataUpdateInit += value;
        }

        remove
        {
            MetadataUpdateInit -= value;
        }
    }
    public event EventHandler<IReadOnlyModificationLog<TNode>>? MetadataUpdateInit;

    void internalOnGraphUpdate(object? sender, IReadOnlyModificationLog<TNode> e)
    {
        MetadataUpdateInit?.Invoke(this, e);
        OnGraphUpdate(e);
        MetadataUpdated?.Invoke(this, e);
    }
    protected virtual void OnGraphUpdate(IReadOnlyModificationLog<TNode> modLog) {}
}