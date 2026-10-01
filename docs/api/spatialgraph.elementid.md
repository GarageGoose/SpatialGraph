# ElementID

Namespace: SpatialGraph

Generic element identifier.

```csharp
public readonly record struct ElementID
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://learn.microsoft.com/en-us/dotnet/api/system.valuetype) → [ElementID](./spatialgraph.elementid.md)<br>
Implements [IEquatable&lt;ElementID&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1)<br>
Attributes [IsReadOnlyAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.isreadonlyattribute)

## Properties

### **Type**

Type of element, either Node or Edge.

```csharp
public ElementType Type { get; init; }
```

#### Property Value

[ElementType](./spatialgraph.elementtype.md)<br>

### **ID**

ID of the element.

```csharp
public uint ID { get; init; }
```

#### Property Value

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

## Constructors

### **ElementID(ElementType, UInt32)**

Generic element identifier.

```csharp
public ElementID(ElementType Type, uint ID)
```

#### Parameters

`Type` [ElementType](./spatialgraph.elementtype.md)<br>
Type of element, either Node or Edge.

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the element.
