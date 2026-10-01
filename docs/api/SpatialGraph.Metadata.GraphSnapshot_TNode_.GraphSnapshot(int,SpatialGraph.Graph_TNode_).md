## GraphSnapshot\(int, Graph\<TNode\>\) Constructor

Reconstructed graph from a specific modification step\. Used in GraphHistory\.

```csharp
public GraphSnapshot(int ModStep, SpatialGraph.Graph<TNode> Snapshot);
```
#### Parameters

<a name='SpatialGraph.Metadata.GraphSnapshot_TNode_.GraphSnapshot(int,SpatialGraph.Graph_TNode_).ModStep'></a>

`ModStep` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

Modification step which this graph is recreated from\.

<a name='SpatialGraph.Metadata.GraphSnapshot_TNode_.GraphSnapshot(int,SpatialGraph.Graph_TNode_).Snapshot'></a>

`Snapshot` [SpatialGraph\.Graph&lt;](SpatialGraph.Graph_TNode_.md 'SpatialGraph\.Graph\<TNode\>')[TNode](SpatialGraph.Metadata.GraphSnapshot_TNode_.md#SpatialGraph.Metadata.GraphSnapshot_TNode_.TNode 'SpatialGraph\.Metadata\.GraphSnapshot\<TNode\>\.TNode')[&gt;](SpatialGraph.Graph_TNode_.md 'SpatialGraph\.Graph\<TNode\>')

Reconstructed graph\.