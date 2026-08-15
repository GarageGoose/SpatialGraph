namespace GG.SpatialGraph.Metadata;

/// <summary>
/// Base class for storing additional metadata in a graph.
/// </summary>
/// <typeparam name="TNode"></typeparam>
public abstract class GraphPlugin<TNode> : ITrackedGraphInterceptable<TNode> where TNode : struct, INode
{
    public GraphPlugin(ITrackedGraphInterceptable<TNode> baseGraph)
    {
        BaseGraph = baseGraph;
        baseGraph.OnGraphModificationInit += InternalOnGraphUpdateInit;
    }

    public GraphPlugin(GraphPlugin<TNode> baseGraph)
    {
        BaseGraph = baseGraph;
        baseGraph.OnGraphPluginUpdated += InternalOnGraphUpdateInit;
    }

    //Called after OnGraphUpdate
    public event EventHandler<ModificationLog<TNode>>? OnGraphPluginUpdated;

    //Called before OnGraphUpdate
    public event EventHandler<ModificationLog<TNode>>? OnGraphPluginInit;

    private void InternalOnGraphUpdateInit(object? sender, ModificationLog<TNode> modLog)
    {
        OnGraphPluginInit?.Invoke(this, modLog);
        OnGraphUpdate(sender, modLog);
        OnGraphPluginUpdated?.Invoke(this, modLog);
    }
    protected abstract void OnGraphUpdate(object? sender, IReadOnlyModificationLog<TNode> modLog);

    //BaseGraph stuff
    public readonly ITrackedGraphInterceptable<TNode> BaseGraph;
    public event EventHandler<ModificationLog<TNode>>? OnGraphModificationInit
    {
        add
        {
            BaseGraph.OnGraphModificationInit += value;
        }
        remove
        {
            BaseGraph.OnGraphModificationInit -= value;
        }
    }
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
    public void ApplyBatchedModifications(IReadOnlyBatchedMods<TNode> modifications) => BaseGraph.ApplyBatchedModifications(modifications);
    public uint GenerateID() => BaseGraph.GenerateID();
    public bool RemoveEdge(uint ID) => BaseGraph.RemoveEdge(ID);
    public bool RemoveNode(uint ID) => BaseGraph.RemoveNode(ID);
    public void UpsertEdge(Edge edge) => BaseGraph.UpsertEdge(edge);
    public void UpsertNode(TNode Node) => BaseGraph.UpsertNode(Node);
    public IReadOnlyDictionary<uint, TNode> Nodes => BaseGraph.Nodes;
    public IReadOnlyDictionary<uint, Edge> Edges => BaseGraph.Edges;
}