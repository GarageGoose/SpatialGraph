## GraphPlugin\<TNode\>\.ApplyChangeSet\(GraphChangeSet\<TNode\>\) Method

Perform multiple operations at once with a GraphChangeSet\. Existing nodes or edges with
a corresponding ID in the graph will be replaced\.
Nodes and edges can share the same ID\.

```csharp
public void ApplyChangeSet(SpatialGraph.GraphChangeSet<TNode> modifications);
```
#### Parameters

<a name='SpatialGraph.Metadata.GraphPlugin_TNode_.ApplyChangeSet(SpatialGraph.GraphChangeSet_TNode_).modifications'></a>

`modifications` [SpatialGraph\.GraphChangeSet&lt;](SpatialGraph.GraphChangeSet_TNode_.md 'SpatialGraph\.GraphChangeSet\<TNode\>')[TNode](SpatialGraph.Metadata.GraphPlugin_TNode_.md#SpatialGraph.Metadata.GraphPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.TNode')[&gt;](SpatialGraph.GraphChangeSet_TNode_.md 'SpatialGraph\.GraphChangeSet\<TNode\>')

Contains operations to perform\.

Implements [ApplyChangeSet\(GraphChangeSet&lt;TNode&gt;\)](SpatialGraph.IGraph_TNode_.ApplyChangeSet(SpatialGraph.GraphChangeSet_TNode_).md 'SpatialGraph\.IGraph\<TNode\>\.ApplyChangeSet\(SpatialGraph\.GraphChangeSet\<TNode\>\)')