## Graph2DOperations\.CopyGraph(this IGraph<Node2D>, IGraph<Node2D>, bool) Method

Copy entire graph to another graph\.

```csharp
public static void CopyGraph(this SpatialGraph.IGraph<SpatialGraph.Node2D> copyFrom, SpatialGraph.IGraph<SpatialGraph.Node2D> pasteTo, bool preserveID);
```
#### Parameters

<a name='SpatialGraph.Extensions.Graph2DOperations.CopyGraph(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,SpatialGraph.IGraph_SpatialGraph.Node2D_,bool).copyFrom'></a>

`copyFrom` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

Source graph to copy\.

<a name='SpatialGraph.Extensions.Graph2DOperations.CopyGraph(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,SpatialGraph.IGraph_SpatialGraph.Node2D_,bool).pasteTo'></a>

`pasteTo` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

Target graph to paste the source graph to\.

<a name='SpatialGraph.Extensions.Graph2DOperations.CopyGraph(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,SpatialGraph.IGraph_SpatialGraph.Node2D_,bool).preserveID'></a>

`preserveID` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Preserves the id of the elements from the source graph, do note that elements with same IDs will be replaced with
elements from the target graph\. If false, new ids will be generated for the elements in the target graph\.