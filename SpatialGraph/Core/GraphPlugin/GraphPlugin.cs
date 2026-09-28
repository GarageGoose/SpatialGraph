namespace GG.SpatialGraph.Metadata;

/// <summary>
/// Base class for storing additional metadata in a graph.
/// </summary>
/// <typeparam name="TNode"></typeparam>
public abstract class GraphPlugin<TNode> : IInterceptableTrackedGraph<TNode> where TNode : struct, INode
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
    /// Listens to the graph when an update occurs.
    /// </summary>
    public GraphPlugin(IInterceptableTrackedGraph<TNode> baseGraph)
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
    protected abstract void OnGraphUpdate(object? sender, GraphChangeLog<TNode> modLog);

    //BaseGraph stuff
    IInterceptableTrackedGraph<TNode> BaseGraph;

    /// <summary>
    /// Event for incoming changes. Modifications can be changed before being applied to the graph.
    /// </summary>
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
    /// Perform multiple operations at once.
    /// </summary>
    /// <param name="modifications">Contains operations to perform.</param>
    public void ApplyChangeSet(GraphChangeSet<TNode> modifications) => BaseGraph.ApplyChangeSet(modifications);

    /// <summary>
    /// Generate unique IDs for the elements of the graph.
    /// </summary>
    public uint GenerateID() => BaseGraph.GenerateID();

    /// <summary>
    /// Remove an edge in the graph using its corresponding ID.
    /// </summary>
    /// <param name="ID">ID of the edge to be removed.</param>
    /// <returns>If the edge is removed.</returns>
    public bool RemoveEdge(uint ID) => BaseGraph.RemoveEdge(ID);

    /// <summary>
    /// Remove a node in the graph using their correspinding IDs.
    /// </summary>
    /// <param name="ID">ID of the node to be removed.</param>
    /// <returns>If the node is removed.</returns>
    public bool RemoveNode(uint ID) => BaseGraph.RemoveNode(ID);

    /// <summary>
    /// Add or modify an edge with its corresponding ID.
    /// </summary>
    /// <param name="edge">Edge to upsert.</param>
    public void UpsertEdge(Edge edge) => BaseGraph.UpsertEdge(edge);

    /// <summary>
    /// Add or modify a node with their corresponding ID.
    /// </summary>
    /// <param name="Node">Node to upsert.</param>
    public void UpsertNode(TNode Node) => BaseGraph.UpsertNode(Node);

    /// <summary>
    /// Nodes stored in this graph. Elements such as nodes are referenced be their unique IDs.
    /// </summary>
    public IReadOnlyDictionary<uint, TNode> Nodes => BaseGraph.Nodes;

    /// <summary>
    /// Edges stored in this graph. Elements such as edges are referenced be their unique IDs.
    /// </summary>
    public IReadOnlyDictionary<uint, Edge> Edges => BaseGraph.Edges;
}

/// <summary>
/// Determines an event to subscribe to from a GraphPlugin in a GraphPlugin.
/// </summary>
public enum GraphPluginSubscription
{
    OnGraphModificationInit, OnGraphPluginInit
}