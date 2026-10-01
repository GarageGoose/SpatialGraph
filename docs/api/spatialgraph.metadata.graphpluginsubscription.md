# GraphPluginSubscription

Namespace: SpatialGraph.Metadata

Determines an event to subscribe to from a GraphPlugin in a GraphPlugin.

```csharp
public enum GraphPluginSubscription
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://learn.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum) → [GraphPluginSubscription](./spatialgraph.metadata.graphpluginsubscription.md)<br>
Implements [IComparable](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable), [ISpanFormattable](https://learn.microsoft.com/en-us/dotnet/api/system.ispanformattable), [IFormattable](https://learn.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://learn.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| OnGraphModificationInit | 0 | Points to an event within a GraphPlugin which is invoked when a plugin receives a ChangeLog before it processes the update. |
| OnGraphPluginInit | 1 | Points to an event within a GraphPlugin which is invoked after the plugin processes the update. |
