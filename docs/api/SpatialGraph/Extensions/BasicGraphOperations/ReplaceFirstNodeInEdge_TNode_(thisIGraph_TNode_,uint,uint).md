## BasicGraphOperations\.ReplaceFirstNodeInEdge<TNode>(this IGraph<TNode>, uint, uint) Method

Replace the first [INode](../../INode/index.md 'SpatialGraph\.INode') ([NodeID1](../../Edge/NodeID1.md 'SpatialGraph\.Edge\.NodeID1')) in an [Edge](../../Edge/index.md 'SpatialGraph\.Edge') to a new one in a [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\.

```csharp
public static void ReplaceFirstNodeInEdge<TNode>(this SpatialGraph.IGraph<TNode> graph, uint EdgeID, uint NewNodeID)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceFirstNodeInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).TNode'></a>

`TNode`

Type of node the graph is using\.
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceFirstNodeInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[TNode](ReplaceFirstNodeInEdge_TNode_(thisIGraph_TNode_,uint,uint).md#SpatialGraph.Extensions.BasicGraphOperations.ReplaceFirstNodeInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).TNode 'SpatialGraph\.Extensions\.BasicGraphOperations\.ReplaceFirstNodeInEdge<TNode>(this SpatialGraph\.IGraph<TNode>, uint, uint)\.TNode')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

Graph where to replace the first node of an edge\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceFirstNodeInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).EdgeID'></a>

`EdgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the edge to replace its first node\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceFirstNodeInEdge_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).NewNodeID'></a>

`NewNodeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to replace the first node of the edge\.