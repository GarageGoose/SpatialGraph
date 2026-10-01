## IReadOnlyModificationLog\<TNode\> Interface

Logs incoming changes for a graph\. Stores additional data: type of modification of an element \(Add, Modify, Delete\), old value of an element \(if any\), and new value of an element \(if any\)\.

```csharp
public interface IReadOnlyModificationLog<TNode> : SpatialGraph.GraphChangeSet<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.IReadOnlyModificationLog_TNode_.TNode'></a>

`TNode`

Type of node used in the graph to log changes from\.

Derived  
↳ [GraphChangeLog&lt;TNode&gt;](../GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog\<TNode\>')

Implements [SpatialGraph\.GraphChangeSet&lt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet\<TNode\>')[TNode](index.md#SpatialGraph.IReadOnlyModificationLog_TNode_.TNode 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.TNode')[&gt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet\<TNode\>')

| Properties | |
| :--- | :--- |
| [BaseGraph](BaseGraph.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.BaseGraph') | Graph to reference the changes from\. |
| [EdgeModType](EdgeModType.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.EdgeModType') | Dictionary for type of modifications \(Add, Remove, Modify\) each edge have\. |
| [ModifiedEdges](ModifiedEdges.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.ModifiedEdges') | Dictionary for edges which was/will be modified\. Contains the original and new value of the edge\. |
| [ModifiedNodes](ModifiedNodes.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.ModifiedNodes') | Dictionary for nodes which was/will be modified\. Contains the original and new value of the node\. |
| [NewEdges](NewEdges.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.NewEdges') | Dictionary for edges which was/will be added\. |
| [NewNodes](NewNodes.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.NewNodes') | Dictionary for nodes which was/will be added\. |
| [NodeModType](NodeModType.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.NodeModType') | Dictionary for type of modifications \(Add, Remove, Modify\) each node have\. |
| [RemovedEdges](RemovedEdges.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.RemovedEdges') | Dictionary for edges which was/will be removed\. Contains its original value\. |
| [RemovedNodes](RemovedNodes.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.RemovedNodes') | Dictionary for nodes which was/will be removed\. Contains its original value\. |
