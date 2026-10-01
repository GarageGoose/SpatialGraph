## ITrackedGraph\<TNode\> Interface

Base interface for all tracked graphs\. A graph stores nodes and edges within it, identified by their IDs\.
Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements\.

```csharp
public interface ITrackedGraph<TNode> : SpatialGraph.IReadOnlyTrackedGraph<TNode>, SpatialGraph.IReadOnlyGraph<TNode>, SpatialGraph.IGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.ITrackedGraph_TNode_.TNode'></a>

`TNode`

Type of node to be used in the graph\.

Derived  
↳ [IInterceptableTrackedGraph&lt;TNode&gt;](SpatialGraph.IInterceptableTrackedGraph_TNode_.md 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>')  
↳ [InterceptableTrackedGraph&lt;TNode&gt;](SpatialGraph.InterceptableTrackedGraph_TNode_.md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>')  
↳ [GraphPlugin&lt;TNode&gt;](SpatialGraph.Metadata.GraphPlugin_TNode_.md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>')  
↳ [TrackedGraph&lt;TNode&gt;](SpatialGraph.TrackedGraph_TNode_.md 'SpatialGraph\.TrackedGraph\<TNode\>')

Implements [SpatialGraph\.IReadOnlyTrackedGraph&lt;](SpatialGraph.IReadOnlyTrackedGraph_TNode_.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>')[TNode](SpatialGraph.ITrackedGraph_TNode_.md#SpatialGraph.ITrackedGraph_TNode_.TNode 'SpatialGraph\.ITrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyTrackedGraph_TNode_.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>'), [SpatialGraph\.IReadOnlyGraph&lt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](SpatialGraph.ITrackedGraph_TNode_.md#SpatialGraph.ITrackedGraph_TNode_.TNode 'SpatialGraph\.ITrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>'), [SpatialGraph\.IGraph&lt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')[TNode](SpatialGraph.ITrackedGraph_TNode_.md#SpatialGraph.ITrackedGraph_TNode_.TNode 'SpatialGraph\.ITrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')