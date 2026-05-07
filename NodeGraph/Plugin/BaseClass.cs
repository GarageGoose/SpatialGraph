namespace GG.NodeGraph.Plugin;

/// <summary>
/// Base class for all plugins.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public abstract class GraphPlugin<TNode> where TNode : struct, Node
{
    public GraphPlugin(GraphExtendable<TNode> graphToConnect, int pluginIndex = -1)
    {
        Graph = graphToConnect;
        GraphPlugins = graphToConnect.Plugins;
        CurrentGraph = graphToConnect;
        graphToConnect.plugins.Add(this);
    }

    protected IReadOnlyGraph<TNode> Graph {get; private set;}
    protected IReadOnlyList<GraphPlugin<TNode>> GraphPlugins {get; private set;}
    private GraphExtendable<TNode> CurrentGraph;

    protected internal virtual void OnDisconnection(){}
    protected internal virtual void OnInitialize(){}
    protected internal virtual void OnModificationInitialize(){}
    protected internal virtual void OnModification(ModificationLog<TNode> Log){}
    protected internal virtual void OnModificationFinished(IReadOnlyModificationLog<TNode> Log){}

    protected void Disconnect() => CurrentGraph.DisconnectPlugin(this);
    protected void Disconnect(GraphPlugin<TNode> plugin) => CurrentGraph.DisconnectPlugin(plugin);
    protected void RearrangePlugin(int oldIndex, int newIndex) => CurrentGraph.RearrangePlugin(oldIndex, newIndex);
    protected void Modify(ModificationAggregator<TNode> Modification) => CurrentGraph.ModificationInitiatePlugin(Modification);
}