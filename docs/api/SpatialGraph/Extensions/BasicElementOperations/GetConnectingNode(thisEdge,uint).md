## BasicElementOperations\.GetConnectingNode(this Edge, uint) Method

Get the opposing endpoint from an [Edge](../../Edge/index.md 'SpatialGraph\.Edge')\.

```csharp
public static uint GetConnectingNode(this SpatialGraph.Edge edge, uint sourceNodeID);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicElementOperations.GetConnectingNode(thisSpatialGraph.Edge,uint).edge'></a>

`edge` [Edge](../../Edge/index.md 'SpatialGraph\.Edge')

Edge to check\.

<a name='SpatialGraph.Extensions.BasicElementOperations.GetConnectingNode(thisSpatialGraph.Edge,uint).sourceNodeID'></a>

`sourceNodeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to get the opposing endpoint\.

#### Returns
[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')  
Connecting node from the node\.