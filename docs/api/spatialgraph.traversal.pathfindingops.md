# PathfindingOps

Namespace: SpatialGraph.Traversal

```csharp
public static class PathfindingOps
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [PathfindingOps](./spatialgraph.traversal.pathfindingops.md)<br>
Attributes [ExtensionAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.extensionattribute)

## Methods

### **IsNodeConnected&lt;TNode&gt;(GraphTraversal&lt;TNode&gt;)**

Check if two nodes were connected through edges.

```csharp
public static bool IsNodeConnected<TNode>(GraphTraversal<TNode> graphTraversal) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Node type.

#### Parameters

`graphTraversal` GraphTraversal&lt;TNode&gt;<br>
Traversal algorithm to use.

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
If path between the two nodes were found.

### **PathfindNodes&lt;TNode&gt;(GraphTraversal&lt;TNode&gt;, out Stack&lt;UInt32&gt;)**

Find path between two nodes.

```csharp
public static bool PathfindNodes<TNode>(GraphTraversal<TNode> graphTraversal, out Stack<uint> nodeIDs) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Node type.

#### Parameters

`graphTraversal` GraphTraversal&lt;TNode&gt;<br>
Traversal algorithm to use.

`out` `nodeIDs` [Stack&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1)<br>
IDs of nodes connecting the source and target nodes.

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
If path between the two nodes were found.

### **PathfindEdges&lt;TNode&gt;(GraphTraversal&lt;TNode&gt;, out Stack&lt;UInt32&gt;)**

Find path between two nodes.

```csharp
public static bool PathfindEdges<TNode>(GraphTraversal<TNode> graphTraversal, out Stack<uint> edgeIDs) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Node type.

#### Parameters

`graphTraversal` GraphTraversal&lt;TNode&gt;<br>
Traversal algorithm to use.

`out` `edgeIDs` [Stack&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1)<br>
IDs of edges connecting the source and target nodes.

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
If path between the two nodes were found.

### **Pathfind&lt;TNode&gt;(GraphTraversal&lt;TNode&gt;, out Stack&lt;UInt32&gt;, out Stack&lt;UInt32&gt;)**

Find path between two nodes.

```csharp
public static bool Pathfind<TNode>(GraphTraversal<TNode> graphTraversal, out Stack<uint> edgeIDs, out Stack<uint> nodeIDs) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Node type.

#### Parameters

`graphTraversal` GraphTraversal&lt;TNode&gt;<br>
Traversal algorithm to use.

`out` `edgeIDs` [Stack&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1)<br>
IDs of edges connecting the source and target nodes.

`out` `nodeIDs` [Stack&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1)<br>
IDs of nodes connecting the source and target nodes.

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
If path between the two nodes were found.

### **FloodfillNodes&lt;TNode&gt;(GraphTraversal&lt;TNode&gt;, UInt32?)**

Get all the connected nodes connected from the source node.

```csharp
public static List<uint> FloodfillNodes<TNode>(GraphTraversal<TNode> graphTraversal, uint? limitNodes = null) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Node type.

#### Parameters

`graphTraversal` GraphTraversal&lt;TNode&gt;<br>
Traversal algorithm to use.

`limitNodes` [UInt32?](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
Limit discovered nodes to a specific amount.

#### Returns

[List&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List of NodeIDs connected to the source node.

### **FloodfillEdges&lt;TNode&gt;(GraphTraversal&lt;TNode&gt;, UInt32?)**

```csharp
public static List<uint> FloodfillEdges<TNode>(GraphTraversal<TNode> graphTraversal, uint? limitEdges = null) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>

#### Parameters

`graphTraversal` GraphTraversal&lt;TNode&gt;<br>

`limitEdges` [UInt32?](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

[List&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>

### **Floodfill&lt;TNode&gt;(GraphTraversal&lt;TNode&gt;, out List&lt;UInt32&gt;, out List&lt;UInt32&gt;)**

Get connected elements from the source node.

```csharp
public static void Floodfill<TNode>(GraphTraversal<TNode> graphTraversal, out List<uint> nodeIDs, out List<uint> edgeIDs) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Node type.

#### Parameters

`graphTraversal` GraphTraversal&lt;TNode&gt;<br>
Travseral algorithm to use.

`out` `nodeIDs` [List&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
IDs of node connected from the source node.

`out` `edgeIDs` [List&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
IDs of edges connected from the source node.

### **ElementsOnTraversal&lt;TNode&gt;(GraphTraversal&lt;TNode&gt;, out List&lt;UInt32&gt;, out List&lt;UInt32&gt;)**

Get the elements traversed.

```csharp
public static void ElementsOnTraversal<TNode>(GraphTraversal<TNode> graphTraversal, out List<uint> nodeIDs, out List<uint> edgeIDs) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Node type.

#### Parameters

`graphTraversal` GraphTraversal&lt;TNode&gt;<br>
Traversal algorithm to use.

`out` `nodeIDs` [List&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
IDs of nodes traversed.

`out` `edgeIDs` [List&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
IDs of edges traversed.

### **EdgesTraversed&lt;TNode&gt;(GraphTraversal&lt;TNode&gt;, UInt32?)**

Get the edges traversed.

```csharp
public static List<uint> EdgesTraversed<TNode>(GraphTraversal<TNode> graphTraversal, uint? limitEdges = null) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Node type.

#### Parameters

`graphTraversal` GraphTraversal&lt;TNode&gt;<br>
Traversal algorithm to use.

`limitEdges` [UInt32?](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>
Limit discovered edges to a specific amount.

#### Returns

[List&lt;UInt32&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)<br>
List of edges traversed.
