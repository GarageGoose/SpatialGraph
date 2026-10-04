## GraphIncomingChanges<TNode> Class

Stores incoming changes for a graph\.

```csharp
public class GraphIncomingChanges<TNode> : SpatialGraph.IReadOnlyGraphIncomingChanges<TNode>, SpatialGraph.GraphChangeSet<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.GraphIncomingChanges_TNode_.TNode'></a>

`TNode`

Type of node used in the graph\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → GraphIncomingChanges<TNode>

Implements [SpatialGraph\.IReadOnlyGraphIncomingChanges&lt;](../IReadOnlyGraphIncomingChanges_TNode_/index.md 'SpatialGraph\.IReadOnlyGraphIncomingChanges<TNode>')[TNode](index.md#SpatialGraph.GraphIncomingChanges_TNode_.TNode 'SpatialGraph\.GraphIncomingChanges<TNode>\.TNode')[&gt;](../IReadOnlyGraphIncomingChanges_TNode_/index.md 'SpatialGraph\.IReadOnlyGraphIncomingChanges<TNode>'), [SpatialGraph\.GraphChangeSet&lt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')[TNode](index.md#SpatialGraph.GraphIncomingChanges_TNode_.TNode 'SpatialGraph\.GraphIncomingChanges<TNode>\.TNode')[&gt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')

| Constructors | |
| :--- | :--- |
| [GraphIncomingChanges()](GraphIncomingChanges_TNode_.md#SpatialGraph.GraphIncomingChanges_TNode_.GraphIncomingChanges() 'SpatialGraph\.GraphIncomingChanges<TNode>\.GraphIncomingChanges()') | Create a new empty instance\. |
| [GraphIncomingChanges(IReadOnlyGraphIncomingChanges&lt;TNode&gt;)](GraphIncomingChanges_TNode_.md#SpatialGraph.GraphIncomingChanges_TNode_.GraphIncomingChanges(SpatialGraph.IReadOnlyGraphIncomingChanges_TNode_) 'SpatialGraph\.GraphIncomingChanges<TNode>\.GraphIncomingChanges(SpatialGraph\.IReadOnlyGraphIncomingChanges<TNode>)') | |

| Properties | |
| :--- | :--- |
| [EdgesForRemoval](EdgesForRemoval.md 'SpatialGraph\.GraphIncomingChanges<TNode>\.EdgesForRemoval') | Edges to be removed in a graph\. |
| [EdgesForUpsert](EdgesForUpsert.md 'SpatialGraph\.GraphIncomingChanges<TNode>\.EdgesForUpsert') | Edges to be added or modified (replaced with identical IDs) in a graph\. |
| [NodesForRemoval](NodesForRemoval.md 'SpatialGraph\.GraphIncomingChanges<TNode>\.NodesForRemoval') | Nodes to be removed in a graph\. |
| [NodesForUpsert](NodesForUpsert.md 'SpatialGraph\.GraphIncomingChanges<TNode>\.NodesForUpsert') | Nodes to be added or modified (replaced with identical IDs) in a graph\. |

| Methods | |
| :--- | :--- |
| [EdgeRemovals()](EdgeRemovals().md 'SpatialGraph\.GraphIncomingChanges<TNode>\.EdgeRemovals()') | IDs of the [Edge](../Edge/index.md 'SpatialGraph\.Edge')s to be removed in a graph\. |
| [EdgeUpserts()](EdgeUpserts().md 'SpatialGraph\.GraphIncomingChanges<TNode>\.EdgeUpserts()') | [Edge](../Edge/index.md 'SpatialGraph\.Edge')s to be either added or modified if it has the same ID as an [Edge](../Edge/index.md 'SpatialGraph\.Edge') in a graph\. |
| [Intersect(GraphIncomingChanges&lt;TNode&gt;)](Intersect(GraphIncomingChanges_TNode_).md 'SpatialGraph\.GraphIncomingChanges<TNode>\.Intersect(SpatialGraph\.GraphIncomingChanges<TNode>)') | Intersect between two GraphIncomingChanges\. |
| [NodeRemovals()](NodeRemovals().md 'SpatialGraph\.GraphIncomingChanges<TNode>\.NodeRemovals()') | IDs of the [INode](../INode/index.md 'SpatialGraph\.INode')s to be removed in a graph\. |
| [NodeUpserts()](NodeUpserts().md 'SpatialGraph\.GraphIncomingChanges<TNode>\.NodeUpserts()') | [INode](../INode/index.md 'SpatialGraph\.INode')s to be either added or modified if it has the same ID as a [INode](../INode/index.md 'SpatialGraph\.INode') in a graph\. |
| [RemoveEdge(uint)](RemoveEdge(uint).md 'SpatialGraph\.GraphIncomingChanges<TNode>\.RemoveEdge(uint)') | Remove pending changes to a node\. |
| [RemoveEdgeChange(uint)](RemoveEdgeChange(uint).md 'SpatialGraph\.GraphIncomingChanges<TNode>\.RemoveEdgeChange(uint)') | Remove pending changes to an edge\. |
| [RemoveNode(uint)](RemoveNode(uint).md 'SpatialGraph\.GraphIncomingChanges<TNode>\.RemoveNode(uint)') | Remove a node with its ID\. |
| [RemoveNodeChange(uint)](RemoveNodeChange(uint).md 'SpatialGraph\.GraphIncomingChanges<TNode>\.RemoveNodeChange(uint)') | Remove pending changes to a node\. |
| [Union(GraphIncomingChanges&lt;TNode&gt;)](Union(GraphIncomingChanges_TNode_).md 'SpatialGraph\.GraphIncomingChanges<TNode>\.Union(SpatialGraph\.GraphIncomingChanges<TNode>)') | Union between two GraphIncomingChanges\. |
| [UpsertEdge(Edge)](UpsertEdge(Edge).md 'SpatialGraph\.GraphIncomingChanges<TNode>\.UpsertEdge(SpatialGraph\.Edge)') | Add a new edge or modify one with their corresponding ID\. |
| [UpsertNode(TNode)](UpsertNode(TNode).md 'SpatialGraph\.GraphIncomingChanges<TNode>\.UpsertNode(TNode)') | Add a new node or modify one with their corresponding ID\. |
