## GraphPluginSubscription Enum

Determines an event to subscribe to from a GraphPlugin in a GraphPlugin\.

```csharp
public enum GraphPluginSubscription
```
### Fields

<a name='SpatialGraph.Metadata.GraphPluginSubscription.OnGraphModificationInit'></a>

`OnGraphModificationInit` 0

Points to an event within a GraphPlugin which is invoked when a plugin receives a ChangeLog before it processes the update\.

<a name='SpatialGraph.Metadata.GraphPluginSubscription.OnGraphPluginInit'></a>

`OnGraphPluginInit` 1

Points to an event within a GraphPlugin which is invoked after the plugin processes the update\.