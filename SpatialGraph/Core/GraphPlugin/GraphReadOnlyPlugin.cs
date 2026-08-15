namespace GG.SpatialGraph.Metadata;

/// <summary>
/// Base class for storing additional metadata in a graph.
/// </summary>
/// <typeparam name="TNode"></typeparam>
public abstract class GraphReadOnlyPlugin<TNode> : IReadOnlyTrackedGraph<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Subscribe to baseGraph.OnGraphModified
    /// </summary>
    public GraphReadOnlyPlugin(IReadOnlyTrackedGraph<TNode> baseGraph)
    {
        BaseGraph = baseGraph;
        baseGraph.OnGraphModified += InternalOnGraphUpdate;
    }

    /// <summary>
    /// Subscribe to baseGraph.OnGraphPluginUpdated when in a nested graph plugin
    /// </summary>
    public GraphReadOnlyPlugin(GraphReadOnlyPlugin<TNode> baseGraph)
    {
        BaseGraph = baseGraph;
        baseGraph.OnGraphPluginUpdated += InternalOnGraphUpdate;
    }

    public void Unsubscribe() => BaseGraph.OnGraphModified -= InternalOnGraphUpdate;

    //Called after OnGraphUpdate
    public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphPluginUpdated;

    //Called before OnGraphUpdate
    public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphPluginInit;

    private void InternalOnGraphUpdate(object? sender, IReadOnlyModificationLog<TNode> modLog)
    {
        OnGraphPluginInit?.Invoke(this, modLog);
        OnGraphUpdate(sender, modLog);
        OnGraphPluginUpdated?.Invoke(this, modLog);
    }

    protected abstract void OnGraphUpdate(object? sender, IReadOnlyModificationLog<TNode> modLog);
    
    //BaseGraph stuff
    public readonly IReadOnlyTrackedGraph<TNode> BaseGraph;
    public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphModified
    {
        add
        {
            BaseGraph.OnGraphModified += value;
        }

        remove
        {
            BaseGraph.OnGraphModified -= value;
        }
    }
    public IReadOnlyDictionary<uint, TNode> Nodes => BaseGraph.Nodes;
    public IReadOnlyDictionary<uint, Edge> Edges => BaseGraph.Edges;
    public uint GenerateID() => BaseGraph.GenerateID();
}