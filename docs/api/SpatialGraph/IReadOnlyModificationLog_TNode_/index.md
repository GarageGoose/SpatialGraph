## IReadOnlyModificationLog<TNode> Interface

Read only log for incoming changes for a [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. Stores additional data: type of modification of an
[IElement](../IElement/index.md 'SpatialGraph\.IElement') (Add, Modify, Delete), old value of an [IElement](../IElement/index.md 'SpatialGraph\.IElement') (if any), and new value of an [IElement](../IElement/index.md 'SpatialGraph\.IElement') (if any)\.

```csharp
public interface IReadOnlyModificationLog<TNode> : SpatialGraph.GraphChangeSet<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.IReadOnlyModificationLog_TNode_.TNode'></a>

`TNode`

Type of node used in the graph to log changes from\.

Derived  
↳ [GraphChangeLog&lt;TNode&gt;](../GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog<TNode>')

Implements [SpatialGraph\.GraphChangeSet&lt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')[TNode](index.md#SpatialGraph.IReadOnlyModificationLog_TNode_.TNode 'SpatialGraph\.IReadOnlyModificationLog<TNode>\.TNode')[&gt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')

| Properties | |
| :--- | :--- |
| [BaseGraph](BaseGraph.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>\.BaseGraph') | Graph to reference the changes from\. |
| [EdgeModType](EdgeModType.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>\.EdgeModType') | Dictionary for type of modifications (Add, Remove, Modify) each [Edge](../Edge/index.md 'SpatialGraph\.Edge') have\. |
| [ModifiedEdges](ModifiedEdges.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>\.ModifiedEdges') | Dictionary for [Edge](../Edge/index.md 'SpatialGraph\.Edge')s which was/will be modified\. Contains the original and new value of the [Edge](../Edge/index.md 'SpatialGraph\.Edge')\. |
| [ModifiedNodes](ModifiedNodes.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>\.ModifiedNodes') | Dictionary for [INode](../INode/index.md 'SpatialGraph\.INode')s which was/will be modified\. Contains the original and new value of the [INode](../INode/index.md 'SpatialGraph\.INode')\. |
| [NewEdges](NewEdges.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>\.NewEdges') | Dictionary for [Edge](../Edge/index.md 'SpatialGraph\.Edge')s which was/will be added\. |
| [NewNodes](NewNodes.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>\.NewNodes') | Dictionary for [INode](../INode/index.md 'SpatialGraph\.INode')s which was/will be added\. |
| [NodeModType](NodeModType.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>\.NodeModType') | Dictionary for type of modifications (Add, Remove, Modify) each [INode](../INode/index.md 'SpatialGraph\.INode') have\. |
| [RemovedEdges](RemovedEdges.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>\.RemovedEdges') | Dictionary for [Edge](../Edge/index.md 'SpatialGraph\.Edge')s which was/will be removed\. Contains its original value\. |
| [RemovedNodes](RemovedNodes.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>\.RemovedNodes') | Dictionary for [INode](../INode/index.md 'SpatialGraph\.INode')s which was/will be removed\. Contains its original value\. |
