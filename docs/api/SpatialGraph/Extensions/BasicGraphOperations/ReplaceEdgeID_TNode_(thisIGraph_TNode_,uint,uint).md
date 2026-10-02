## BasicGraphOperations\.ReplaceEdgeID<TNode>(this IGraph<TNode>, uint, uint) Method

Replace the ID of an [Edge](../../Edge/index.md 'SpatialGraph\.Edge') with a new ID\. An existing [Edge](../../Edge/index.md 'SpatialGraph\.Edge') with the same ID as the new ID will be replaced\.

```csharp
public static void ReplaceEdgeID<TNode>(this SpatialGraph.IGraph<TNode> graph, uint EdgeID, uint NewEdgeID)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceEdgeID_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).TNode'></a>

`TNode`
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceEdgeID_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[TNode](ReplaceEdgeID_TNode_(thisIGraph_TNode_,uint,uint).md#SpatialGraph.Extensions.BasicGraphOperations.ReplaceEdgeID_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).TNode 'SpatialGraph\.Extensions\.BasicGraphOperations\.ReplaceEdgeID<TNode>(this SpatialGraph\.IGraph<TNode>, uint, uint)\.TNode')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

[IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') where to replace an [Edge](../../Edge/index.md 'SpatialGraph\.Edge') ID\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceEdgeID_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).EdgeID'></a>

`EdgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

Current ID of the [Edge](../../Edge/index.md 'SpatialGraph\.Edge') to be replaced with a new ID\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceEdgeID_TNode_(thisSpatialGraph.IGraph_TNode_,uint,uint).NewEdgeID'></a>

`NewEdgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

New ID of the [Edge](../../Edge/index.md 'SpatialGraph\.Edge')\.