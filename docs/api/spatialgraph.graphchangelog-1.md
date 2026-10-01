# GraphChangeLog&lt;TNode&gt;

Namespace: SpatialGraph

Logs incoming changes for a graph. Stores additional data: type of modification of an element (Add, Modify, Delete), old value of an element (if any), and new value of an element (if any).

```csharp
public class GraphChangeLog<TNode> : IReadOnlyModificationLog`1, GraphChangeSet`1 where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Node which the base graph uses.

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [GraphChangeLog&lt;TNode&gt;](./spatialgraph.graphchangelog-1.md)<br>
Implements IReadOnlyModificationLog&lt;TNode&gt;, GraphChangeSet&lt;TNode&gt;<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute)

## Properties

### **BaseGraph**

```csharp
public IReadOnlyGraph<TNode> BaseGraph { get; }
```

#### Property Value

IReadOnlyGraph&lt;TNode&gt;<br>

### **NodeModType**

```csharp
public IReadOnlyDictionary<uint, ModificationType> NodeModType { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;UInt32, ModificationType&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

### **EdgeModType**

```csharp
public IReadOnlyDictionary<uint, ModificationType> EdgeModType { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;UInt32, ModificationType&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

### **NewNodes**

```csharp
public IReadOnlyDictionary<uint, ElementAdded<TNode>> NewNodes { get; }
```

#### Property Value

IReadOnlyDictionary&lt;UInt32, ElementAdded&lt;TNode&gt;&gt;<br>

### **NewEdges**

```csharp
public IReadOnlyDictionary<uint, ElementAdded<Edge>> NewEdges { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;UInt32, ElementAdded&lt;Edge&gt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

### **ModifiedNodes**

```csharp
public IReadOnlyDictionary<uint, ElementModified<TNode>> ModifiedNodes { get; }
```

#### Property Value

IReadOnlyDictionary&lt;UInt32, ElementModified&lt;TNode&gt;&gt;<br>

### **ModifiedEdges**

```csharp
public IReadOnlyDictionary<uint, ElementModified<Edge>> ModifiedEdges { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;UInt32, ElementModified&lt;Edge&gt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

### **RemovedNodes**

```csharp
public IReadOnlyDictionary<uint, ElementRemoved<TNode>> RemovedNodes { get; }
```

#### Property Value

IReadOnlyDictionary&lt;UInt32, ElementRemoved&lt;TNode&gt;&gt;<br>

### **RemovedEdges**

```csharp
public IReadOnlyDictionary<uint, ElementRemoved<Edge>> RemovedEdges { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;UInt32, ElementRemoved&lt;Edge&gt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

## Constructors

### **GraphChangeLog(IReadOnlyGraph&lt;TNode&gt;)**

Create a ChangeLog referencing a graph.

```csharp
public GraphChangeLog(IReadOnlyGraph<TNode> baseGraph)
```

#### Parameters

`baseGraph` IReadOnlyGraph&lt;TNode&gt;<br>
Graph to reference the changes from.

### **GraphChangeLog(IReadOnlyModificationLog&lt;TNode&gt;)**

Duplicate a ChangeLog from another ChangeLog.

```csharp
public GraphChangeLog(IReadOnlyModificationLog<TNode> baseGraph)
```

#### Parameters

`baseGraph` IReadOnlyModificationLog&lt;TNode&gt;<br>
ChangeLog to duplicate from.

### **GraphChangeLog(IReadOnlyGraph&lt;TNode&gt;, GraphChangeSet&lt;TNode&gt;)**

Create a ChangeLog referencing a graph with changes from a ChangeSet.

```csharp
public GraphChangeLog(IReadOnlyGraph<TNode> baseGraph, GraphChangeSet<TNode> changeSet)
```

#### Parameters

`baseGraph` IReadOnlyGraph&lt;TNode&gt;<br>
Graph to reference the changes from.

`changeSet` GraphChangeSet&lt;TNode&gt;<br>
Set of changes to log.

## Methods

### **LogChangeSet(GraphChangeSet&lt;TNode&gt;)**

Log changes from a change set.

```csharp
public void LogChangeSet(GraphChangeSet<TNode> batchedMods)
```

#### Parameters

`batchedMods` GraphChangeSet&lt;TNode&gt;<br>
Contains set of changes for this graph.

### **EdgeUpsert(Edge)**

Add a log for a new edge or modify an edge with its corresponding ID. This will not add it to the base graph.

```csharp
public void EdgeUpsert(Edge edge)
```

#### Parameters

`edge` [Edge](./spatialgraph.edge.md)<br>
Edge to upsert, identified by its ID.

### **NodeUpsert(TNode)**

Add a log for new node or modify a node with its corresponding ID. This will not add it to the base graph.

```csharp
public void NodeUpsert(TNode node)
```

#### Parameters

`node` TNode<br>
Node to upsert, identified by its ID.

### **EdgeRemoval(UInt32)**

Add a log for the removal of an edge in the graph using its corresponding ID. This will not remove it from the base graph.

```csharp
public void EdgeRemoval(uint ID)
```

#### Parameters

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the edge to be removed.

### **NodeRemoval(UInt32)**

Add a log for the removal of a node in the graph using its corresponding ID. This will not remove it from the base graph.

```csharp
public void NodeRemoval(uint ID)
```

#### Parameters

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to be removed.

### **UnlogEdge(UInt32)**

Remove the log of a change in an edge.

```csharp
public void UnlogEdge(uint ID)
```

#### Parameters

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the edge for its log to be removed.

### **UnlogNode(UInt32)**



```csharp
public void UnlogNode(uint ID)
```

#### Parameters

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

### **NodeUpserts()**

Log of nodes to be upserted/has been upserted in the graph.

```csharp
public IEnumerable<TNode> NodeUpserts()
```

#### Returns

IEnumerable&lt;TNode&gt;<br>

### **EdgeUpserts()**

Log of edges to be upserted/has been upserted in the graph.

```csharp
public IEnumerable<Edge> EdgeUpserts()
```

#### Returns

[IEnumerable&lt;Edge&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

### **NodeRemovals()**

Log of nodes to be removed/has been removed in the graph.

```csharp
public IEnumerable<uint> NodeRemovals()
```

#### Returns

[IEnumerable&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>

### **EdgeRemovals()**

Log of edges to be removed/has been removed in the graph.

```csharp
public IEnumerable<uint> EdgeRemovals()
```

#### Returns

[IEnumerable&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
