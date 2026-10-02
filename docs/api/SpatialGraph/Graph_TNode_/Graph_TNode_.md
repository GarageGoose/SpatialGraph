## Graph<TNode> Constructors

| Overloads | |
| :--- | :--- |
| [Graph()](Graph_TNode_.md#SpatialGraph.Graph_TNode_.Graph() 'SpatialGraph\.Graph<TNode>\.Graph()') | Start an empty graph\. |
| [Graph(IReadOnlyGraph&lt;TNode&gt;)](Graph_TNode_.md#SpatialGraph.Graph_TNode_.Graph(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.Graph<TNode>\.Graph(SpatialGraph\.IReadOnlyGraph<TNode>)') | Start graph from a pre-existing graph\. |
| [Graph(Dictionary&lt;uint,TNode&gt;, Dictionary&lt;uint,Edge&gt;)](Graph_TNode_.md#SpatialGraph.Graph_TNode_.Graph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_) 'SpatialGraph\.Graph<TNode>\.Graph(System\.Collections\.Generic\.Dictionary<uint,TNode>, System\.Collections\.Generic\.Dictionary<uint,SpatialGraph\.Edge>)') | Start a graph from pre-existing dictionaries of nodes and edges\. |

<a name='SpatialGraph.Graph_TNode_.Graph()'></a>

## Graph() Constructor

Start an empty graph\.

```csharp
public Graph();
```

<a name='SpatialGraph.Graph_TNode_.Graph(SpatialGraph.IReadOnlyGraph_TNode_)'></a>

## Graph(IReadOnlyGraph<TNode>) Constructor

Start graph from a pre-existing graph\.

```csharp
public Graph(SpatialGraph.IReadOnlyGraph<TNode> graph);
```
#### Parameters

<a name='SpatialGraph.Graph_TNode_.Graph(SpatialGraph.IReadOnlyGraph_TNode_).graph'></a>

`graph` [SpatialGraph\.IReadOnlyGraph&lt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[TNode](index.md#SpatialGraph.Graph_TNode_.TNode 'SpatialGraph\.Graph<TNode>\.TNode')[&gt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')

Graph to replicate from\.

<a name='SpatialGraph.Graph_TNode_.Graph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_)'></a>

## Graph(Dictionary<uint,TNode>, Dictionary<uint,Edge>) Constructor

Start a graph from pre-existing dictionaries of nodes and edges\.

```csharp
public Graph(System.Collections.Generic.Dictionary<uint,TNode> nodes, System.Collections.Generic.Dictionary<uint,SpatialGraph.Edge> edges);
```
#### Parameters

<a name='SpatialGraph.Graph_TNode_.Graph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_).nodes'></a>

`nodes` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[TNode](index.md#SpatialGraph.Graph_TNode_.TNode 'SpatialGraph\.Graph<TNode>\.TNode')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')

<a name='SpatialGraph.Graph_TNode_.Graph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_).edges'></a>

`edges` [System\.Collections\.Generic\.Dictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')[Edge](../Edge/index.md 'SpatialGraph\.Edge')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2 'System\.Collections\.Generic\.Dictionary\`2')