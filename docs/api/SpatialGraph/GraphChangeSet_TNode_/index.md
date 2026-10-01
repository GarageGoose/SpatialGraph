## GraphChangeSet<TNode> Interface

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
↳ [GraphChangeLog&lt;TNode&gt;](../GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog<TNode>')  
↳ [GraphIncomingChanges&lt;TNode&gt;](../GraphIncomingChanges_TNode_/index.md 'SpatialGraph\.GraphIncomingChanges<TNode>')  
↳ [IReadOnlyGraphIncomingChanges&lt;TNode&gt;](../IReadOnlyGraphIncomingChanges_TNode_/index.md 'SpatialGraph\.IReadOnlyGraphIncomingChanges<TNode>')  
↳ [IReadOnlyModificationLog&lt;TNode&gt;](../IReadOnlyModificationLog_TNode_/index.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>')

| Methods | |
| :--- | :--- |
| [EdgeRemovals()](EdgeRemovals().md 'SpatialGraph\.GraphChangeSet<TNode>\.EdgeRemovals()') | IDs of the edges to be removed in a graph\. |
| [EdgeUpserts()](EdgeUpserts().md 'SpatialGraph\.GraphChangeSet<TNode>\.EdgeUpserts()') | Edges to be either added or replaced if it has the same ID as a node in a graph\. |
| [NodeRemovals()](NodeRemovals().md 'SpatialGraph\.GraphChangeSet<TNode>\.NodeRemovals()') | IDs of the nodes to be removed in a graph\. |
| [NodeUpserts()](NodeUpserts().md 'SpatialGraph\.GraphChangeSet<TNode>\.NodeUpserts()') | Nodes to be either added or replaced if it has the same ID as a node in a graph\. |
