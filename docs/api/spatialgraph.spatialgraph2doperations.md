# SpatialGraph2DOperations

Namespace: SpatialGraph

Get spatial information in 2D graphs.

```csharp
public static class SpatialGraph2DOperations
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [SpatialGraph2DOperations](./spatialgraph.spatialgraph2doperations.md)<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute), [ExtensionAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.extensionattribute)

## Methods

### **EdgeAngle(IReadOnlyGraph&lt;Node2D&gt;, UInt32)**

Get the angle of an edge in radians.

```csharp
public static float EdgeAngle(IReadOnlyGraph<Node2D> baseGraph, uint edgeID)
```

#### Parameters

`baseGraph` [IReadOnlyGraph&lt;Node2D&gt;](./spatialgraph.ireadonlygraph-1.md)<br>
Graph where the edge resides from.

`edgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the target edge.

#### Returns

[Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
Angle of the edge in radians.

### **EdgeAngleOpposite(IReadOnlyGraph&lt;Node2D&gt;, UInt32)**

Get the angle of an edge, flipped 180 degrees, in radians.

```csharp
public static float EdgeAngleOpposite(IReadOnlyGraph<Node2D> baseGraph, uint edgeID)
```

#### Parameters

`baseGraph` [IReadOnlyGraph&lt;Node2D&gt;](./spatialgraph.ireadonlygraph-1.md)<br>
Graph where the edge resides from.

`edgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the target edge.

#### Returns

[Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
Angle of the edge, flipped 180 degrees, in radians.

### **EdgeAngleFromNode(IReadOnlyGraph&lt;Node2D&gt;, UInt32, UInt32)**

Get the angle of an edge (in radians) relative to one of the node connected from it.

```csharp
public static float EdgeAngleFromNode(IReadOnlyGraph<Node2D> baseGraph, uint edgeID, uint nodeID)
```

#### Parameters

`baseGraph` [IReadOnlyGraph&lt;Node2D&gt;](./spatialgraph.ireadonlygraph-1.md)<br>
Graph where the edge resides from.

`edgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the edge get its angle.

`nodeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the node to get the angle of the edge from.

#### Returns

[Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
Angle of the edge (in radians) relative to the node.

### **EdgeLengthSquared(IReadOnlyGraph&lt;Node2D&gt;, UInt32)**

Get the squared length of an edge.

```csharp
public static float EdgeLengthSquared(IReadOnlyGraph<Node2D> baseGraph, uint edgeID)
```

#### Parameters

`baseGraph` [IReadOnlyGraph&lt;Node2D&gt;](./spatialgraph.ireadonlygraph-1.md)<br>
Graph where the edge resides from.

`edgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the edge get its length.

#### Returns

[Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
Length of the edge.

### **EdgeLength(IReadOnlyGraph&lt;Node2D&gt;, UInt32)**

Get length of an edge.

```csharp
public static float EdgeLength(IReadOnlyGraph<Node2D> baseGraph, uint edgeID)
```

#### Parameters

`baseGraph` [IReadOnlyGraph&lt;Node2D&gt;](./spatialgraph.ireadonlygraph-1.md)<br>
Graph where the edge resides from.

`edgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of the edge get its length.

#### Returns

[Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
Length of the edge.

### **IsNodeWithinRadius(Node2D, Vector2, Single)**

Checks if a node is within the radius

```csharp
public static bool IsNodeWithinRadius(Node2D node, Vector2 loc, float radius)
```

#### Parameters

`node` [Node2D](./spatialgraph.node2d.md)<br>
Node to check.

`loc` [Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2)<br>
Location of the radius.

`radius` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
Size of the radius.

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
True of the node is within radius, else false.

### **IsNodeWithinAABB(Node2D, Vector2, Single, Single)**

Check if a node is within an axis aligned bounding box.

```csharp
public static bool IsNodeWithinAABB(Node2D node, Vector2 topLeftCorner, float width, float height)
```

#### Parameters

`node` [Node2D](./spatialgraph.node2d.md)<br>
Node to check.

`topLeftCorner` [Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2)<br>
Upper left bounds of the AABB.

`width` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
Width of the AABB.

`height` [Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>
Height of the AABB.

#### Returns

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
True if the node is within AABB, else false.
