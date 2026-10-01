# ReadOnlyGraphPluginListenerForTrackedGraph

Namespace: SpatialGraph.Metadata

Determines an event to subscribe to from a TrackedGraph in a GraphReadOnlyPlugin.

```csharp
public enum ReadOnlyGraphPluginListenerForTrackedGraph
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://learn.microsoft.com/en-us/dotnet/api/system.valuetype) → [Enum](https://learn.microsoft.com/en-us/dotnet/api/system.enum) → [ReadOnlyGraphPluginListenerForTrackedGraph](./spatialgraph.metadata.readonlygraphpluginlistenerfortrackedgraph.md)<br>
Implements [IComparable](https://learn.microsoft.com/en-us/dotnet/api/system.icomparable), [ISpanFormattable](https://learn.microsoft.com/en-us/dotnet/api/system.ispanformattable), [IFormattable](https://learn.microsoft.com/en-us/dotnet/api/system.iformattable), [IConvertible](https://learn.microsoft.com/en-us/dotnet/api/system.iconvertible)

## Fields

| Name | Value | Description |
| --- | --: | --- |
| OnGraphModified | 0 | Points to an event within a TrackedGraph which is invoked after it is modified. |
| OnGraphModificationInit | 1 | Points to an event within a TrackedGraph which is invoked before it is modified. |
