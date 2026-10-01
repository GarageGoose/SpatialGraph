# GraphChangeSet&lt;TNode&gt;

Namespace: SpatialGraph

Set of changes in a graph.

```csharp
public interface GraphChangeSet<TNode> where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Node which the base graph uses.

Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute)

## Methods

### **NodeUpserts()**

Nodes to be either added or replaced if it has the same ID as a node in a graph.

```csharp
IEnumerable<TNode> NodeUpserts()
```

#### Returns

IEnumerable&lt;TNode&gt;<br>
Set of nodes to be either added or replaced.

### **EdgeUpserts()**

Edges to be either added or replaced if it has the same ID as a node in a graph.

```csharp
IEnumerable<Edge> EdgeUpserts()
```

#### Returns

[IEnumerable&lt;Edge&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
Set of edges to be either added or replaced.

### **NodeRemovals()**

IDs of the nodes to be removed in a graph.

```csharp
IEnumerable<uint> NodeRemovals()
```

#### Returns

[IEnumerable&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
Set of nodes to be either added or replaced.

### **EdgeRemovals()**

IDs of the edges to be removed in a graph.

```csharp
IEnumerable<uint> EdgeRemovals()
```

#### Returns

[IEnumerable&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
Set of edges to be either added or replaced.
