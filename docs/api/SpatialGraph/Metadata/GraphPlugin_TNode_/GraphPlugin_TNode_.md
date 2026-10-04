## GraphPlugin<TNode> Constructors

| Overloads | |
| :--- | :--- |
| [GraphPlugin(IInterceptableObservableGraph&lt;TNode&gt;)](GraphPlugin_TNode_.md#SpatialGraph.Metadata.GraphPlugin_TNode_.GraphPlugin(SpatialGraph.IInterceptableObservableGraph_TNode_) 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.GraphPlugin(SpatialGraph\.IInterceptableObservableGraph<TNode>)') | Listens to a graph when an update occurs\. An update is invoked when the base graph is modified by adding, modifying, and removing any of its elements\. |
| [GraphPlugin(GraphPlugin&lt;TNode&gt;, GraphPluginSubscription)](GraphPlugin_TNode_.md#SpatialGraph.Metadata.GraphPlugin_TNode_.GraphPlugin(SpatialGraph.Metadata.GraphPlugin_TNode_,SpatialGraph.Metadata.GraphPluginSubscription) 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.GraphPlugin(SpatialGraph\.Metadata\.GraphPlugin<TNode>, SpatialGraph\.Metadata\.GraphPluginSubscription)') | Listens to the plugin when an update occurs\. An update is invoked when the base graph is modified by adding, modifying, and removing any of its elements\. |

<a name='SpatialGraph.Metadata.GraphPlugin_TNode_.GraphPlugin(SpatialGraph.IInterceptableObservableGraph_TNode_)'></a>

## GraphPlugin(IInterceptableObservableGraph<TNode>) Constructor

Listens to a graph when an update occurs\.
An update is invoked when the base graph is modified by adding, modifying, and removing any of its elements\.

```csharp
public GraphPlugin(SpatialGraph.IInterceptableObservableGraph<TNode> baseGraph);
```
#### Parameters

<a name='SpatialGraph.Metadata.GraphPlugin_TNode_.GraphPlugin(SpatialGraph.IInterceptableObservableGraph_TNode_).baseGraph'></a>

`baseGraph` [SpatialGraph\.IInterceptableObservableGraph&lt;](../../IInterceptableObservableGraph_TNode_/index.md 'SpatialGraph\.IInterceptableObservableGraph<TNode>')[TNode](index.md#SpatialGraph.Metadata.GraphPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.TNode')[&gt;](../../IInterceptableObservableGraph_TNode_/index.md 'SpatialGraph\.IInterceptableObservableGraph<TNode>')

<a name='SpatialGraph.Metadata.GraphPlugin_TNode_.GraphPlugin(SpatialGraph.Metadata.GraphPlugin_TNode_,SpatialGraph.Metadata.GraphPluginSubscription)'></a>

## GraphPlugin(GraphPlugin<TNode>, GraphPluginSubscription) Constructor

Listens to the plugin when an update occurs\.
An update is invoked when the base graph is modified by adding, modifying, and removing any of its elements\.

```csharp
public GraphPlugin(SpatialGraph.Metadata.GraphPlugin<TNode> baseGraph, SpatialGraph.Metadata.GraphPluginSubscription SubscribeTo);
```
#### Parameters

<a name='SpatialGraph.Metadata.GraphPlugin_TNode_.GraphPlugin(SpatialGraph.Metadata.GraphPlugin_TNode_,SpatialGraph.Metadata.GraphPluginSubscription).baseGraph'></a>

`baseGraph` [SpatialGraph\.Metadata\.GraphPlugin&lt;](index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>')[TNode](index.md#SpatialGraph.Metadata.GraphPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.TNode')[&gt;](index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>')

Plugin to subscribe to\.

<a name='SpatialGraph.Metadata.GraphPlugin_TNode_.GraphPlugin(SpatialGraph.Metadata.GraphPlugin_TNode_,SpatialGraph.Metadata.GraphPluginSubscription).SubscribeTo'></a>

`SubscribeTo` [GraphPluginSubscription](../GraphPluginSubscription/index.md 'SpatialGraph\.Metadata\.GraphPluginSubscription')

Determine which event from the baseGraph to subscribe to\.