## SpatialGraph2DOperations Class

Get spatial information in 2D graphs\.

```csharp
public static class SpatialGraph2DOperations
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → SpatialGraph2DOperations

| Methods | |
| :--- | :--- |
| [EdgeAngle(this IReadOnlyGraph&lt;Node2D&gt;, uint)](EdgeAngle(thisIReadOnlyGraph_Node2D_,uint).md 'SpatialGraph\.Extensions\.SpatialGraph2DOperations\.EdgeAngle(this SpatialGraph\.IReadOnlyGraph<SpatialGraph\.Node2D>, uint)') | Get the angle of an edge in radians\. |
| [EdgeAngleFromNode(this IReadOnlyGraph&lt;Node2D&gt;, uint, uint)](EdgeAngleFromNode(thisIReadOnlyGraph_Node2D_,uint,uint).md 'SpatialGraph\.Extensions\.SpatialGraph2DOperations\.EdgeAngleFromNode(this SpatialGraph\.IReadOnlyGraph<SpatialGraph\.Node2D>, uint, uint)') | Get the angle of an edge (in radians) relative to one of the node connected from it\. |
| [EdgeAngleOpposite(this IReadOnlyGraph&lt;Node2D&gt;, uint)](EdgeAngleOpposite(thisIReadOnlyGraph_Node2D_,uint).md 'SpatialGraph\.Extensions\.SpatialGraph2DOperations\.EdgeAngleOpposite(this SpatialGraph\.IReadOnlyGraph<SpatialGraph\.Node2D>, uint)') | Get the angle of an edge, flipped 180 degrees, in radians\. |
| [EdgeLength(this IReadOnlyGraph&lt;Node2D&gt;, uint)](EdgeLength(thisIReadOnlyGraph_Node2D_,uint).md 'SpatialGraph\.Extensions\.SpatialGraph2DOperations\.EdgeLength(this SpatialGraph\.IReadOnlyGraph<SpatialGraph\.Node2D>, uint)') | Get length of an edge\. |
| [EdgeLengthSquared(this IReadOnlyGraph&lt;Node2D&gt;, uint)](EdgeLengthSquared(thisIReadOnlyGraph_Node2D_,uint).md 'SpatialGraph\.Extensions\.SpatialGraph2DOperations\.EdgeLengthSquared(this SpatialGraph\.IReadOnlyGraph<SpatialGraph\.Node2D>, uint)') | Get the squared length of an edge\. |
| [IsNodeWithinAABB(this Node2D, Vector2, float, float)](IsNodeWithinAABB(thisNode2D,Vector2,float,float).md 'SpatialGraph\.Extensions\.SpatialGraph2DOperations\.IsNodeWithinAABB(this SpatialGraph\.Node2D, System\.Numerics\.Vector2, float, float)') | Check if a node is within an axis aligned bounding box\. |
| [IsNodeWithinRadius(this Node2D, Vector2, float)](IsNodeWithinRadius(thisNode2D,Vector2,float).md 'SpatialGraph\.Extensions\.SpatialGraph2DOperations\.IsNodeWithinRadius(this SpatialGraph\.Node2D, System\.Numerics\.Vector2, float)') | Checks if a node is within the radius |
