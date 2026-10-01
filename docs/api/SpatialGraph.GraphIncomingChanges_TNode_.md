## GraphIncomingChanges\<TNode\> Class

Stores incoming changes for a graph\.

```csharp
public class GraphIncomingChanges<TNode> : SpatialGraph.IReadOnlyGraphIncomingChanges<TNode>, SpatialGraph.GraphChangeSet<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.GraphIncomingChanges_TNode_.TNode'></a>

`TNode`

Type of node used in the graph\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → GraphIncomingChanges\<TNode\>

Implements [SpatialGraph\.IReadOnlyGraphIncomingChanges&lt;](SpatialGraph.IReadOnlyGraphIncomingChanges_TNode_.md 'SpatialGraph\.IReadOnlyGraphIncomingChanges\<TNode\>')[TNode](SpatialGraph.GraphIncomingChanges_TNode_.md#SpatialGraph.GraphIncomingChanges_TNode_.TNode 'SpatialGraph\.GraphIncomingChanges\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyGraphIncomingChanges_TNode_.md 'SpatialGraph\.IReadOnlyGraphIncomingChanges\<TNode\>'), [SpatialGraph\.GraphChangeSet&lt;](SpatialGraph.GraphChangeSet_TNode_.md 'SpatialGraph\.GraphChangeSet\<TNode\>')[TNode](SpatialGraph.GraphIncomingChanges_TNode_.md#SpatialGraph.GraphIncomingChanges_TNode_.TNode 'SpatialGraph\.GraphIncomingChanges\<TNode\>\.TNode')[&gt;](SpatialGraph.GraphChangeSet_TNode_.md 'SpatialGraph\.GraphChangeSet\<TNode\>')

| Constructors | |
| :--- | :--- |
| [GraphIncomingChanges\(\)](SpatialGraph.GraphIncomingChanges_TNode_.#ctor.md#SpatialGraph.GraphIncomingChanges_TNode_.GraphIncomingChanges() 'SpatialGraph\.GraphIncomingChanges\<TNode\>\.GraphIncomingChanges\(\)') | Create a new empty instance\. |
| [GraphIncomingChanges\(IReadOnlyGraphIncomingChanges&lt;TNode&gt;\)](SpatialGraph.GraphIncomingChanges_TNode_.#ctor.md#SpatialGraph.GraphIncomingChanges_TNode_.GraphIncomingChanges(SpatialGraph.IReadOnlyGraphIncomingChanges_TNode_) 'SpatialGraph\.GraphIncomingChanges\<TNode\>\.GraphIncomingChanges\(SpatialGraph\.IReadOnlyGraphIncomingChanges\<TNode\>\)') | |

| Properties | |
| :--- | :--- |
| [EdgesForRemoval](SpatialGraph.GraphIncomingChanges_TNode_.EdgesForRemoval.md 'SpatialGraph\.GraphIncomingChanges\<TNode\>\.EdgesForRemoval') | Edges to be removed in a graph\. |
| [EdgesForUpsert](SpatialGraph.GraphIncomingChanges_TNode_.EdgesForUpsert.md 'SpatialGraph\.GraphIncomingChanges\<TNode\>\.EdgesForUpsert') | Edges to be added or modified \(replaced with identical IDs\) in a graph\. |
| [NodesForRemoval](SpatialGraph.GraphIncomingChanges_TNode_.NodesForRemoval.md 'SpatialGraph\.GraphIncomingChanges\<TNode\>\.NodesForRemoval') | Nodes to be removed in a graph\. |
| [NodesForUpsert](SpatialGraph.GraphIncomingChanges_TNode_.NodesForUpsert.md 'SpatialGraph\.GraphIncomingChanges\<TNode\>\.NodesForUpsert') | Nodes to be added or modified \(replaced with identical IDs\) in a graph\. |

| Methods | |
| :--- | :--- |
| [EdgeRemovals\(\)](SpatialGraph.GraphIncomingChanges_TNode_.EdgeRemovals().md 'SpatialGraph\.GraphIncomingChanges\<TNode\>\.EdgeRemovals\(\)') | IDs of the edges to be removed in a graph\. |
| [EdgeUpserts\(\)](SpatialGraph.GraphIncomingChanges_TNode_.EdgeUpserts().md 'SpatialGraph\.GraphIncomingChanges\<TNode\>\.EdgeUpserts\(\)') | Edges to be either added or replaced if it has the same ID as a node in a graph\. |
| [NodeRemovals\(\)](SpatialGraph.GraphIncomingChanges_TNode_.NodeRemovals().md 'SpatialGraph\.GraphIncomingChanges\<TNode\>\.NodeRemovals\(\)') | IDs of the nodes to be removed in a graph\. |
| [NodeUpserts\(\)](SpatialGraph.GraphIncomingChanges_TNode_.NodeUpserts().md 'SpatialGraph\.GraphIncomingChanges\<TNode\>\.NodeUpserts\(\)') | Nodes to be either added or replaced if it has the same ID as a node in a graph\. |
| [UpsertNode\(TNode\)](SpatialGraph.GraphIncomingChanges_TNode_.UpsertNode(TNode).md 'SpatialGraph\.GraphIncomingChanges\<TNode\>\.UpsertNode\(TNode\)') | Add a new node or modify one with their corresponding ID\. |
