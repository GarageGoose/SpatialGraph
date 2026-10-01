# GraphSnapshot&lt;TNode&gt;

Namespace: SpatialGraph.Metadata

```csharp
public readonly record struct GraphSnapshot<TNode> where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [ValueType](https://learn.microsoft.com/en-us/dotnet/api/system.valuetype) → [GraphSnapshot&lt;TNode&gt;](./spatialgraph.metadata.graphsnapshot-1.md)<br>
Implements IEquatable&lt;GraphSnapshot&lt;TNode&gt;&gt;<br>
Attributes [IsReadOnlyAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.isreadonlyattribute)

## Properties

### **ModStep**

```csharp
public int ModStep { get; init; }
```

#### Property Value

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Snapshot**

```csharp
public Graph<TNode> Snapshot { get; init; }
```

#### Property Value

Graph&lt;TNode&gt;<br>

## Constructors

### **GraphSnapshot(Int32, Graph&lt;TNode&gt;)**

```csharp
public GraphSnapshot(int ModStep, Graph<TNode> Snapshot)
```

#### Parameters

`ModStep` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

`Snapshot` Graph&lt;TNode&gt;<br>
