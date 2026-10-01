## TrackedGraph\<TNode\> Class

Graph which tracks changes within it\.

```csharp
public class TrackedGraph<TNode> : SpatialGraph.Graph<TNode>, SpatialGraph.ITrackedGraph<TNode>, SpatialGraph.IReadOnlyTrackedGraph<TNode>, SpatialGraph.IReadOnlyGraph<TNode>, SpatialGraph.IGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.TrackedGraph_TNode_.TNode'></a>

`TNode`

Type of node to be used in the graph\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [SpatialGraph\.Graph&lt;](SpatialGraph.Graph_TNode_.md 'SpatialGraph\.Graph\<TNode\>')[TNode](SpatialGraph.TrackedGraph_TNode_.md#SpatialGraph.TrackedGraph_TNode_.TNode 'SpatialGraph\.TrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.Graph_TNode_.md 'SpatialGraph\.Graph\<TNode\>') → TrackedGraph\<TNode\>

Implements [SpatialGraph\.ITrackedGraph&lt;](SpatialGraph.ITrackedGraph_TNode_.md 'SpatialGraph\.ITrackedGraph\<TNode\>')[TNode](SpatialGraph.TrackedGraph_TNode_.md#SpatialGraph.TrackedGraph_TNode_.TNode 'SpatialGraph\.TrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.ITrackedGraph_TNode_.md 'SpatialGraph\.ITrackedGraph\<TNode\>'), [SpatialGraph\.IReadOnlyTrackedGraph&lt;](SpatialGraph.IReadOnlyTrackedGraph_TNode_.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>')[TNode](SpatialGraph.TrackedGraph_TNode_.md#SpatialGraph.TrackedGraph_TNode_.TNode 'SpatialGraph\.TrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyTrackedGraph_TNode_.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>'), [SpatialGraph\.IReadOnlyGraph&lt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](SpatialGraph.TrackedGraph_TNode_.md#SpatialGraph.TrackedGraph_TNode_.TNode 'SpatialGraph\.TrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>'), [SpatialGraph\.IGraph&lt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')[TNode](SpatialGraph.TrackedGraph_TNode_.md#SpatialGraph.TrackedGraph_TNode_.TNode 'SpatialGraph\.TrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')

| Constructors | |
| :--- | :--- |
| [TrackedGraph\(\)](SpatialGraph.TrackedGraph_TNode_.#ctor.md#SpatialGraph.TrackedGraph_TNode_.TrackedGraph() 'SpatialGraph\.TrackedGraph\<TNode\>\.TrackedGraph\(\)') | Start an empty graph\. |
| [TrackedGraph\(IReadOnlyGraph&lt;TNode&gt;\)](SpatialGraph.TrackedGraph_TNode_.#ctor.md#SpatialGraph.TrackedGraph_TNode_.TrackedGraph(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.TrackedGraph\<TNode\>\.TrackedGraph\(SpatialGraph\.IReadOnlyGraph\<TNode\>\)') | Start graph from a pre\-exisitng graph\. |
| [TrackedGraph\(Dictionary&lt;uint,TNode&gt;, Dictionary&lt;uint,Edge&gt;\)](SpatialGraph.TrackedGraph_TNode_.#ctor.md#SpatialGraph.TrackedGraph_TNode_.TrackedGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_) 'SpatialGraph\.TrackedGraph\<TNode\>\.TrackedGraph\(System\.Collections\.Generic\.Dictionary\<uint,TNode\>, System\.Collections\.Generic\.Dictionary\<uint,SpatialGraph\.Edge\>\)') | Start a graph from pre\-exisiting dictionaries of nodes and edges\. |

| Methods | |
| :--- | :--- |
| [ApplyChangeSet\(GraphChangeSet&lt;TNode&gt;\)](SpatialGraph.TrackedGraph_TNode_.ApplyChangeSet(SpatialGraph.GraphChangeSet_TNode_).md 'SpatialGraph\.TrackedGraph\<TNode\>\.ApplyChangeSet\(SpatialGraph\.GraphChangeSet\<TNode\>\)') | Perform multiple operations at once with a GraphChangeSet\. Existing nodes or edges with a corresponding ID in the graph will be replaced\. Nodes and edges can share the same ID\. |
| [RemoveEdge\(uint\)](SpatialGraph.TrackedGraph_TNode_.RemoveEdge(uint).md 'SpatialGraph\.TrackedGraph\<TNode\>\.RemoveEdge\(uint\)') | Remove an edge in the graph using its corresponding ID\. Nodes and edges can share the same ID, this will remove only the edge with the corresponding ID\. |
| [RemoveNode\(uint\)](SpatialGraph.TrackedGraph_TNode_.RemoveNode(uint).md 'SpatialGraph\.TrackedGraph\<TNode\>\.RemoveNode\(uint\)') | Remove a node in the graph using its correspinding ID\. Connecting edges referencing this node will not be removed\. Nodes and edges can share the same ID, this will remove only the node with the corresponding ID\. |
| [UpsertEdge\(Edge\)](SpatialGraph.TrackedGraph_TNode_.UpsertEdge(SpatialGraph.Edge).md 'SpatialGraph\.TrackedGraph\<TNode\>\.UpsertEdge\(SpatialGraph\.Edge\)') | Add a new edge or modify an edge with its corresponding ID\. |
| [UpsertNode\(TNode\)](SpatialGraph.TrackedGraph_TNode_.UpsertNode(TNode).md 'SpatialGraph\.TrackedGraph\<TNode\>\.UpsertNode\(TNode\)') | Add a new node or modify one with their corresponding ID\. Nodes and edges can share the same ID\. |

| Events | |
| :--- | :--- |
| [OnGraphModified](SpatialGraph.TrackedGraph_TNode_.OnGraphModified.md 'SpatialGraph\.TrackedGraph\<TNode\>\.OnGraphModified') | Event for changes applied\. Invokes with an IReadOnlyModificationLog, which contains the changes in the graph after it is modified\. |
