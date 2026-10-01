## GraphReadOnlyPlugin\<TNode\>\.Edges Property

Edges stored in this graph\. Elements such as edges are referenced be their unique ID\.
Nodes and edges can share the same ID\.

```csharp
public System.Collections.Generic.IReadOnlyDictionary<uint,SpatialGraph.Edge> Edges { get; }
```

Implements [Edges](SpatialGraph.IReadOnlyGraph_TNode_.Edges.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>\.Edges')

#### Property Value
[System\.Collections\.Generic\.IReadOnlyDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2 'System\.Collections\.Generic\.IReadOnlyDictionary\`2')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2 'System\.Collections\.Generic\.IReadOnlyDictionary\`2')[Edge](SpatialGraph.Edge.md 'SpatialGraph\.Edge')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2 'System\.Collections\.Generic\.IReadOnlyDictionary\`2')