## SpatialGraph2DOperations\.EdgeLength\(this IReadOnlyGraph\<Node2D\>, uint\) Method

Get length of an edge\.

```csharp
public static float EdgeLength(this SpatialGraph.IReadOnlyGraph<SpatialGraph.Node2D> baseGraph, uint edgeID);
```
#### Parameters

<a name='SpatialGraph.Extentions.SpatialGraph2DOperations.EdgeLength(thisSpatialGraph.IReadOnlyGraph_SpatialGraph.Node2D_,uint).baseGraph'></a>

`baseGraph` [SpatialGraph\.IReadOnlyGraph&lt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[Node2D](SpatialGraph.Node2D.md 'SpatialGraph\.Node2D')[&gt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')

Graph where the edge resides from\.

<a name='SpatialGraph.Extentions.SpatialGraph2DOperations.EdgeLength(thisSpatialGraph.IReadOnlyGraph_SpatialGraph.Node2D_,uint).edgeID'></a>

`edgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the edge get its length\.

#### Returns
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')  
Length of the edge\.