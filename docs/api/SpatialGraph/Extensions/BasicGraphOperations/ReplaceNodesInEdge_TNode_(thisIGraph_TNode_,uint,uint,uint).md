## BasicGraphOperations\.ReplaceNodesInEdge<TNode>(this IGraph<TNode>, uint, uint, uint) Method

Replace both [INode](../../INode/index.md 'SpatialGraph\.INode')s in an [Edge](../../Edge/index.md 'SpatialGraph\.Edge') with new ones in a [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\.

```csharp
public static void ReplaceNodesInEdge<TNode>(this SpatialGraph.IGraph<TNode> graph, uint EdgeID, uint NewNodeID1, uint NewNodeID2)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint,uint).TNode'></a>

`TNode`

Type of node the graph is using\.
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint,uint).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[TNode](ReplaceNodesInEdge_TNode_(thisIGraph_TNode_,uint,uint,uint).md#SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint,uint).TNode 'SpatialGraph\.Extensions\.BasicGraphOperations\.ReplaceNodesInEdge<TNode>(this SpatialGraph\.IGraph<TNode>, uint, uint, uint)\.TNode')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

Graph where to replace the nodes of an edge\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint,uint).EdgeID'></a>

`EdgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the edge to replace its nodes\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint,uint).NewNodeID1'></a>

`NewNodeID1` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to replace the first node of the edge\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint,uint).NewNodeID2'></a>

`NewNodeID2` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to replace the second node of the edge\.