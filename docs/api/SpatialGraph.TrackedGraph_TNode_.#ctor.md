## TrackedGraph\<TNode\> Constructors

| Overloads | |
| :--- | :--- |
| [TrackedGraph\(\)](SpatialGraph.TrackedGraph_TNode_.#ctor.md#SpatialGraph.TrackedGraph_TNode_.TrackedGraph() 'SpatialGraph\.TrackedGraph\<TNode\>\.TrackedGraph\(\)') | Start an empty graph\. |
| [TrackedGraph\(IReadOnlyGraph&lt;TNode&gt;\)](SpatialGraph.TrackedGraph_TNode_.#ctor.md#SpatialGraph.TrackedGraph_TNode_.TrackedGraph(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.TrackedGraph\<TNode\>\.TrackedGraph\(SpatialGraph\.IReadOnlyGraph\<TNode\>\)') | Start graph from a pre\-exisitng graph\. |
| [TrackedGraph\(Dictionary&lt;uint,TNode&gt;, Dictionary&lt;uint,Edge&gt;\)](SpatialGraph.TrackedGraph_TNode_.#ctor.md#SpatialGraph.TrackedGraph_TNode_.TrackedGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_) 'SpatialGraph\.TrackedGraph\<TNode\>\.TrackedGraph\(System\.Collections\.Generic\.Dictionary\<uint,TNode\>, System\.Collections\.Generic\.Dictionary\<uint,SpatialGraph\.Edge\>\)') | Start a graph from pre\-exisiting dictionaries of nodes and edges\. |

<a name='ctor.md#SpatialGraph.TrackedGraph_TNode_.TrackedGraph()'></a>

## TrackedGraph\(\) Constructor

Start an empty graph\.

```csharp
public TrackedGraph();
```

<a name='ctor.md#SpatialGraph.TrackedGraph_TNode_.TrackedGraph(SpatialGraph.IReadOnlyGraph_TNode_)'></a>

## TrackedGraph\(IReadOnlyGraph\<TNode\>\) Constructor

Start graph from a pre\-exisitng graph\.

```csharp
public TrackedGraph(SpatialGraph.IReadOnlyGraph<TNode> graph);
```
#### Parameters

<a name='SpatialGraph.TrackedGraph_TNode_.TrackedGraph(SpatialGraph.IReadOnlyGraph_TNode_).graph'></a>

`graph` [SpatialGraph\.IReadOnlyGraph&lt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](SpatialGraph.TrackedGraph_TNode_.md#SpatialGraph.TrackedGraph_TNode_.TNode 'SpatialGraph\.TrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')

Graph to replicate from\.

<a name='ctor.md#SpatialGraph.TrackedGraph_TNode_.TrackedGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_)'></a>

## TrackedGraph\(Dictionary\<uint,TNode\>, Dictionary\<uint,Edge\>\) Constructor

Start a graph from pre\-exisiting dictionaries of nodes and edges\.

```csharp
public TrackedGraph(System.Collections.Generic.Dictionary<uint,TNode> nodes, System.Collections.Generic.Dictionary<uint,SpatialGraph.Edge> edges);
```
#### Parameters

<a name='SpatialGraph.TrackedGraph_TNode_.TrackedGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_).nodes'></a>

`nodes` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[TNode](SpatialGraph.TrackedGraph_TNode_.md#SpatialGraph.TrackedGraph_TNode_.TNode 'SpatialGraph\.TrackedGraph\<TNode\>\.TNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

<a name='SpatialGraph.TrackedGraph_TNode_.TrackedGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_).edges'></a>

`edges` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[Edge](SpatialGraph.Edge.md 'SpatialGraph\.Edge')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')