## Edge Struct

A line segment which is formed from 2 [INode](../INode/index.md 'SpatialGraph\.INode')\.

```csharp
public readonly record struct Edge : SpatialGraph.IElement, System.IEquatable<SpatialGraph.Edge>
```

Implements [IElement](../IElement/index.md 'SpatialGraph\.IElement'), [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[Edge](index.md 'SpatialGraph\.Edge')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [Edge(uint, uint, uint)](Edge(uint,uint,uint).md 'SpatialGraph\.Edge\.Edge(uint, uint, uint)') | A line segment which is formed from 2 [INode](../INode/index.md 'SpatialGraph\.INode')\. |

| Properties | |
| :--- | :--- |
| [ID](ID.md 'SpatialGraph\.Edge\.ID') | Unique identifier for an element\. |
| [NodeID1](NodeID1.md 'SpatialGraph\.Edge\.NodeID1') | ID of the node for the first endpoint of the edge\. |
| [NodeID2](NodeID2.md 'SpatialGraph\.Edge\.NodeID2') | ID of the node for the second endpoint of the edge\. |
