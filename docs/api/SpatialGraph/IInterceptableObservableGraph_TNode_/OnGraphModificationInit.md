## IInterceptableObservableGraph<TNode>\.OnGraphModificationInit Event

Event for incoming changes\. Invokes with a GraphChangeLog which contains the modifications being performed\.
Modifications can be changed via the GraphChangeLog before being applied to the graph\.

```csharp
event EventHandler<GraphChangeLog<TNode>>? OnGraphModificationInit;
```

#### Event Type
[System\.EventHandler&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1 'System\.EventHandler\`1')[SpatialGraph\.GraphChangeLog&lt;](../GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog<TNode>')[TNode](index.md#SpatialGraph.IInterceptableObservableGraph_TNode_.TNode 'SpatialGraph\.IInterceptableObservableGraph<TNode>\.TNode')[&gt;](../GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog<TNode>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1 'System\.EventHandler\`1')