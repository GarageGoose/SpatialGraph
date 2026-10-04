## ObservableGraph<TNode> Class

Graph which track changes within it\. A graph stores [INode](../INode/index.md 'SpatialGraph\.INode') and [Edge](../Edge/index.md 'SpatialGraph\.Edge') within it, identified by their IDs\.
Observable graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements\.

```csharp
public class ObservableGraph<TNode> : SpatialGraph.Graph<TNode>, SpatialGraph.IObservableGraph<TNode>, SpatialGraph.IReadOnlyObservableGraph<TNode>, SpatialGraph.IReadOnlyGraph<TNode>, SpatialGraph.IGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.ObservableGraph_TNode_.TNode'></a>

`TNode`

Type of node to be used in the graph\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [SpatialGraph\.Graph&lt;](../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')[TNode](index.md#SpatialGraph.ObservableGraph_TNode_.TNode 'SpatialGraph\.ObservableGraph<TNode>\.TNode')[&gt;](../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>') → ObservableGraph<TNode>

Implements [SpatialGraph\.IObservableGraph&lt;](../IObservableGraph_TNode_/index.md 'SpatialGraph\.IObservableGraph<TNode>')[TNode](index.md#SpatialGraph.ObservableGraph_TNode_.TNode 'SpatialGraph\.ObservableGraph<TNode>\.TNode')[&gt;](../IObservableGraph_TNode_/index.md 'SpatialGraph\.IObservableGraph<TNode>'), [SpatialGraph\.IReadOnlyObservableGraph&lt;](../IReadOnlyObservableGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyObservableGraph<TNode>')[TNode](index.md#SpatialGraph.ObservableGraph_TNode_.TNode 'SpatialGraph\.ObservableGraph<TNode>\.TNode')[&gt;](../IReadOnlyObservableGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyObservableGraph<TNode>'), [SpatialGraph\.IReadOnlyGraph&lt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[TNode](index.md#SpatialGraph.ObservableGraph_TNode_.TNode 'SpatialGraph\.ObservableGraph<TNode>\.TNode')[&gt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>'), [SpatialGraph\.IGraph&lt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[TNode](index.md#SpatialGraph.ObservableGraph_TNode_.TNode 'SpatialGraph\.ObservableGraph<TNode>\.TNode')[&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

| Constructors | |
| :--- | :--- |
| [ObservableGraph()](ObservableGraph_TNode_.md#SpatialGraph.ObservableGraph_TNode_.ObservableGraph() 'SpatialGraph\.ObservableGraph<TNode>\.ObservableGraph()') | Start an empty graph\. |
| [ObservableGraph(IReadOnlyGraph&lt;TNode&gt;)](ObservableGraph_TNode_.md#SpatialGraph.ObservableGraph_TNode_.ObservableGraph(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.ObservableGraph<TNode>\.ObservableGraph(SpatialGraph\.IReadOnlyGraph<TNode>)') | Start graph from a pre-existing graph\. |
| [ObservableGraph(Dictionary&lt;uint,TNode&gt;, Dictionary&lt;uint,Edge&gt;)](ObservableGraph_TNode_.md#SpatialGraph.ObservableGraph_TNode_.ObservableGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_) 'SpatialGraph\.ObservableGraph<TNode>\.ObservableGraph(System\.Collections\.Generic\.Dictionary<uint,TNode>, System\.Collections\.Generic\.Dictionary<uint,SpatialGraph\.Edge>)') | Start a graph from pre-existing dictionaries of nodes and edges\. |

| Methods | |
| :--- | :--- |
| [ApplyChangeSet(GraphChangeSet&lt;TNode&gt;)](ApplyChangeSet(GraphChangeSet_TNode_).md 'SpatialGraph\.ObservableGraph<TNode>\.ApplyChangeSet(SpatialGraph\.GraphChangeSet<TNode>)') | Perform multiple operations at once with a [GraphChangeSet&lt;TNode&gt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')\. Existing [INode](../INode/index.md 'SpatialGraph\.INode') or [Edge](../Edge/index.md 'SpatialGraph\.Edge')s with a corresponding ID in the graph will be replaced\. Nodes and edges can share the same ID\. |
| [RemoveEdge(uint)](RemoveEdge(uint).md 'SpatialGraph\.ObservableGraph<TNode>\.RemoveEdge(uint)') | Remove an [Edge](../Edge/index.md 'SpatialGraph\.Edge') in the graph using its corresponding ID\. Nodes and edges can share the same ID, this will remove only the edge with the corresponding ID\. |
| [RemoveNode(uint)](RemoveNode(uint).md 'SpatialGraph\.ObservableGraph<TNode>\.RemoveNode(uint)') | Remove a [INode](../INode/index.md 'SpatialGraph\.INode') in the graph using its correspinding ID\. Connecting [Edge](../Edge/index.md 'SpatialGraph\.Edge') referencing this node will not be removed\. Nodes and edges can share the same ID, this will remove only the node with the corresponding ID\. |
| [UpsertEdge(Edge)](UpsertEdge(Edge).md 'SpatialGraph\.ObservableGraph<TNode>\.UpsertEdge(SpatialGraph\.Edge)') | Add a new [Edge](../Edge/index.md 'SpatialGraph\.Edge') or modify an [Edge](../Edge/index.md 'SpatialGraph\.Edge') with its corresponding ID\. |
| [UpsertNode(TNode)](UpsertNode(TNode).md 'SpatialGraph\.ObservableGraph<TNode>\.UpsertNode(TNode)') | Add a new [INode](../INode/index.md 'SpatialGraph\.INode') or modify one with their corresponding ID\. Nodes and edges can share the same ID\. |

| Events | |
| :--- | :--- |
| [OnGraphModified](OnGraphModified.md 'SpatialGraph\.ObservableGraph<TNode>\.OnGraphModified') | Event for changes applied\. Invokes with an IReadOnlyModificationLog, which contains the changes in the graph after it is modified\. |
