## BasicGraphOperations\.ReplaceSecondNodeInEdge<TNode>(this IGraph<TNode>, uint, uint) Method

Replace the second [INode](../../INode/index.md 'SpatialGraph\.INode') ([SpatialGraph\.Edge\.NodeID2](https://learn.microsoft.com/en-us/dotnet/api/spatialgraph.edge.nodeid2 'SpatialGraph\.Edge\.NodeID2')) in an [Edge](../../Edge/index.md 'SpatialGraph\.Edge') to a new one in a [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\.

```csharp
public static void ReplaceSecondNodeInEdge<TNode>(this SpatialGraph.IGraph<TNode> graph, uint EdgeID, uint NewNodeID)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceSecondNodeInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).TNode'></a>

`TNode`

Type of node the [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') is using\.
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceSecondNodeInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[TNode](ReplaceSecondNodeInEdge_TNode_(thisIGraph_TNode_,uint,uint).md#SpatialGraph.Extensions.BasicGraphOperations.ReplaceSecondNodeInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).TNode 'SpatialGraph\.Extensions\.BasicGraphOperations\.ReplaceSecondNodeInEdge<TNode>(this SpatialGraph\.IGraph<TNode>, uint, uint)\.TNode')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

[IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') where to replace the second [INode](../../INode/index.md 'SpatialGraph\.INode') of an [Edge](../../Edge/index.md 'SpatialGraph\.Edge')\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceSecondNodeInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).EdgeID'></a>

`EdgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the [Edge](../../Edge/index.md 'SpatialGraph\.Edge') to replace its second [INode](../../INode/index.md 'SpatialGraph\.INode')\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceSecondNodeInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).NewNodeID'></a>

`NewNodeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the [INode](../../INode/index.md 'SpatialGraph\.INode') to replace the second [INode](../../INode/index.md 'SpatialGraph\.INode') of the [Edge](../../Edge/index.md 'SpatialGraph\.Edge')\.