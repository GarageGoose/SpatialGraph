## GraphPlugin\<TNode\>\.OnGraphPluginInit Event

Emits before the plugin starts logging changes\.

```csharp
public event EventHandler<GraphChangeLog<TNode>>? OnGraphPluginInit;
```

#### Event Type
[System\.EventHandler&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1 'System\.EventHandler\`1')[SpatialGraph\.GraphChangeLog&lt;](../../GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog\<TNode\>')[TNode](index.md#SpatialGraph.Metadata.GraphPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.TNode')[&gt;](../../GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog\<TNode\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1 'System\.EventHandler\`1')