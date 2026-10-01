## GraphReadOnlyPlugin\<TNode\> Constructors

| Overloads | |
| :--- | :--- |
| [GraphReadOnlyPlugin\(IInterceptableTrackedGraph&lt;TNode&gt;, ReadOnlyGraphPluginListenerForTrackedGraph\)](GraphReadOnlyPlugin_TNode_.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IInterceptableTrackedGraph_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForTrackedGraph) 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.GraphReadOnlyPlugin\(SpatialGraph\.IInterceptableTrackedGraph\<TNode\>, SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForTrackedGraph\)') | Listens to a TrackedGraphInterceptable when an update occurs\. |
| [GraphReadOnlyPlugin\(IReadOnlyTrackedGraph&lt;TNode&gt;\)](GraphReadOnlyPlugin_TNode_.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IReadOnlyTrackedGraph_TNode_) 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.GraphReadOnlyPlugin\(SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>\)') | Listens to a TrackedGraph when an update occurs\. An update is the |
| [GraphReadOnlyPlugin\(GraphPlugin&lt;TNode&gt;, ReadOnlyGraphPluginListenerForPlugin\)](GraphReadOnlyPlugin_TNode_.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin) 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.GraphReadOnlyPlugin\(SpatialGraph\.Metadata\.GraphPlugin\<TNode\>, SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForPlugin\)') | Listens to a GraphPlugin when an update occurs\. |
| [GraphReadOnlyPlugin\(GraphReadOnlyPlugin&lt;TNode&gt;, ReadOnlyGraphPluginListenerForPlugin\)](GraphReadOnlyPlugin_TNode_.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin) 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.GraphReadOnlyPlugin\(SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>, SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForPlugin\)') | Listens to a GraphReadOnlyPlugin when an update occurs\. |

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IInterceptableTrackedGraph_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForTrackedGraph)'></a>

## GraphReadOnlyPlugin\(IInterceptableTrackedGraph\<TNode\>, ReadOnlyGraphPluginListenerForTrackedGraph\) Constructor

Listens to a TrackedGraphInterceptable when an update occurs\.

```csharp
public GraphReadOnlyPlugin(SpatialGraph.IInterceptableTrackedGraph<TNode> baseGraph, SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForTrackedGraph SubscribeTo);
```
#### Parameters

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IInterceptableTrackedGraph_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForTrackedGraph).baseGraph'></a>

`baseGraph` [SpatialGraph\.IInterceptableTrackedGraph&lt;](../../IInterceptableTrackedGraph_TNode_/index.md 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>')[TNode](index.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.TNode')[&gt;](../../IInterceptableTrackedGraph_TNode_/index.md 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>')

Graph to subscribe to\.

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IInterceptableTrackedGraph_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForTrackedGraph).SubscribeTo'></a>

`SubscribeTo` [ReadOnlyGraphPluginListenerForTrackedGraph](../ReadOnlyGraphPluginListenerForTrackedGraph/index.md 'SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForTrackedGraph')

Determine which event from the TrackedGraphInterceptable to subscribe to\.

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IReadOnlyTrackedGraph_TNode_)'></a>

## GraphReadOnlyPlugin\(IReadOnlyTrackedGraph\<TNode\>\) Constructor

Listens to a TrackedGraph when an update occurs\. An update is the

```csharp
public GraphReadOnlyPlugin(SpatialGraph.IReadOnlyTrackedGraph<TNode> baseGraph);
```
#### Parameters

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IReadOnlyTrackedGraph_TNode_).baseGraph'></a>

`baseGraph` [SpatialGraph\.IReadOnlyTrackedGraph&lt;](../../IReadOnlyTrackedGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>')[TNode](index.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.TNode')[&gt;](../../IReadOnlyTrackedGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>')

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin)'></a>

## GraphReadOnlyPlugin\(GraphPlugin\<TNode\>, ReadOnlyGraphPluginListenerForPlugin\) Constructor

Listens to a GraphPlugin when an update occurs\.

```csharp
public GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphPlugin<TNode> baseGraph, SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin SubscribeTo);
```
#### Parameters

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin).baseGraph'></a>

`baseGraph` [SpatialGraph\.Metadata\.GraphPlugin&lt;](../GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>')[TNode](index.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.TNode')[&gt;](../GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>')

Plugin to subscribe to\.

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin).SubscribeTo'></a>

`SubscribeTo` [ReadOnlyGraphPluginListenerForPlugin](../ReadOnlyGraphPluginListenerForPlugin/index.md 'SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForPlugin')

Determine which event from the baseGraph to subscribe to\.

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin)'></a>

## GraphReadOnlyPlugin\(GraphReadOnlyPlugin\<TNode\>, ReadOnlyGraphPluginListenerForPlugin\) Constructor

Listens to a GraphReadOnlyPlugin when an update occurs\.

```csharp
public GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphReadOnlyPlugin<TNode> baseGraph, SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin SubscribeTo);
```
#### Parameters

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin).baseGraph'></a>

`baseGraph` [SpatialGraph\.Metadata\.GraphReadOnlyPlugin&lt;](index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>')[TNode](index.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.TNode')[&gt;](index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>')

Plugin to subscribe to\.

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin).SubscribeTo'></a>

`SubscribeTo` [ReadOnlyGraphPluginListenerForPlugin](../ReadOnlyGraphPluginListenerForPlugin/index.md 'SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForPlugin')

Determine which event from the baseGraph to subscribe to\.