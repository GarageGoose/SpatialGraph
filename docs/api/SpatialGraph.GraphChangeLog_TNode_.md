## GraphChangeLog\<TNode\> Class

Logs incoming changes for a graph\. Stores additional data: type of modification of an element \(Add, Modify, Delete\), old value of an element \(if any\), and new value of an element \(if any\)\.

```csharp
public class GraphChangeLog<TNode> : SpatialGraph.IReadOnlyModificationLog<TNode>, SpatialGraph.GraphChangeSet<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.GraphChangeLog_TNode_.TNode'></a>

`TNode`

Node which the base graph uses\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → GraphChangeLog\<TNode\>

Implements [SpatialGraph\.IReadOnlyModificationLog&lt;](SpatialGraph.IReadOnlyModificationLog_TNode_.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>')[TNode](SpatialGraph.GraphChangeLog_TNode_.md#SpatialGraph.GraphChangeLog_TNode_.TNode 'SpatialGraph\.GraphChangeLog\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyModificationLog_TNode_.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>'), [SpatialGraph\.GraphChangeSet&lt;](SpatialGraph.GraphChangeSet_TNode_.md 'SpatialGraph\.GraphChangeSet\<TNode\>')[TNode](SpatialGraph.GraphChangeLog_TNode_.md#SpatialGraph.GraphChangeLog_TNode_.TNode 'SpatialGraph\.GraphChangeLog\<TNode\>\.TNode')[&gt;](SpatialGraph.GraphChangeSet_TNode_.md 'SpatialGraph\.GraphChangeSet\<TNode\>')

| Constructors | |
| :--- | :--- |
| [GraphChangeLog\(IReadOnlyGraph&lt;TNode&gt;\)](SpatialGraph.GraphChangeLog_TNode_.#ctor.md#SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.GraphChangeLog\<TNode\>\.GraphChangeLog\(SpatialGraph\.IReadOnlyGraph\<TNode\>\)') | Create a ChangeLog referencing a graph\. |
| [GraphChangeLog\(IReadOnlyGraph&lt;TNode&gt;, GraphChangeSet&lt;TNode&gt;\)](SpatialGraph.GraphChangeLog_TNode_.#ctor.md#SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_,SpatialGraph.GraphChangeSet_TNode_) 'SpatialGraph\.GraphChangeLog\<TNode\>\.GraphChangeLog\(SpatialGraph\.IReadOnlyGraph\<TNode\>, SpatialGraph\.GraphChangeSet\<TNode\>\)') | Create a ChangeLog referencing a graph with changes from a ChangeSet\. |
| [GraphChangeLog\(IReadOnlyModificationLog&lt;TNode&gt;\)](SpatialGraph.GraphChangeLog_TNode_.#ctor.md#SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyModificationLog_TNode_) 'SpatialGraph\.GraphChangeLog\<TNode\>\.GraphChangeLog\(SpatialGraph\.IReadOnlyModificationLog\<TNode\>\)') | Duplicate a ChangeLog from another ChangeLog\. |

| Properties | |
| :--- | :--- |
| [BaseGraph](SpatialGraph.GraphChangeLog_TNode_.BaseGraph.md 'SpatialGraph\.GraphChangeLog\<TNode\>\.BaseGraph') | Graph to reference the changes from\. |
| [EdgeModType](SpatialGraph.GraphChangeLog_TNode_.EdgeModType.md 'SpatialGraph\.GraphChangeLog\<TNode\>\.EdgeModType') | Dictionary for type of modifications \(Add, Remove, Modify\) each edge have\. |
| [ModifiedEdges](SpatialGraph.GraphChangeLog_TNode_.ModifiedEdges.md 'SpatialGraph\.GraphChangeLog\<TNode\>\.ModifiedEdges') | Dictionary for edges which was/will be modified\. Contains the original and new value of the edge\. |
| [ModifiedNodes](SpatialGraph.GraphChangeLog_TNode_.ModifiedNodes.md 'SpatialGraph\.GraphChangeLog\<TNode\>\.ModifiedNodes') | Dictionary for nodes which was/will be modified\. Contains the original and new value of the node\. |
| [NewEdges](SpatialGraph.GraphChangeLog_TNode_.NewEdges.md 'SpatialGraph\.GraphChangeLog\<TNode\>\.NewEdges') | Dictionary for edges which was/will be added\. |
| [NewNodes](SpatialGraph.GraphChangeLog_TNode_.NewNodes.md 'SpatialGraph\.GraphChangeLog\<TNode\>\.NewNodes') | Dictionary for nodes which was/will be added\. |
| [NodeModType](SpatialGraph.GraphChangeLog_TNode_.NodeModType.md 'SpatialGraph\.GraphChangeLog\<TNode\>\.NodeModType') | Dictionary for type of modifications \(Add, Remove, Modify\) each node have\. |
| [RemovedEdges](SpatialGraph.GraphChangeLog_TNode_.RemovedEdges.md 'SpatialGraph\.GraphChangeLog\<TNode\>\.RemovedEdges') | Dictionary for edges which was/will be removed\. Contains its original value\. |
| [RemovedNodes](SpatialGraph.GraphChangeLog_TNode_.RemovedNodes.md 'SpatialGraph\.GraphChangeLog\<TNode\>\.RemovedNodes') | Dictionary for nodes which was/will be removed\. Contains its original value\. |

| Methods | |
| :--- | :--- |
| [EdgeRemoval\(uint\)](SpatialGraph.GraphChangeLog_TNode_.EdgeRemoval(uint).md 'SpatialGraph\.GraphChangeLog\<TNode\>\.EdgeRemoval\(uint\)') | Add a log for the removal of an edge in the graph using its corresponding ID\. This will not remove it from the base graph\. |
| [EdgeRemovals\(\)](SpatialGraph.GraphChangeLog_TNode_.EdgeRemovals().md 'SpatialGraph\.GraphChangeLog\<TNode\>\.EdgeRemovals\(\)') | Log of edges to be removed/has been removed in the graph\. |
| [EdgeUpsert\(Edge\)](SpatialGraph.GraphChangeLog_TNode_.EdgeUpsert(SpatialGraph.Edge).md 'SpatialGraph\.GraphChangeLog\<TNode\>\.EdgeUpsert\(SpatialGraph\.Edge\)') | Add a log for a new edge or modify an edge with its corresponding ID\. This will not add it to the base graph\. |
| [EdgeUpserts\(\)](SpatialGraph.GraphChangeLog_TNode_.EdgeUpserts().md 'SpatialGraph\.GraphChangeLog\<TNode\>\.EdgeUpserts\(\)') | Log of edges to be upserted/has been upserted in the graph\. |
| [LogChangeSet\(GraphChangeSet&lt;TNode&gt;\)](SpatialGraph.GraphChangeLog_TNode_.LogChangeSet(SpatialGraph.GraphChangeSet_TNode_).md 'SpatialGraph\.GraphChangeLog\<TNode\>\.LogChangeSet\(SpatialGraph\.GraphChangeSet\<TNode\>\)') | Log changes from a change set\. |
| [NodeRemoval\(uint\)](SpatialGraph.GraphChangeLog_TNode_.NodeRemoval(uint).md 'SpatialGraph\.GraphChangeLog\<TNode\>\.NodeRemoval\(uint\)') | Add a log for the removal of a node in the graph using its corresponding ID\. This will not remove it from the base graph\. |
| [NodeRemovals\(\)](SpatialGraph.GraphChangeLog_TNode_.NodeRemovals().md 'SpatialGraph\.GraphChangeLog\<TNode\>\.NodeRemovals\(\)') | Log of nodes to be removed/has been removed in the graph\. |
| [NodeUpsert\(TNode\)](SpatialGraph.GraphChangeLog_TNode_.NodeUpsert(TNode).md 'SpatialGraph\.GraphChangeLog\<TNode\>\.NodeUpsert\(TNode\)') | Add a log for new node or modify a node with its corresponding ID\. This will not add it to the base graph\. |
| [NodeUpserts\(\)](SpatialGraph.GraphChangeLog_TNode_.NodeUpserts().md 'SpatialGraph\.GraphChangeLog\<TNode\>\.NodeUpserts\(\)') | Log of nodes to be upserted/has been upserted in the graph\. |
| [UnlogEdge\(uint\)](SpatialGraph.GraphChangeLog_TNode_.UnlogEdge(uint).md 'SpatialGraph\.GraphChangeLog\<TNode\>\.UnlogEdge\(uint\)') | Remove the log of a change in an edge\. |
| [UnlogNode\(uint\)](SpatialGraph.GraphChangeLog_TNode_.UnlogNode(uint).md 'SpatialGraph\.GraphChangeLog\<TNode\>\.UnlogNode\(uint\)') | |
