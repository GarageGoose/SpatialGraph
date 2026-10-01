# Edge

Namespace: SpatialGraph

A line segment which is formed from 2 nodes.

```csharp
public readonly record struct Edge
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://learn.microsoft.com/en-us/dotnet/api/system.valuetype) → [Edge](./spatialgraph.edge.md)<br>
Implements [IElement](./spatialgraph.ielement.md), [IEquatable&lt;Edge&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [IsReadOnlyAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.isreadonlyattribute)

## Properties

### **ID**

```csharp
public uint ID { get; init; }
```

#### Property Value

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

### **NodeID1**

```csharp
public uint NodeID1 { get; init; }
```

#### Property Value

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

### **NodeID2**

```csharp
public uint NodeID2 { get; init; }
```

#### Property Value

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

## Constructors

### **Edge(UInt32, UInt32, UInt32)**

A line segment which is formed from 2 nodes.

```csharp
public Edge(uint ID, uint NodeID1, uint NodeID2)
```

#### Parameters

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

`NodeID1` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

`NodeID2` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
