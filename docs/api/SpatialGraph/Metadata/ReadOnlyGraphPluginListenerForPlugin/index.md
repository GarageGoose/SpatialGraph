## ReadOnlyGraphPluginListenerForPlugin Enum

Determines an event to subscribe to from a Plugin \(GraphPlugin/GraphReadOnlyPlugin\) in a GraphReadOnlyPlugin\.

```csharp
public enum ReadOnlyGraphPluginListenerForPlugin
```
### Fields

<a name='SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin.OnGraphPluginInit'></a>

`OnGraphPluginInit` 0

Points to an event within a plugin which is invoked before the plugin processes the update\.

<a name='SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin.OnGraphPluginUpdated'></a>

`OnGraphPluginUpdated` 1

Points to an event within a plugin which is invoked after the plugin processes the update\.