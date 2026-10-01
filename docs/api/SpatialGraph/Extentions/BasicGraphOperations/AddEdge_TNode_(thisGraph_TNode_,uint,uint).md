## BasicGraphOperations\.AddEdge<TNode>(this Graph<TNode>, uint, uint) Method

Add an edge in a graph\.

```csharp
public static uint AddEdge<TNode>(this SpatialGraph.Graph<TNode> graph, uint NodeID1, uint NodeID2)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddEdge_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint).TNode'></a>

`TNode`

Type of node the graph have\.
#### Parameters

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddEdge_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint).graph'></a>

`graph` [SpatialGraph\.Graph&lt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')[TNode](AddEdge_TNode_(thisGraph_TNode_,uint,uint).md#SpatialGraph.Extentions.BasicGraphOperations.AddEdge_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint).TNode 'SpatialGraph\.Extentions\.BasicGraphOperations\.AddEdge<TNode>(this SpatialGraph\.Graph<TNode>, uint, uint)\.TNode')[&gt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')

Graph to add an edge\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddEdge_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint).NodeID1'></a>

`NodeID1` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

The first node in an edge\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddEdge_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint).NodeID2'></a>

`NodeID2` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

The second node in an edge\.

#### Returns
[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')