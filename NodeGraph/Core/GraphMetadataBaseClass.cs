namespace GG.NodeGraph;

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