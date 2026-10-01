## GraphHistory\<TNode\>\.OnGraphUpdate\(object, IReadOnlyModificationLog\<TNode\>\) Method

Emits when a modification occurs in the base graph\.

```csharp
protected override void OnGraphUpdate(object? sender, SpatialGraph.IReadOnlyModificationLog<TNode> modLog);
```
#### Parameters

<a name='SpatialGraph.Metadata.GraphHistory_TNode_.OnGraphUpdate(object,SpatialGraph.IReadOnlyModificationLog_TNode_).sender'></a>

`sender` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

Source of the event\.

<a name='SpatialGraph.Metadata.GraphHistory_TNode_.OnGraphUpdate(object,SpatialGraph.IReadOnlyModificationLog_TNode_).modLog'></a>

`modLog` [SpatialGraph\.IReadOnlyModificationLog&lt;](SpatialGraph.IReadOnlyModificationLog_TNode_.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>')[TNode](SpatialGraph.Metadata.GraphHistory_TNode_.md#SpatialGraph.Metadata.GraphHistory_TNode_.TNode 'SpatialGraph\.Metadata\.GraphHistory\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyModificationLog_TNode_.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>')

Log of changes for the base graph\.