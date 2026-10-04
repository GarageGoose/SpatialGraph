## ReadOnlyGraphPluginListenerForTrackedGraph Enum

Determines an event to subscribe to from a [IObservableGraph&lt;TNode&gt;](../../IObservableGraph_TNode_/index.md 'SpatialGraph\.IObservableGraph<TNode>') in a [GraphReadOnlyPlugin&lt;TNode&gt;](../GraphReadOnlyPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>')\.

```csharp
public enum ReadOnlyGraphPluginListenerForTrackedGraph
```
### Fields

<a name='SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForTrackedGraph.OnGraphModified'></a>

`OnGraphModified` 0

Points to an event within a [IObservableGraph&lt;TNode&gt;](../../IObservableGraph_TNode_/index.md 'SpatialGraph\.IObservableGraph<TNode>') which is invoked after it is modified\.

<a name='SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForTrackedGraph.OnGraphModificationInit'></a>

`OnGraphModificationInit` 1

Points to an event within a [IObservableGraph&lt;TNode&gt;](../../IObservableGraph_TNode_/index.md 'SpatialGraph\.IObservableGraph<TNode>') which is invoked before it is modified\.