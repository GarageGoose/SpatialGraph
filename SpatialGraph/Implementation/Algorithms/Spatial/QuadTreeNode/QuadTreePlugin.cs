using GG.SpatialGraph.Metadata;

namespace GG.SpatialGraph.Spatial;

public class QuadTreeNodes : GraphReadOnlyPlugin<Node2D>
{
    public QuadTreeNodes(ITrackedGraph<Node2D> graph) : base(graph)
    {
    }

    protected override void OnGraphUpdate(object? sender, IReadOnlyModificationLog<Node2D> modLog)
    {
        
    }
}