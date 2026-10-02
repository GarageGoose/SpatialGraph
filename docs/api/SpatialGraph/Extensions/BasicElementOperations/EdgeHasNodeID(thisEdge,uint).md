## BasicElementOperations\.EdgeHasNodeID(this Edge, uint) Method

Check if an Edge connect to a node with a specific ID\.

```csharp
public static bool EdgeHasNodeID(this SpatialGraph.Edge edge, uint nodeID);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicElementOperations.EdgeHasNodeID(thisSpatialGraph.Edge,uint).edge'></a>

`edge` [Edge](../../Edge/index.md 'SpatialGraph\.Edge')

Edge to check\.

<a name='SpatialGraph.Extensions.BasicElementOperations.EdgeHasNodeID(thisSpatialGraph.Edge,uint).nodeID'></a>

`nodeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to check\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the edge connects to the specific node ID, else false\.