# GraphPlugin&lt;TNode&gt;

Namespace: SpatialGraph.Metadata

Base class for plugins which can observe and modify changes either in a graph or another plugin (only GraphPlugins).

```csharp
public abstract class GraphPlugin<TNode> : IInterceptableTrackedGraph`1, ITrackedGraph`1, IReadOnlyTrackedGraph`1, IReadOnlyGraph`1, IGraph`1 where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node used in the base graph.

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [GraphPlugin&lt;TNode&gt;](./spatialgraph.metadata.graphplugin-1.md)<br>
Implements IInterceptableTrackedGraph&lt;TNode&gt;, ITrackedGraph&lt;TNode&gt;, IReadOnlyTrackedGraph&lt;TNode&gt;, IReadOnlyGraph&lt;TNode&gt;, IGraph&lt;TNode&gt;

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

### **GraphPlugin(IInterceptableTrackedGraph&lt;TNode&gt;)**

Listens to a graph when an update occurs.
 An update is invoked when the base graph is modified by adding, modifying, and removing any of its elements.

```csharp
public GraphPlugin(IInterceptableTrackedGraph<TNode> baseGraph)
```

#### Parameters

`baseGraph` IInterceptableTrackedGraph&lt;TNode&gt;<br>

### **GraphPlugin(GraphPlugin&lt;TNode&gt;, GraphPluginSubscription)**

Listens to the plugin when an update occurs.
 An update is invoked when the base graph is modified by adding, modifying, and removing any of its elements.

```csharp
public GraphPlugin(GraphPlugin<TNode> baseGraph, GraphPluginSubscription SubscribeTo)
```

#### Parameters

`baseGraph` [GraphPlugin&lt;TNode&gt;](./spatialgraph.metadata.graphplugin-1.md)<br>
Plugin to subscribe to.

`SubscribeTo` [GraphPluginSubscription](./spatialgraph.metadata.graphpluginsubscription.md)<br>
Determine which event from the baseGraph to subscribe to.

## Methods

### **OnGraphUpdate(Object, GraphChangeLog&lt;TNode&gt;)**

Emits when a modification occurs in the base graph.

```csharp
protected abstract void OnGraphUpdate(object? sender, GraphChangeLog<TNode> modLog)
```

#### Parameters

`sender` [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object)?<br>
Source of the event.

`modLog` GraphChangeLog&lt;TNode&gt;<br>
Log of changes for the base graph.

### **ApplyChangeSet(GraphChangeSet&lt;TNode&gt;)**

Perform multiple operations at once with a GraphChangeSet. Existing nodes or edges with
 a corresponding ID in the graph will be replaced.
 Nodes and edges can share the same ID.

```csharp
public void ApplyChangeSet(GraphChangeSet<TNode> modifications)
```

#### Parameters

`modifications` GraphChangeSet&lt;TNode&gt;<br>
Contains operations to perform.

### **GenerateID()**

Generate unique ID for the elements of the graph.
 Nodes and edges can share the same ID.

```csharp
public uint GenerateID()
```

#### Returns

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

### **RemoveEdge(UInt32)**

Remove an edge in the graph using its corresponding ID.
 Nodes and edges can share the same ID, this will remove only the edge with the corresponding ID.

```csharp
public bool RemoveEdge(uint ID)
```

#### Parameters

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the edge to be removed.

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Edge is removed.

### **RemoveNode(UInt32)**

Remove a node in the graph using its correspinding ID. Connecting edges referencing this node will not be removed.
 Nodes and edges can share the same ID, this will remove only the node with the corresponding ID.

```csharp
public bool RemoveNode(uint ID)
```

#### Parameters

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to be removed.

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Node is removed.

### **UpsertEdge(Edge)**

Add a new edge or modify an edge with its corresponding ID.

```csharp
public void UpsertEdge(Edge edge)
```

#### Parameters

`edge` [Edge](./spatialgraph.edge.md)<br>
Edge to upsert, identified by its ID.

### **UpsertNode(TNode)**

Add a new node or modify one with their corresponding ID.
 Nodes and edges can share the same ID.

```csharp
public void UpsertNode(TNode Node)
```

#### Parameters

`Node` TNode<br>
Node to upsert, identified by its ID.

## Events

### **OnGraphPluginUpdated**

Emits after the plugin starts logging changes.

```csharp
public event EventHandler<GraphChangeLog<TNode>>? OnGraphPluginUpdated;
```

### **OnGraphPluginInit**

Emits before the plugin starts logging changes.

```csharp
public event EventHandler<GraphChangeLog<TNode>>? OnGraphPluginInit;
```

### **OnGraphModificationInit**

```csharp
public event EventHandler<GraphChangeLog<TNode>>? OnGraphModificationInit;
```

### **OnGraphModified**

```csharp
public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphModified;
```
