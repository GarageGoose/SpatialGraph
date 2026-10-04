## IReadOnlyObservableGraph<TNode> Interface

Read only interface of [IObservableGraph&lt;TNode&gt;](../IObservableGraph_TNode_/index.md 'SpatialGraph\.IObservableGraph<TNode>')\. Tracked graphs returns read only
modification logs when it is modified by adding, modifying, and removing any of its elements\.

```csharp
public interface IReadOnlyObservableGraph<TNode> : SpatialGraph.IReadOnlyGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.IReadOnlyObservableGraph_TNode_.TNode'></a>

`TNode`

Type of node to be used in the graph\.

Derived  
↳ [IInterceptableObservableGraph&lt;TNode&gt;](../IInterceptableObservableGraph_TNode_/index.md 'SpatialGraph\.IInterceptableObservableGraph<TNode>')  
↳ [InterceptableObservableGraph&lt;TNode&gt;](../InterceptableObservableGraph_TNode_/index.md 'SpatialGraph\.InterceptableObservableGraph<TNode>')  
↳ [IObservableGraph&lt;TNode&gt;](../IObservableGraph_TNode_/index.md 'SpatialGraph\.IObservableGraph<TNode>')  
↳ [GraphPlugin&lt;TNode&gt;](../Metadata/GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>')  
↳ [GraphReadOnlyPlugin&lt;TNode&gt;](../Metadata/GraphReadOnlyPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>')  
↳ [ObservableGraph&lt;TNode&gt;](../ObservableGraph_TNode_/index.md 'SpatialGraph\.ObservableGraph<TNode>')

Implements [SpatialGraph\.IReadOnlyGraph&lt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[TNode](index.md#SpatialGraph.IReadOnlyObservableGraph_TNode_.TNode 'SpatialGraph\.IReadOnlyObservableGraph<TNode>\.TNode')[&gt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')

| Events | |
| :--- | :--- |
| [OnGraphModified](OnGraphModified.md 'SpatialGraph\.IReadOnlyObservableGraph<TNode>\.OnGraphModified') | Event for changes applied\. Invokes with an IReadOnlyModificationLog, which contains the changes in the graph after it is modified\. |
