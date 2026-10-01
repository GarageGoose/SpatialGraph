## GraphPlugin\<TNode\>\.RemoveEdge\(uint\) Method

Remove an edge in the graph using its corresponding ID\.
Nodes and edges can share the same ID, this will remove only the edge with the corresponding ID\.

```csharp
public bool RemoveEdge(uint ID);
```
#### Parameters

<a name='SpatialGraph.Metadata.GraphPlugin_TNode_.RemoveEdge(uint).ID'></a>

`ID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the edge to be removed\.

Implements [RemoveEdge\(uint\)](SpatialGraph.IGraph_TNode_.RemoveEdge(uint).md 'SpatialGraph\.IGraph\<TNode\>\.RemoveEdge\(uint\)')

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
Edge is removed\.