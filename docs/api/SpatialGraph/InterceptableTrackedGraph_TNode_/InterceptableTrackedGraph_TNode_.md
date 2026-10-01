## InterceptableTrackedGraph\<TNode\> Constructors

| Overloads | |
| :--- | :--- |
| [InterceptableTrackedGraph\(\)](InterceptableTrackedGraph_TNode_.md#SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph() 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.InterceptableTrackedGraph\(\)') | Start an empty graph\. |
| [InterceptableTrackedGraph\(IReadOnlyGraph&lt;TNode&gt;\)](InterceptableTrackedGraph_TNode_.md#SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.InterceptableTrackedGraph\(SpatialGraph\.IReadOnlyGraph\<TNode\>\)') | Start graph from a pre\-exisitng graph\. |
| [InterceptableTrackedGraph\(Dictionary&lt;uint,TNode&gt;, Dictionary&lt;uint,Edge&gt;\)](InterceptableTrackedGraph_TNode_.md#SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_) 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.InterceptableTrackedGraph\(System\.Collections\.Generic\.Dictionary\<uint,TNode\>, System\.Collections\.Generic\.Dictionary\<uint,SpatialGraph\.Edge\>\)') | Start a graph from pre\-exisiting dictionaries of nodes and edges\. |

<a name='SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph()'></a>

## InterceptableTrackedGraph\(\) Constructor

Start an empty graph\.

```csharp
public InterceptableTrackedGraph();
```

<a name='SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(SpatialGraph.IReadOnlyGraph_TNode_)'></a>

## InterceptableTrackedGraph\(IReadOnlyGraph\<TNode\>\) Constructor

Start graph from a pre\-exisitng graph\.

```csharp
public InterceptableTrackedGraph(SpatialGraph.IReadOnlyGraph<TNode> graph);
```
#### Parameters

<a name='SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(SpatialGraph.IReadOnlyGraph_TNode_).graph'></a>

`graph` [SpatialGraph\.IReadOnlyGraph&lt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](index.md#SpatialGraph.InterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')

Graph to replicate from\.

<a name='SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_)'></a>

## InterceptableTrackedGraph\(Dictionary\<uint,TNode\>, Dictionary\<uint,Edge\>\) Constructor

Start a graph from pre\-exisiting dictionaries of nodes and edges\.

```csharp
public InterceptableTrackedGraph(System.Collections.Generic.Dictionary<uint,TNode> nodes, System.Collections.Generic.Dictionary<uint,SpatialGraph.Edge> edges);
```
#### Parameters

<a name='SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_).nodes'></a>

`nodes` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[TNode](index.md#SpatialGraph.InterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

<a name='SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_).edges'></a>

`edges` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[Edge](../Edge/index.md 'SpatialGraph\.Edge')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')