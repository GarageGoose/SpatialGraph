# ElementRemoved&lt;TElement&gt;

Namespace: SpatialGraph

Single log of an element which is removed. Used in a ModificationLog.

```csharp
public readonly record struct ElementRemoved<TElement> where TElement : struct
```

#### Type Parameters

`TElement`<br>
Type of an element which is/will be removed. Typically an edge or a type of node.

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://learn.microsoft.com/en-us/dotnet/api/system.valuetype) → [ElementRemoved&lt;TElement&gt;](./spatialgraph.elementremoved-1.md)<br>
Implements IEquatable&lt;ElementRemoved&lt;TElement&gt;&gt;<br>
Attributes [IsReadOnlyAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.isreadonlyattribute)

## Properties

### **Element**

Value of an element which is/will be removed.

```csharp
public TElement Element { get; init; }
```

#### Property Value

TElement<br>

### **ID**

Identifier of the element.

```csharp
public uint ID { get; init; }
```

#### Property Value

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

## Constructors

### **ElementRemoved(TElement, UInt32)**

Single log of an element which is removed. Used in a ModificationLog.

```csharp
public ElementRemoved(TElement Element, uint ID)
```

#### Parameters

`Element` TElement<br>
Value of an element which is/will be removed.

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
Identifier of the element.
