## GraphChangeSet<TNode> Interface

Set of changes for a [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\.

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
| [EdgeRemovals()](EdgeRemovals().md 'SpatialGraph\.GraphChangeSet<TNode>\.EdgeRemovals()') | IDs of the [Edge](../Edge/index.md 'SpatialGraph\.Edge')s to be removed in [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |
| [EdgeUpserts()](EdgeUpserts().md 'SpatialGraph\.GraphChangeSet<TNode>\.EdgeUpserts()') | [Edge](../Edge/index.md 'SpatialGraph\.Edge')s to be either added or modified if it has the same ID as an [Edge](../Edge/index.md 'SpatialGraph\.Edge') in [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |
| [NodeRemovals()](NodeRemovals().md 'SpatialGraph\.GraphChangeSet<TNode>\.NodeRemovals()') | IDs of the [INode](../INode/index.md 'SpatialGraph\.INode')s to be removed in [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |
| [NodeUpserts()](NodeUpserts().md 'SpatialGraph\.GraphChangeSet<TNode>\.NodeUpserts()') | [INode](../INode/index.md 'SpatialGraph\.INode')s to be either added or modified if it has the same ID as a [INode](../INode/index.md 'SpatialGraph\.INode') in [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |
