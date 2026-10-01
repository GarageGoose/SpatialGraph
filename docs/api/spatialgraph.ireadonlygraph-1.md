# IReadOnlyGraph&lt;TNode&gt;

Namespace: SpatialGraph

Read only interface of a graph. A graph stores nodes and edges within it, identified by their IDs.

```csharp
public interface IReadOnlyGraph<TNode> where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node to be used in the graph.

Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute)

## Properties

### **Nodes**

Nodes stored in this graph. Elements such as nodes are referenced be their unique ID.
 Nodes and edges can share the same ID.

```csharp
IReadOnlyDictionary<uint, TNode> Nodes { get; }
```

#### Property Value

IReadOnlyDictionary&lt;UInt32, TNode&gt;<br>

### **Edges**

Edges stored in this graph. Elements such as edges are referenced be their unique ID.
 Nodes and edges can share the same ID.

```csharp
IReadOnlyDictionary<uint, Edge> Edges { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;UInt32, Edge&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

## Methods

### **GenerateID()**

Generate unique ID for the elements of the graph.
 Nodes and edges can share the same ID.

```csharp
uint GenerateID()
```

#### Returns

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
