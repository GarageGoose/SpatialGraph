## QuadTreeNodeOperations\.QueryAABB(this QuadTreeNode, Vector2, float, float) Method

Find nodes withn an axis aligned bounding box in a 2D quadtree\.

```csharp
public static System.Collections.Generic.IEnumerable<uint> QueryAABB(this SpatialGraph.Metadata.QuadTreeNode Quadtree, System.Numerics.Vector2 TopLeftCorner, float Width, float Height);
```
#### Parameters

<a name='SpatialGraph.Metadata.QuadTreeNodeOperations.QueryAABB(thisSpatialGraph.Metadata.QuadTreeNode,System.Numerics.Vector2,float,float).Quadtree'></a>

`Quadtree` [QuadTreeNode](../QuadTreeNode/index.md 'SpatialGraph\.Metadata\.QuadTreeNode')

Quadtree where the nodes resides\.

<a name='SpatialGraph.Metadata.QuadTreeNodeOperations.QueryAABB(thisSpatialGraph.Metadata.QuadTreeNode,System.Numerics.Vector2,float,float).TopLeftCorner'></a>

`TopLeftCorner` [System\.Numerics\.Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2 'System\.Numerics\.Vector2')

Top left boundary of the AABB\.

<a name='SpatialGraph.Metadata.QuadTreeNodeOperations.QueryAABB(thisSpatialGraph.Metadata.QuadTreeNode,System.Numerics.Vector2,float,float).Width'></a>

`Width` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Width of the AABB\.

<a name='SpatialGraph.Metadata.QuadTreeNodeOperations.QueryAABB(thisSpatialGraph.Metadata.QuadTreeNode,System.Numerics.Vector2,float,float).Height'></a>

`Height` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Height of the AABB\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
Nodes within an AABB\.