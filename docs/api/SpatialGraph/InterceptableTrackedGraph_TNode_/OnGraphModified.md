## InterceptableTrackedGraph<TNode>\.OnGraphModified Event

Event for changes applied\. Invokes with an IReadOnlyModificationLog,
which contains the changes in the graph after it is modified\.

```csharp
public event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphModified;
```

Implements [OnGraphModified](../IReadOnlyTrackedGraph_TNode_/OnGraphModified.md 'SpatialGraph\.IReadOnlyTrackedGraph<TNode>\.OnGraphModified')

#### Event Type
[System\.EventHandler&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1 'System\.EventHandler\`1')[SpatialGraph\.IReadOnlyModificationLog&lt;](../IReadOnlyModificationLog_TNode_/index.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>')[TNode](index.md#SpatialGraph.InterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.InterceptableTrackedGraph<TNode>\.TNode')[&gt;](../IReadOnlyModificationLog_TNode_/index.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1 'System\.EventHandler\`1')