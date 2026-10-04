## GraphChangeLog<TNode>\.ModifiedNodes Property

Dictionary for [INode](../INode/index.md 'SpatialGraph\.INode')s which was/will be modified\. Contains the original and new value of the [INode](../INode/index.md 'SpatialGraph\.INode')\.

```csharp
public System.Collections.Generic.IReadOnlyDictionary<uint,SpatialGraph.ElementModified<TNode>> ModifiedNodes { get; }
```

Implements [ModifiedNodes](../IReadOnlyModificationLog_TNode_/ModifiedNodes.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>\.ModifiedNodes')

#### Property Value
[System\.Collections\.Generic\.IReadOnlyDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2 'System\.Collections\.Generic\.IReadOnlyDictionary\`2')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2 'System\.Collections\.Generic\.IReadOnlyDictionary\`2')[SpatialGraph\.ElementModified&lt;](../ElementModified_TElement_/index.md 'SpatialGraph\.ElementModified<TElement>')[TNode](index.md#SpatialGraph.GraphChangeLog_TNode_.TNode 'SpatialGraph\.GraphChangeLog<TNode>\.TNode')[&gt;](../ElementModified_TElement_/index.md 'SpatialGraph\.ElementModified<TElement>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2 'System\.Collections\.Generic\.IReadOnlyDictionary\`2')