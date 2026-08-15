namespace GG.SpatialGraph.Metadata;

public class EdgeAngles2D : GraphMetadata<Node2D>
{
    NodeAdjacency<Node2D> baseGraph;
    public EdgeAngles2D(NodeAdjacency<Node2D> baseGraph) : base(baseGraph)
    {
        this.baseGraph = baseGraph;
        baseGraph.GraphModified += GraphModified;
    }

    private void GraphModified(object? sender, IReadOnlyModificationLog<Node2D> e)
    {
        
    }
}