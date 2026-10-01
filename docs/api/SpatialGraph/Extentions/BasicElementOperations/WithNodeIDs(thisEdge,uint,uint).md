## BasicElementOperations\.WithNodeIDs(this Edge, uint, uint) Method

Creates a new copy of an edge with different ID of connecting nodes\.

```csharp
public static SpatialGraph.Edge WithNodeIDs(this SpatialGraph.Edge edge, uint newNodeID1, uint newNodeID2);
```
#### Parameters

<a name='SpatialGraph.Extentions.BasicElementOperations.WithNodeIDs(thisSpatialGraph.Edge,uint,uint).edge'></a>

`edge` [Edge](../../Edge/index.md 'SpatialGraph\.Edge')

Edge to copy\.

<a name='SpatialGraph.Extentions.BasicElementOperations.WithNodeIDs(thisSpatialGraph.Edge,uint,uint).newNodeID1'></a>

`newNodeID1` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

New node ID for the first edge\.

<a name='SpatialGraph.Extentions.BasicElementOperations.WithNodeIDs(thisSpatialGraph.Edge,uint,uint).newNodeID2'></a>

`newNodeID2` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

New node ID for the second edge\.

#### Returns
[Edge](../../Edge/index.md 'SpatialGraph\.Edge')  
Edge with new connecting nodes\.