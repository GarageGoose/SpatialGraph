# IReadOnlyGraphIncomingChanges&lt;TNode&gt;

Namespace: SpatialGraph

Interface for objects which stores incoming changes for a graph.

```csharp
public interface IReadOnlyGraphIncomingChanges<TNode> : GraphChangeSet`1 where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node used in the graph.

Implements GraphChangeSet&lt;TNode&gt;<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute)

## Properties

### **NodesForUpsert**

Nodes to be added or modified (replaced with identical IDs) in a graph.

```csharp
IReadOnlyDictionary<uint, TNode> NodesForUpsert { get; }
```

#### Property Value

IReadOnlyDictionary&lt;UInt32, TNode&gt;<br>

### **NodesForRemoval**

Nodes to be removed in a graph.

```csharp
IReadOnlySet<uint> NodesForRemoval { get; }
```

#### Property Value

[IReadOnlySet&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlyset-1)<br>

### **EdgesForUpsert**

Edges to be added or modified (replaced with identical IDs) in a graph.

```csharp
IReadOnlyDictionary<uint, Edge> EdgesForUpsert { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;UInt32, Edge&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

### **EdgesForRemoval**

Edges to be removed in a graph.

```csharp
IReadOnlySet<uint> EdgesForRemoval { get; }
```

#### Property Value

[IReadOnlySet&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlyset-1)<br>
