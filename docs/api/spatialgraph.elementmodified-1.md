# ElementModified&lt;TElement&gt;

Namespace: SpatialGraph

Single log of an element which is modified. Used in a ModificationLog.

```csharp
public readonly record struct ElementModified<TElement> where TElement : struct
```

#### Type Parameters

`TElement`<br>
Type of an element which is modified. Typically an edge or a type of node.

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://learn.microsoft.com/en-us/dotnet/api/system.valuetype) → [ElementModified&lt;TElement&gt;](./spatialgraph.elementmodified-1.md)<br>
Implements IEquatable&lt;ElementModified&lt;TElement&gt;&gt;<br>
Attributes [IsReadOnlyAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.isreadonlyattribute)

## Properties

### **NewElement**

The new value of the element after it was modified.

```csharp
public TElement NewElement { get; init; }
```

#### Property Value

TElement<br>

### **OldElement**

The old value of the element before it was modified.

```csharp
public TElement OldElement { get; init; }
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

### **ElementModified(TElement, TElement, UInt32)**

Single log of an element which is modified. Used in a ModificationLog.

```csharp
public ElementModified(TElement NewElement, TElement OldElement, uint ID)
```

#### Parameters

`NewElement` TElement<br>
The new value of the element after it was modified.

`OldElement` TElement<br>
The old value of the element before it was modified.

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
Identifier of the element.
