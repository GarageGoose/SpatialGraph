## OrderedEdgesByAngle2D Class

Records the order and adjacency of edges in a node including the angles between them\.

```csharp
public class OrderedEdgesByAngle2D : SpatialGraph.Metadata.GraphReadOnlyPlugin<SpatialGraph.Node2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [SpatialGraph\.Metadata\.GraphReadOnlyPlugin&lt;](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>')[Node2D](SpatialGraph.Node2D.md 'SpatialGraph\.Node2D')[&gt;](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>') → OrderedEdgesByAngle2D

| Constructors | |
| :--- | :--- |
| [OrderedEdgesByAngle2D\(IReadOnlyTrackedGraph&lt;Node2D&gt;\)](SpatialGraph.Metadata.OrderedEdgesByAngle2D.OrderedEdgesByAngle2D(SpatialGraph.IReadOnlyTrackedGraph_SpatialGraph.Node2D_).md 'SpatialGraph\.Metadata\.OrderedEdgesByAngle2D\.OrderedEdgesByAngle2D\(SpatialGraph\.IReadOnlyTrackedGraph\<SpatialGraph\.Node2D\>\)') | Records the order and adjacency of edges in a node including the angles between them in a graph\. |

| Methods | |
| :--- | :--- |
| [AngleBetweenNextEdge\(uint, uint\)](SpatialGraph.Metadata.OrderedEdgesByAngle2D.AngleBetweenNextEdge(uint,uint).md 'SpatialGraph\.Metadata\.OrderedEdgesByAngle2D\.AngleBetweenNextEdge\(uint, uint\)') | Get the angle in rads between the target edge and the next adjacent edge in a node\. |
| [AngleBetweenPreviousEdge\(uint, uint\)](SpatialGraph.Metadata.OrderedEdgesByAngle2D.AngleBetweenPreviousEdge(uint,uint).md 'SpatialGraph\.Metadata\.OrderedEdgesByAngle2D\.AngleBetweenPreviousEdge\(uint, uint\)') | Get the angle in rads between the target edge and the previous adjacent edge in a node\. |
| [NextEdgeFromEdge\(uint, uint\)](SpatialGraph.Metadata.OrderedEdgesByAngle2D.NextEdgeFromEdge(uint,uint).md 'SpatialGraph\.Metadata\.OrderedEdgesByAngle2D\.NextEdgeFromEdge\(uint, uint\)') | Get the next adjacent edge from a specified edge\. |
| [PreviousEdgeFromEdge\(uint, uint\)](SpatialGraph.Metadata.OrderedEdgesByAngle2D.PreviousEdgeFromEdge(uint,uint).md 'SpatialGraph\.Metadata\.OrderedEdgesByAngle2D\.PreviousEdgeFromEdge\(uint, uint\)') | Get the previous adjacent edge from a specified edge\. |
