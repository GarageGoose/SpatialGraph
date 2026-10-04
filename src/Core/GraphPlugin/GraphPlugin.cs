namespace SpatialGraph.Metadata;

/// <summary>
/// Base class for plugins which can observe and modify changes either in <see cref="IInterceptableObservableGraph{TNode}"/> or another <see cref="GraphPlugin{TNode}"/>.
/// </summary>
/// <typeparam name="TNode">Type of node used in the base graph.</typeparam>
/// <seealso cref="GraphReadOnlyPlugin{TNode}"/>
public abstract class GraphPlugin<TNode> : IInterceptableObservableGraph<TNode> where TNode : struct, INode
{
    /*
    Graph Events:
    OnGraphModificationInit - - Emits before the graph itself is updated. (Write access, only on TrackedGraphInterceptable)
    OnGraphModified - - - - - - Emits when the graph itself is updated.
    OnGraphPluginInit - - - - - Emits before the plugin starts logging changes. (Has write access on GraphPlugin)
    OnGraphPluginUpdated  - - - Emits after the plugin starts logging changes.

    GraphPlugins can only subscribe to OnGraphModificationInit and OnGraphModificationInit
    (from GraphPlugin) as only these two offer write access to ModificationLog.

    GraphReadOnlyPlugin can subscribe to all 4 of the events above from TrackedGraph, TrackedGraphInterceptable,
    GraphPlugin, and GraphReadOnlyPlugin since it only needs read access from ModificationLog.
    */

    /// <summary>
    /// Listens to a graph when an update occurs.
    /// An update is invoked when the base graph is modified by adding, modifying, and removing any of its elements.
    /// </summary>
    public GraphPlugin(IInterceptableObservableGraph<TNode> baseGraph)
    {
        BaseGraph = baseGraph;
        baseGraph.OnGraphModificationInit += InternalOnGraphUpdateInit;
    }

    /// <summary>
    /// Listens to the plugin when an update occurs.
    /// An update is invoked when the base graph is modified by adding, modifying, and removing any of its elements.
    /// </summary>
    /// <param name="SubscribeTo">Determine which event from the baseGraph to subscribe to.</param>
    /// <param name="baseGraph">Plugin to subscribe to.</param>
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
    public event EventHandler<GraphChangeLog<TNode>>? OnGraphPluginUpdated;

    /// <summary>
    /// Emits before the plugin starts logging changes.
    /// </summary>
    public event EventHandler<GraphChangeLog<TNode>>? OnGraphPluginInit;

    private void InternalOnGraphUpdateInit(object? sender, GraphChangeLog<TNode> modLog)
    {
        OnGraphPluginInit?.Invoke(this, modLog);
        OnGraphUpdate(sender, modLog);
        OnGraphPluginUpdated?.Invoke(this, modLog);
    }

    /// <summary>
    /// Emits when a modification occurs in the base graph.
    /// </summary>
    /// <param name="sender">Source of the event.</param>
    /// <param name="modLog">Log of changes for the base graph.</param>
    protected abstract void OnGraphUpdate(object? sender, GraphChangeLog<TNode> modLog);

    //BaseGraph stuff
    IInterceptableObservableGraph<TNode> BaseGraph;

    /// <inheritdoc/>
    public event EventHandler<GraphChangeLog<TNode>>? OnGraphModificationInit
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

    /// <inheritdoc/>
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

    /// <inheritdoc/>
    public void ApplyChangeSet(GraphChangeSet<TNode> modifications) => BaseGraph.ApplyChangeSet(modifications);

    /// <inheritdoc/>
    public uint GenerateID() => BaseGraph.GenerateID();

    /// <inheritdoc/>
    public bool RemoveEdge(uint ID) => BaseGraph.RemoveEdge(ID);

    /// <inheritdoc/>
    public bool RemoveNode(uint ID) => BaseGraph.RemoveNode(ID);

    /// <inheritdoc/>
    public void UpsertEdge(Edge edge) => BaseGraph.UpsertEdge(edge);

    /// <inheritdoc/>
    public void UpsertNode(TNode Node) => BaseGraph.UpsertNode(Node);

    /// <inheritdoc/>
    public IReadOnlyDictionary<uint, TNode> Nodes => BaseGraph.Nodes;

    /// <inheritdoc/>
    public IReadOnlyDictionary<uint, Edge> Edges => BaseGraph.Edges;
}

/// <summary>
/// Determines an event to subscribe to from a <see cref="GraphPlugin{TNode}"/> in a <see cref="GraphPlugin{TNode}"/>.
/// </summary>
public enum GraphPluginSubscription
{
    /// <summary>
    /// Points to an event within a <see cref="GraphPlugin{TNode}"/> which is invoked when a plugin receives a <see cref="GraphChangeLog{TNode}"/> before it processes the update.
    /// </summary>
    OnGraphModificationInit,
    
    /// <summary>
    /// Points to an event within a <see cref="GraphPlugin{TNode}"/> which is invoked after the plugin processes the update.
    /// </summary>
    OnGraphPluginInit
}