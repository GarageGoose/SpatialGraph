using GG.SpatialGraph.Metadata;

namespace GG.SpatialGraph.Spatial;

public class QuadTree : GraphReadOnlyPlugin<Node2D>
{
    public QuadTree(ITrackedGraph<Node2D> graph) : base(graph)
    {
    }

    protected override void OnGraphUpdate(object? sender, IReadOnlyModificationLog<Node2D> modLog)
    {
        
    }
}