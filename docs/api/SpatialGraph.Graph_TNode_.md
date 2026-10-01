## Graph\<TNode\> Class

Base class for graphs, can be built upon\.

```csharp
public class Graph<TNode> : SpatialGraph.IGraph<TNode>, SpatialGraph.IReadOnlyGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.Graph_TNode_.TNode'></a>

`TNode`

Type of node to be used in the graph\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Graph\<TNode\>

Derived  
↳ [InterceptableTrackedGraph&lt;TNode&gt;](SpatialGraph.InterceptableTrackedGraph_TNode_.md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>')  
↳ [TrackedGraph&lt;TNode&gt;](SpatialGraph.TrackedGraph_TNode_.md 'SpatialGraph\.TrackedGraph\<TNode\>')

Implements [SpatialGraph\.IGraph&lt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')[TNode](SpatialGraph.Graph_TNode_.md#SpatialGraph.Graph_TNode_.TNode 'SpatialGraph\.Graph\<TNode\>\.TNode')[&gt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>'), [SpatialGraph\.IReadOnlyGraph&lt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](SpatialGraph.Graph_TNode_.md#SpatialGraph.Graph_TNode_.TNode 'SpatialGraph\.Graph\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')

| Constructors | |
| :--- | :--- |
| [Graph\(\)](SpatialGraph.Graph_TNode_.#ctor.md#SpatialGraph.Graph_TNode_.Graph() 'SpatialGraph\.Graph\<TNode\>\.Graph\(\)') | Start an empty graph\. |
| [Graph\(IReadOnlyGraph&lt;TNode&gt;\)](SpatialGraph.Graph_TNode_.#ctor.md#SpatialGraph.Graph_TNode_.Graph(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.Graph\<TNode\>\.Graph\(SpatialGraph\.IReadOnlyGraph\<TNode\>\)') | Start graph from a pre\-exisitng graph\. |
| [Graph\(Dictionary&lt;uint,TNode&gt;, Dictionary&lt;uint,Edge&gt;\)](SpatialGraph.Graph_TNode_.#ctor.md#SpatialGraph.Graph_TNode_.Graph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_) 'SpatialGraph\.Graph\<TNode\>\.Graph\(System\.Collections\.Generic\.Dictionary\<uint,TNode\>, System\.Collections\.Generic\.Dictionary\<uint,SpatialGraph\.Edge\>\)') | Start a graph from pre\-exisiting dictionaries of nodes and edges\. |

| Fields | |
| :--- | :--- |
| [edges](SpatialGraph.Graph_TNode_.edges.md 'SpatialGraph\.Graph\<TNode\>\.edges') | Writable dictionary for edges in the graph\. |
| [nodes](SpatialGraph.Graph_TNode_.nodes.md 'SpatialGraph\.Graph\<TNode\>\.nodes') | Writable dictionary for nodes in the graph\. |

| Properties | |
| :--- | :--- |
| [Edges](SpatialGraph.Graph_TNode_.Edges.md 'SpatialGraph\.Graph\<TNode\>\.Edges') | Edges stored in this graph\. Elements such as edges are referenced be their unique ID\. Nodes and edges can share the same ID\. |
| [Nodes](SpatialGraph.Graph_TNode_.Nodes.md 'SpatialGraph\.Graph\<TNode\>\.Nodes') | Nodes stored in this graph\. Elements such as nodes are referenced be their unique ID\. Nodes and edges can share the same ID\. |

| Methods | |
| :--- | :--- |
| [ApplyChangeSet\(GraphChangeSet&lt;TNode&gt;\)](SpatialGraph.Graph_TNode_.ApplyChangeSet(SpatialGraph.GraphChangeSet_TNode_).md 'SpatialGraph\.Graph\<TNode\>\.ApplyChangeSet\(SpatialGraph\.GraphChangeSet\<TNode\>\)') | Perform multiple operations at once with a GraphChangeSet\. Existing nodes or edges with a corresponding ID in the graph will be replaced\. Nodes and edges can share the same ID\. |
| [GenerateID\(\)](SpatialGraph.Graph_TNode_.GenerateID().md 'SpatialGraph\.Graph\<TNode\>\.GenerateID\(\)') | Generate unique ID for the elements of the graph\. Nodes and edges can share the same ID\. |
| [RemoveEdge\(uint\)](SpatialGraph.Graph_TNode_.RemoveEdge(uint).md 'SpatialGraph\.Graph\<TNode\>\.RemoveEdge\(uint\)') | Remove an edge in the graph using its corresponding ID\. Nodes and edges can share the same ID, this will remove only the edge with the corresponding ID\. |
| [RemoveNode\(uint\)](SpatialGraph.Graph_TNode_.RemoveNode(uint).md 'SpatialGraph\.Graph\<TNode\>\.RemoveNode\(uint\)') | Remove a node in the graph using its correspinding ID\. Connecting edges referencing this node will not be removed\. Nodes and edges can share the same ID, this will remove only the node with the corresponding ID\. |
| [UpsertEdge\(Edge\)](SpatialGraph.Graph_TNode_.UpsertEdge(SpatialGraph.Edge).md 'SpatialGraph\.Graph\<TNode\>\.UpsertEdge\(SpatialGraph\.Edge\)') | Add a new edge or modify an edge with its corresponding ID\. |
| [UpsertNode\(TNode\)](SpatialGraph.Graph_TNode_.UpsertNode(TNode).md 'SpatialGraph\.Graph\<TNode\>\.UpsertNode\(TNode\)') | Add a new node or modify one with their corresponding ID\. Nodes and edges can share the same ID\. |
