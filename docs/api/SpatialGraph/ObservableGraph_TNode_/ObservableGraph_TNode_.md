## ObservableGraph<TNode> Constructors

| Overloads | |
| :--- | :--- |
| [ObservableGraph()](ObservableGraph_TNode_.md#SpatialGraph.ObservableGraph_TNode_.ObservableGraph() 'SpatialGraph\.ObservableGraph<TNode>\.ObservableGraph()') | Start an empty graph\. |
| [ObservableGraph(IReadOnlyGraph&lt;TNode&gt;)](ObservableGraph_TNode_.md#SpatialGraph.ObservableGraph_TNode_.ObservableGraph(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.ObservableGraph<TNode>\.ObservableGraph(SpatialGraph\.IReadOnlyGraph<TNode>)') | Start graph from a pre-existing graph\. |
| [ObservableGraph(Dictionary&lt;uint,TNode&gt;, Dictionary&lt;uint,Edge&gt;)](ObservableGraph_TNode_.md#SpatialGraph.ObservableGraph_TNode_.ObservableGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_) 'SpatialGraph\.ObservableGraph<TNode>\.ObservableGraph(System\.Collections\.Generic\.Dictionary<uint,TNode>, System\.Collections\.Generic\.Dictionary<uint,SpatialGraph\.Edge>)') | Start a graph from pre-existing dictionaries of nodes and edges\. |

<a name='SpatialGraph.ObservableGraph_TNode_.ObservableGraph()'></a>

## ObservableGraph() Constructor

Start an empty graph\.

```csharp
public ObservableGraph();
```

<a name='SpatialGraph.ObservableGraph_TNode_.ObservableGraph(SpatialGraph.IReadOnlyGraph_TNode_)'></a>

## ObservableGraph(IReadOnlyGraph<TNode>) Constructor

Start graph from a pre-existing graph\.

```csharp
public ObservableGraph(SpatialGraph.IReadOnlyGraph<TNode> graph);
```
#### Parameters

<a name='SpatialGraph.ObservableGraph_TNode_.ObservableGraph(SpatialGraph.IReadOnlyGraph_TNode_).graph'></a>

`graph` [SpatialGraph\.IReadOnlyGraph&lt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[TNode](index.md#SpatialGraph.ObservableGraph_TNode_.TNode 'SpatialGraph\.ObservableGraph<TNode>\.TNode')[&gt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')

Graph to replicate from\.

<a name='SpatialGraph.ObservableGraph_TNode_.ObservableGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_)'></a>

## ObservableGraph(Dictionary<uint,TNode>, Dictionary<uint,Edge>) Constructor

Start a graph from pre-existing dictionaries of nodes and edges\.

```csharp
public ObservableGraph(System.Collections.Generic.Dictionary<uint,TNode> nodes, System.Collections.Generic.Dictionary<uint,SpatialGraph.Edge> edges);
```
#### Parameters

<a name='SpatialGraph.ObservableGraph_TNode_.ObservableGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_).nodes'></a>

`nodes` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[TNode](index.md#SpatialGraph.ObservableGraph_TNode_.TNode 'SpatialGraph\.ObservableGraph<TNode>\.TNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

<a name='SpatialGraph.ObservableGraph_TNode_.ObservableGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_).edges'></a>

`edges` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[Edge](../Edge/index.md 'SpatialGraph\.Edge')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')