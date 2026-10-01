# QuadTreeNode

Namespace: SpatialGraph.Spatial

Quadtree implementation for nodes in a graph. Enables spatial indexing for nodes.

```csharp
public class QuadTreeNode : SpatialGraph.Metadata.GraphReadOnlyPlugin`1[[SpatialGraph.Node2D, SpatialGraph, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], SpatialGraph.IReadOnlyTrackedGraph`1[[SpatialGraph.Node2D, SpatialGraph, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]], SpatialGraph.IReadOnlyGraph`1[[SpatialGraph.Node2D, SpatialGraph, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [GraphReadOnlyPlugin&lt;Node2D&gt;](./spatialgraph.metadata.graphreadonlyplugin-1.md) → [QuadTreeNode](./spatialgraph.spatial.quadtreenode.md)<br>
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

### **QuadTreeNode(ITrackedGraph&lt;Node2D&gt;, Int32, Vector2, Single, Single)**

```csharp
public QuadTreeNode(ITrackedGraph<Node2D> graph, int cellCapacity, Vector2 originTopLeft, float width, float height)
```

#### Parameters

`graph` [ITrackedGraph&lt;Node2D&gt;](./spatialgraph.itrackedgraph-1.md)<br>

`cellCapacity` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

`originTopLeft` [Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2)<br>

`width` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>

`height` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>

## Methods

### **ParentCell()**



```csharp
public IReadOnlyQuadTreeNodeCell ParentCell()
```

#### Returns

[IReadOnlyQuadTreeNodeCell](./spatialgraph.ireadonlyquadtreenodecell.md)<br>

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
