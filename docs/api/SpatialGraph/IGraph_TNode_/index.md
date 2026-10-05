## IGraph<TNode> Interface

Base interface for all graphs\. A graph stores [INode](../INode/index.md 'SpatialGraph\.INode') and [Edge](../Edge/index.md 'SpatialGraph\.Edge') within it, identified by their IDs\.
Nodes and edges can share the same ID\.

```csharp
public interface IGraph<TNode> : SpatialGraph.IReadOnlyGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.IGraph_TNode_.TNode'></a>

`TNode`

Type of node to be used in the graph\.

Derived  
↳ [Graph&lt;TNode&gt;](../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')  
↳ [IInterceptableObservableGraph&lt;TNode&gt;](../IInterceptableObservableGraph_TNode_/index.md 'SpatialGraph\.IInterceptableObservableGraph<TNode>')  
↳ [InterceptableObservableGraph&lt;TNode&gt;](../InterceptableObservableGraph_TNode_/index.md 'SpatialGraph\.InterceptableObservableGraph<TNode>')  
↳ [IObservableGraph&lt;TNode&gt;](../IObservableGraph_TNode_/index.md 'SpatialGraph\.IObservableGraph<TNode>')  
↳ [GraphPlugin&lt;TNode&gt;](../Metadata/GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>')  
↳ [ObservableGraph&lt;TNode&gt;](../ObservableGraph_TNode_/index.md 'SpatialGraph\.ObservableGraph<TNode>')

Implements [SpatialGraph\.IReadOnlyGraph&lt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[TNode](index.md#SpatialGraph.IGraph_TNode_.TNode 'SpatialGraph\.IGraph<TNode>\.TNode')[&gt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')

| Methods | |
| :--- | :--- |
| [ApplyChangeSet(GraphChangeSet&lt;TNode&gt;)](ApplyChangeSet(GraphChangeSet_TNode_).md 'SpatialGraph\.IGraph<TNode>\.ApplyChangeSet(SpatialGraph\.GraphChangeSet<TNode>)') | Perform multiple operations at once with a [GraphChangeSet&lt;TNode&gt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')\. Existing [INode](../INode/index.md 'SpatialGraph\.INode') or [Edge](../Edge/index.md 'SpatialGraph\.Edge')s with a corresponding ID in the graph will be replaced\. |
| [RemoveEdge(uint)](RemoveEdge(uint).md 'SpatialGraph\.IGraph<TNode>\.RemoveEdge(uint)') | Remove an [Edge](../Edge/index.md 'SpatialGraph\.Edge') in the graph using its corresponding ID\. Nodes and edges can share the same ID, this will remove only the edge with the corresponding ID\. |
| [RemoveNode(uint)](RemoveNode(uint).md 'SpatialGraph\.IGraph<TNode>\.RemoveNode(uint)') | Remove a [INode](../INode/index.md 'SpatialGraph\.INode') in the graph using its correspinding ID\. Connecting [Edge](../Edge/index.md 'SpatialGraph\.Edge') referencing this node will not be removed\. Nodes and edges can share the same ID, this will remove only the node with the corresponding ID\. |
| [UpsertEdge(Edge)](UpsertEdge(Edge).md 'SpatialGraph\.IGraph<TNode>\.UpsertEdge(SpatialGraph\.Edge)') | Add a new [Edge](../Edge/index.md 'SpatialGraph\.Edge') or modify an [Edge](../Edge/index.md 'SpatialGraph\.Edge') with its corresponding ID\. |
| [UpsertNode(TNode)](UpsertNode(TNode).md 'SpatialGraph\.IGraph<TNode>\.UpsertNode(TNode)') | Add a new [INode](../INode/index.md 'SpatialGraph\.INode') or modify one with their corresponding ID\. |
