## GraphHistory\<TNode\>\.TakeSnapshot\(int\) Method

Reconstruct a graph from a specific modification step\. A modification snapshot is a ModificationLog which is taken every time the graph is updated with each one counting as a single modStep, with index 0 being the oldest/first snapshot\.

```csharp
public SpatialGraph.Metadata.GraphSnapshot<TNode> TakeSnapshot(int modStep);
```
#### Parameters

<a name='SpatialGraph.Metadata.GraphHistory_TNode_.TakeSnapshot(int).modStep'></a>

`modStep` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

Modification step to reconstruct a graph from\.

#### Returns
[SpatialGraph\.Metadata\.GraphSnapshot&lt;](https://learn.microsoft.com/en-us/dotnet/api/spatialgraph.metadata.graphsnapshot-1 'SpatialGraph\.Metadata\.GraphSnapshot\`1')[TNode](SpatialGraph.Metadata.GraphHistory_TNode_.md#SpatialGraph.Metadata.GraphHistory_TNode_.TNode 'SpatialGraph\.Metadata\.GraphHistory\<TNode\>\.TNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/spatialgraph.metadata.graphsnapshot-1 'SpatialGraph\.Metadata\.GraphSnapshot\`1')  
Reconstructed graph\.