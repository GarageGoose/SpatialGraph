## SpatialGraph2DOperations\.IsNodeWithinAABB\(this Node2D, Vector2, float, float\) Method

Check if a node is within an axis aligned bounding box\.

```csharp
public static bool IsNodeWithinAABB(this SpatialGraph.Node2D node, System.Numerics.Vector2 topLeftCorner, float width, float height);
```
#### Parameters

<a name='SpatialGraph.Extentions.SpatialGraph2DOperations.IsNodeWithinAABB(thisSpatialGraph.Node2D,System.Numerics.Vector2,float,float).node'></a>

`node` [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')

Node to check\.

<a name='SpatialGraph.Extentions.SpatialGraph2DOperations.IsNodeWithinAABB(thisSpatialGraph.Node2D,System.Numerics.Vector2,float,float).topLeftCorner'></a>

`topLeftCorner` [System\.Numerics\.Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2 'System\.Numerics\.Vector2')

Upper left bounds of the AABB\.

<a name='SpatialGraph.Extentions.SpatialGraph2DOperations.IsNodeWithinAABB(thisSpatialGraph.Node2D,System.Numerics.Vector2,float,float).width'></a>

`width` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Width of the AABB\.

<a name='SpatialGraph.Extentions.SpatialGraph2DOperations.IsNodeWithinAABB(thisSpatialGraph.Node2D,System.Numerics.Vector2,float,float).height'></a>

`height` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Height of the AABB\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the node is within AABB, else false\.