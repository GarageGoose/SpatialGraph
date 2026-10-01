# ReadOnlyGraphPluginListenerForPlugin

Namespace: SpatialGraph.Metadata

Determines an event to subscribe to from a Plugin (GraphPlugin/GraphReadOnlyPlugin) in a GraphReadOnlyPlugin.

```csharp
public enum ReadOnlyGraphPluginListenerForPlugin
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://learn.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum) → [ReadOnlyGraphPluginListenerForPlugin](./spatialgraph.metadata.readonlygraphpluginlistenerforplugin.md)<br>
Implements [IComparable](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable), [ISpanFormattable](https://learn.microsoft.com/en-us/dotnet/api/system.ispanformattable), [IFormattable](https://learn.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://learn.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| OnGraphPluginInit | 0 | Points to an event within a plugin which is invoked before the plugin processes the update. |
| OnGraphPluginUpdated | 1 | Points to an event within a plugin which is invoked after the plugin processes the update. |
