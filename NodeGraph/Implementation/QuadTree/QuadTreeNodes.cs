namespace GG.NodeGraph.Implementation;

public class QuadTreeNodes : GraphMetadata<Node2D>
{

    public QuadTreeNodes(IReadOnlyTrackedGraph<Node2D> baseGraph, float InitSize) : base(baseGraph){}

    protected override void OnInitialize()
    {
        
    }

    protected override void OnGraphUpdate(object? sender, IReadOnlyModificationLog<Node2D> e)
    {
        base.OnGraphUpdate(sender, e);
    }

    public uint GenerateID()
    {
        throw new NotImplementedException();
    }
}