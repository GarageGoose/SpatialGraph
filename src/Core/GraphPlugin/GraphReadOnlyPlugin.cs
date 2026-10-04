namespace SpatialGraph.Metadata;

/// <summary>
/// Base class for plugins which can observe changes either in <see cref="IReadOnlyObservableGraph{TNode}"/> or another plugin.
/// </summary>
/// <typeparam name="TNode">Type of node used in the base graph.</typeparam>
/// <seealso cref="GraphPlugin{TNode}"/>
public abstract class GraphReadOnlyPlugin<TNode> : IReadOnlyObservableGraph<TNode> where TNode : struct, INode
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
    /// Listens to a TrackedGraph when an update occurs. An update is invoked when the base graph is modified by adding, modifying, and removing any of its elements.
    /// </summary>
    public GraphReadOnlyPlugin(IReadOnlyObservableGraph<TNode> baseGraph)
    {
        BaseGraph = baseGraph;
        baseGraph.OnGraphModified += InternalOnGraphUpdate;
    }

    /// <summary>
    /// Listens to a <see cref="IInterceptableObservableGraph{TNode}"/> when an update occurs.
    /// </summary>
    /// <param name="SubscribeTo">Determine which event from the TrackedGraphInterceptable to subscribe to.</param>
    /// <param name="baseGraph">Graph to subscribe to.</param>
    public GraphReadOnlyPlugin(IInterceptableObservableGraph<TNode> baseGraph, ReadOnlyGraphPluginListenerForTrackedGraph SubscribeTo)
    {
        BaseGraph = baseGraph;
        switch (SubscribeTo)
        {
            case ReadOnlyGraphPluginListenerForTrackedGraph.OnGraphModified:
                baseGraph.OnGraphModified += InternalOnGraphUpdate;
            break;

            case ReadOnlyGraphPluginListenerForTrackedGraph.OnGraphModificationInit:
                baseGraph.OnGraphModificationInit += InternalOnGraphUpdate;
            break;
        }
    }

    /// <summary>
    /// Listens to a <see cref="GraphReadOnlyPlugin{TNode}"/> when an update occurs.
    /// </summary>
    /// <param name="SubscribeTo">Determine which event from the baseGraph to subscribe to.</param>
    /// /// <param name="baseGraph">Plugin to subscribe to.</param>
    public GraphReadOnlyPlugin(GraphReadOnlyPlugin<TNode> baseGraph, ReadOnlyGraphPluginListenerForPlugin SubscribeTo)
    {
        BaseGraph = baseGraph;
        switch (SubscribeTo)
        {
            case ReadOnlyGraphPluginListenerForPlugin.OnGraphPluginInit:
                baseGraph.OnGraphPluginInit += InternalOnGraphUpdate;
            break;

            case ReadOnlyGraphPluginListenerForPlugin.OnGraphPluginUpdated:
                baseGraph.OnGraphPluginUpdated += InternalOnGraphUpdate;
            break;
        }
    }

    /// <summary>
    /// Listens to a <see cref="GraphPlugin{TNode}"/> when an update occurs.
    /// </summary>
    /// <param name="SubscribeTo">Determine which event from the baseGraph to subscribe to.</param>
    /// /// <param name="baseGraph">Plugin to subscribe to.</param>
    public GraphReadOnlyPlugin(GraphPlugin<TNode> baseGraph, ReadOnlyGraphPluginListenerForPlugin SubscribeTo)
    {
        BaseGraph = baseGraph;
        switch (SubscribeTo)
        {
            case ReadOnlyGraphPluginListenerForPlugin.OnGraphPluginInit:
                baseGraph.OnGraphPluginInit += InternalOnGraphUpdate;
            break;

            case ReadOnlyGraphPluginListenerForPlugin.OnGraphPluginUpdated:
                baseGraph.OnGraphPluginUpdated += InternalOnGraphUpdate;
            break;
        }
    }

    /// <summary>
    /// Emits before the plugin starts logging changes.
    /// </summary>
    public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphPluginUpdated;

    /// <summary>
    /// Emits after the plugin starts logging changes.
    /// </summary>
    public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphPluginInit;

    private void InternalOnGraphUpdate(object? sender, IReadOnlyModificationLog<TNode> modLog)
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
    protected abstract void OnGraphUpdate(object? sender, IReadOnlyModificationLog<TNode> modLog);
    


    //BaseGraph stuff
    IReadOnlyObservableGraph<TNode> BaseGraph;

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
    public IReadOnlyDictionary<uint, TNode> Nodes => BaseGraph.Nodes;

    /// <inheritdoc/>
    public IReadOnlyDictionary<uint, Edge> Edges => BaseGraph.Edges;

    /// <inheritdoc/>
    public uint GenerateID() => BaseGraph.GenerateID();
}

/// <summary>
/// Determines an event to subscribe to from a <see cref="IObservableGraph{TNode}"/> in a <see cref="GraphReadOnlyPlugin{TNode}"/>.
/// </summary>
public enum ReadOnlyGraphPluginListenerForTrackedGraph
{
    /// <summary>
    /// Points to an event within a <see cref="IObservableGraph{TNode}"/> which is invoked after it is modified.
    /// </summary>
    OnGraphModified,
    
    /// <summary>
    /// Points to an event within a <see cref="IObservableGraph{TNode}"/> which is invoked before it is modified.
    /// </summary>
    OnGraphModificationInit
}

/// <summary>
/// Determines an event to subscribe to from a Plugin (<see cref="GraphPlugin{TNode}"/>/<see cref="GraphReadOnlyPlugin{TNode}"/>) in a <see cref="GraphReadOnlyPlugin{TNode}"/>.
/// </summary>
public enum ReadOnlyGraphPluginListenerForPlugin
{
    /// <summary>
    /// Points to an event within a plugin which is invoked before the plugin processes the update.
    /// </summary>
    OnGraphPluginInit,
    
    /// <summary>
    /// Points to an event within a plugin which is invoked after the plugin processes the update.
    /// </summary>
    OnGraphPluginUpdated
}