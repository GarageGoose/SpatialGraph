## Graph2DOperations\.CollapseNode(this IGraph<Node2D>, NodeAdjacency<Node2D>, uint\[\]) Method

Combine multiple [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')s into a single one\.

```csharp
public static void CollapseNode(this SpatialGraph.IGraph<SpatialGraph.Node2D> baseGraph, SpatialGraph.Metadata.NodeAdjacency<SpatialGraph.Node2D> adjacency, params uint[] nodeIDsToCollapse);
```
#### Parameters

<a name='SpatialGraph.Extensions.Graph2DOperations.CollapseNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,SpatialGraph.Metadata.NodeAdjacency_SpatialGraph.Node2D_,uint[]).baseGraph'></a>

`baseGraph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

Graph to perform the operation\.

<a name='SpatialGraph.Extensions.Graph2DOperations.CollapseNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,SpatialGraph.Metadata.NodeAdjacency_SpatialGraph.Node2D_,uint[]).adjacency'></a>

`adjacency` [SpatialGraph\.Metadata\.NodeAdjacency&lt;](../../Metadata/NodeAdjacency_TNode_/index.md 'SpatialGraph\.Metadata\.NodeAdjacency<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../Metadata/NodeAdjacency_TNode_/index.md 'SpatialGraph\.Metadata\.NodeAdjacency<TNode>')

Elements adjacency plugin for baseGraph\.

<a name='SpatialGraph.Extensions.Graph2DOperations.CollapseNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,SpatialGraph.Metadata.NodeAdjacency_SpatialGraph.Node2D_,uint[]).nodeIDsToCollapse'></a>

`nodeIDsToCollapse` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

IDs of the node to collapse to a single node\. The first in the array will be the new node\.