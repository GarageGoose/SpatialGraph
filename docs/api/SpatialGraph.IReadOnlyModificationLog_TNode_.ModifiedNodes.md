## IReadOnlyModificationLog\<TNode\>\.ModifiedNodes Property

Dictionary for nodes which was/will be modified\. Contains the original and new value of the node\.

```csharp
System.Collections.Generic.IReadOnlyDictionary<uint,SpatialGraph.ElementModified<TNode>> ModifiedNodes { get; }
```

#### Property Value
[System\.Collections\.Generic\.IReadOnlyDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2 'System\.Collections\.Generic\.IReadOnlyDictionary\`2')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2 'System\.Collections\.Generic\.IReadOnlyDictionary\`2')[SpatialGraph\.ElementModified&lt;](SpatialGraph.ElementModified_TElement_.md 'SpatialGraph\.ElementModified\<TElement\>')[TNode](SpatialGraph.IReadOnlyModificationLog_TNode_.md#SpatialGraph.IReadOnlyModificationLog_TNode_.TNode 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>\.TNode')[&gt;](SpatialGraph.ElementModified_TElement_.md 'SpatialGraph\.ElementModified\<TElement\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2 'System\.Collections\.Generic\.IReadOnlyDictionary\`2')