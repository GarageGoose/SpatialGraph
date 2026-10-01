## OrderedEdgesByAngle2D\.EdgesAnglesOnNode\(uint\) Method

Returns a dictionary of connected edges from a node with its angle relative to the node\. Keyed by ID, returns node in radians\.

```csharp
public System.Collections.Generic.IReadOnlyDictionary<uint,float> EdgesAnglesOnNode(uint nodeID);
```
#### Parameters

<a name='SpatialGraph.Metadata.OrderedEdgesByAngle2D.EdgesAnglesOnNode(uint).nodeID'></a>

`nodeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to get its connected edges\.

#### Returns
[System\.Collections\.Generic\.IReadOnlyDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2 'System\.Collections\.Generic\.IReadOnlyDictionary\`2')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2 'System\.Collections\.Generic\.IReadOnlyDictionary\`2')[System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2 'System\.Collections\.Generic\.IReadOnlyDictionary\`2')  
Dictionary of connected edges\.