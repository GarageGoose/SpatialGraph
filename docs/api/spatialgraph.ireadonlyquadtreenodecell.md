# IReadOnlyQuadTreeNodeCell

Namespace: SpatialGraph

A specific region in a quadtree which holds nodes or if subdivided,
 four sub quad trees each on the of the quadrant of the quadtree.

```csharp
public interface IReadOnlyQuadTreeNodeCell
```

Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute)

## Properties

### **Subdivided**

Indicated if a cell is subdivided.
 Subdivided cells contains four child cells on each of its quadrant.
 Else it contains nodes in it.

```csharp
bool Subdivided { get; }
```

#### Property Value

[Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>

### **CellCapacity**

Maximum amount of nodes allowed in this cell before being subdivied.

```csharp
int CellCapacity { get; }
```

#### Property Value

[Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32)<br>

### **Nodes**

Nodes stored in this cell. Set is empty if the cell is subdivided.

```csharp
IReadOnlySet<Node2D> Nodes { get; }
```

#### Property Value

[IReadOnlySet&lt;Node2D&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlyset-1)<br>

### **North**

Upper border of the cell.

```csharp
float North { get; }
```

#### Property Value

[Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>

### **West**

Leftmost border of the cell.

```csharp
float West { get; }
```

#### Property Value

[Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>

### **East**

Rightmost border of the cell.

```csharp
float East { get; }
```

#### Property Value

[Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>

### **South**

Lower border of the cell.

```csharp
float South { get; }
```

#### Property Value

[Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>

### **Center**

Center point of the cell.

```csharp
Vector2 Center { get; }
```

#### Property Value

[Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2)<br>

### **Width**

Width of the cell.

```csharp
float Width { get; }
```

#### Property Value

[Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>

### **Height**

Height of the cell.

```csharp
float Height { get; }
```

#### Property Value

[Single](https://learn.microsoft.com/en-us/dotnet/api/system.single)<br>

## Methods

### **UpperLeft()**

Upper left (Northwest) quadrant of the cell.

```csharp
IReadOnlyQuadTreeNodeCell? UpperLeft()
```

#### Returns

[IReadOnlyQuadTreeNodeCell](./spatialgraph.ireadonlyquadtreenodecell.md)?<br>
Quad tree cell, null if the cell isn't subdivided yet.

### **UpperRight()**

Upper right (Northeast) quadrant of the cell.

```csharp
IReadOnlyQuadTreeNodeCell? UpperRight()
```

#### Returns

[IReadOnlyQuadTreeNodeCell](./spatialgraph.ireadonlyquadtreenodecell.md)?<br>
Quad tree cell, null if the cell isn't subdivided yet.

### **LowerLeft()**

Lower left (Southwest) quadrant of the cell.

```csharp
IReadOnlyQuadTreeNodeCell? LowerLeft()
```

#### Returns

[IReadOnlyQuadTreeNodeCell](./spatialgraph.ireadonlyquadtreenodecell.md)?<br>
Quad tree cell, null if the cell isn't subdivided yet.

### **LowerRight()**

Lower right (Southeast) quadrant of the cell.

```csharp
IReadOnlyQuadTreeNodeCell? LowerRight()
```

#### Returns

[IReadOnlyQuadTreeNodeCell](./spatialgraph.ireadonlyquadtreenodecell.md)?<br>
Quad tree cell, null if the cell isn't subdivided yet.

### **ParentCell()**

Upper left (Northwest) quadrant of the cell.

```csharp
IReadOnlyQuadTreeNodeCell? ParentCell()
```

#### Returns

[IReadOnlyQuadTreeNodeCell](./spatialgraph.ireadonlyquadtreenodecell.md)?<br>
Quad tree cell, null if the current cell is the parent cell.
