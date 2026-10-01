# IGraph&lt;TNode&gt;

Namespace: SpatialGraph

Base interface for all graphs. A graph stores nodes and edges within it, identified by their IDs.
 Nodes and edges can share the same ID.

```csharp
public interface IGraph<TNode> : IReadOnlyGraph`1 where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node to be used in the graph.

Implements IReadOnlyGraph&lt;TNode&gt;

## Methods

### **UpsertNode(TNode)**

Add a new node or modify one with their corresponding ID.
 Nodes and edges can share the same ID.

```csharp
void UpsertNode(TNode Node)
```

#### Parameters

`Node` TNode<br>
Node to upsert, identified by its ID.

### **RemoveNode(UInt32)**

Remove a node in the graph using its correspinding ID. Connecting edges referencing this node will not be removed.
 Nodes and edges can share the same ID, this will remove only the node with the corresponding ID.

```csharp
bool RemoveNode(uint ID)
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
void UpsertEdge(Edge edge)
```

#### Parameters

`edge` [Edge](./spatialgraph.edge.md)<br>
Edge to upsert, identified by its ID.

### **RemoveEdge(UInt32)**

Remove an edge in the graph using its corresponding ID.
 Nodes and edges can share the same ID, this will remove only the edge with the corresponding ID.

```csharp
bool RemoveEdge(uint ID)
```

#### Parameters

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the edge to be removed.

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Edge is removed.

### **ApplyChangeSet(GraphChangeSet&lt;TNode&gt;)**

Perform multiple operations at once with a GraphChangeSet. Existing nodes or edges with
 a corresponding ID in the graph will be replaced.
 Nodes and edges can share the same ID.

```csharp
void ApplyChangeSet(GraphChangeSet<TNode> modifications)
```

#### Parameters

`modifications` GraphChangeSet&lt;TNode&gt;<br>
Contains operations to perform.
