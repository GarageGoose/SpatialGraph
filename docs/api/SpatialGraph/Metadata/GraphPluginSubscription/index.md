## GraphPluginSubscription Enum

Determines an event to subscribe to from a [GraphPlugin&lt;TNode&gt;](../GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>') in a [GraphPlugin&lt;TNode&gt;](../GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>')\.

```csharp
public enum GraphPluginSubscription
```
### Fields

<a name='SpatialGraph.Metadata.GraphPluginSubscription.OnGraphModificationInit'></a>

`OnGraphModificationInit` 0

Points to an event within a [GraphPlugin&lt;TNode&gt;](../GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>') which is invoked when a plugin receives a [GraphChangeLog&lt;TNode&gt;](../../GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog<TNode>') before it processes the update\.

<a name='SpatialGraph.Metadata.GraphPluginSubscription.OnGraphPluginInit'></a>

`OnGraphPluginInit` 1

Points to an event within a [GraphPlugin&lt;TNode&gt;](../GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>') which is invoked after the plugin processes the update\.