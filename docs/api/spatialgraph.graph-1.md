# Graph&lt;TNode&gt;

Namespace: SpatialGraph

Base class for graphs, can be built upon.

```csharp
public class Graph<TNode> : IGraph`1, IReadOnlyGraph`1 where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node to be used in the graph.

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [Graph&lt;TNode&gt;](./spatialgraph.graph-1.md)<br>
Implements IGraph&lt;TNode&gt;, IReadOnlyGraph&lt;TNode&gt;

## Fields

### **nodes**

```csharp
protected Dictionary<uint, TNode> nodes;
```

### **edges**

```csharp
protected Dictionary<uint, Edge> edges;
```

## Properties

### **Nodes**

```csharp
public IReadOnlyDictionary<uint, TNode> Nodes { get; }
```

#### Property Value

IReadOnlyDictionary&lt;UInt32, TNode&gt;<br>

### **Edges**

```csharp
public IReadOnlyDictionary<uint, Edge> Edges { get; }
```

#### Property Value

[IReadOnlyDictionary&lt;UInt32, Edge&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)<br>

## Constructors

### **Graph()**

Start an empty graph.

```csharp
public Graph()
```

### **Graph(IReadOnlyGraph&lt;TNode&gt;)**

Start graph from a pre-exisitng graph.

```csharp
public Graph(IReadOnlyGraph<TNode> graph)
```

#### Parameters

`graph` IReadOnlyGraph&lt;TNode&gt;<br>
Graph to replicate from.

### **Graph(Dictionary&lt;UInt32, TNode&gt;, Dictionary&lt;UInt32, Edge&gt;)**

Start a graph from pre-exisiting dictionaries of nodes and edges.

```csharp
public Graph(Dictionary<uint, TNode> nodes, Dictionary<uint, Edge> edges)
```

#### Parameters

`nodes` Dictionary&lt;UInt32, TNode&gt;<br>

`edges` [Dictionary&lt;UInt32, Edge&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2)<br>

## Methods

### **UpsertNode(TNode)**

```csharp
public virtual void UpsertNode(TNode Node)
```

#### Parameters

`Node` TNode<br>

### **RemoveNode(UInt32)**

```csharp
public virtual bool RemoveNode(uint ID)
```

#### Parameters

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **UpsertEdge(Edge)**

```csharp
public virtual void UpsertEdge(Edge Edge)
```

#### Parameters

`Edge` [Edge](./spatialgraph.edge.md)<br>

### **RemoveEdge(UInt32)**

```csharp
public virtual bool RemoveEdge(uint ID)
```

#### Parameters

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **ApplyChangeSet(GraphChangeSet&lt;TNode&gt;)**

```csharp
public virtual void ApplyChangeSet(GraphChangeSet<TNode> mods)
```

#### Parameters

`mods` GraphChangeSet&lt;TNode&gt;<br>

### **GenerateID()**

```csharp
public virtual uint GenerateID()
```

#### Returns

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
