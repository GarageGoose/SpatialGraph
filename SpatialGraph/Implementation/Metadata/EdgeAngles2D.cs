namespace GG.SpatialGraph.Metadata;

public class EdgeAngles2D : GraphReadOnlyPlugin<Node2D>
{
    public EdgeAngles2D(NodeAdjacency<Node2D> baseGraph) : base(baseGraph)
    {
        
    }

    protected override void OnGraphUpdate(object? sender, IReadOnlyModificationLog<Node2D> modLog)
    {
        throw new NotImplementedException();
    }
}