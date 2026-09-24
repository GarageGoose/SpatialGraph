namespace GG.SpatialGraph.Metadata;

/// <summary>
/// Base class for storing additional metadata in a graph.
/// </summary>
/// <typeparam name="TNode"></typeparam>
public abstract class GraphPlugin<TNode> : ITrackedGraphInterceptable<TNode> where TNode : struct, INode
{
    /*
    Graph Events:
    OnGraphModificationInit - - Emits before the graph itself is updated. (Write access, only on TrackedGraphInterceptable)
    OnGraphModified - - - - - - Emits when the graph itself is updated.
    OnGraphPluginInit - - - - - Emits before the plugin starts logging changes. (Has write access on GraphPlugin)
    OnGraphPluginUpdated  - - - Emits after the plugin starts logging changes.

    GraphPlugins can only subscribe to OnGraphModificationInit and OnGraphModificationInit
    (from GraphPlugin) as only these these two offer write access to ModificationLog.

    GraphReadOnlyPlugin can subscribe to all 4 of the events above from TrackedGraph, TrackedGraphInterceptable,
    GraphPlugin, and GraphReadOnlyPlugin since it only needs read access from ModificationLog.
    */

    /// <summary>
    /// Listens to the graph when an update occurs.
    /// </summary>
    public GraphPlugin(ITrackedGraphInterceptable<TNode> baseGraph)
    {
        BaseGraph = baseGraph;
        baseGraph.OnGraphModificationInit += InternalOnGraphUpdateInit;
    }

    /// <summary>
    /// Listens to the plugin when an update occurs.
    /// </summary>
    /// <param name="SubscribeTo">Determine which event from the baseGraph to subscribe to.</param>
    public GraphPlugin(GraphPlugin<TNode> baseGraph, GraphPluginSubscription SubscribeTo)
    {
        BaseGraph = baseGraph;
        switch (SubscribeTo)
        {
            case GraphPluginSubscription.OnGraphModificationInit:
                baseGraph.OnGraphModificationInit += InternalOnGraphUpdateInit;
            break;

            case GraphPluginSubscription.OnGraphPluginInit:
                baseGraph.OnGraphPluginInit += InternalOnGraphUpdateInit;
            break;
        }
    }

    /// <summary>
    /// Emits after the plugin starts logging changes.
    /// </summary>
    public event EventHandler<ModificationLog<TNode>>? OnGraphPluginUpdated;

    /// <summary>
    /// Emits before the plugin starts logging changes.
    /// </summary>
    public event EventHandler<ModificationLog<TNode>>? OnGraphPluginInit;

    private void InternalOnGraphUpdateInit(object? sender, ModificationLog<TNode> modLog)
    {
        OnGraphPluginInit?.Invoke(this, modLog);
        OnGraphUpdate(sender, modLog);
        OnGraphPluginUpdated?.Invoke(this, modLog);
    }
    protected abstract void OnGraphUpdate(object? sender, ModificationLog<TNode> modLog);

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
    public uint AddEdge(uint NodeID1, uint NodeID2)
    {
        uint EdgeID = BaseGraph.GenerateID();
        UpsertEdge(new(EdgeID, NodeID1, NodeID2));
        return EdgeID;
    }
    public void UpsertNode(TNode Node) => BaseGraph.UpsertNode(Node);
    public IReadOnlyDictionary<uint, TNode> Nodes => BaseGraph.Nodes;
    public IReadOnlyDictionary<uint, Edge> Edges => BaseGraph.Edges;
}

public enum GraphPluginSubscription
{
    OnGraphModificationInit, OnGraphPluginInit
}