## OrderedEdgesByAngle2D Class

Records the order and adjacency of edges in a node including the angles between them\.

```csharp
public class OrderedEdgesByAngle2D : SpatialGraph.Metadata.GraphReadOnlyPlugin<SpatialGraph.Node2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [SpatialGraph\.Metadata\.GraphReadOnlyPlugin&lt;](../GraphReadOnlyPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../GraphReadOnlyPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>') → OrderedEdgesByAngle2D

| Constructors | |
| :--- | :--- |
| [OrderedEdgesByAngle2D(IReadOnlyObservableGraph&lt;Node2D&gt;)](OrderedEdgesByAngle2D(IReadOnlyObservableGraph_Node2D_).md 'SpatialGraph\.Metadata\.OrderedEdgesByAngle2D\.OrderedEdgesByAngle2D(SpatialGraph\.IReadOnlyObservableGraph<SpatialGraph\.Node2D>)') | Records the order and adjacency of edges in a node including the angles between them in a graph\. |

| Methods | |
| :--- | :--- |
| [AngleBetweenNextEdge(uint, uint)](AngleBetweenNextEdge(uint,uint).md 'SpatialGraph\.Metadata\.OrderedEdgesByAngle2D\.AngleBetweenNextEdge(uint, uint)') | Get the angle in rads between the target edge and the next adjacent edge in a node\. |
| [AngleBetweenPreviousEdge(uint, uint)](AngleBetweenPreviousEdge(uint,uint).md 'SpatialGraph\.Metadata\.OrderedEdgesByAngle2D\.AngleBetweenPreviousEdge(uint, uint)') | Get the angle in rads between the target edge and the previous adjacent edge in a node\. |
| [EdgesAnglesOnNode(uint)](EdgesAnglesOnNode(uint).md 'SpatialGraph\.Metadata\.OrderedEdgesByAngle2D\.EdgesAnglesOnNode(uint)') | Returns a dictionary of connected edges from a node with its angle relative to the node\. Keyed by ID, returns node in radians\. |
| [NextEdgeFromEdge(uint, uint)](NextEdgeFromEdge(uint,uint).md 'SpatialGraph\.Metadata\.OrderedEdgesByAngle2D\.NextEdgeFromEdge(uint, uint)') | Get the next adjacent edge from a specified edge\. |
| [PreviousEdgeFromEdge(uint, uint)](PreviousEdgeFromEdge(uint,uint).md 'SpatialGraph\.Metadata\.OrderedEdgesByAngle2D\.PreviousEdgeFromEdge(uint, uint)') | Get the previous adjacent edge from a specified edge\. |
