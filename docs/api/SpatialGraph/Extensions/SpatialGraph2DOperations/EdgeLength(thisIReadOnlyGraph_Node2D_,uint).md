## SpatialGraph2DOperations\.EdgeLength(this IReadOnlyGraph<Node2D>, uint) Method

Get length of an [Edge](../../Edge/index.md 'SpatialGraph\.Edge')\.

```csharp
public static float EdgeLength(this SpatialGraph.IReadOnlyGraph<SpatialGraph.Node2D> baseGraph, uint edgeID);
```
#### Parameters

<a name='SpatialGraph.Extensions.SpatialGraph2DOperations.EdgeLength(thisSpatialGraph.IReadOnlyGraph_SpatialGraph.Node2D_,uint).baseGraph'></a>

`baseGraph` [SpatialGraph\.IReadOnlyGraph&lt;](../../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')

Graph where the edge resides from\.

<a name='SpatialGraph.Extensions.SpatialGraph2DOperations.EdgeLength(thisSpatialGraph.IReadOnlyGraph_SpatialGraph.Node2D_,uint).edgeID'></a>

`edgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the edge get its length\.

#### Returns
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')  
Length of the edge\.

### See Also
- [EdgeLengthSquared(this IReadOnlyGraph&lt;Node2D&gt;, uint)](EdgeLengthSquared(thisIReadOnlyGraph_Node2D_,uint).md 'SpatialGraph\.Extensions\.SpatialGraph2DOperations\.EdgeLengthSquared(this SpatialGraph\.IReadOnlyGraph<SpatialGraph\.Node2D>, uint)')