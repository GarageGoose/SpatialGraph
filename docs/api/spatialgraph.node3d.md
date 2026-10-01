# Node3D

Namespace: SpatialGraph

Node with coordinate in 3 dimensions. Used for 3D graphs.

```csharp
public readonly record struct Node3D
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://learn.microsoft.com/en-us/dotnet/api/system.valuetype) → [Node3D](./spatialgraph.node3d.md)<br>
Implements [INode](./spatialgraph.inode.md), [IElement](./spatialgraph.ielement.md), [IEquatable&lt;Node3D&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
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
public Vector3 Loc { get; init; }
```

#### Property Value

[Vector3](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector3)<br>

## Constructors

### **Node3D(UInt32, Vector3)**

Node with coordinate in 3 dimensions. Used for 3D graphs.

```csharp
public Node3D(uint ID, Vector3 Loc)
```

#### Parameters

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

`Loc` [Vector3](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector3)<br>
