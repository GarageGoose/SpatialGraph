## BasicElementOperations\.GetSecondNodeOfEdge<TNode>(this IReadOnlyGraph<TNode>, uint) Method

Get the [INode](../../INode/index.md 'SpatialGraph\.INode') that is referenced from [NodeID2](../../Edge/NodeID2.md 'SpatialGraph\.Edge\.NodeID2') of an [Edge](../../Edge/index.md 'SpatialGraph\.Edge')\.

```csharp
public static TNode GetSecondNodeOfEdge<TNode>(this SpatialGraph.IReadOnlyGraph<TNode> graph, uint edgeID)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Extensions.BasicElementOperations.GetSecondNodeOfEdge_TNode_(thisSpatialGraph.IReadOnlyGraph_TNode_,uint).TNode'></a>

`TNode`

Type of node used in the graph\.
#### Parameters

<a name='SpatialGraph.Extensions.BasicElementOperations.GetSecondNodeOfEdge_TNode_(thisSpatialGraph.IReadOnlyGraph_TNode_,uint).graph'></a>

`graph` [SpatialGraph\.IReadOnlyGraph&lt;](../../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[TNode](GetSecondNodeOfEdge_TNode_(thisIReadOnlyGraph_TNode_,uint).md#SpatialGraph.Extensions.BasicElementOperations.GetSecondNodeOfEdge_TNode_(thisSpatialGraph.IReadOnlyGraph_TNode_,uint).TNode 'SpatialGraph\.Extensions\.BasicElementOperations\.GetSecondNodeOfEdge<TNode>(this SpatialGraph\.IReadOnlyGraph<TNode>, uint)\.TNode')[&gt;](../../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')

Graph where the edge resides\.

<a name='SpatialGraph.Extensions.BasicElementOperations.GetSecondNodeOfEdge_TNode_(thisSpatialGraph.IReadOnlyGraph_TNode_,uint).edgeID'></a>

`edgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the edge\.

#### Returns
[TNode](GetSecondNodeOfEdge_TNode_(thisIReadOnlyGraph_TNode_,uint).md#SpatialGraph.Extensions.BasicElementOperations.GetSecondNodeOfEdge_TNode_(thisSpatialGraph.IReadOnlyGraph_TNode_,uint).TNode 'SpatialGraph\.Extensions\.BasicElementOperations\.GetSecondNodeOfEdge<TNode>(this SpatialGraph\.IReadOnlyGraph<TNode>, uint)\.TNode')  
Second connecting node of the edge\.