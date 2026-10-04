## Graph2DOperations\.InsertNode(this IGraph<Node2D>, uint, Node2D) Method

Insert a new [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') in between an [Edge](../../Edge/index.md 'SpatialGraph\.Edge')\.

```csharp
public static void InsertNode(this SpatialGraph.IGraph<SpatialGraph.Node2D> baseGraph, uint edgeID, SpatialGraph.Node2D newNode);
```
#### Parameters

<a name='SpatialGraph.Extensions.Graph2DOperations.InsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,SpatialGraph.Node2D).baseGraph'></a>

`baseGraph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

Graph to perform the operation\.

<a name='SpatialGraph.Extensions.Graph2DOperations.InsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,SpatialGraph.Node2D).edgeID'></a>

`edgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of target edge\.

<a name='SpatialGraph.Extensions.Graph2DOperations.InsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,SpatialGraph.Node2D).newNode'></a>

`newNode` [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')

Node to insert\.