## Graph\<TNode\>\.ApplyChangeSet\(GraphChangeSet\<TNode\>\) Method

Perform multiple operations at once with a GraphChangeSet\. Existing nodes or edges with
a corresponding ID in the graph will be replaced\.
Nodes and edges can share the same ID\.

```csharp
public virtual void ApplyChangeSet(SpatialGraph.GraphChangeSet<TNode> mods);
```
#### Parameters

<a name='SpatialGraph.Graph_TNode_.ApplyChangeSet(SpatialGraph.GraphChangeSet_TNode_).mods'></a>

`mods` [SpatialGraph\.GraphChangeSet&lt;](SpatialGraph.GraphChangeSet_TNode_.md 'SpatialGraph\.GraphChangeSet\<TNode\>')[TNode](SpatialGraph.Graph_TNode_.md#SpatialGraph.Graph_TNode_.TNode 'SpatialGraph\.Graph\<TNode\>\.TNode')[&gt;](SpatialGraph.GraphChangeSet_TNode_.md 'SpatialGraph\.GraphChangeSet\<TNode\>')

Implements [ApplyChangeSet\(GraphChangeSet&lt;TNode&gt;\)](SpatialGraph.IGraph_TNode_.ApplyChangeSet(SpatialGraph.GraphChangeSet_TNode_).md 'SpatialGraph\.IGraph\<TNode\>\.ApplyChangeSet\(SpatialGraph\.GraphChangeSet\<TNode\>\)')