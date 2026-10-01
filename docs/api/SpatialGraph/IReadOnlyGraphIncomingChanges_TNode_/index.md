## IReadOnlyGraphIncomingChanges\<TNode\> Interface

Interface for objects which stores incoming changes for a graph\.

```csharp
public interface IReadOnlyGraphIncomingChanges<TNode> : SpatialGraph.GraphChangeSet<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.IReadOnlyGraphIncomingChanges_TNode_.TNode'></a>

`TNode`

Type of node used in the graph\.

Derived  
↳ [GraphIncomingChanges&lt;TNode&gt;](../GraphIncomingChanges_TNode_/index.md 'SpatialGraph\.GraphIncomingChanges\<TNode\>')

Implements [SpatialGraph\.GraphChangeSet&lt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet\<TNode\>')[TNode](index.md#SpatialGraph.IReadOnlyGraphIncomingChanges_TNode_.TNode 'SpatialGraph\.IReadOnlyGraphIncomingChanges\<TNode\>\.TNode')[&gt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet\<TNode\>')

| Properties | |
| :--- | :--- |
| [EdgesForRemoval](EdgesForRemoval.md 'SpatialGraph\.IReadOnlyGraphIncomingChanges\<TNode\>\.EdgesForRemoval') | Edges to be removed in a graph\. |
| [EdgesForUpsert](EdgesForUpsert.md 'SpatialGraph\.IReadOnlyGraphIncomingChanges\<TNode\>\.EdgesForUpsert') | Edges to be added or modified \(replaced with identical IDs\) in a graph\. |
| [NodesForRemoval](NodesForRemoval.md 'SpatialGraph\.IReadOnlyGraphIncomingChanges\<TNode\>\.NodesForRemoval') | Nodes to be removed in a graph\. |
| [NodesForUpsert](NodesForUpsert.md 'SpatialGraph\.IReadOnlyGraphIncomingChanges\<TNode\>\.NodesForUpsert') | Nodes to be added or modified \(replaced with identical IDs\) in a graph\. |
