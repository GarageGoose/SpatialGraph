# GraphHistory&lt;TNode&gt;

Namespace: SpatialGraph.Metadata

Records changes from a graph.

```csharp
public class GraphHistory<TNode> : GraphReadOnlyPlugin`1, IReadOnlyTrackedGraph`1, IReadOnlyGraph`1 where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Node which the base graph uses.

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → GraphReadOnlyPlugin&lt;TNode&gt; → [GraphHistory&lt;TNode&gt;](./spatialgraph.metadata.graphhistory-1.md)<br>
Implements IReadOnlyTrackedGraph&lt;TNode&gt;, IReadOnlyGraph&lt;TNode&gt;

## Properties

### **ModSnapshotCount**

Amount of snapshots taken since the plugin was created.

```csharp
public int ModSnapshotCount { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **ModSnapshots**

List of graph modification snapshots. A modification snapshot is a ModificationLog which is taken every time the graph is updated, with index 0 being the oldest/first snapshot.

```csharp
public IReadOnlyList<IReadOnlyModificationLog<TNode>> ModSnapshots { get; }
```

#### Property Value

IReadOnlyList&lt;IReadOnlyModificationLog&lt;TNode&gt;&gt;<br>

### **GraphSnapshot**

List of graph snapshots. A graph snapshot is a reconstructed Graph from accumulated ModificationLogs. Taken and stored in this list with TakeSnapshot().

```csharp
public IReadOnlyList<GraphSnapshot<TNode>> GraphSnapshot { get; }
```

#### Property Value

IReadOnlyList&lt;GraphSnapshot&lt;TNode&gt;&gt;<br>

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

### **GraphHistory(IReadOnlyTrackedGraph&lt;TNode&gt;)**

Create a graph history from a graph.

```csharp
public GraphHistory(IReadOnlyTrackedGraph<TNode> baseGraph)
```

#### Parameters

`baseGraph` IReadOnlyTrackedGraph&lt;TNode&gt;<br>
Graph to record changes from.

## Methods

### **TakeSnapshot(Int32)**

Reconstruct a graph from a specific modification step. A modification snapshot is a ModificationLog which is taken every time the graph is updated with each one counting as a single modStep, with index 0 being the oldest/first snapshot.

```csharp
public GraphSnapshot<TNode> TakeSnapshot(int modStep)
```

#### Parameters

`modStep` [Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>
Modification step to reconstruct a graph from.

#### Returns

GraphSnapshot&lt;TNode&gt;<br>
Reconstructed graph.

### **OnGraphUpdate(Object, IReadOnlyModificationLog&lt;TNode&gt;)**

```csharp
protected override void OnGraphUpdate(object? sender, IReadOnlyModificationLog<TNode> modLog)
```

#### Parameters

`sender` [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object)?<br>

`modLog` IReadOnlyModificationLog&lt;TNode&gt;<br>

## Events

### **OnGraphPluginUpdated**

```csharp
public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphPluginUpdated;
```

### **OnGraphPluginInit**

```csharp
public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphPluginInit;
```

### **OnGraphModified**

```csharp
public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphModified;
```
