## IGraph\<TNode\>\.ApplyChangeSet\(GraphChangeSet\<TNode\>\) Method

Perform multiple operations at once with a GraphChangeSet\. Existing nodes or edges with
a corresponding ID in the graph will be replaced\.
Nodes and edges can share the same ID\.

```csharp
void ApplyChangeSet(SpatialGraph.GraphChangeSet<TNode> modifications);
```
#### Parameters

<a name='SpatialGraph.IGraph_TNode_.ApplyChangeSet(SpatialGraph.GraphChangeSet_TNode_).modifications'></a>

`modifications` [SpatialGraph\.GraphChangeSet&lt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet\<TNode\>')[TNode](index.md#SpatialGraph.IGraph_TNode_.TNode 'SpatialGraph\.IGraph\<TNode\>\.TNode')[&gt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet\<TNode\>')

Contains operations to perform\.