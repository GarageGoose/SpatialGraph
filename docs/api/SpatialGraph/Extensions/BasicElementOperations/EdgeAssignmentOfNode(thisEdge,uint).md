## BasicElementOperations\.EdgeAssignmentOfNode(this Edge, uint) Method

Determine if a [INode](../../INode/index.md 'SpatialGraph\.INode') is assigned as [NodeID1](../../Edge/NodeID1.md 'SpatialGraph\.Edge\.NodeID1') or [NodeID2](../../Edge/NodeID2.md 'SpatialGraph\.Edge\.NodeID2') in an [Edge](../../Edge/index.md 'SpatialGraph\.Edge')\.

```csharp
public static SpatialGraph.NodeInEdge EdgeAssignmentOfNode(this SpatialGraph.Edge edge, uint nodeID);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicElementOperations.EdgeAssignmentOfNode(thisSpatialGraph.Edge,uint).edge'></a>

`edge` [Edge](../../Edge/index.md 'SpatialGraph\.Edge')

Edge to check\.

<a name='SpatialGraph.Extensions.BasicElementOperations.EdgeAssignmentOfNode(thisSpatialGraph.Edge,uint).nodeID'></a>

`nodeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to check\.

#### Returns
[NodeInEdge](../../NodeInEdge/index.md 'SpatialGraph\.NodeInEdge')  
Assignment of the node in the edge, [None](../../NodeInEdge/index.md#SpatialGraph.NodeInEdge.None 'SpatialGraph\.NodeInEdge\.None') if not in edge\.