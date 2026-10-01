## IInterceptableTrackedGraph\<TNode\>\.OnGraphModificationInit Event

Event for incoming changes\. Invokes with a GraphChangeLog which contains the modifications being performed\.
Modifications can be changed via the GraphChangeLog before being applied to the graph\.

```csharp
event EventHandler<GraphChangeLog<TNode>>? OnGraphModificationInit;
```

#### Event Type
[System\.EventHandler&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1 'System\.EventHandler\`1')[SpatialGraph\.GraphChangeLog&lt;](SpatialGraph.GraphChangeLog_TNode_.md 'SpatialGraph\.GraphChangeLog\<TNode\>')[TNode](SpatialGraph.IInterceptableTrackedGraph_TNode_.md#SpatialGraph.IInterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.GraphChangeLog_TNode_.md 'SpatialGraph\.GraphChangeLog\<TNode\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler-1 'System\.EventHandler\`1')