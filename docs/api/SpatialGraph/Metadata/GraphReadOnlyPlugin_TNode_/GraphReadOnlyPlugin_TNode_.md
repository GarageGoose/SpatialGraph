## GraphReadOnlyPlugin<TNode> Constructors

| Overloads | |
| :--- | :--- |
| [GraphReadOnlyPlugin(IInterceptableObservableGraph&lt;TNode&gt;, ReadOnlyGraphPluginListenerForTrackedGraph)](GraphReadOnlyPlugin_TNode_.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IInterceptableObservableGraph_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForTrackedGraph) 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.GraphReadOnlyPlugin(SpatialGraph\.IInterceptableObservableGraph<TNode>, SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForTrackedGraph)') | Listens to a [IInterceptableObservableGraph&lt;TNode&gt;](../../IInterceptableObservableGraph_TNode_/index.md 'SpatialGraph\.IInterceptableObservableGraph<TNode>') when an update occurs\. |
| [GraphReadOnlyPlugin(IReadOnlyObservableGraph&lt;TNode&gt;)](GraphReadOnlyPlugin_TNode_.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IReadOnlyObservableGraph_TNode_) 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.GraphReadOnlyPlugin(SpatialGraph\.IReadOnlyObservableGraph<TNode>)') | Listens to a TrackedGraph when an update occurs\. An update is invoked when the base graph is modified by adding, modifying, and removing any of its elements\. |
| [GraphReadOnlyPlugin(GraphPlugin&lt;TNode&gt;, ReadOnlyGraphPluginListenerForPlugin)](GraphReadOnlyPlugin_TNode_.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin) 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.GraphReadOnlyPlugin(SpatialGraph\.Metadata\.GraphPlugin<TNode>, SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForPlugin)') | Listens to a [GraphPlugin&lt;TNode&gt;](../GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>') when an update occurs\. |
| [GraphReadOnlyPlugin(GraphReadOnlyPlugin&lt;TNode&gt;, ReadOnlyGraphPluginListenerForPlugin)](GraphReadOnlyPlugin_TNode_.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin) 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.GraphReadOnlyPlugin(SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>, SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForPlugin)') | Listens to a [GraphReadOnlyPlugin&lt;TNode&gt;](index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>') when an update occurs\. |

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IInterceptableObservableGraph_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForTrackedGraph)'></a>

## GraphReadOnlyPlugin(IInterceptableObservableGraph<TNode>, ReadOnlyGraphPluginListenerForTrackedGraph) Constructor

Listens to a [IInterceptableObservableGraph&lt;TNode&gt;](../../IInterceptableObservableGraph_TNode_/index.md 'SpatialGraph\.IInterceptableObservableGraph<TNode>') when an update occurs\.

```csharp
public GraphReadOnlyPlugin(SpatialGraph.IInterceptableObservableGraph<TNode> baseGraph, SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForTrackedGraph SubscribeTo);
```
#### Parameters

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IInterceptableObservableGraph_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForTrackedGraph).baseGraph'></a>

`baseGraph` [SpatialGraph\.IInterceptableObservableGraph&lt;](../../IInterceptableObservableGraph_TNode_/index.md 'SpatialGraph\.IInterceptableObservableGraph<TNode>')[TNode](index.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.TNode')[&gt;](../../IInterceptableObservableGraph_TNode_/index.md 'SpatialGraph\.IInterceptableObservableGraph<TNode>')

Graph to subscribe to\.

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IInterceptableObservableGraph_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForTrackedGraph).SubscribeTo'></a>

`SubscribeTo` [ReadOnlyGraphPluginListenerForTrackedGraph](../ReadOnlyGraphPluginListenerForTrackedGraph/index.md 'SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForTrackedGraph')

Determine which event from the TrackedGraphInterceptable to subscribe to\.

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IReadOnlyObservableGraph_TNode_)'></a>

## GraphReadOnlyPlugin(IReadOnlyObservableGraph<TNode>) Constructor

Listens to a TrackedGraph when an update occurs\. An update is invoked when the base graph is modified by adding, modifying, and removing any of its elements\.

```csharp
public GraphReadOnlyPlugin(SpatialGraph.IReadOnlyObservableGraph<TNode> baseGraph);
```
#### Parameters

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IReadOnlyObservableGraph_TNode_).baseGraph'></a>

`baseGraph` [SpatialGraph\.IReadOnlyObservableGraph&lt;](../../IReadOnlyObservableGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyObservableGraph<TNode>')[TNode](index.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.TNode')[&gt;](../../IReadOnlyObservableGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyObservableGraph<TNode>')

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin)'></a>

## GraphReadOnlyPlugin(GraphPlugin<TNode>, ReadOnlyGraphPluginListenerForPlugin) Constructor

Listens to a [GraphPlugin&lt;TNode&gt;](../GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>') when an update occurs\.

```csharp
public GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphPlugin<TNode> baseGraph, SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin SubscribeTo);
```
#### Parameters

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin).baseGraph'></a>

`baseGraph` [SpatialGraph\.Metadata\.GraphPlugin&lt;](../GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>')[TNode](index.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.TNode')[&gt;](../GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>')

Plugin to subscribe to\.

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin).SubscribeTo'></a>

`SubscribeTo` [ReadOnlyGraphPluginListenerForPlugin](../ReadOnlyGraphPluginListenerForPlugin/index.md 'SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForPlugin')

Determine which event from the baseGraph to subscribe to\.

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin)'></a>

## GraphReadOnlyPlugin(GraphReadOnlyPlugin<TNode>, ReadOnlyGraphPluginListenerForPlugin) Constructor

Listens to a [GraphReadOnlyPlugin&lt;TNode&gt;](index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>') when an update occurs\.

```csharp
public GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphReadOnlyPlugin<TNode> baseGraph, SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin SubscribeTo);
```
#### Parameters

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin).baseGraph'></a>

`baseGraph` [SpatialGraph\.Metadata\.GraphReadOnlyPlugin&lt;](index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>')[TNode](index.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.TNode')[&gt;](index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>')

Plugin to subscribe to\.

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin).SubscribeTo'></a>

`SubscribeTo` [ReadOnlyGraphPluginListenerForPlugin](../ReadOnlyGraphPluginListenerForPlugin/index.md 'SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForPlugin')

Determine which event from the baseGraph to subscribe to\.