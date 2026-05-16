namespace GG.NodeGraph;

/// <summary>
/// Base class for all plugins.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public abstract class GraphPlugin<TNode> where TNode : struct, INode
{
    public GraphPlugin(GraphExtendable<TNode> graphToConnect, int pluginIndex = -1)
    {
        BaseGraph = graphToConnect;
        graphToConnect.AddPlugin(this, pluginIndex);
    }
    protected GraphExtendable<TNode> BaseGraph;

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
    protected internal virtual void OnModificationApplied(IReadOnlyModificationLog<TNode> Log){}
}