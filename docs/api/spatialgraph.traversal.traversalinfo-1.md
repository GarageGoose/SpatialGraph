# TraversalInfo&lt;TNode&gt;

Namespace: SpatialGraph.Traversal

Provides traversal info for a specific node.

```csharp
public readonly record struct TraversalInfo<TNode> where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Node type.

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://learn.microsoft.com/en-us/dotnet/api/system.valuetype) → [TraversalInfo&lt;TNode&gt;](./spatialgraph.traversal.traversalinfo-1.md)<br>
Implements IEquatable&lt;TraversalInfo&lt;TNode&gt;&gt;<br>
Attributes [IsReadOnlyAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.isreadonlyattribute)

## Properties

### **NodeID**

Current node ID.

```csharp
public uint NodeID { get; init; }
```

#### Property Value

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

### **OriginNodeID**

Node where the current node was found.

```csharp
public uint? OriginNodeID { get; init; }
```

#### Property Value

[UInt32?](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

### **EdgeUsedForTraversal**

Edge where the current node was found.

```csharp
public uint? EdgeUsedForTraversal { get; init; }
```

#### Property Value

[UInt32?](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

## Constructors

### **TraversalInfo(UInt32, UInt32?, UInt32?)**

Provides traversal info for a specific node.

```csharp
public TraversalInfo(uint NodeID, uint? OriginNodeID, uint? EdgeUsedForTraversal)
```

#### Parameters

`NodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
Current node ID.

`OriginNodeID` [UInt32?](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
Node where the current node was found.

`EdgeUsedForTraversal` [UInt32?](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
Edge where the current node was found.
