## InterceptableObservableGraph<TNode> Constructors

| Overloads | |
| :--- | :--- |
| [InterceptableObservableGraph()](InterceptableObservableGraph_TNode_.md#SpatialGraph.InterceptableObservableGraph_TNode_.InterceptableObservableGraph() 'SpatialGraph\.InterceptableObservableGraph<TNode>\.InterceptableObservableGraph()') | Start an empty graph\. |
| [InterceptableObservableGraph(IReadOnlyGraph&lt;TNode&gt;)](InterceptableObservableGraph_TNode_.md#SpatialGraph.InterceptableObservableGraph_TNode_.InterceptableObservableGraph(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.InterceptableObservableGraph<TNode>\.InterceptableObservableGraph(SpatialGraph\.IReadOnlyGraph<TNode>)') | Start graph from a pre-existing graph\. |
| [InterceptableObservableGraph(Dictionary&lt;uint,TNode&gt;, Dictionary&lt;uint,Edge&gt;)](InterceptableObservableGraph_TNode_.md#SpatialGraph.InterceptableObservableGraph_TNode_.InterceptableObservableGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_) 'SpatialGraph\.InterceptableObservableGraph<TNode>\.InterceptableObservableGraph(System\.Collections\.Generic\.Dictionary<uint,TNode>, System\.Collections\.Generic\.Dictionary<uint,SpatialGraph\.Edge>)') | Start a graph from pre-existing dictionaries of nodes and edges\. |

<a name='SpatialGraph.InterceptableObservableGraph_TNode_.InterceptableObservableGraph()'></a>

## InterceptableObservableGraph() Constructor

Start an empty graph\.

```csharp
public InterceptableObservableGraph();
```

<a name='SpatialGraph.InterceptableObservableGraph_TNode_.InterceptableObservableGraph(SpatialGraph.IReadOnlyGraph_TNode_)'></a>

## InterceptableObservableGraph(IReadOnlyGraph<TNode>) Constructor

Start graph from a pre-existing graph\.

```csharp
public InterceptableObservableGraph(SpatialGraph.IReadOnlyGraph<TNode> graph);
```
#### Parameters

<a name='SpatialGraph.InterceptableObservableGraph_TNode_.InterceptableObservableGraph(SpatialGraph.IReadOnlyGraph_TNode_).graph'></a>

`graph` [SpatialGraph\.IReadOnlyGraph&lt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[TNode](index.md#SpatialGraph.InterceptableObservableGraph_TNode_.TNode 'SpatialGraph\.InterceptableObservableGraph<TNode>\.TNode')[&gt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')

Graph to replicate from\.

<a name='SpatialGraph.InterceptableObservableGraph_TNode_.InterceptableObservableGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_)'></a>

## InterceptableObservableGraph(Dictionary<uint,TNode>, Dictionary<uint,Edge>) Constructor

Start a graph from pre-existing dictionaries of nodes and edges\.

```csharp
public InterceptableObservableGraph(System.Collections.Generic.Dictionary<uint,TNode> nodes, System.Collections.Generic.Dictionary<uint,SpatialGraph.Edge> edges);
```
#### Parameters

<a name='SpatialGraph.InterceptableObservableGraph_TNode_.InterceptableObservableGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_).nodes'></a>

`nodes` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[TNode](index.md#SpatialGraph.InterceptableObservableGraph_TNode_.TNode 'SpatialGraph\.InterceptableObservableGraph<TNode>\.TNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

<a name='SpatialGraph.InterceptableObservableGraph_TNode_.InterceptableObservableGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_).edges'></a>

`edges` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[Edge](../Edge/index.md 'SpatialGraph\.Edge')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')