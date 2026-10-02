## SpatialGraph2DOperations\.EdgeLengthSquared(this IReadOnlyGraph<Node2D>, uint) Method

Get the squared length of an edge\.

```csharp
public static float EdgeLengthSquared(this SpatialGraph.IReadOnlyGraph<SpatialGraph.Node2D> baseGraph, uint edgeID);
```
#### Parameters

<a name='SpatialGraph.Extensions.SpatialGraph2DOperations.EdgeLengthSquared(thisSpatialGraph.IReadOnlyGraph_SpatialGraph.Node2D_,uint).baseGraph'></a>

`baseGraph` [SpatialGraph\.IReadOnlyGraph&lt;](../../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')

Graph where the edge resides from\.

<a name='SpatialGraph.Extensions.SpatialGraph2DOperations.EdgeLengthSquared(thisSpatialGraph.IReadOnlyGraph_SpatialGraph.Node2D_,uint).edgeID'></a>

`edgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the edge get its length\.

#### Returns
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')  
Length of the edge\.