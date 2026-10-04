## GraphChangeLog<TNode> Class

Logs incoming changes for a [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. Stores additional data: type of modification of an
[IElement](../IElement/index.md 'SpatialGraph\.IElement') (Add, Modify, Delete), old value of an [IElement](../IElement/index.md 'SpatialGraph\.IElement') (if any), and new value of an [IElement](../IElement/index.md 'SpatialGraph\.IElement') (if any)\.

```csharp
public class GraphChangeLog<TNode> : SpatialGraph.IReadOnlyModificationLog<TNode>, SpatialGraph.GraphChangeSet<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.GraphChangeLog_TNode_.TNode'></a>

`TNode`

Node which the base graph uses\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → GraphChangeLog<TNode>

Implements [SpatialGraph\.IReadOnlyModificationLog&lt;](../IReadOnlyModificationLog_TNode_/index.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>')[TNode](index.md#SpatialGraph.GraphChangeLog_TNode_.TNode 'SpatialGraph\.GraphChangeLog<TNode>\.TNode')[&gt;](../IReadOnlyModificationLog_TNode_/index.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>'), [SpatialGraph\.GraphChangeSet&lt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')[TNode](index.md#SpatialGraph.GraphChangeLog_TNode_.TNode 'SpatialGraph\.GraphChangeLog<TNode>\.TNode')[&gt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')

| Constructors | |
| :--- | :--- |
| [GraphChangeLog(IReadOnlyGraph&lt;TNode&gt;)](GraphChangeLog_TNode_.md#SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.GraphChangeLog<TNode>\.GraphChangeLog(SpatialGraph\.IReadOnlyGraph<TNode>)') | Create a ChangeLog referencing a graph\. |
| [GraphChangeLog(IReadOnlyGraph&lt;TNode&gt;, GraphChangeSet&lt;TNode&gt;)](GraphChangeLog_TNode_.md#SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_,SpatialGraph.GraphChangeSet_TNode_) 'SpatialGraph\.GraphChangeLog<TNode>\.GraphChangeLog(SpatialGraph\.IReadOnlyGraph<TNode>, SpatialGraph\.GraphChangeSet<TNode>)') | Create a ChangeLog referencing a [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') with changes from a [GraphChangeSet&lt;TNode&gt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')\. |
| [GraphChangeLog(IReadOnlyModificationLog&lt;TNode&gt;)](GraphChangeLog_TNode_.md#SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyModificationLog_TNode_) 'SpatialGraph\.GraphChangeLog<TNode>\.GraphChangeLog(SpatialGraph\.IReadOnlyModificationLog<TNode>)') | Duplicate a ChangeLog from another ChangeLog\. |

| Properties | |
| :--- | :--- |
| [BaseGraph](BaseGraph.md 'SpatialGraph\.GraphChangeLog<TNode>\.BaseGraph') | Graph to reference the changes from\. |
| [EdgeModType](EdgeModType.md 'SpatialGraph\.GraphChangeLog<TNode>\.EdgeModType') | Dictionary for type of modifications (Add, Remove, Modify) each [Edge](../Edge/index.md 'SpatialGraph\.Edge') have\. |
| [ModifiedEdges](ModifiedEdges.md 'SpatialGraph\.GraphChangeLog<TNode>\.ModifiedEdges') | Dictionary for [Edge](../Edge/index.md 'SpatialGraph\.Edge')s which was/will be modified\. Contains the original and new value of the [Edge](../Edge/index.md 'SpatialGraph\.Edge')\. |
| [ModifiedNodes](ModifiedNodes.md 'SpatialGraph\.GraphChangeLog<TNode>\.ModifiedNodes') | Dictionary for [INode](../INode/index.md 'SpatialGraph\.INode')s which was/will be modified\. Contains the original and new value of the [INode](../INode/index.md 'SpatialGraph\.INode')\. |
| [NewEdges](NewEdges.md 'SpatialGraph\.GraphChangeLog<TNode>\.NewEdges') | Dictionary for [Edge](../Edge/index.md 'SpatialGraph\.Edge')s which was/will be added\. |
| [NewNodes](NewNodes.md 'SpatialGraph\.GraphChangeLog<TNode>\.NewNodes') | Dictionary for [INode](../INode/index.md 'SpatialGraph\.INode')s which was/will be added\. |
| [NodeModType](NodeModType.md 'SpatialGraph\.GraphChangeLog<TNode>\.NodeModType') | Dictionary for type of modifications (Add, Remove, Modify) each [INode](../INode/index.md 'SpatialGraph\.INode') have\. |
| [RemovedEdges](RemovedEdges.md 'SpatialGraph\.GraphChangeLog<TNode>\.RemovedEdges') | Dictionary for [Edge](../Edge/index.md 'SpatialGraph\.Edge')s which was/will be removed\. Contains its original value\. |
| [RemovedNodes](RemovedNodes.md 'SpatialGraph\.GraphChangeLog<TNode>\.RemovedNodes') | Dictionary for [INode](../INode/index.md 'SpatialGraph\.INode')s which was/will be removed\. Contains its original value\. |

| Methods | |
| :--- | :--- |
| [EdgeRemoval(uint)](EdgeRemoval(uint).md 'SpatialGraph\.GraphChangeLog<TNode>\.EdgeRemoval(uint)') | Add a log for the removal of an [Edge](../Edge/index.md 'SpatialGraph\.Edge') in the [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') using its corresponding ID\. This will not remove it from the base [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |
| [EdgeRemovals()](EdgeRemovals().md 'SpatialGraph\.GraphChangeLog<TNode>\.EdgeRemovals()') | Log of IDs of [Edge](../Edge/index.md 'SpatialGraph\.Edge')s to be removed/has been removed in the graph\. |
| [EdgeUpsert(Edge)](EdgeUpsert(Edge).md 'SpatialGraph\.GraphChangeLog<TNode>\.EdgeUpsert(SpatialGraph\.Edge)') | Add a log for a new [Edge](../Edge/index.md 'SpatialGraph\.Edge') or modify an [Edge](../Edge/index.md 'SpatialGraph\.Edge') with its corresponding ID\. This will not add it to the base [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |
| [EdgeUpserts()](EdgeUpserts().md 'SpatialGraph\.GraphChangeLog<TNode>\.EdgeUpserts()') | Log of [Edge](../Edge/index.md 'SpatialGraph\.Edge')s to be upserted/has been upserted in the graph\. |
| [LogChangeSet(GraphChangeSet&lt;TNode&gt;)](LogChangeSet(GraphChangeSet_TNode_).md 'SpatialGraph\.GraphChangeLog<TNode>\.LogChangeSet(SpatialGraph\.GraphChangeSet<TNode>)') | Log changes from a [GraphChangeSet&lt;TNode&gt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')\. |
| [NodeRemoval(uint)](NodeRemoval(uint).md 'SpatialGraph\.GraphChangeLog<TNode>\.NodeRemoval(uint)') | Add a log for the removal of a [INode](../INode/index.md 'SpatialGraph\.INode') in the [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') using its corresponding ID\. This will not remove it from the base [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |
| [NodeRemovals()](NodeRemovals().md 'SpatialGraph\.GraphChangeLog<TNode>\.NodeRemovals()') | Log of IDs of [INode](../INode/index.md 'SpatialGraph\.INode')s to be removed/has been removed in the graph\. |
| [NodeUpsert(TNode)](NodeUpsert(TNode).md 'SpatialGraph\.GraphChangeLog<TNode>\.NodeUpsert(TNode)') | Add a log for a new [INode](../INode/index.md 'SpatialGraph\.INode') or modify a [INode](../INode/index.md 'SpatialGraph\.INode') with its corresponding ID\. This will not add it to the base [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |
| [NodeUpserts()](NodeUpserts().md 'SpatialGraph\.GraphChangeLog<TNode>\.NodeUpserts()') | Log of [INode](../INode/index.md 'SpatialGraph\.INode')s to be upserted/has been upserted in the graph\. |
| [UnlogEdge(uint)](UnlogEdge(uint).md 'SpatialGraph\.GraphChangeLog<TNode>\.UnlogEdge(uint)') | Remove the log of a change in an [Edge](../Edge/index.md 'SpatialGraph\.Edge')\. |
| [UnlogNode(uint)](UnlogNode(uint).md 'SpatialGraph\.GraphChangeLog<TNode>\.UnlogNode(uint)') | Remove the log of a change in a [INode](../INode/index.md 'SpatialGraph\.INode')\. |
