# GraphTraversal&lt;TNode&gt;

Namespace: SpatialGraph.Traversal

Graph traversal algorithms.

```csharp
public readonly record struct GraphTraversal<TNode> where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Node type.

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://learn.microsoft.com/en-us/dotnet/api/system.valuetype) → [GraphTraversal&lt;TNode&gt;](./spatialgraph.traversal.graphtraversal-1.md)<br>
Implements IEquatable&lt;GraphTraversal&lt;TNode&gt;&gt;<br>
Attributes [IsReadOnlyAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.isreadonlyattribute)

## Properties

### **Traverse**

Traverse the graph.

```csharp
public IEnumerable<TraversalInfo<TNode>> Traverse { get; init; }
```

#### Property Value

IEnumerable&lt;TraversalInfo&lt;TNode&gt;&gt;<br>

### **BaseGraph**

Graph to traverse.

```csharp
public NodeAdjacency<TNode> BaseGraph { get; init; }
```

#### Property Value

NodeAdjacency&lt;TNode&gt;<br>

### **StartingNodeID**

Node to start traversal.

```csharp
public uint StartingNodeID { get; init; }
```

#### Property Value

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

### **TagretNodeID**

Node to find when travering.

```csharp
public uint? TagretNodeID { get; init; }
```

#### Property Value

[UInt32?](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **GraphTraversal(IEnumerable&lt;TraversalInfo&lt;TNode&gt;&gt;, NodeAdjacency&lt;TNode&gt;, UInt32, UInt32?)**

Graph traversal algorithms.

```csharp
public GraphTraversal(IEnumerable<TraversalInfo<TNode>> Traverse, NodeAdjacency<TNode> BaseGraph, uint StartingNodeID, uint? TagretNodeID)
```

#### Parameters

`Traverse` IEnumerable&lt;TraversalInfo&lt;TNode&gt;&gt;<br>
Traverse the graph.

`BaseGraph` NodeAdjacency&lt;TNode&gt;<br>
Graph to traverse.

`StartingNodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
Node to start traversal.

`TagretNodeID` [UInt32?](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
Node to find when travering.
