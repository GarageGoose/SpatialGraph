## QuadTreeNodeOperations\.QueryCircle(this QuadTreeNode, Vector2, float) Method

Find nodes within a circle in a quadtree\.

```csharp
public static System.Collections.Generic.IEnumerable<uint> QueryCircle(this SpatialGraph.Metadata.QuadTreeNode Quadtree, System.Numerics.Vector2 Location, float Radius);
```
#### Parameters

<a name='SpatialGraph.Metadata.QuadTreeNodeOperations.QueryCircle(thisSpatialGraph.Metadata.QuadTreeNode,System.Numerics.Vector2,float).Quadtree'></a>

`Quadtree` [QuadTreeNode](../QuadTreeNode/index.md 'SpatialGraph\.Metadata\.QuadTreeNode')

Quadtree where the nodes resides\.

<a name='SpatialGraph.Metadata.QuadTreeNodeOperations.QueryCircle(thisSpatialGraph.Metadata.QuadTreeNode,System.Numerics.Vector2,float).Location'></a>

`Location` [System\.Numerics\.Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2 'System\.Numerics\.Vector2')

Center point of the circle\.

<a name='SpatialGraph.Metadata.QuadTreeNodeOperations.QueryCircle(thisSpatialGraph.Metadata.QuadTreeNode,System.Numerics.Vector2,float).Radius'></a>

`Radius` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Radius of the circle

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
Nodes within a circle\.