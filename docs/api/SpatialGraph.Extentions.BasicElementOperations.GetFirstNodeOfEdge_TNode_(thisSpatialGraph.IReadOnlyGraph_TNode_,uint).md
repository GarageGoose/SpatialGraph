## BasicElementOperations\.GetFirstNodeOfEdge\<TNode\>\(this IReadOnlyGraph\<TNode\>, uint\) Method

Get the first connecting node of an edge\.

```csharp
public static TNode GetFirstNodeOfEdge<TNode>(this SpatialGraph.IReadOnlyGraph<TNode> graph, uint edgeID)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Extentions.BasicElementOperations.GetFirstNodeOfEdge_TNode_(thisSpatialGraph.IReadOnlyGraph_TNode_,uint).TNode'></a>

`TNode`

Type of node used in the graph\.
#### Parameters

<a name='SpatialGraph.Extentions.BasicElementOperations.GetFirstNodeOfEdge_TNode_(thisSpatialGraph.IReadOnlyGraph_TNode_,uint).graph'></a>

`graph` [SpatialGraph\.IReadOnlyGraph&lt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](SpatialGraph.Extentions.BasicElementOperations.GetFirstNodeOfEdge_TNode_(thisSpatialGraph.IReadOnlyGraph_TNode_,uint).md#SpatialGraph.Extentions.BasicElementOperations.GetFirstNodeOfEdge_TNode_(thisSpatialGraph.IReadOnlyGraph_TNode_,uint).TNode 'SpatialGraph\.Extentions\.BasicElementOperations\.GetFirstNodeOfEdge\<TNode\>\(this SpatialGraph\.IReadOnlyGraph\<TNode\>, uint\)\.TNode')[&gt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')

Graph where the edge resides\.

<a name='SpatialGraph.Extentions.BasicElementOperations.GetFirstNodeOfEdge_TNode_(thisSpatialGraph.IReadOnlyGraph_TNode_,uint).edgeID'></a>

`edgeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the edge\.

#### Returns
[TNode](SpatialGraph.Extentions.BasicElementOperations.GetFirstNodeOfEdge_TNode_(thisSpatialGraph.IReadOnlyGraph_TNode_,uint).md#SpatialGraph.Extentions.BasicElementOperations.GetFirstNodeOfEdge_TNode_(thisSpatialGraph.IReadOnlyGraph_TNode_,uint).TNode 'SpatialGraph\.Extentions\.BasicElementOperations\.GetFirstNodeOfEdge\<TNode\>\(this SpatialGraph\.IReadOnlyGraph\<TNode\>, uint\)\.TNode')  
First connecting node of the edge\.