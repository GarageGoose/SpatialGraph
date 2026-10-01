## IReadOnlyTrackedGraph\<TNode\> Interface

Read only interface of a tracked graph\. Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements\.

```csharp
public interface IReadOnlyTrackedGraph<TNode> : SpatialGraph.IReadOnlyGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.IReadOnlyTrackedGraph_TNode_.TNode'></a>

`TNode`

Type of node to be used in the graph\.

Derived  
↳ [IInterceptableTrackedGraph&lt;TNode&gt;](SpatialGraph.IInterceptableTrackedGraph_TNode_.md 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>')  
↳ [InterceptableTrackedGraph&lt;TNode&gt;](SpatialGraph.InterceptableTrackedGraph_TNode_.md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>')  
↳ [ITrackedGraph&lt;TNode&gt;](SpatialGraph.ITrackedGraph_TNode_.md 'SpatialGraph\.ITrackedGraph\<TNode\>')  
↳ [GraphPlugin&lt;TNode&gt;](SpatialGraph.Metadata.GraphPlugin_TNode_.md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>')  
↳ [GraphReadOnlyPlugin&lt;TNode&gt;](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>')  
↳ [TrackedGraph&lt;TNode&gt;](SpatialGraph.TrackedGraph_TNode_.md 'SpatialGraph\.TrackedGraph\<TNode\>')

Implements [SpatialGraph\.IReadOnlyGraph&lt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](SpatialGraph.IReadOnlyTrackedGraph_TNode_.md#SpatialGraph.IReadOnlyTrackedGraph_TNode_.TNode 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')

| Events | |
| :--- | :--- |
| [OnGraphModified](SpatialGraph.IReadOnlyTrackedGraph_TNode_.OnGraphModified.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>\.OnGraphModified') | Event for changes applied\. Invokes with an IReadOnlyModificationLog, which contains the changes in the graph after it is modified\. |
