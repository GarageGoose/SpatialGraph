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
↳ [GraphChangeLog&lt;TNode&gt;](SpatialGraph.GraphChangeLog_TNode_.md 'SpatialGraph\.GraphChangeLog\<TNode\>')

Implements [SpatialGraph\.GraphChangeSet&lt;](SpatialGraph.GraphChangeSet_TNode_.md 'SpatialGraph\.GraphChangeSet\<TNode\>')[TNode](SpatialGraph.IReadOnlyModificationLog_TNode_.md#SpatialGraph.IReadOnlyModificationLog_TNode_.TNode 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.TNode')[&gt;](SpatialGraph.GraphChangeSet_TNode_.md 'SpatialGraph\.GraphChangeSet\<TNode\>')

| Properties | |
| :--- | :--- |
| [BaseGraph](SpatialGraph.IReadOnlyModificationLog_TNode_.BaseGraph.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.BaseGraph') | Graph to reference the changes from\. |
| [EdgeModType](SpatialGraph.IReadOnlyModificationLog_TNode_.EdgeModType.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.EdgeModType') | Dictionary for type of modifications \(Add, Remove, Modify\) each edge have\. |
| [ModifiedEdges](SpatialGraph.IReadOnlyModificationLog_TNode_.ModifiedEdges.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.ModifiedEdges') | Dictionary for edges which was/will be modified\. Contains the original and new value of the edge\. |
| [ModifiedNodes](SpatialGraph.IReadOnlyModificationLog_TNode_.ModifiedNodes.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.ModifiedNodes') | Dictionary for nodes which was/will be modified\. Contains the original and new value of the node\. |
| [NewEdges](SpatialGraph.IReadOnlyModificationLog_TNode_.NewEdges.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.NewEdges') | Dictionary for edges which was/will be added\. |
| [NewNodes](SpatialGraph.IReadOnlyModificationLog_TNode_.NewNodes.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.NewNodes') | Dictionary for nodes which was/will be added\. |
| [NodeModType](SpatialGraph.IReadOnlyModificationLog_TNode_.NodeModType.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.NodeModType') | Dictionary for type of modifications \(Add, Remove, Modify\) each node have\. |
| [RemovedEdges](SpatialGraph.IReadOnlyModificationLog_TNode_.RemovedEdges.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.RemovedEdges') | Dictionary for edges which was/will be removed\. Contains its original value\. |
| [RemovedNodes](SpatialGraph.IReadOnlyModificationLog_TNode_.RemovedNodes.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.RemovedNodes') | Dictionary for nodes which was/will be removed\. Contains its original value\. |
