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

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [SpatialGraph\.Graph&lt;](../Graph_TNode_/index.md 'SpatialGraph\.Graph\<TNode\>')[TNode](index.md#SpatialGraph.InterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](../Graph_TNode_/index.md 'SpatialGraph\.Graph\<TNode\>') → InterceptableTrackedGraph\<TNode\>

Implements [SpatialGraph\.IInterceptableTrackedGraph&lt;](../IInterceptableTrackedGraph_TNode_/index.md 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>')[TNode](index.md#SpatialGraph.InterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](../IInterceptableTrackedGraph_TNode_/index.md 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>'), [SpatialGraph\.ITrackedGraph&lt;](../ITrackedGraph_TNode_/index.md 'SpatialGraph\.ITrackedGraph\<TNode\>')[TNode](index.md#SpatialGraph.InterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](../ITrackedGraph_TNode_/index.md 'SpatialGraph\.ITrackedGraph\<TNode\>'), [SpatialGraph\.IReadOnlyTrackedGraph&lt;](../IReadOnlyTrackedGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>')[TNode](index.md#SpatialGraph.InterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](../IReadOnlyTrackedGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>'), [SpatialGraph\.IReadOnlyGraph&lt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](index.md#SpatialGraph.InterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>'), [SpatialGraph\.IGraph&lt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph\<TNode\>')[TNode](index.md#SpatialGraph.InterceptableTrackedGraph_TNode_.TNode 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.TNode')[&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph\<TNode\>')

| Constructors | |
| :--- | :--- |
| [InterceptableTrackedGraph\(\)](InterceptableTrackedGraph_TNode_.md#SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph() 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.InterceptableTrackedGraph\(\)') | Start an empty graph\. |
| [InterceptableTrackedGraph\(IReadOnlyGraph&lt;TNode&gt;\)](InterceptableTrackedGraph_TNode_.md#SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.InterceptableTrackedGraph\(SpatialGraph\.IReadOnlyGraph\<TNode\>\)') | Start graph from a pre\-exisitng graph\. |
| [InterceptableTrackedGraph\(Dictionary&lt;uint,TNode&gt;, Dictionary&lt;uint,Edge&gt;\)](InterceptableTrackedGraph_TNode_.md#SpatialGraph.InterceptableTrackedGraph_TNode_.InterceptableTrackedGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_) 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.InterceptableTrackedGraph\(System\.Collections\.Generic\.Dictionary\<uint,TNode\>, System\.Collections\.Generic\.Dictionary\<uint,SpatialGraph\.Edge\>\)') | Start a graph from pre\-exisiting dictionaries of nodes and edges\. |

| Methods | |
| :--- | :--- |
| [ApplyChangeSet\(GraphChangeSet&lt;TNode&gt;\)](ApplyChangeSet(GraphChangeSet_TNode_).md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.ApplyChangeSet\(SpatialGraph\.GraphChangeSet\<TNode\>\)') | Perform multiple operations at once with a GraphChangeSet\. Existing nodes or edges with a corresponding ID in the graph will be replaced\. Nodes and edges can share the same ID\. |
| [RemoveEdge\(uint\)](RemoveEdge(uint).md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.RemoveEdge\(uint\)') | Remove an edge in the graph using its corresponding ID\. Nodes and edges can share the same ID, this will remove only the edge with the corresponding ID\. |
| [RemoveNode\(uint\)](RemoveNode(uint).md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.RemoveNode\(uint\)') | Remove a node in the graph using its correspinding ID\. Connecting edges referencing this node will not be removed\. Nodes and edges can share the same ID, this will remove only the node with the corresponding ID\. |
| [UpsertEdge\(Edge\)](UpsertEdge(Edge).md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.UpsertEdge\(SpatialGraph\.Edge\)') | Add a new edge or modify an edge with its corresponding ID\. |
| [UpsertNode\(TNode\)](UpsertNode(TNode).md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.UpsertNode\(TNode\)') | Add a new node or modify one with their corresponding ID\. Nodes and edges can share the same ID\. |

| Events | |
| :--- | :--- |
| [OnGraphModificationInit](OnGraphModificationInit.md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.OnGraphModificationInit') | Event for incoming changes\. Invokes with a GraphChangeLog which contains the modifications being performed\. Modifications can be changed via the GraphChangeLog before being applied to the graph\. |
| [OnGraphModified](OnGraphModified.md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>\.OnGraphModified') | Event for changes applied\. Invokes with an IReadOnlyModificationLog, which contains the changes in the graph after it is modified\. |
