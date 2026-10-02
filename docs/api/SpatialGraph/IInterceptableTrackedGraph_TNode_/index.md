## IInterceptableTrackedGraph<TNode> Interface

Base interface for all tracked graphs which can modify incoming changes\. A graph stores nodes and edges within it, identified by their IDs\.
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
↳ [InterceptableTrackedGraph&lt;TNode&gt;](../InterceptableTrackedGraph_TNode_/index.md 'SpatialGraph\.InterceptableTrackedGraph<TNode>')  
↳ [GraphPlugin&lt;TNode&gt;](../Metadata/GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>')

Implements [SpatialGraph\.ITrackedGraph&lt;](../ITrackedGraph_TNode_/index.md 'SpatialGraph\.ITrackedGraph<TNode>')[TNode](index.md#SpatialGraph.IInterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.IInterceptableTrackedGraph<TNode>\.TNode')[&gt;](../ITrackedGraph_TNode_/index.md 'SpatialGraph\.ITrackedGraph<TNode>'), [SpatialGraph\.IReadOnlyTrackedGraph&lt;](../IReadOnlyTrackedGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyTrackedGraph<TNode>')[TNode](index.md#SpatialGraph.IInterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.IInterceptableTrackedGraph<TNode>\.TNode')[&gt;](../IReadOnlyTrackedGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyTrackedGraph<TNode>'), [SpatialGraph\.IReadOnlyGraph&lt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[TNode](index.md#SpatialGraph.IInterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.IInterceptableTrackedGraph<TNode>\.TNode')[&gt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>'), [SpatialGraph\.IGraph&lt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[TNode](index.md#SpatialGraph.IInterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.IInterceptableTrackedGraph<TNode>\.TNode')[&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

| Events | |
| :--- | :--- |
| [OnGraphModificationInit](OnGraphModificationInit.md 'SpatialGraph\.IInterceptableTrackedGraph<TNode>\.OnGraphModificationInit') | Event for incoming changes\. Invokes with a GraphChangeLog which contains the modifications being performed\. Modifications can be changed via the GraphChangeLog before being applied to the graph\. |
