## GraphHistory\<TNode\> Class

Records changes from a graph\.

```csharp
public class GraphHistory<TNode> : SpatialGraph.Metadata.GraphReadOnlyPlugin<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.Metadata.GraphHistory_TNode_.TNode'></a>

`TNode`

Node which the base graph uses\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [SpatialGraph\.Metadata\.GraphReadOnlyPlugin&lt;](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>')[TNode](SpatialGraph.Metadata.GraphHistory_TNode_.md#SpatialGraph.Metadata.GraphHistory_TNode_.TNode 'SpatialGraph\.Metadata\.GraphHistory\<TNode\>\.TNode')[&gt;](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>') → GraphHistory\<TNode\>

| Constructors | |
| :--- | :--- |
| [GraphHistory\(IReadOnlyTrackedGraph&lt;TNode&gt;\)](SpatialGraph.Metadata.GraphHistory_TNode_.GraphHistory(SpatialGraph.IReadOnlyTrackedGraph_TNode_).md 'SpatialGraph\.Metadata\.GraphHistory\<TNode\>\.GraphHistory\(SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>\)') | Create a graph history from a graph\. |

| Properties | |
| :--- | :--- |
| [GraphSnapshot](SpatialGraph.Metadata.GraphHistory_TNode_.GraphSnapshot.md 'SpatialGraph\.Metadata\.GraphHistory\<TNode\>\.GraphSnapshot') | List of graph snapshots\. A graph snapshot is a reconstructed Graph from accumulated ModificationLogs\. Taken and stored in this list with TakeSnapshot\(\)\. |
| [ModSnapshotCount](SpatialGraph.Metadata.GraphHistory_TNode_.ModSnapshotCount.md 'SpatialGraph\.Metadata\.GraphHistory\<TNode\>\.ModSnapshotCount') | Amount of snapshots taken since the plugin was created\. |
| [ModSnapshots](SpatialGraph.Metadata.GraphHistory_TNode_.ModSnapshots.md 'SpatialGraph\.Metadata\.GraphHistory\<TNode\>\.ModSnapshots') | List of graph modification snapshots\. A modification snapshot is a ModificationLog which is taken every time the graph is updated, with index 0 being the oldest/first snapshot\. |

| Methods | |
| :--- | :--- |
| [TakeSnapshot\(int\)](SpatialGraph.Metadata.GraphHistory_TNode_.TakeSnapshot(int).md 'SpatialGraph\.Metadata\.GraphHistory\<TNode\>\.TakeSnapshot\(int\)') | Reconstruct a graph from a specific modification step\. A modification snapshot is a ModificationLog which is taken every time the graph is updated with each one counting as a single modStep, with index 0 being the oldest/first snapshot\. |
