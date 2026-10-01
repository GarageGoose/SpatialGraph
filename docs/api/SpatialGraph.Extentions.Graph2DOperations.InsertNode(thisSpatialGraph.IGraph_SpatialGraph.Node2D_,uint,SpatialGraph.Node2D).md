## Graph2DOperations\.InsertNode\(this IGraph\<Node2D\>, uint, Node2D\) Method

Insert a new node in between an edge\.

```csharp
public static void InsertNode(this SpatialGraph.IGraph<SpatialGraph.Node2D> baseGraph, uint edgeID, SpatialGraph.Node2D newNode);
```
#### Parameters

<a name='SpatialGraph.Extentions.Graph2DOperations.InsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,SpatialGraph.Node2D).baseGraph'></a>

`baseGraph` [SpatialGraph\.IGraph&lt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')[Node2D](SpatialGraph.Node2D.md 'SpatialGraph\.Node2D')[&gt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')

Graph to perform the operation\.

<a name='SpatialGraph.Extentions.Graph2DOperations.InsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,SpatialGraph.Node2D).edgeID'></a>

`edgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of target edge\.

<a name='SpatialGraph.Extentions.Graph2DOperations.InsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,SpatialGraph.Node2D).newNode'></a>

`newNode` [Node2D](SpatialGraph.Node2D.md 'SpatialGraph\.Node2D')

Node to insert\.