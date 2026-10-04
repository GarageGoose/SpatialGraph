## ObservableGraph<TNode>\.ApplyChangeSet(GraphChangeSet<TNode>) Method

Perform multiple operations at once with a [GraphChangeSet&lt;TNode&gt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')\. Existing [INode](../INode/index.md 'SpatialGraph\.INode') or [Edge](../Edge/index.md 'SpatialGraph\.Edge')s with
a corresponding ID in the graph will be replaced\.
Nodes and edges can share the same ID\.

```csharp
public override void ApplyChangeSet(SpatialGraph.GraphChangeSet<TNode> mods);
```
#### Parameters

<a name='SpatialGraph.ObservableGraph_TNode_.ApplyChangeSet(SpatialGraph.GraphChangeSet_TNode_).mods'></a>

`mods` [SpatialGraph\.GraphChangeSet&lt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')[TNode](index.md#SpatialGraph.ObservableGraph_TNode_.TNode 'SpatialGraph\.ObservableGraph<TNode>\.TNode')[&gt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')

Implements [ApplyChangeSet(GraphChangeSet&lt;TNode&gt;)](../IGraph_TNode_/ApplyChangeSet(GraphChangeSet_TNode_).md 'SpatialGraph\.IGraph<TNode>\.ApplyChangeSet(SpatialGraph\.GraphChangeSet<TNode>)')