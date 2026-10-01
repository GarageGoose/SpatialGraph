## GraphPlugin\<TNode\>\.OnGraphUpdate\(object, GraphChangeLog\<TNode\>\) Method

Emits when a modification occurs in the base graph\.

```csharp
protected abstract void OnGraphUpdate(object? sender, SpatialGraph.GraphChangeLog<TNode> modLog);
```
#### Parameters

<a name='SpatialGraph.Metadata.GraphPlugin_TNode_.OnGraphUpdate(object,SpatialGraph.GraphChangeLog_TNode_).sender'></a>

`sender` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

Source of the event\.

<a name='SpatialGraph.Metadata.GraphPlugin_TNode_.OnGraphUpdate(object,SpatialGraph.GraphChangeLog_TNode_).modLog'></a>

`modLog` [SpatialGraph\.GraphChangeLog&lt;](../../GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog\<TNode\>')[TNode](index.md#SpatialGraph.Metadata.GraphPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.TNode')[&gt;](../../GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog\<TNode\>')

Log of changes for the base graph\.