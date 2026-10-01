## IGraph\<TNode\> Interface

Base interface for all graphs\. A graph stores nodes and edges within it, identified by their IDs\.
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
↳ [Graph&lt;TNode&gt;](../Graph_TNode_/index.md 'SpatialGraph\.Graph\<TNode\>')  
↳ [IInterceptableTrackedGraph&lt;TNode&gt;](../IInterceptableTrackedGraph_TNode_/index.md 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>')  
↳ [InterceptableTrackedGraph&lt;TNode&gt;](../InterceptableTrackedGraph_TNode_/index.md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>')  
↳ [ITrackedGraph&lt;TNode&gt;](../ITrackedGraph_TNode_/index.md 'SpatialGraph\.ITrackedGraph\<TNode\>')  
↳ [GraphPlugin&lt;TNode&gt;](../Metadata/GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>')  
↳ [TrackedGraph&lt;TNode&gt;](../TrackedGraph_TNode_/index.md 'SpatialGraph\.TrackedGraph\<TNode\>')

Implements [SpatialGraph\.IReadOnlyGraph&lt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](index.md#SpatialGraph.IGraph_TNode_.TNode 'SpatialGraph\.IGraph\<TNode\>\.TNode')[&gt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')

| Methods | |
| :--- | :--- |
| [ApplyChangeSet\(GraphChangeSet&lt;TNode&gt;\)](ApplyChangeSet(GraphChangeSet_TNode_).md 'SpatialGraph\.IGraph\<TNode\>\.ApplyChangeSet\(SpatialGraph\.GraphChangeSet\<TNode\>\)') | Perform multiple operations at once with a GraphChangeSet\. Existing nodes or edges with a corresponding ID in the graph will be replaced\. Nodes and edges can share the same ID\. |
| [RemoveEdge\(uint\)](RemoveEdge(uint).md 'SpatialGraph\.IGraph\<TNode\>\.RemoveEdge\(uint\)') | Remove an edge in the graph using its corresponding ID\. Nodes and edges can share the same ID, this will remove only the edge with the corresponding ID\. |
| [RemoveNode\(uint\)](RemoveNode(uint).md 'SpatialGraph\.IGraph\<TNode\>\.RemoveNode\(uint\)') | Remove a node in the graph using its correspinding ID\. Connecting edges referencing this node will not be removed\. Nodes and edges can share the same ID, this will remove only the node with the corresponding ID\. |
| [UpsertEdge\(Edge\)](UpsertEdge(Edge).md 'SpatialGraph\.IGraph\<TNode\>\.UpsertEdge\(SpatialGraph\.Edge\)') | Add a new edge or modify an edge with its corresponding ID\. |
| [UpsertNode\(TNode\)](UpsertNode(TNode).md 'SpatialGraph\.IGraph\<TNode\>\.UpsertNode\(TNode\)') | Add a new node or modify one with their corresponding ID\. Nodes and edges can share the same ID\. |
