# GraphIncomingChanges&lt;TNode&gt;

Namespace: SpatialGraph

Stores incoming changes for a graph.

```csharp
public class GraphIncomingChanges<TNode> : IReadOnlyGraphIncomingChanges`1, GraphChangeSet`1 where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node used in the graph.

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [GraphIncomingChanges&lt;TNode&gt;](./spatialgraph.graphincomingchanges-1.md)<br>
Implements IReadOnlyGraphIncomingChanges&lt;TNode&gt;, GraphChangeSet&lt;TNode&gt;<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute)

## Properties

### **NodesForUpsert**

```csharp
public IReadOnlyDictionary<uint, TNode> NodesForUpsert { get; }
```

#### Property Value

IReadOnlyDictionary&lt;UInt32, TNode&gt;<br>

### **NodesForRemoval**

```csharp
public IReadOnlySet<uint> NodesForRemoval { get; }
```

#### Property Value

[IReadOnlySet&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlyset-1)<br>

### **EdgesForUpsert**

```csharp
public IReadOnlyDictionary<uint, Edge> EdgesForUpsert { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;UInt32, Edge&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

### **EdgesForRemoval**

```csharp
public IReadOnlySet<uint> EdgesForRemoval { get; }
```

#### Property Value

[IReadOnlySet&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlyset-1)<br>

## Constructors

### **GraphIncomingChanges()**

Create a new empty instance.

```csharp
public GraphIncomingChanges()
```

### **GraphIncomingChanges(IReadOnlyGraphIncomingChanges&lt;TNode&gt;)**



```csharp
public GraphIncomingChanges(IReadOnlyGraphIncomingChanges<TNode> batchedMods)
```

#### Parameters

`batchedMods` IReadOnlyGraphIncomingChanges&lt;TNode&gt;<br>

## Methods

### **UpsertNode(TNode)**

Add a new node or modify one with their corresponding ID.

```csharp
public void UpsertNode(TNode node)
```

#### Parameters

`node` TNode<br>
Node to upsert.

### **RemoveNode(UInt32)**

```csharp
public void RemoveNode(uint nodeID)
```

#### Parameters

`nodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

### **RemoveNodeMod(UInt32)**

```csharp
public void RemoveNodeMod(uint nodeID)
```

#### Parameters

`nodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

### **UpsertEdge(Edge)**

```csharp
public void UpsertEdge(Edge edge)
```

#### Parameters

`edge` [Edge](./spatialgraph.edge.md)<br>

### **RemoveEdge(UInt32)**

```csharp
public void RemoveEdge(uint edgeID)
```

#### Parameters

`edgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

### **RemoveEdgeMod(UInt32)**

```csharp
public void RemoveEdgeMod(uint edgeID)
```

#### Parameters

`edgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

### **Union(GraphIncomingChanges&lt;TNode&gt;)**

```csharp
public void Union(GraphIncomingChanges<TNode> batchedMods)
```

#### Parameters

`batchedMods` [GraphIncomingChanges&lt;TNode&gt;](./spatialgraph.graphincomingchanges-1.md)<br>

### **Intersect(GraphIncomingChanges&lt;TNode&gt;)**

```csharp
public void Intersect(GraphIncomingChanges<TNode> batchedMods)
```

#### Parameters

`batchedMods` [GraphIncomingChanges&lt;TNode&gt;](./spatialgraph.graphincomingchanges-1.md)<br>

### **NodeUpserts()**

Nodes to be either added or replaced if it has the same ID as a node in a graph.

```csharp
public IEnumerable<TNode> NodeUpserts()
```

#### Returns

IEnumerable&lt;TNode&gt;<br>
Set of nodes to be either added or replaced.

### **EdgeUpserts()**

Edges to be either added or replaced if it has the same ID as a node in a graph.

```csharp
public IEnumerable<Edge> EdgeUpserts()
```

#### Returns

[IEnumerable&lt;Edge&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
Set of edges to be either added or replaced.

### **NodeRemovals()**

IDs of the nodes to be removed in a graph.

```csharp
public IEnumerable<uint> NodeRemovals()
```

#### Returns

[IEnumerable&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
Set of nodes to be either added or replaced.

### **EdgeRemovals()**

IDs of the edges to be removed in a graph.

```csharp
public IEnumerable<uint> EdgeRemovals()
```

#### Returns

[IEnumerable&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
Set of edges to be either added or replaced.
