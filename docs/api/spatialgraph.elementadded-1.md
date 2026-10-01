# ElementAdded&lt;TElement&gt;

Namespace: SpatialGraph

Single log of an element which is added. Used in a ModificationLog.

```csharp
public readonly record struct ElementAdded<TElement> where TElement : struct
```

#### Type Parameters

`TElement`<br>
Type of an element which is/will be added. Typically an edge or a type of node.

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://learn.microsoft.com/en-us/dotnet/api/system.valuetype) → [ElementAdded&lt;TElement&gt;](./spatialgraph.elementadded-1.md)<br>
Implements IEquatable&lt;ElementAdded&lt;TElement&gt;&gt;<br>
Attributes [IsReadOnlyAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.isreadonlyattribute)

## Properties

### **Element**

Value of an element which is/will be added.

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

### **ElementAdded(TElement, UInt32)**

Single log of an element which is added. Used in a ModificationLog.

```csharp
public ElementAdded(TElement Element, uint ID)
```

#### Parameters

`Element` TElement<br>
Value of an element which is/will be added.

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
Identifier of the element.
