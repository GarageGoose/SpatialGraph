## GraphReadOnlyPlugin<TNode>\.OnGraphUpdate(object, IReadOnlyModificationLog<TNode>) Method

Emits when a modification occurs in the base graph\.

```csharp
protected abstract void OnGraphUpdate(object? sender, SpatialGraph.IReadOnlyModificationLog<TNode> modLog);
```
#### Parameters

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.OnGraphUpdate(object,SpatialGraph.IReadOnlyModificationLog_TNode_).sender'></a>

`sender` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

Source of the event\.

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.OnGraphUpdate(object,SpatialGraph.IReadOnlyModificationLog_TNode_).modLog'></a>

`modLog` [SpatialGraph\.IReadOnlyModificationLog&lt;](../../IReadOnlyModificationLog_TNode_/index.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>')[TNode](index.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.TNode')[&gt;](../../IReadOnlyModificationLog_TNode_/index.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>')

Log of changes for the base graph\.