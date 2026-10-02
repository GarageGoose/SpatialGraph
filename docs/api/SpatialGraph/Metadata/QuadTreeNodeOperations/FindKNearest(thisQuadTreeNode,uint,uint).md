## QuadTreeNodeOperations\.FindKNearest(this QuadTreeNode, uint, uint) Method

Find K nearest node from a node\.

```csharp
public static System.Collections.Generic.IEnumerable<uint> FindKNearest(this SpatialGraph.Metadata.QuadTreeNode Quadtree, uint SourceNodeID, uint KNodes);
```
#### Parameters

<a name='SpatialGraph.Metadata.QuadTreeNodeOperations.FindKNearest(thisSpatialGraph.Metadata.QuadTreeNode,uint,uint).Quadtree'></a>

`Quadtree` [QuadTreeNode](../QuadTreeNode/index.md 'SpatialGraph\.Metadata\.QuadTreeNode')

Quadtree where the nodes resides\.

<a name='SpatialGraph.Metadata.QuadTreeNodeOperations.FindKNearest(thisSpatialGraph.Metadata.QuadTreeNode,uint,uint).SourceNodeID'></a>

`SourceNodeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to find its nearest neighbor\.

<a name='SpatialGraph.Metadata.QuadTreeNodeOperations.FindKNearest(thisSpatialGraph.Metadata.QuadTreeNode,uint,uint).KNodes'></a>

`KNodes` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

Amount of neighbors to find\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
ID of the nearest K neighbors of a node\. Returns the ID of the current node if the quadtree only has one node\.