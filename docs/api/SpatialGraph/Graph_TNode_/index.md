## Graph<TNode> Class

Base class for graphs, can be built upon\. A graph stores [INode](../INode/index.md 'SpatialGraph\.INode') and [Edge](../Edge/index.md 'SpatialGraph\.Edge') within it, identified by their IDs\.

```csharp
public class Graph<TNode> : SpatialGraph.IGraph<TNode>, SpatialGraph.IReadOnlyGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.Graph_TNode_.TNode'></a>

`TNode`

Type of node to be used in the graph\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Graph<TNode>

Derived  
↳ [InterceptableObservableGraph&lt;TNode&gt;](../InterceptableObservableGraph_TNode_/index.md 'SpatialGraph\.InterceptableObservableGraph<TNode>')  
↳ [ObservableGraph&lt;TNode&gt;](../ObservableGraph_TNode_/index.md 'SpatialGraph\.ObservableGraph<TNode>')

Implements [SpatialGraph\.IGraph&lt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[TNode](index.md#SpatialGraph.Graph_TNode_.TNode 'SpatialGraph\.Graph<TNode>\.TNode')[&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>'), [SpatialGraph\.IReadOnlyGraph&lt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[TNode](index.md#SpatialGraph.Graph_TNode_.TNode 'SpatialGraph\.Graph<TNode>\.TNode')[&gt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')

| Constructors | |
| :--- | :--- |
| [Graph()](Graph_TNode_.md#SpatialGraph.Graph_TNode_.Graph() 'SpatialGraph\.Graph<TNode>\.Graph()') | Start an empty graph\. |
| [Graph(IReadOnlyGraph&lt;TNode&gt;)](Graph_TNode_.md#SpatialGraph.Graph_TNode_.Graph(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.Graph<TNode>\.Graph(SpatialGraph\.IReadOnlyGraph<TNode>)') | Start graph from a pre-existing graph\. |
| [Graph(Dictionary&lt;uint,TNode&gt;, Dictionary&lt;uint,Edge&gt;)](Graph_TNode_.md#SpatialGraph.Graph_TNode_.Graph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_) 'SpatialGraph\.Graph<TNode>\.Graph(System\.Collections\.Generic\.Dictionary<uint,TNode>, System\.Collections\.Generic\.Dictionary<uint,SpatialGraph\.Edge>)') | Start a graph from pre-existing dictionaries of nodes and edges\. |

| Fields | |
| :--- | :--- |
| [\_Edges](_Edges.md 'SpatialGraph\.Graph<TNode>\.\_Edges') | Writable dictionary for edges in the graph\. |
| [\_Nodes](_Nodes.md 'SpatialGraph\.Graph<TNode>\.\_Nodes') | Writable dictionary for nodes in the graph\. |

| Properties | |
| :--- | :--- |
| [Edges](Edges.md 'SpatialGraph\.Graph<TNode>\.Edges') | Edges stored in this graph\. Elements such as edges are referenced be their unique ID\. Nodes and edges can share the same ID\. |
| [Nodes](Nodes.md 'SpatialGraph\.Graph<TNode>\.Nodes') | Nodes stored in this graph\. Elements such as nodes are referenced be their unique ID\. Nodes and edges can share the same ID\. |

| Methods | |
| :--- | :--- |
| [ApplyChangeSet(GraphChangeSet&lt;TNode&gt;)](ApplyChangeSet(GraphChangeSet_TNode_).md 'SpatialGraph\.Graph<TNode>\.ApplyChangeSet(SpatialGraph\.GraphChangeSet<TNode>)') | Perform multiple operations at once with a [GraphChangeSet&lt;TNode&gt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')\. Existing [INode](../INode/index.md 'SpatialGraph\.INode') or [Edge](../Edge/index.md 'SpatialGraph\.Edge')s with a corresponding ID in the graph will be replaced\. Nodes and edges can share the same ID\. |
| [GenerateID()](GenerateID().md 'SpatialGraph\.Graph<TNode>\.GenerateID()') | Generate unique ID for the elements of the graph\. Nodes and edges can share the same ID\. |
| [RemoveEdge(uint)](RemoveEdge(uint).md 'SpatialGraph\.Graph<TNode>\.RemoveEdge(uint)') | Remove an [Edge](../Edge/index.md 'SpatialGraph\.Edge') in the graph using its corresponding ID\. Nodes and edges can share the same ID, this will remove only the edge with the corresponding ID\. |
| [RemoveNode(uint)](RemoveNode(uint).md 'SpatialGraph\.Graph<TNode>\.RemoveNode(uint)') | Remove a [INode](../INode/index.md 'SpatialGraph\.INode') in the graph using its correspinding ID\. Connecting [Edge](../Edge/index.md 'SpatialGraph\.Edge') referencing this node will not be removed\. Nodes and edges can share the same ID, this will remove only the node with the corresponding ID\. |
| [UpsertEdge(Edge)](UpsertEdge(Edge).md 'SpatialGraph\.Graph<TNode>\.UpsertEdge(SpatialGraph\.Edge)') | Add a new [Edge](../Edge/index.md 'SpatialGraph\.Edge') or modify an [Edge](../Edge/index.md 'SpatialGraph\.Edge') with its corresponding ID\. |
| [UpsertNode(TNode)](UpsertNode(TNode).md 'SpatialGraph\.Graph<TNode>\.UpsertNode(TNode)') | Add a new [INode](../INode/index.md 'SpatialGraph\.INode') or modify one with their corresponding ID\. Nodes and edges can share the same ID\. |
