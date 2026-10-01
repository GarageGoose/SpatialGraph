# NodeAdjacency&lt;TNode&gt;

Namespace: SpatialGraph.Metadata

Records adjecent nodes and edges from a node in a graph.

```csharp
public class NodeAdjacency<TNode> : GraphReadOnlyPlugin`1, IReadOnlyTrackedGraph`1, IReadOnlyGraph`1 where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Node which the base class uses.

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → GraphReadOnlyPlugin&lt;TNode&gt; → [NodeAdjacency&lt;TNode&gt;](./spatialgraph.metadata.nodeadjacency-1.md)<br>
Implements IReadOnlyTrackedGraph&lt;TNode&gt;, IReadOnlyGraph&lt;TNode&gt;<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute)

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

### **NodeAdjacency(IReadOnlyTrackedGraph&lt;TNode&gt;)**

```csharp
public NodeAdjacency(IReadOnlyTrackedGraph<TNode> baseGraph)
```

#### Parameters

`baseGraph` IReadOnlyTrackedGraph&lt;TNode&gt;<br>

## Methods

### **ConnectedNodes(UInt32)**

Get connected nodes from a node.

```csharp
public IReadOnlySet<uint> ConnectedNodes(uint nodeID)
```

#### Parameters

`nodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

#### Returns

[IReadOnlySet&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlyset-1)<br>

### **ConnectedEdges(UInt32)**

Get connecting edges from a node.

```csharp
public IReadOnlySet<uint> ConnectedEdges(uint nodeID)
```

#### Parameters

`nodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

#### Returns

[IReadOnlySet&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlyset-1)<br>

### **ConnectedEdgesCount(UInt32)**

Get the amount of edges connected in a node.

```csharp
public int ConnectedEdgesCount(uint nodeID)
```

#### Parameters

`nodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the specified node.

#### Returns

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
Amount of edges connected in a node.

### **OnGraphUpdate(Object, IReadOnlyModificationLog&lt;TNode&gt;)**

```csharp
protected override void OnGraphUpdate(object? sender, IReadOnlyModificationLog<TNode> log)
```

#### Parameters

`sender` [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object)?<br>

`log` IReadOnlyModificationLog&lt;TNode&gt;<br>

## Events

### **OnGraphPluginUpdated**

```csharp
public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphPluginUpdated;
```

### **OnGraphPluginInit**

```csharp
public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphPluginInit;
```

### **OnGraphModified**

```csharp
public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphModified;
```
