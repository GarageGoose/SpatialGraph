## BasicGraphOperations\.ReplaceNodesInEdge<TNode>(this IGraph<TNode>, uint, uint, uint) Method

Replace both [INode](../../INode/index.md 'SpatialGraph\.INode')s in an [Edge](../../Edge/index.md 'SpatialGraph\.Edge') to a new one in a [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\.

```csharp
public static void ReplaceNodesInEdge<TNode>(this SpatialGraph.IGraph<TNode> graph, uint EdgeID, uint NewNodeID1, uint NewNodeID2)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint,uint).TNode'></a>

`TNode`

Type of [INode](../../INode/index.md 'SpatialGraph\.INode') the [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') is using\.
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint,uint).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[TNode](ReplaceNodesInEdge_TNode_(thisIGraph_TNode_,uint,uint,uint).md#SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint,uint).TNode 'SpatialGraph\.Extensions\.BasicGraphOperations\.ReplaceNodesInEdge<TNode>(this SpatialGraph\.IGraph<TNode>, uint, uint, uint)\.TNode')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

[IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') where to replace the second [INode](../../INode/index.md 'SpatialGraph\.INode') of an [Edge](../../Edge/index.md 'SpatialGraph\.Edge')\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint,uint).EdgeID'></a>

`EdgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the [Edge](../../Edge/index.md 'SpatialGraph\.Edge') to replace its second [INode](../../INode/index.md 'SpatialGraph\.INode')\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint,uint).NewNodeID1'></a>

`NewNodeID1` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the [INode](../../INode/index.md 'SpatialGraph\.INode') to replace the first [INode](../../INode/index.md 'SpatialGraph\.INode') of the [Edge](../../Edge/index.md 'SpatialGraph\.Edge')\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint,uint).NewNodeID2'></a>

`NewNodeID2` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the [INode](../../INode/index.md 'SpatialGraph\.INode') to replace the second [INode](../../INode/index.md 'SpatialGraph\.INode') of the [Edge](../../Edge/index.md 'SpatialGraph\.Edge')\.