## GraphHistory\<TNode\>\.ModSnapshots Property

List of graph modification snapshots\. A modification snapshot is a ModificationLog which is taken every time the graph is updated, with index 0 being the oldest/first snapshot\.

```csharp
public System.Collections.Generic.IReadOnlyList<SpatialGraph.IReadOnlyModificationLog<TNode>> ModSnapshots { get; }
```

#### Property Value
[System\.Collections\.Generic\.IReadOnlyList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')[SpatialGraph\.IReadOnlyModificationLog&lt;](SpatialGraph.IReadOnlyModificationLog_TNode_.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>')[TNode](SpatialGraph.Metadata.GraphHistory_TNode_.md#SpatialGraph.Metadata.GraphHistory_TNode_.TNode 'SpatialGraph\.Metadata\.GraphHistory\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyModificationLog_TNode_.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1 'System\.Collections\.Generic\.IReadOnlyList\`1')