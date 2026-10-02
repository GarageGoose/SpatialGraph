## QuadTreeNodeOperations\.FindNearest(this QuadTreeNode, uint) Method

Find nearest node from a node\.

```csharp
public static uint FindNearest(this SpatialGraph.Metadata.QuadTreeNode Quadtree, uint SourceNodeID);
```
#### Parameters

<a name='SpatialGraph.Metadata.QuadTreeNodeOperations.FindNearest(thisSpatialGraph.Metadata.QuadTreeNode,uint).Quadtree'></a>

`Quadtree` [QuadTreeNode](../QuadTreeNode/index.md 'SpatialGraph\.Metadata\.QuadTreeNode')

Quadtree where the node resides\.

<a name='SpatialGraph.Metadata.QuadTreeNodeOperations.FindNearest(thisSpatialGraph.Metadata.QuadTreeNode,uint).SourceNodeID'></a>

`SourceNodeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to find its nearest neighbor\.

#### Returns
[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')  
ID of the nearest neighbor of a node\. Returns the ID of the current node if the quadtree only has one node\.