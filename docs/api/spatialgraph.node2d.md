# Node2D

Namespace: SpatialGraph

Node with coordinate in 2 dimensions. Used for 2D graphs.

```csharp
public readonly record struct Node2D
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://learn.microsoft.com/en-us/dotnet/api/system.valuetype) → [Node2D](./spatialgraph.node2d.md)<br>
Implements [INode](./spatialgraph.inode.md), [IElement](./spatialgraph.ielement.md), [IEquatable&lt;Node2D&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [IsReadOnlyAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.isreadonlyattribute)

## Properties

### **ID**

```csharp
public uint ID { get; init; }
```

#### Property Value

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

### **Loc**

```csharp
public Vector2 Loc { get; init; }
```

#### Property Value

[Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2)<br>

## Constructors

### **Node2D(UInt32, Vector2)**

Node with coordinate in 2 dimensions. Used for 2D graphs.

```csharp
public Node2D(uint ID, Vector2 Loc)
```

#### Parameters

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

`Loc` [Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2)<br>
