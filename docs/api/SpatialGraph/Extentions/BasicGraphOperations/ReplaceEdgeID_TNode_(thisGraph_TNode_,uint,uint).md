## BasicGraphOperations\.ReplaceEdgeID\<TNode\>\(this Graph\<TNode\>, uint, uint\) Method

Replace the ID of an edge with a new ID\. An existing edge with the same ID as the new ID will be replaced\.

```csharp
public static void ReplaceEdgeID<TNode>(this SpatialGraph.Graph<TNode> graph, uint EdgeID, uint NewEdgeID)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Extentions.BasicGraphOperations.ReplaceEdgeID_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint).TNode'></a>

`TNode`
#### Parameters

<a name='SpatialGraph.Extentions.BasicGraphOperations.ReplaceEdgeID_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint).graph'></a>

`graph` [SpatialGraph\.Graph&lt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph\<TNode\>')[TNode](ReplaceEdgeID_TNode_(thisGraph_TNode_,uint,uint).md#SpatialGraph.Extentions.BasicGraphOperations.ReplaceEdgeID_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint).TNode 'SpatialGraph\.Extentions\.BasicGraphOperations\.ReplaceEdgeID\<TNode\>\(this SpatialGraph\.Graph\<TNode\>, uint, uint\)\.TNode')[&gt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph\<TNode\>')

Graph where to replace an edge ID\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.ReplaceEdgeID_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint).EdgeID'></a>

`EdgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

Current ID of the edge to be replaced with a new ID\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.ReplaceEdgeID_TNode_(thisSpatialGraph.Graph_TNode_,uint,uint).NewEdgeID'></a>

`NewEdgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

New ID of the edge\.