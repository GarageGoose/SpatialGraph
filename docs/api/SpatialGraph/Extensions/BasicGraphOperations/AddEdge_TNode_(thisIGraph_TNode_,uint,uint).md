## BasicGraphOperations\.AddEdge<TNode>(this IGraph<TNode>, uint, uint) Method

Add an [Edge](../../Edge/index.md 'SpatialGraph\.Edge') in a [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\.

```csharp
public static uint AddEdge<TNode>(this SpatialGraph.IGraph<TNode> graph, uint NodeID1, uint NodeID2)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).TNode'></a>

`TNode`

Type of node the graph has\.
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[TNode](AddEdge_TNode_(thisIGraph_TNode_,uint,uint).md#SpatialGraph.Extensions.BasicGraphOperations.AddEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).TNode 'SpatialGraph\.Extensions\.BasicGraphOperations\.AddEdge<TNode>(this SpatialGraph\.IGraph<TNode>, uint, uint)\.TNode')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

Graph to add an edge\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).NodeID1'></a>

`NodeID1` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

The first node in an edge\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).NodeID2'></a>

`NodeID2` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

The second node in an edge\.

#### Returns
[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')  
ID of the new edge\.