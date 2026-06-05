namespace GG.NodeGraph;

/// <summary>
/// Base class for storing additional metadata in a graph.
/// </summary>
/// <typeparam name="TNode"></typeparam>
public abstract class GraphMetadata<TNode> where TNode : struct, INode
{
    public IReadOnlyTrackedGraph<TNode> BaseGraph {get; private set;}

    public GraphMetadata(IReadOnlyTrackedGraph<TNode> baseGraph)
    {
        BaseGraph = baseGraph;
        baseGraph.GraphModified += OnGraphUpdate;
        OnInitialize();
    }

    protected virtual void OnInitialize() {}
    protected virtual void OnGraphUpdate(object? sender, IReadOnlyModificationLog<TNode> e) {}
}