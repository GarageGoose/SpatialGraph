## SpatialGraph2DOperations\.EdgeAngleFromNode(this IReadOnlyGraph<Node2D>, uint, uint) Method

Get the angle of an edge (in radians) relative to one of the node connected from it\.

```csharp
public static float EdgeAngleFromNode(this SpatialGraph.IReadOnlyGraph<SpatialGraph.Node2D> baseGraph, uint edgeID, uint nodeID);
```
#### Parameters

<a name='SpatialGraph.Extentions.SpatialGraph2DOperations.EdgeAngleFromNode(thisSpatialGraph.IReadOnlyGraph_SpatialGraph.Node2D_,uint,uint).baseGraph'></a>

`baseGraph` [SpatialGraph\.IReadOnlyGraph&lt;](../../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')

Graph where the edge resides from\.

<a name='SpatialGraph.Extentions.SpatialGraph2DOperations.EdgeAngleFromNode(thisSpatialGraph.IReadOnlyGraph_SpatialGraph.Node2D_,uint,uint).edgeID'></a>

`edgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the edge get its angle\.

<a name='SpatialGraph.Extentions.SpatialGraph2DOperations.EdgeAngleFromNode(thisSpatialGraph.IReadOnlyGraph_SpatialGraph.Node2D_,uint,uint).nodeID'></a>

`nodeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to get the angle of the edge from\.

#### Returns
[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')  
Angle of the edge (in radians) relative to the node\.