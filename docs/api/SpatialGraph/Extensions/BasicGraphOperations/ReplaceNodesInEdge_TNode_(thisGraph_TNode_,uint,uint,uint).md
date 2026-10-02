## BasicGraphOperations\.ReplaceNodesInEdge<TNode>(this Graph<TNode>, uint, uint, uint) Method

Replace both nodes in an edge to a new one in a graph\.

```csharp
public static void ReplaceNodesInEdge<TNode>(this SpatialGraph.Graph<TNode> graph, uint EdgeID, uint NewNodeID1, uint NewNodeID2)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint,uint).TNode'></a>

`TNode`

Type of node the graph is using\.
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint,uint).graph'></a>

`graph` [SpatialGraph\.Graph&lt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')[TNode](ReplaceNodesInEdge_TNode_(thisGraph_TNode_,uint,uint,uint).md#SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint,uint).TNode 'SpatialGraph\.Extensions\.BasicGraphOperations\.ReplaceNodesInEdge<TNode>(this SpatialGraph\.Graph<TNode>, uint, uint, uint)\.TNode')[&gt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')

Graph where to replace the second node of an edge\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint,uint).EdgeID'></a>

`EdgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the edge to replace its second node\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint,uint).NewNodeID1'></a>

`NewNodeID1` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to replace the first node of the edge\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodesInEdge_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint,uint).NewNodeID2'></a>

`NewNodeID2` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to replace the second node of the edge\.