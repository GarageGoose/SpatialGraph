namespace GG.NodeGraph;

/// <summary>
/// Base class for storing additional metadata in a graph.
/// </summary>
/// <typeparam name="TNode"></typeparam>
public abstract class GraphMetadata<TNode> : IReadOnlyTrackedGraph<TNode> where TNode : struct, INode
{
    IReadOnlyTrackedGraph<TNode> BaseGraph;

    public IReadOnlyDictionary<uint, TNode> Nodes => BaseGraph.Nodes;

    public IReadOnlyDictionary<uint, Edge> Edges => BaseGraph.Edges;

    public GraphMetadata(IReadOnlyTrackedGraph<TNode> baseGraph)
    {
        BaseGraph = baseGraph;
        baseGraph.GraphModified += OnGraphUpdate;
        OnInitialize();
    }

    public event EventHandler<IReadOnlyModificationLog<TNode>>? GraphModified
    {
        add
        {
            BaseGraph.GraphModified += value;
        }

        remove
        {
            BaseGraph.GraphModified -= value;
        }
    }

    protected virtual void OnInitialize() {}
    protected virtual void OnGraphUpdate(object? sender, IReadOnlyModificationLog<TNode> e) {}

    public uint GenerateID()
    {
        return BaseGraph.GenerateID();
    }
}