# IReadOnlyModificationLog&lt;TNode&gt;

Namespace: SpatialGraph

Logs incoming changes for a graph. Stores additional data: type of modification of an element (Add, Modify, Delete), old value of an element (if any), and new value of an element (if any).

```csharp
public interface IReadOnlyModificationLog<TNode> : GraphChangeSet`1 where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node used in the graph to log changes from.

Implements GraphChangeSet&lt;TNode&gt;<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute)

## Properties

### **BaseGraph**

Graph to reference the changes from.

```csharp
IReadOnlyGraph<TNode> BaseGraph { get; }
```

#### Property Value

IReadOnlyGraph&lt;TNode&gt;<br>

### **NodeModType**

Dictionary for type of modifications (Add, Remove, Modify) each node have.

```csharp
IReadOnlyDictionary<uint, ModificationType> NodeModType { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;UInt32, ModificationType&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

### **EdgeModType**

Dictionary for type of modifications (Add, Remove, Modify) each edge have.

```csharp
IReadOnlyDictionary<uint, ModificationType> EdgeModType { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;UInt32, ModificationType&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

### **NewNodes**

Dictionary for nodes which was/will be added.

```csharp
IReadOnlyDictionary<uint, ElementAdded<TNode>> NewNodes { get; }
```

#### Property Value

IReadOnlyDictionary&lt;UInt32, ElementAdded&lt;TNode&gt;&gt;<br>

### **NewEdges**

Dictionary for edges which was/will be added.

```csharp
IReadOnlyDictionary<uint, ElementAdded<Edge>> NewEdges { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;UInt32, ElementAdded&lt;Edge&gt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

### **ModifiedNodes**

Dictionary for nodes which was/will be modified. Contains the original and new value of the node.

```csharp
IReadOnlyDictionary<uint, ElementModified<TNode>> ModifiedNodes { get; }
```

#### Property Value

IReadOnlyDictionary&lt;UInt32, ElementModified&lt;TNode&gt;&gt;<br>

### **ModifiedEdges**

Dictionary for edges which was/will be modified. Contains the original and new value of the edge.

```csharp
IReadOnlyDictionary<uint, ElementModified<Edge>> ModifiedEdges { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;UInt32, ElementModified&lt;Edge&gt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

### **RemovedNodes**

Dictionary for nodes which was/will be removed. Contains its original value.

```csharp
IReadOnlyDictionary<uint, ElementRemoved<TNode>> RemovedNodes { get; }
```

#### Property Value

IReadOnlyDictionary&lt;UInt32, ElementRemoved&lt;TNode&gt;&gt;<br>

### **RemovedEdges**

Dictionary for edges which was/will be removed. Contains its original value.

```csharp
IReadOnlyDictionary<uint, ElementRemoved<Edge>> RemovedEdges { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;UInt32, ElementRemoved&lt;Edge&gt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>
