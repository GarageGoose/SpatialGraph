namespace GG.SpatialGraph.Metadata;

/// <summary>
/// Base class for storing additional metadata in a graph.
/// </summary>
/// <typeparam name="TNode"></typeparam>
public abstract class GraphReadOnlyPlugin<TNode> : IReadOnlyTrackedGraph<TNode> where TNode : struct, INode
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
    /// Listens to a TrackedGraph when an update occurs.
    /// </summary>
    public GraphReadOnlyPlugin(IReadOnlyTrackedGraph<TNode> baseGraph)
    {
        BaseGraph = baseGraph;
        baseGraph.OnGraphModified += InternalOnGraphUpdate;
    }

    /// <summary>
    /// Listens to a TrackedGraphInterceptable when an update occurs.
    /// </summary>
    /// <param name="SubscribeTo">Determine which event from the TrackedGraphInterceptable to subscribe to.</param>
    public GraphReadOnlyPlugin(IInterceptableTrackedGraph<TNode> baseGraph, ReadOnlyGraphPluginListenerForTrackedGraph SubscribeTo)
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
    /// Listens to a GraphReadOnlyPlugin when an update occurs.
    /// </summary>
    /// <param name="SubscribeTo">Determine which event from the baseGraph to subscribe to.</param>
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
    /// Listens to a GraphPlugin when an update occurs.
    /// </summary>
    /// <param name="SubscribeTo">Determine which event from the baseGraph to subscribe to.</param>
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

    protected abstract void OnGraphUpdate(object? sender, IReadOnlyModificationLog<TNode> modLog);
    


    //BaseGraph stuff
    IReadOnlyTrackedGraph<TNode> BaseGraph;

    /// <summary>
    /// Event for changes applied. Invokes after the graph is modified.
    /// </summary>
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
    
    /// <summary>
    /// Nodes stored in this graph. Elements such as nodes are referenced be their unique IDs.
    /// </summary>
    public IReadOnlyDictionary<uint, TNode> Nodes => BaseGraph.Nodes;

    /// <summary>
    /// Edges stored in this graph. Elements such as edges are referenced be their unique IDs.
    /// </summary>
    public IReadOnlyDictionary<uint, Edge> Edges => BaseGraph.Edges;

    /// <summary>
    /// Generate unique IDs for the elements of the graph.
    /// </summary>
    public uint GenerateID() => BaseGraph.GenerateID();
}

/// <summary>
/// Determines an event to subscribe to from a TrackedGraph in a GraphReadOnlyPlugin.
/// </summary>
public enum ReadOnlyGraphPluginListenerForTrackedGraph
{
    OnGraphModified, OnGraphModificationInit
}

/// <summary>
/// Determines an event to subscribe to from a Plugin (GraphPlugin/GraphReadOnlyPlugin) in a GraphReadOnlyPlugin.
/// </summary>
public enum ReadOnlyGraphPluginListenerForPlugin
{
    OnGraphPluginInit, OnGraphPluginUpdated
}