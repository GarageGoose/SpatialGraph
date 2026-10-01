# TrackedGraph&lt;TNode&gt;

Namespace: SpatialGraph

Graph which tracks changes within it.

```csharp
public class TrackedGraph<TNode> : Graph`1, IGraph`1, IReadOnlyGraph`1, ITrackedGraph`1, IReadOnlyTrackedGraph`1 where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node to be used in the graph.

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → Graph&lt;TNode&gt; → [TrackedGraph&lt;TNode&gt;](./spatialgraph.trackedgraph-1.md)<br>
Implements IGraph&lt;TNode&gt;, IReadOnlyGraph&lt;TNode&gt;, ITrackedGraph&lt;TNode&gt;, IReadOnlyTrackedGraph&lt;TNode&gt;

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

### **TrackedGraph()**

Start an empty graph.

```csharp
public TrackedGraph()
```

### **TrackedGraph(IReadOnlyGraph&lt;TNode&gt;)**

Start graph from a pre-exisitng graph.

```csharp
public TrackedGraph(IReadOnlyGraph<TNode> graph)
```

#### Parameters

`graph` IReadOnlyGraph&lt;TNode&gt;<br>
Graph to replicate from.

### **TrackedGraph(Dictionary&lt;UInt32, TNode&gt;, Dictionary&lt;UInt32, Edge&gt;)**

Start a graph from pre-exisiting dictionaries of nodes and edges.

```csharp
public TrackedGraph(Dictionary<uint, TNode> nodes, Dictionary<uint, Edge> edges)
```

#### Parameters

`nodes` Dictionary&lt;UInt32, TNode&gt;<br>

`edges` [Dictionary&lt;UInt32, Edge&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2)<br>

## Methods

### **ApplyChangeSet(GraphChangeSet&lt;TNode&gt;)**

```csharp
public override void ApplyChangeSet(GraphChangeSet<TNode> mods)
```

#### Parameters

`mods` GraphChangeSet&lt;TNode&gt;<br>

### **RemoveEdge(UInt32)**

```csharp
public override bool RemoveEdge(uint ID)
```

#### Parameters

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **RemoveNode(UInt32)**

```csharp
public override bool RemoveNode(uint ID)
```

#### Parameters

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **UpsertEdge(Edge)**

```csharp
public override void UpsertEdge(Edge edge)
```

#### Parameters

`edge` [Edge](./spatialgraph.edge.md)<br>

### **UpsertNode(TNode)**

```csharp
public override void UpsertNode(TNode Node)
```

#### Parameters

`Node` TNode<br>

## Events

### **OnGraphModified**

```csharp
public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphModified;
```
