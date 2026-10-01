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
↳ [GraphIncomingChanges&lt;TNode&gt;](SpatialGraph.GraphIncomingChanges_TNode_.md 'SpatialGraph\.GraphIncomingChanges\<TNode\>')

Implements [SpatialGraph\.GraphChangeSet&lt;](SpatialGraph.GraphChangeSet_TNode_.md 'SpatialGraph\.GraphChangeSet\<TNode\>')[TNode](SpatialGraph.IReadOnlyGraphIncomingChanges_TNode_.md#SpatialGraph.IReadOnlyGraphIncomingChanges_TNode_.TNode 'SpatialGraph\.IReadOnlyGraphIncomingChanges\<TNode\>\.TNode')[&gt;](SpatialGraph.GraphChangeSet_TNode_.md 'SpatialGraph\.GraphChangeSet\<TNode\>')

| Properties | |
| :--- | :--- |
| [EdgesForRemoval](SpatialGraph.IReadOnlyGraphIncomingChanges_TNode_.EdgesForRemoval.md 'SpatialGraph\.IReadOnlyGraphIncomingChanges\<TNode\>\.EdgesForRemoval') | Edges to be removed in a graph\. |
| [EdgesForUpsert](SpatialGraph.IReadOnlyGraphIncomingChanges_TNode_.EdgesForUpsert.md 'SpatialGraph\.IReadOnlyGraphIncomingChanges\<TNode\>\.EdgesForUpsert') | Edges to be added or modified \(replaced with identical IDs\) in a graph\. |
| [NodesForRemoval](SpatialGraph.IReadOnlyGraphIncomingChanges_TNode_.NodesForRemoval.md 'SpatialGraph\.IReadOnlyGraphIncomingChanges\<TNode\>\.NodesForRemoval') | Nodes to be removed in a graph\. |
| [NodesForUpsert](SpatialGraph.IReadOnlyGraphIncomingChanges_TNode_.NodesForUpsert.md 'SpatialGraph\.IReadOnlyGraphIncomingChanges\<TNode\>\.NodesForUpsert') | Nodes to be added or modified \(replaced with identical IDs\) in a graph\. |
