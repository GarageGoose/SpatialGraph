# OrderedEdgesByAngle2D

Namespace: SpatialGraph.Metadata

Records the order and adjacency of edges in a node including the angles between them.

```csharp
public class OrderedEdgesByAngle2D : GraphReadOnlyPlugin`1, SpatialGraph.IReadOnlyTrackedGraph`1[[SpatialGraph.Node2D, SpatialGraph, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], SpatialGraph.IReadOnlyGraph`1[[SpatialGraph.Node2D, SpatialGraph, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [GraphReadOnlyPlugin&lt;Node2D&gt;](./spatialgraph.metadata.graphreadonlyplugin-1.md) → [OrderedEdgesByAngle2D](./spatialgraph.metadata.orderededgesbyangle2d.md)<br>
Implements [IReadOnlyTrackedGraph&lt;Node2D&gt;](./spatialgraph.ireadonlytrackedgraph-1.md), [IReadOnlyGraph&lt;Node2D&gt;](./spatialgraph.ireadonlygraph-1.md)<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute)

## Properties

### **Nodes**

```csharp
public IReadOnlyDictionary<uint, Node2D> Nodes { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;UInt32, Node2D&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

### **Edges**

```csharp
public IReadOnlyDictionary<uint, Edge> Edges { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;UInt32, Edge&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

## Constructors

### **OrderedEdgesByAngle2D(IReadOnlyTrackedGraph&lt;Node2D&gt;)**

Records the order and adjacency of edges in a node including the angles between them in a graph.

```csharp
public OrderedEdgesByAngle2D(IReadOnlyTrackedGraph<Node2D> baseGraph)
```

#### Parameters

`baseGraph` [IReadOnlyTrackedGraph&lt;Node2D&gt;](./spatialgraph.ireadonlytrackedgraph-1.md)<br>
Graph to create the data from.

## Methods

### **EdgesAnglesOnNode(UInt32)**

```csharp
public IReadOnlyDictionary<uint, float> EdgesAnglesOnNode(uint nodeID)
```

#### Parameters

`nodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

#### Returns

[IReadOnlyDictionary&lt;UInt32, Single&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

### **NextEdgeFromEdge(UInt32, UInt32)**

Get the next adjacent edge from a specified edge.

```csharp
public uint NextEdgeFromEdge(uint nodeID, uint edgeID)
```

#### Parameters

`nodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node on where to find the next adjecent edge.

`edgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the specified edge.

#### Returns

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
Next adjacent edge from a specified edge.

### **PreviousEdgeFromEdge(UInt32, UInt32)**

Get the previous adjacent edge from a specified edge.

```csharp
public uint PreviousEdgeFromEdge(uint nodeID, uint edgeID)
```

#### Parameters

`nodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node on where to find the next adjecent edge.

`edgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the specified edge.

#### Returns

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
Next previous edge from a specified edge.

### **AngleBetweenNextEdge(UInt32, UInt32)**

Get the angle in rads between the target edge and the next adjacent edge in a node.

```csharp
public float AngleBetweenNextEdge(uint nodeID, uint edgeID)
```

#### Parameters

`nodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the specified node.

`edgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the specified edge.

#### Returns

[Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
Angle in rads between the target edge and the next adjacent edge in a node.

### **AngleBetweenPreviousEdge(UInt32, UInt32)**

Get the angle in rads between the target edge and the previous adjacent edge in a node.

```csharp
public float AngleBetweenPreviousEdge(uint nodeID, uint edgeID)
```

#### Parameters

`nodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the specified node.

`edgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the specified edge.

#### Returns

[Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
Angle in rads between the target edge and the previous adjacent edge in a node.

### **OnGraphUpdate(Object, IReadOnlyModificationLog&lt;Node2D&gt;)**

```csharp
protected override void OnGraphUpdate(object? sender, IReadOnlyModificationLog<Node2D> modLog)
```

#### Parameters

`sender` [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object)?<br>

`modLog` [IReadOnlyModificationLog&lt;Node2D&gt;](./spatialgraph.ireadonlymodificationlog-1.md)<br>

## Events

### **OnGraphPluginUpdated**

Emits before the plugin starts logging changes.

```csharp
public event EventHandler<IReadOnlyModificationLog<Node2D>>? OnGraphPluginUpdated;
```

### **OnGraphPluginInit**

Emits after the plugin starts logging changes.

```csharp
public event EventHandler<IReadOnlyModificationLog<Node2D>>? OnGraphPluginInit;
```

### **OnGraphModified**

```csharp
public event EventHandler<IReadOnlyModificationLog<Node2D>>? OnGraphModified;
```
