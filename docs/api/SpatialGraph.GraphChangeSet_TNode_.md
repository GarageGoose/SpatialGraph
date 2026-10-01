## GraphChangeSet\<TNode\> Interface

Set of changes in a graph\.

```csharp
public interface GraphChangeSet<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.GraphChangeSet_TNode_.TNode'></a>

`TNode`

Node which the base graph uses\.

Derived  
↳ [GraphChangeLog&lt;TNode&gt;](SpatialGraph.GraphChangeLog_TNode_.md 'SpatialGraph\.GraphChangeLog\<TNode\>')  
↳ [GraphIncomingChanges&lt;TNode&gt;](SpatialGraph.GraphIncomingChanges_TNode_.md 'SpatialGraph\.GraphIncomingChanges\<TNode\>')  
↳ [IReadOnlyGraphIncomingChanges&lt;TNode&gt;](SpatialGraph.IReadOnlyGraphIncomingChanges_TNode_.md 'SpatialGraph\.IReadOnlyGraphIncomingChanges\<TNode\>')  
↳ [IReadOnlyModificationLog&lt;TNode&gt;](SpatialGraph.IReadOnlyModificationLog_TNode_.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>')

| Methods | |
| :--- | :--- |
| [EdgeRemovals\(\)](SpatialGraph.GraphChangeSet_TNode_.EdgeRemovals().md 'SpatialGraph\.GraphChangeSet\<TNode\>\.EdgeRemovals\(\)') | IDs of the edges to be removed in a graph\. |
| [EdgeUpserts\(\)](SpatialGraph.GraphChangeSet_TNode_.EdgeUpserts().md 'SpatialGraph\.GraphChangeSet\<TNode\>\.EdgeUpserts\(\)') | Edges to be either added or replaced if it has the same ID as a node in a graph\. |
| [NodeRemovals\(\)](SpatialGraph.GraphChangeSet_TNode_.NodeRemovals().md 'SpatialGraph\.GraphChangeSet\<TNode\>\.NodeRemovals\(\)') | IDs of the nodes to be removed in a graph\. |
| [NodeUpserts\(\)](SpatialGraph.GraphChangeSet_TNode_.NodeUpserts().md 'SpatialGraph\.GraphChangeSet\<TNode\>\.NodeUpserts\(\)') | Nodes to be either added or replaced if it has the same ID as a node in a graph\. |
