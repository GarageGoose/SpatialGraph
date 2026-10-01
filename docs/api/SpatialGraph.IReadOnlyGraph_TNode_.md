## IReadOnlyGraph\<TNode\> Interface

Read only interface of a graph\. A graph stores nodes and edges within it, identified by their IDs\.

```csharp
public interface IReadOnlyGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.IReadOnlyGraph_TNode_.TNode'></a>

`TNode`

Type of node to be used in the graph\.

Derived  
↳ [Graph&lt;TNode&gt;](SpatialGraph.Graph_TNode_.md 'SpatialGraph\.Graph\<TNode\>')  
↳ [IGraph&lt;TNode&gt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')  
↳ [IInterceptableTrackedGraph&lt;TNode&gt;](SpatialGraph.IInterceptableTrackedGraph_TNode_.md 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>')  
↳ [InterceptableTrackedGraph&lt;TNode&gt;](SpatialGraph.InterceptableTrackedGraph_TNode_.md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>')  
↳ [IReadOnlyTrackedGraph&lt;TNode&gt;](SpatialGraph.IReadOnlyTrackedGraph_TNode_.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>')  
↳ [ITrackedGraph&lt;TNode&gt;](SpatialGraph.ITrackedGraph_TNode_.md 'SpatialGraph\.ITrackedGraph\<TNode\>')  
↳ [GraphPlugin&lt;TNode&gt;](SpatialGraph.Metadata.GraphPlugin_TNode_.md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>')  
↳ [GraphReadOnlyPlugin&lt;TNode&gt;](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>')  
↳ [TrackedGraph&lt;TNode&gt;](SpatialGraph.TrackedGraph_TNode_.md 'SpatialGraph\.TrackedGraph\<TNode\>')

| Properties | |
| :--- | :--- |
| [Edges](SpatialGraph.IReadOnlyGraph_TNode_.Edges.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>\.Edges') | Edges stored in this graph\. Elements such as edges are referenced be their unique ID\. Nodes and edges can share the same ID\. |
| [Nodes](SpatialGraph.IReadOnlyGraph_TNode_.Nodes.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>\.Nodes') | Nodes stored in this graph\. Elements such as nodes are referenced be their unique ID\. Nodes and edges can share the same ID\. |

| Methods | |
| :--- | :--- |
| [GenerateID\(\)](SpatialGraph.IReadOnlyGraph_TNode_.GenerateID().md 'SpatialGraph\.IReadOnlyGraph\<TNode\>\.GenerateID\(\)') | Generate unique ID for the elements of the graph\. Nodes and edges can share the same ID\. |
