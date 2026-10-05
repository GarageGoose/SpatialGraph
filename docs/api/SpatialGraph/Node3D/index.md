## Node3D Struct

Node with coordinate in 3 dimensions\. Used for 3D graphs\.

```csharp
public readonly record struct Node3D : SpatialGraph.INode, SpatialGraph.IElement, System.IEquatable<SpatialGraph.Node3D>
```

Implements [INode](../INode/index.md 'SpatialGraph\.INode'), [IElement](../IElement/index.md 'SpatialGraph\.IElement'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[Node3D](index.md 'SpatialGraph\.Node3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [Node3D(uint, Vector3)](Node3D(uint,Vector3).md 'SpatialGraph\.Node3D\.Node3D(uint, System\.Numerics\.Vector3)') | Node with coordinate in 3 dimensions\. Used for 3D graphs\. |

| Properties | |
| :--- | :--- |
| [ID](ID.md 'SpatialGraph\.Node3D\.ID') | Identifier for the element\. |
| [Loc](Loc.md 'SpatialGraph\.Node3D\.Loc') | Location of the node\. |
