## BasicGraphOperations\.ReplaceSecondNodeInEdge<TNode>(this Graph<TNode>, uint, uint) Method

Replace the second node (NodeID2) in an edge to a new one in a graph\.

```csharp
public static void ReplaceSecondNodeInEdge<TNode>(this SpatialGraph.Graph<TNode> graph, uint EdgeID, uint NewNodeID)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceSecondNodeInEdge_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint).TNode'></a>

`TNode`

Type of node the graph is using\.
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceSecondNodeInEdge_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint).graph'></a>

`graph` [SpatialGraph\.Graph&lt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')[TNode](ReplaceSecondNodeInEdge_TNode_(thisGraph_TNode_,uint,uint).md#SpatialGraph.Extensions.BasicGraphOperations.ReplaceSecondNodeInEdge_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint).TNode 'SpatialGraph\.Extensions\.BasicGraphOperations\.ReplaceSecondNodeInEdge<TNode>(this SpatialGraph\.Graph<TNode>, uint, uint)\.TNode')[&gt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')

Graph where to replace the second node of an edge\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceSecondNodeInEdge_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint).EdgeID'></a>

`EdgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the edge to replace its second node\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceSecondNodeInEdge_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint).NewNodeID'></a>

`NewNodeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to replace the second node of the edge\.