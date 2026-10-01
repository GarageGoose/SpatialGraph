# BasicGraphOperations

Namespace: SpatialGraph

Basic operations for a graph.

```csharp
public static class BasicGraphOperations
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [BasicGraphOperations](./spatialgraph.basicgraphoperations.md)<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute), [ExtensionAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.extensionattribute)

## Methods

### **UpsertNode(Graph&lt;Node2D&gt;, UInt32, Single, Single)**

Add or replace a node with the same ID in a 2D graph.

```csharp
public static void UpsertNode(Graph<Node2D> graph, uint ID, float X, float Y)
```

#### Parameters

`graph` [Graph&lt;Node2D&gt;](./spatialgraph.graph-1.md)<br>
Graph to upsert a node.

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to add/replace.

`X` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
X position of the node.

`Y` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
Y position of the node.

### **UpsertNode(Graph&lt;Node2D&gt;, UInt32, Vector2)**

Add or replace a node with the same ID in a 2D graph.

```csharp
public static void UpsertNode(Graph<Node2D> graph, uint ID, Vector2 Loc)
```

#### Parameters

`graph` [Graph&lt;Node2D&gt;](./spatialgraph.graph-1.md)<br>
Graph to upsert a node.

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to add/replace.

`Loc` [Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2)<br>
Location of the node.

### **AddNode(Graph&lt;Node2D&gt;, Single, Single)**

Add a node in a 2D graph.

```csharp
public static uint AddNode(Graph<Node2D> graph, float X, float Y)
```

#### Parameters

`graph` [Graph&lt;Node2D&gt;](./spatialgraph.graph-1.md)<br>
Graph to add a node.

`X` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
X position of the node.

`Y` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
Y position of the node.

#### Returns

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the new node.

### **AddNode(Graph&lt;Node2D&gt;, Vector2)**

Add a node in a 2D graph.

```csharp
public static uint AddNode(Graph<Node2D> graph, Vector2 Loc)
```

#### Parameters

`graph` [Graph&lt;Node2D&gt;](./spatialgraph.graph-1.md)<br>
Graph to add a node.

`Loc` [Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2)<br>
Location of the node.

#### Returns

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the new node.

### **UpsertNode(Graph&lt;Node3D&gt;, UInt32, Single, Single, Single)**

Add or replace a node with the same ID in a 3D graph.

```csharp
public static void UpsertNode(Graph<Node3D> graph, uint ID, float X, float Y, float Z)
```

#### Parameters

`graph` [Graph&lt;Node3D&gt;](./spatialgraph.graph-1.md)<br>
Graph to add a node.

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to add/replace.

`X` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
X position of the node.

`Y` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
Y position of the node.

`Z` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
Z position of the node.

### **UpsertNode(Graph&lt;Node3D&gt;, UInt32, Vector3)**

Add or replace a node with the same ID in a 3D graph.

```csharp
public static void UpsertNode(Graph<Node3D> graph, uint ID, Vector3 Loc)
```

#### Parameters

`graph` [Graph&lt;Node3D&gt;](./spatialgraph.graph-1.md)<br>
Graph to add a node.

`ID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to add/replace.

`Loc` [Vector3](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector3)<br>
Location of the node.

### **AddNode(Graph&lt;Node3D&gt;, Single, Single, Single)**

Add a node in a 3D graph.

```csharp
public static uint AddNode(Graph<Node3D> graph, float X, float Y, float Z)
```

#### Parameters

`graph` [Graph&lt;Node3D&gt;](./spatialgraph.graph-1.md)<br>
Graph to add a node.

`X` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
X position of the new node.

`Y` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
Y position of the new node.

`Z` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
Z position of the new node.

#### Returns

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the new node.

### **AddNode(Graph&lt;Node3D&gt;, Vector3)**

Add a node in a 3D graph.

```csharp
public static uint AddNode(Graph<Node3D> graph, Vector3 Loc)
```

#### Parameters

`graph` [Graph&lt;Node3D&gt;](./spatialgraph.graph-1.md)<br>
Graph to add a node.

`Loc` [Vector3](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector3)<br>
Location of the node.

#### Returns

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the new node.

### **AddEdge&lt;TNode&gt;(Graph&lt;TNode&gt;, UInt32, UInt32)**

Add an edge in a graph.

```csharp
public static uint AddEdge<TNode>(Graph<TNode> graph, uint NodeID1, uint NodeID2) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node the graph have.

#### Parameters

`graph` Graph&lt;TNode&gt;<br>
Graph to add an edge.

`NodeID1` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
The first node in an edge.

`NodeID2` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
The second node in an edge.

#### Returns

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

### **ReplaceNodeID(Graph&lt;Node2D&gt;, UInt32, UInt32)**

Replace the ID of a node with a new ID. Existing node with the same ID as the new ID will be replaced.

```csharp
public static void ReplaceNodeID(Graph<Node2D> graph, uint NodeID, uint NewNodeID)
```

#### Parameters

`graph` [Graph&lt;Node2D&gt;](./spatialgraph.graph-1.md)<br>
Graph where to replace a node ID.

`NodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
Current ID of the node to be replaced with a new ID.

`NewNodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
New ID of the node.

### **ReplaceNodeID(Graph&lt;Node3D&gt;, UInt32, UInt32)**

Replace the ID of a node with a new ID. Existing node with the same ID as the new ID will be replaced.

```csharp
public static void ReplaceNodeID(Graph<Node3D> graph, uint NodeID, uint NewNodeID)
```

#### Parameters

`graph` [Graph&lt;Node3D&gt;](./spatialgraph.graph-1.md)<br>
Graph where to replace a node ID.

`NodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
Current ID of the node to be replaced with a new ID.

`NewNodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
New ID of the node.

### **ReplaceEdgeID&lt;TNode&gt;(Graph&lt;TNode&gt;, UInt32, UInt32)**

Replace the ID of an edge with a new ID. An existing edge with the same ID as the new ID will be replaced.

```csharp
public static void ReplaceEdgeID<TNode>(Graph<TNode> graph, uint EdgeID, uint NewEdgeID) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>

#### Parameters

`graph` Graph&lt;TNode&gt;<br>
Graph where to replace an edge ID.

`EdgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
Current ID of the edge to be replaced with a new ID.

`NewEdgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
New ID of the edge.

### **ReplaceFirstNodeInEdge&lt;TNode&gt;(Graph&lt;TNode&gt;, UInt32, UInt32)**

Replace the first node (NodeID1) in an edge to a new one in a graph.

```csharp
public static void ReplaceFirstNodeInEdge<TNode>(Graph<TNode> graph, uint EdgeID, uint NewNodeID) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node the graph is using.

#### Parameters

`graph` Graph&lt;TNode&gt;<br>
Graph where to replace the first node of an edge.

`EdgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the edge to replace its first node.

`NewNodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to replace the first node of the edge.

### **ReplaceSecondNodeInEdge&lt;TNode&gt;(Graph&lt;TNode&gt;, UInt32, UInt32)**

Replace the second node (NodeID2) in an edge to a new one in a graph.

```csharp
public static void ReplaceSecondNodeInEdge<TNode>(Graph<TNode> graph, uint EdgeID, uint NewNodeID) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node the graph is using.

#### Parameters

`graph` Graph&lt;TNode&gt;<br>
Graph where to replace the second node of an edge.

`EdgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the edge to replace its second node.

`NewNodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to replace the second node of the edge.

### **ReplaceNodesInEdge&lt;TNode&gt;(Graph&lt;TNode&gt;, UInt32, UInt32, UInt32)**

Replace both nodes in an edge to a new one in a graph.

```csharp
public static void ReplaceNodesInEdge<TNode>(Graph<TNode> graph, uint EdgeID, uint NewNodeID1, uint NewNodeID2) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node the graph is using.

#### Parameters

`graph` Graph&lt;TNode&gt;<br>
Graph where to replace the second node of an edge.

`EdgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the edge to replace its second node.

`NewNodeID1` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to replace the first node of the edge.

`NewNodeID2` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to replace the second node of the edge.

### **ReplaceLocationOfNode(Graph&lt;Node2D&gt;, UInt32, Vector2)**

Replace the location of a node in a graph.

```csharp
public static void ReplaceLocationOfNode(Graph<Node2D> graph, uint NodeID, Vector2 NewLoc)
```

#### Parameters

`graph` [Graph&lt;Node2D&gt;](./spatialgraph.graph-1.md)<br>
Graph with the node to replace its location.

`NodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to replace its location.

`NewLoc` [Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2)<br>
New location of the node.

### **ReplaceLocationOfNode(Graph&lt;Node3D&gt;, UInt32, Vector3)**

Replace the location of a node in a graph.

```csharp
public static void ReplaceLocationOfNode(Graph<Node3D> graph, uint NodeID, Vector3 NewLoc)
```

#### Parameters

`graph` [Graph&lt;Node3D&gt;](./spatialgraph.graph-1.md)<br>
Graph with the node to replace its location.

`NodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to replace its location.

`NewLoc` [Vector3](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector3)<br>
New location of the node.

### **ReplaceXPosOfNode(Graph&lt;Node2D&gt;, UInt32, Single)**

Replace the X location of a node in a graph.

```csharp
public static void ReplaceXPosOfNode(Graph<Node2D> graph, uint NodeID, float NewXPos)
```

#### Parameters

`graph` [Graph&lt;Node2D&gt;](./spatialgraph.graph-1.md)<br>
Graph with the node to replace its X location.

`NodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to replace its X location.

`NewXPos` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
New X location of the node.

### **ReplaceXPosOfNode(Graph&lt;Node3D&gt;, UInt32, Single)**

Replace the X location of a node in a graph.

```csharp
public static void ReplaceXPosOfNode(Graph<Node3D> graph, uint NodeID, float NewXPos)
```

#### Parameters

`graph` [Graph&lt;Node3D&gt;](./spatialgraph.graph-1.md)<br>
Graph with the node to replace its X location.

`NodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to replace its X location.

`NewXPos` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
New X location of the node.

### **ReplaceYPosOfNode(Graph&lt;Node2D&gt;, UInt32, Single)**

Replace the Y location of a node in a graph.

```csharp
public static void ReplaceYPosOfNode(Graph<Node2D> graph, uint NodeID, float NewYPos)
```

#### Parameters

`graph` [Graph&lt;Node2D&gt;](./spatialgraph.graph-1.md)<br>
Graph with the node to replace its Y location.

`NodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to replace its Y location.

`NewYPos` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
New Y location of the node.

### **ReplaceYPosOfNode(Graph&lt;Node3D&gt;, UInt32, Single)**

Replace the Y location of a node in a graph.

```csharp
public static void ReplaceYPosOfNode(Graph<Node3D> graph, uint NodeID, float NewYPos)
```

#### Parameters

`graph` [Graph&lt;Node3D&gt;](./spatialgraph.graph-1.md)<br>
Graph with the node to replace its Y location.

`NodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to replace its Y location.

`NewYPos` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
New Y location of the node.

### **ReplaceZPosOfNode(Graph&lt;Node3D&gt;, UInt32, Single)**

Replace the Z location of a node in a graph.

```csharp
public static void ReplaceZPosOfNode(Graph<Node3D> graph, uint NodeID, float NewZPos)
```

#### Parameters

`graph` [Graph&lt;Node3D&gt;](./spatialgraph.graph-1.md)<br>
Graph with the node to replace its Z location.

`NodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to replace its Z location.

`NewZPos` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
New Z location of the node.
