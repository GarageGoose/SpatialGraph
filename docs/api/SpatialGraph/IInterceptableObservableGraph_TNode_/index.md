## IInterceptableObservableGraph<TNode> Interface

Base interface for all observable graphs which can modify incoming changes and track changed within it\. A graph stores [INode](../INode/index.md 'SpatialGraph\.INode') and [Edge](../Edge/index.md 'SpatialGraph\.Edge') within it, identified by their IDs\.
Observable graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements\.

```csharp
public interface IInterceptableObservableGraph<TNode> : SpatialGraph.IObservableGraph<TNode>, SpatialGraph.IReadOnlyObservableGraph<TNode>, SpatialGraph.IReadOnlyGraph<TNode>, SpatialGraph.IGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.IInterceptableObservableGraph_TNode_.TNode'></a>

`TNode`

Type of node to be used in the graph\.

Derived  
↳ [InterceptableObservableGraph&lt;TNode&gt;](../InterceptableObservableGraph_TNode_/index.md 'SpatialGraph\.InterceptableObservableGraph<TNode>')  
↳ [GraphPlugin&lt;TNode&gt;](../Metadata/GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>')

Implements [SpatialGraph\.IObservableGraph&lt;](../IObservableGraph_TNode_/index.md 'SpatialGraph\.IObservableGraph<TNode>')[TNode](index.md#SpatialGraph.IInterceptableObservableGraph_TNode_.TNode 'SpatialGraph\.IInterceptableObservableGraph<TNode>\.TNode')[&gt;](../IObservableGraph_TNode_/index.md 'SpatialGraph\.IObservableGraph<TNode>'), [SpatialGraph\.IReadOnlyObservableGraph&lt;](../IReadOnlyObservableGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyObservableGraph<TNode>')[TNode](index.md#SpatialGraph.IInterceptableObservableGraph_TNode_.TNode 'SpatialGraph\.IInterceptableObservableGraph<TNode>\.TNode')[&gt;](../IReadOnlyObservableGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyObservableGraph<TNode>'), [SpatialGraph\.IReadOnlyGraph&lt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[TNode](index.md#SpatialGraph.IInterceptableObservableGraph_TNode_.TNode 'SpatialGraph\.IInterceptableObservableGraph<TNode>\.TNode')[&gt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>'), [SpatialGraph\.IGraph&lt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[TNode](index.md#SpatialGraph.IInterceptableObservableGraph_TNode_.TNode 'SpatialGraph\.IInterceptableObservableGraph<TNode>\.TNode')[&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

| Events | |
| :--- | :--- |
| [OnGraphModificationInit](OnGraphModificationInit.md 'SpatialGraph\.IInterceptableObservableGraph<TNode>\.OnGraphModificationInit') | Event for incoming changes\. Invokes with a GraphChangeLog which contains the modifications being performed\. Modifications can be changed via the GraphChangeLog before being applied to the graph\. |
