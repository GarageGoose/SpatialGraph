## InterceptableTrackedGraph\<TNode\> Class

Graph which tracks and can modifiy incoming changes within it\.

```csharp
public class InterceptableTrackedGraph<TNode> : SpatialGraph.Graph<TNode>, SpatialGraph.IInterceptableTrackedGraph<TNode>, SpatialGraph.ITrackedGraph<TNode>, SpatialGraph.IReadOnlyTrackedGraph<TNode>, SpatialGraph.IReadOnlyGraph<TNode>, SpatialGraph.IGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.InterceptableTrackedGraph_TNode_.TNode'></a>

`TNode`

Type of node to be used in the graph\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [SpatialGraph\.Graph&lt;](SpatialGraph.Graph_TNode_.md 'SpatialGraph\.Graph\<TNode\>')[TNode](SpatialGraph.InterceptableTrackedGraph_TNode_.md#SpatialGraph.InterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.Graph_TNode_.md 'SpatialGraph\.Graph\<TNode\>') → InterceptableTrackedGraph\<TNode\>

Implements [SpatialGraph\.IInterceptableTrackedGraph&lt;](SpatialGraph.IInterceptableTrackedGraph_TNode_.md 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>')[TNode](SpatialGraph.InterceptableTrackedGraph_TNode_.md#SpatialGraph.InterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.IInterceptableTrackedGraph_TNode_.md 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>'), [SpatialGraph\.ITrackedGraph&lt;](SpatialGraph.ITrackedGraph_TNode_.md 'SpatialGraph\.ITrackedGraph\<TNode\>')[TNode](SpatialGraph.InterceptableTrackedGraph_TNode_.md#SpatialGraph.InterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.ITrackedGraph_TNode_.md 'SpatialGraph\.ITrackedGraph\<TNode\>'), [SpatialGraph\.IReadOnlyTrackedGraph&lt;](SpatialGraph.IReadOnlyTrackedGraph_TNode_.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>')[TNode](SpatialGraph.InterceptableTrackedGraph_TNode_.md#SpatialGraph.InterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyTrackedGraph_TNode_.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>'), [SpatialGraph\.IReadOnlyGraph&lt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](SpatialGraph.InterceptableTrackedGraph_TNode_.md#SpatialGraph.InterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>'), [SpatialGraph\.IGraph&lt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')[TNode](SpatialGraph.InterceptableTrackedGraph_TNode_.md#SpatialGraph.InterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')

| Constructors | |
| :--- | :--- |
| [InterceptableTrackedGraph\(\)](SpatialGraph.InterceptableTrackedGraph_TNode_.#ctor.md#SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph() 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.InterceptableTrackedGraph\(\)') | Start an empty graph\. |
| [InterceptableTrackedGraph\(IReadOnlyGraph&lt;TNode&gt;\)](SpatialGraph.InterceptableTrackedGraph_TNode_.#ctor.md#SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.InterceptableTrackedGraph\(SpatialGraph\.IReadOnlyGraph\<TNode\>\)') | Start graph from a pre\-exisitng graph\. |
| [InterceptableTrackedGraph\(Dictionary&lt;uint,TNode&gt;, Dictionary&lt;uint,Edge&gt;\)](SpatialGraph.InterceptableTrackedGraph_TNode_.#ctor.md#SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_) 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.InterceptableTrackedGraph\(System\.Collections\.Generic\.Dictionary\<uint,TNode\>, System\.Collections\.Generic\.Dictionary\<uint,SpatialGraph\.Edge\>\)') | Start a graph from pre\-exisiting dictionaries of nodes and edges\. |

| Methods | |
| :--- | :--- |
| [ApplyChangeSet\(GraphChangeSet&lt;TNode&gt;\)](SpatialGraph.InterceptableTrackedGraph_TNode_.ApplyChangeSet(SpatialGraph.GraphChangeSet_TNode_).md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.ApplyChangeSet\(SpatialGraph\.GraphChangeSet\<TNode\>\)') | Perform multiple operations at once with a GraphChangeSet\. Existing nodes or edges with a corresponding ID in the graph will be replaced\. Nodes and edges can share the same ID\. |
| [RemoveEdge\(uint\)](SpatialGraph.InterceptableTrackedGraph_TNode_.RemoveEdge(uint).md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.RemoveEdge\(uint\)') | Remove an edge in the graph using its corresponding ID\. Nodes and edges can share the same ID, this will remove only the edge with the corresponding ID\. |
| [RemoveNode\(uint\)](SpatialGraph.InterceptableTrackedGraph_TNode_.RemoveNode(uint).md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.RemoveNode\(uint\)') | Remove a node in the graph using its correspinding ID\. Connecting edges referencing this node will not be removed\. Nodes and edges can share the same ID, this will remove only the node with the corresponding ID\. |
| [UpsertEdge\(Edge\)](SpatialGraph.InterceptableTrackedGraph_TNode_.UpsertEdge(SpatialGraph.Edge).md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.UpsertEdge\(SpatialGraph\.Edge\)') | Add a new edge or modify an edge with its corresponding ID\. |
| [UpsertNode\(TNode\)](SpatialGraph.InterceptableTrackedGraph_TNode_.UpsertNode(TNode).md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.UpsertNode\(TNode\)') | Add a new node or modify one with their corresponding ID\. Nodes and edges can share the same ID\. |

| Events | |
| :--- | :--- |
| [OnGraphModificationInit](SpatialGraph.InterceptableTrackedGraph_TNode_.OnGraphModificationInit.md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.OnGraphModificationInit') | Event for incoming changes\. Invokes with a GraphChangeLog which contains the modifications being performed\. Modifications can be changed via the GraphChangeLog before being applied to the graph\. |
| [OnGraphModified](SpatialGraph.InterceptableTrackedGraph_TNode_.OnGraphModified.md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.OnGraphModified') | Event for changes applied\. Invokes with an IReadOnlyModificationLog, which contains the changes in the graph after it is modified\. |
