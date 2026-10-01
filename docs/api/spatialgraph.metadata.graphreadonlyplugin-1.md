# GraphReadOnlyPlugin&lt;TNode&gt;

Namespace: SpatialGraph.Metadata

Base class for plugins which can observe changes either in a graph or another plugin.

```csharp
public abstract class GraphReadOnlyPlugin<TNode> : IReadOnlyTrackedGraph`1, IReadOnlyGraph`1 where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node used in the base graph.

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [GraphReadOnlyPlugin&lt;TNode&gt;](./spatialgraph.metadata.graphreadonlyplugin-1.md)<br>
Implements IReadOnlyTrackedGraph&lt;TNode&gt;, IReadOnlyGraph&lt;TNode&gt;

## Properties

### **Nodes**

```csharp
public IReadOnlyDictionary<uint, TNode> Nodes { get; }
```

#### Property Value

IReadOnlyDictionary&lt;UInt32, TNode&gt;<br>

### **Edges**

```csharp
public IReadOnlyDictionary<uint, Edge> Edges { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;UInt32, Edge&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

## Constructors

### **GraphReadOnlyPlugin(IReadOnlyTrackedGraph&lt;TNode&gt;)**

Listens to a TrackedGraph when an update occurs. An update is the

```csharp
public GraphReadOnlyPlugin(IReadOnlyTrackedGraph<TNode> baseGraph)
```

#### Parameters

`baseGraph` IReadOnlyTrackedGraph&lt;TNode&gt;<br>

### **GraphReadOnlyPlugin(IInterceptableTrackedGraph&lt;TNode&gt;, ReadOnlyGraphPluginListenerForTrackedGraph)**

Listens to a TrackedGraphInterceptable when an update occurs.

```csharp
public GraphReadOnlyPlugin(IInterceptableTrackedGraph<TNode> baseGraph, ReadOnlyGraphPluginListenerForTrackedGraph SubscribeTo)
```

#### Parameters

`baseGraph` IInterceptableTrackedGraph&lt;TNode&gt;<br>
Graph to subscribe to.

`SubscribeTo` [ReadOnlyGraphPluginListenerForTrackedGraph](./spatialgraph.metadata.readonlygraphpluginlistenerfortrackedgraph.md)<br>
Determine which event from the TrackedGraphInterceptable to subscribe to.

### **GraphReadOnlyPlugin(GraphReadOnlyPlugin&lt;TNode&gt;, ReadOnlyGraphPluginListenerForPlugin)**

Listens to a GraphReadOnlyPlugin when an update occurs.

```csharp
public GraphReadOnlyPlugin(GraphReadOnlyPlugin<TNode> baseGraph, ReadOnlyGraphPluginListenerForPlugin SubscribeTo)
```

#### Parameters

`baseGraph` [GraphReadOnlyPlugin&lt;TNode&gt;](./spatialgraph.metadata.graphreadonlyplugin-1.md)<br>
Plugin to subscribe to.

`SubscribeTo` [ReadOnlyGraphPluginListenerForPlugin](./spatialgraph.metadata.readonlygraphpluginlistenerforplugin.md)<br>
Determine which event from the baseGraph to subscribe to.

### **GraphReadOnlyPlugin(GraphPlugin&lt;TNode&gt;, ReadOnlyGraphPluginListenerForPlugin)**

Listens to a GraphPlugin when an update occurs.

```csharp
public GraphReadOnlyPlugin(GraphPlugin<TNode> baseGraph, ReadOnlyGraphPluginListenerForPlugin SubscribeTo)
```

#### Parameters

`baseGraph` GraphPlugin&lt;TNode&gt;<br>
Plugin to subscribe to.

`SubscribeTo` [ReadOnlyGraphPluginListenerForPlugin](./spatialgraph.metadata.readonlygraphpluginlistenerforplugin.md)<br>
Determine which event from the baseGraph to subscribe to.

## Methods

### **OnGraphUpdate(Object, IReadOnlyModificationLog&lt;TNode&gt;)**

Emits when a modification occurs in the base graph.

```csharp
protected abstract void OnGraphUpdate(object? sender, IReadOnlyModificationLog<TNode> modLog)
```

#### Parameters

`sender` [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object)?<br>
Source of the event.

`modLog` IReadOnlyModificationLog&lt;TNode&gt;<br>
Log of changes for the base graph.

### **GenerateID()**

Generate unique ID for the elements of the graph.
 Nodes and edges can share the same ID.

```csharp
public uint GenerateID()
```

#### Returns

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

## Events

### **OnGraphPluginUpdated**

Emits before the plugin starts logging changes.

```csharp
public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphPluginUpdated;
```

### **OnGraphPluginInit**

Emits after the plugin starts logging changes.

```csharp
public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphPluginInit;
```

### **OnGraphModified**

```csharp
public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphModified;
```
