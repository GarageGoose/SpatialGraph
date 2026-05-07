namespace GG.NodeGraph.Plugin;

/// <summary>
/// Base class for all plugins.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public abstract class GraphPlugin<TNode> where TNode : struct, INode
{
    public GraphPlugin(GraphExtendable<TNode> graphToConnect, int pluginIndex = -1)
    {
        Graph = graphToConnect;
        GraphPlugins = graphToConnect.GetPlugins();
        CurrentGraph = graphToConnect;
        graphToConnect.AddPlugin(this, pluginIndex);
    }

    protected IReadOnlyGraph<TNode> Graph {get; private set;}
    protected IReadOnlyList<GraphPlugin<TNode>> GraphPlugins {get; private set;}
    private GraphExtendable<TNode> CurrentGraph;

    /// <summary>
    /// Called when the plugin is disconnected from the graph. Do note that it cannot be reconnected again.
    /// </summary>
    protected internal virtual void OnDisconnection(){}

    /// <summary>
    /// Called when the plugin is successfully connected to the graph.
    /// </summary>
    protected internal virtual void OnInitialize(){}

    /// <summary>
    /// Called when a modification will happen to the graph.
    /// </summary>
    protected internal virtual void OnModificationInitialize(){}

    /// <summary>
    /// Called when modifying the graph. The plugin can also contribute here via the ModificationLog.
    /// </summary>
    /// <param name="Log">Stores what will be modified in the graph.</param>
    protected internal virtual void OnModification(ModificationLog<TNode> Log){}

    /// <summary>
    /// Called when the modification is finished and applied.
    /// </summary>
    /// <param name="Log">Stores the modification on the graph. Do note that it cannot be changed since the modifications are applied.</param>
    protected internal virtual void OnModificationFinished(IReadOnlyModificationLog<TNode> Log){}

    /// <summary>
    /// Disconnect the plugin from the graph. It cannot be reversed.
    /// </summary>
    protected void Disconnect() => CurrentGraph.DisconnectPlugin(this);

    /// <summary>
    /// Disconnect a plugin from the graph. It cannot be reversed.
    /// </summary>
    protected void Disconnect(GraphPlugin<TNode> plugin) => CurrentGraph.DisconnectPlugin(plugin);

    /// <summary>
    /// Rearrange the order by which the plugins are called.
    /// </summary>
    /// <param name="oldIndex">Index of the target plugin.</param>
    /// <param name="newIndex">Desired index of the target pluign.</param>
    protected void RearrangePlugin(int oldIndex, int newIndex) => CurrentGraph.RearrangePlugin(oldIndex, newIndex);

    /// <summary>
    /// Modify the graph.
    /// </summary>
    protected void Modify(ModificationAggregator<TNode> Modification) => CurrentGraph.AggregatedModifications(Modification);
}