## InterceptableTrackedGraph\<TNode\> Constructors

| Overloads | |
| :--- | :--- |
| [InterceptableTrackedGraph\(\)](SpatialGraph.InterceptableTrackedGraph_TNode_.#ctor.md#SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph() 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.InterceptableTrackedGraph\(\)') | Start an empty graph\. |
| [InterceptableTrackedGraph\(IReadOnlyGraph&lt;TNode&gt;\)](SpatialGraph.InterceptableTrackedGraph_TNode_.#ctor.md#SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.InterceptableTrackedGraph\(SpatialGraph\.IReadOnlyGraph\<TNode\>\)') | Start graph from a pre\-exisitng graph\. |
| [InterceptableTrackedGraph\(Dictionary&lt;uint,TNode&gt;, Dictionary&lt;uint,Edge&gt;\)](SpatialGraph.InterceptableTrackedGraph_TNode_.#ctor.md#SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_) 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.InterceptableTrackedGraph\(System\.Collections\.Generic\.Dictionary\<uint,TNode\>, System\.Collections\.Generic\.Dictionary\<uint,SpatialGraph\.Edge\>\)') | Start a graph from pre\-exisiting dictionaries of nodes and edges\. |

<a name='ctor.md#SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph()'></a>

## InterceptableTrackedGraph\(\) Constructor

Start an empty graph\.

```csharp
public InterceptableTrackedGraph();
```

<a name='ctor.md#SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(SpatialGraph.IReadOnlyGraph_TNode_)'></a>

## InterceptableTrackedGraph\(IReadOnlyGraph\<TNode\>\) Constructor

Start graph from a pre\-exisitng graph\.

```csharp
public InterceptableTrackedGraph(SpatialGraph.IReadOnlyGraph<TNode> graph);
```
#### Parameters

<a name='SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(SpatialGraph.IReadOnlyGraph_TNode_).graph'></a>

`graph` [SpatialGraph\.IReadOnlyGraph&lt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](SpatialGraph.InterceptableTrackedGraph_TNode_.md#SpatialGraph.InterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')

Graph to replicate from\.

<a name='ctor.md#SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_)'></a>

## InterceptableTrackedGraph\(Dictionary\<uint,TNode\>, Dictionary\<uint,Edge\>\) Constructor

Start a graph from pre\-exisiting dictionaries of nodes and edges\.

```csharp
public InterceptableTrackedGraph(System.Collections.Generic.Dictionary<uint,TNode> nodes, System.Collections.Generic.Dictionary<uint,SpatialGraph.Edge> edges);
```
#### Parameters

<a name='SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_).nodes'></a>

`nodes` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[TNode](SpatialGraph.InterceptableTrackedGraph_TNode_.md#SpatialGraph.InterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

<a name='SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_).edges'></a>

`edges` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[Edge](SpatialGraph.Edge.md 'SpatialGraph\.Edge')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')