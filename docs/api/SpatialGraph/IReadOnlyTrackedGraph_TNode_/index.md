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
↳ [IInterceptableTrackedGraph&lt;TNode&gt;](../IInterceptableTrackedGraph_TNode_/index.md 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>')  
↳ [InterceptableTrackedGraph&lt;TNode&gt;](../InterceptableTrackedGraph_TNode_/index.md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>')  
↳ [ITrackedGraph&lt;TNode&gt;](../ITrackedGraph_TNode_/index.md 'SpatialGraph\.ITrackedGraph\<TNode\>')  
↳ [GraphPlugin&lt;TNode&gt;](../Metadata/GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>')  
↳ [GraphReadOnlyPlugin&lt;TNode&gt;](../Metadata/GraphReadOnlyPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>')  
↳ [TrackedGraph&lt;TNode&gt;](../TrackedGraph_TNode_/index.md 'SpatialGraph\.TrackedGraph\<TNode\>')

Implements [SpatialGraph\.IReadOnlyGraph&lt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](index.md#SpatialGraph.IReadOnlyTrackedGraph_TNode_.TNode 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>\.TNode')[&gt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')

| Events | |
| :--- | :--- |
| [OnGraphModified](OnGraphModified.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>\.OnGraphModified') | Event for changes applied\. Invokes with an IReadOnlyModificationLog, which contains the changes in the graph after it is modified\. |
