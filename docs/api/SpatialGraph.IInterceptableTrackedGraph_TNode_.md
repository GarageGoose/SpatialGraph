## IInterceptableTrackedGraph\<TNode\> Interface

Base interface for all tracked graphs which can modifiy incoming changes\. A graph stores nodes and edges within it, identified by their IDs\.
Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements\.

```csharp
public interface IInterceptableTrackedGraph<TNode> : SpatialGraph.ITrackedGraph<TNode>, SpatialGraph.IReadOnlyTrackedGraph<TNode>, SpatialGraph.IReadOnlyGraph<TNode>, SpatialGraph.IGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.IInterceptableTrackedGraph_TNode_.TNode'></a>

`TNode`

Type of node to be used in the graph\.

Derived  
↳ [InterceptableTrackedGraph&lt;TNode&gt;](SpatialGraph.InterceptableTrackedGraph_TNode_.md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>')  
↳ [GraphPlugin&lt;TNode&gt;](SpatialGraph.Metadata.GraphPlugin_TNode_.md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>')

Implements [SpatialGraph\.ITrackedGraph&lt;](SpatialGraph.ITrackedGraph_TNode_.md 'SpatialGraph\.ITrackedGraph\<TNode\>')[TNode](SpatialGraph.IInterceptableTrackedGraph_TNode_.md#SpatialGraph.IInterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.ITrackedGraph_TNode_.md 'SpatialGraph\.ITrackedGraph\<TNode\>'), [SpatialGraph\.IReadOnlyTrackedGraph&lt;](SpatialGraph.IReadOnlyTrackedGraph_TNode_.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>')[TNode](SpatialGraph.IInterceptableTrackedGraph_TNode_.md#SpatialGraph.IInterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyTrackedGraph_TNode_.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>'), [SpatialGraph\.IReadOnlyGraph&lt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](SpatialGraph.IInterceptableTrackedGraph_TNode_.md#SpatialGraph.IInterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>'), [SpatialGraph\.IGraph&lt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')[TNode](SpatialGraph.IInterceptableTrackedGraph_TNode_.md#SpatialGraph.IInterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')

| Events | |
| :--- | :--- |
| [OnGraphModificationInit](SpatialGraph.IInterceptableTrackedGraph_TNode_.OnGraphModificationInit.md 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>\.OnGraphModificationInit') | Event for incoming changes\. Invokes with a GraphChangeLog which contains the modifications being performed\. Modifications can be changed via the GraphChangeLog before being applied to the graph\. |
