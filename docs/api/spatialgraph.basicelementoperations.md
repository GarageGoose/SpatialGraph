# BasicElementOperations

Namespace: SpatialGraph

Basic operation for the elements of a graph.

```csharp
public static class BasicElementOperations
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [BasicElementOperations](./spatialgraph.basicelementoperations.md)<br>
Attributes [ExtensionAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.extensionattribute)

## Methods

### **WithID(Edge, UInt32)**

Create a new copy of an edge with a different ID.

```csharp
public static Edge WithID(Edge edge, uint newID)
```

#### Parameters

`edge` [Edge](./spatialgraph.edge.md)<br>
Edge to copy.

`newID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID for the new edge.

#### Returns

[Edge](./spatialgraph.edge.md)<br>
Edge with new ID.

### **WithNodeIDs(Edge, UInt32, UInt32)**

Creates a new copy of an edge with different ID of connecting nodes.

```csharp
public static Edge WithNodeIDs(Edge edge, uint newNodeID1, uint newNodeID2)
```

#### Parameters

`edge` [Edge](./spatialgraph.edge.md)<br>
Edge to copy.

`newNodeID1` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
New node ID for the first edge.

`newNodeID2` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
New node ID for the second edge.

#### Returns

[Edge](./spatialgraph.edge.md)<br>
Edge with new connecting nodes.

### **WithNodeID1(Edge, UInt32)**

Creates a new copy of an edge with different ID of the first connecting node.

```csharp
public static Edge WithNodeID1(Edge edge, uint newNodeID1)
```

#### Parameters

`edge` [Edge](./spatialgraph.edge.md)<br>
Edge to copy.

`newNodeID1` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
New node ID for the first edge.

#### Returns

[Edge](./spatialgraph.edge.md)<br>
Edge with new connecting node.

### **WithNodeID2(Edge, UInt32)**

Creates a new copy of an edge with different ID of the second connecting node.

```csharp
public static Edge WithNodeID2(Edge edge, uint newNodeID2)
```

#### Parameters

`edge` [Edge](./spatialgraph.edge.md)<br>
Edge to copy.

`newNodeID2` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
New node ID for the second edge.

#### Returns

[Edge](./spatialgraph.edge.md)<br>
Edge with new connecting node.

### **WithID(Node2D, UInt32)**

Creates a new copy of a node with a different ID.

```csharp
public static Node2D WithID(Node2D node, uint newID)
```

#### Parameters

`node` [Node2D](./spatialgraph.node2d.md)<br>
Node to copy.

`newID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID for the new node.

#### Returns

[Node2D](./spatialgraph.node2d.md)<br>
Node with new ID.

### **WithLoc(Node2D, Vector2)**

Creates a new copy of a node with a different node location.

```csharp
public static Node2D WithLoc(Node2D node, Vector2 newLoc)
```

#### Parameters

`node` [Node2D](./spatialgraph.node2d.md)<br>
Node to copy.

`newLoc` [Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2)<br>
New location of the node.

#### Returns

[Node2D](./spatialgraph.node2d.md)<br>
Node with new location.

### **WithX(Node2D, Single)**

Creates a new copy of a node with a different X location.

```csharp
public static Node2D WithX(Node2D node, float newX)
```

#### Parameters

`node` [Node2D](./spatialgraph.node2d.md)<br>
Node to copy.

`newX` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
New X location of the node.

#### Returns

[Node2D](./spatialgraph.node2d.md)<br>
Node with new X location.

### **WithY(Node2D, Single)**

Creates a new copy of a node with a different Y location.

```csharp
public static Node2D WithY(Node2D node, float newY)
```

#### Parameters

`node` [Node2D](./spatialgraph.node2d.md)<br>
Node to copy.

`newY` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
New Y location of the node.

#### Returns

[Node2D](./spatialgraph.node2d.md)<br>
Node with new Y location.

### **WithID(Node3D, UInt32)**

Creates a new copy of a node with a different ID.

```csharp
public static Node3D WithID(Node3D node, uint newID)
```

#### Parameters

`node` [Node3D](./spatialgraph.node3d.md)<br>
Node to copy.

`newID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID for the new node.

#### Returns

[Node3D](./spatialgraph.node3d.md)<br>
Node with new ID.

### **WithLoc(Node3D, Vector3)**

Creates a new copy of a node with a different node location.

```csharp
public static Node3D WithLoc(Node3D node, Vector3 newLoc)
```

#### Parameters

`node` [Node3D](./spatialgraph.node3d.md)<br>
Node to copy.

`newLoc` [Vector3](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector3)<br>
New location of the node.

#### Returns

[Node3D](./spatialgraph.node3d.md)<br>
Node with new location.

### **WithX(Node3D, Single)**

Creates a new copy of a node with a different X location.

```csharp
public static Node3D WithX(Node3D node, float newX)
```

#### Parameters

`node` [Node3D](./spatialgraph.node3d.md)<br>
Node to copy.

`newX` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
New X location of the node.

#### Returns

[Node3D](./spatialgraph.node3d.md)<br>
Node with new X location.

### **WithY(Node3D, Single)**

Creates a new copy of a node with a different Y location.

```csharp
public static Node3D WithY(Node3D node, float newY)
```

#### Parameters

`node` [Node3D](./spatialgraph.node3d.md)<br>
Node to copy.

`newY` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
New Y location of the node.

#### Returns

[Node3D](./spatialgraph.node3d.md)<br>
Node with new Y location.

### **WithZ(Node3D, Single)**

Creates a new copy of a node with a different Y location.

```csharp
public static Node3D WithZ(Node3D node, float newZ)
```

#### Parameters

`node` [Node3D](./spatialgraph.node3d.md)<br>
Node to copy.

`newZ` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
New Z location of the node.

#### Returns

[Node3D](./spatialgraph.node3d.md)<br>
Node with new Z location.

### **GetFirstNodeOfEdge&lt;TNode&gt;(IReadOnlyGraph&lt;TNode&gt;, UInt32)**

Get the first connecting node of an edge.

```csharp
public static TNode GetFirstNodeOfEdge<TNode>(IReadOnlyGraph<TNode> graph, uint edgeID) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node used in the graph.

#### Parameters

`graph` IReadOnlyGraph&lt;TNode&gt;<br>
Graph where the edge resides.

`edgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the edge.

#### Returns

TNode<br>
First connecting node of the edge.

### **GetSecondNodeOfEdge&lt;TNode&gt;(IReadOnlyGraph&lt;TNode&gt;, UInt32)**

Get the second connecting node of an edge.

```csharp
public static TNode GetSecondNodeOfEdge<TNode>(IReadOnlyGraph<TNode> graph, uint edgeID) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node used in the graph.

#### Parameters

`graph` IReadOnlyGraph&lt;TNode&gt;<br>
Graph where the edge resides.

`edgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the edge.

#### Returns

TNode<br>
Second connecting node of the edge.

### **EdgeAssignmentOfNode(Edge, UInt32)**

Determine if a node is assigned as Node 1 or Node 2 in an edge.

```csharp
public static NodeInEdge EdgeAssignmentOfNode(Edge edge, uint nodeID)
```

#### Parameters

`edge` [Edge](./spatialgraph.edge.md)<br>

`nodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

#### Returns

[NodeInEdge](./spatialgraph.nodeinedge.md)<br>

### **EdgeHasNodeID(Edge, UInt32)**

Check if an Edge connect to a node with a specific ID.

```csharp
public static bool EdgeHasNodeID(Edge edge, uint nodeID)
```

#### Parameters

`edge` [Edge](./spatialgraph.edge.md)<br>
Edge to check.

`nodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to check.

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
True if the edge connects to the specific node ID, else false.

### **GetConnectingNode(Edge, UInt32)**

Get the other connecting node from node in an edge.

```csharp
public static uint GetConnectingNode(Edge edge, uint sourceNodeID)
```

#### Parameters

`edge` [Edge](./spatialgraph.edge.md)<br>

`sourceNodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

#### Returns

[UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
