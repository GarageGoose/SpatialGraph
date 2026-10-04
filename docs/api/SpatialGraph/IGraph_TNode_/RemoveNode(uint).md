## IGraph<TNode>\.RemoveNode(uint) Method

Remove a [INode](../INode/index.md 'SpatialGraph\.INode') in the graph using its correspinding ID\. Connecting [Edge](../Edge/index.md 'SpatialGraph\.Edge') referencing this node will not be removed\.
Nodes and edges can share the same ID, this will remove only the node with the corresponding ID\.

```csharp
bool RemoveNode(uint ID);
```
#### Parameters

<a name='SpatialGraph.IGraph_TNode_.RemoveNode(uint).ID'></a>

`ID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to be removed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
Node is removed\.