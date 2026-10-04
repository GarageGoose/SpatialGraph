## InterceptableObservableGraph<TNode> Class

Graph which can modify incoming changes and track changed within it\. A graph stores [INode](../INode/index.md 'SpatialGraph\.INode') and [Edge](../Edge/index.md 'SpatialGraph\.Edge') within it, identified by their IDs\.
Observable graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements\.

```csharp
public class InterceptableObservableGraph<TNode> : SpatialGraph.Graph<TNode>, SpatialGraph.IInterceptableObservableGraph<TNode>, SpatialGraph.IObservableGraph<TNode>, SpatialGraph.IReadOnlyObservableGraph<TNode>, SpatialGraph.IReadOnlyGraph<TNode>, SpatialGraph.IGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.InterceptableObservableGraph_TNode_.TNode'></a>

`TNode`

Type of node to be used in the graph\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [SpatialGraph\.Graph&lt;](../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')[TNode](index.md#SpatialGraph.InterceptableObservableGraph_TNode_.TNode 'SpatialGraph\.InterceptableObservableGraph<TNode>\.TNode')[&gt;](../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>') → InterceptableObservableGraph<TNode>

Implements [SpatialGraph\.IInterceptableObservableGraph&lt;](../IInterceptableObservableGraph_TNode_/index.md 'SpatialGraph\.IInterceptableObservableGraph<TNode>')[TNode](index.md#SpatialGraph.InterceptableObservableGraph_TNode_.TNode 'SpatialGraph\.InterceptableObservableGraph<TNode>\.TNode')[&gt;](../IInterceptableObservableGraph_TNode_/index.md 'SpatialGraph\.IInterceptableObservableGraph<TNode>'), [SpatialGraph\.IObservableGraph&lt;](../IObservableGraph_TNode_/index.md 'SpatialGraph\.IObservableGraph<TNode>')[TNode](index.md#SpatialGraph.InterceptableObservableGraph_TNode_.TNode 'SpatialGraph\.InterceptableObservableGraph<TNode>\.TNode')[&gt;](../IObservableGraph_TNode_/index.md 'SpatialGraph\.IObservableGraph<TNode>'), [SpatialGraph\.IReadOnlyObservableGraph&lt;](../IReadOnlyObservableGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyObservableGraph<TNode>')[TNode](index.md#SpatialGraph.InterceptableObservableGraph_TNode_.TNode 'SpatialGraph\.InterceptableObservableGraph<TNode>\.TNode')[&gt;](../IReadOnlyObservableGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyObservableGraph<TNode>'), [SpatialGraph\.IReadOnlyGraph&lt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[TNode](index.md#SpatialGraph.InterceptableObservableGraph_TNode_.TNode 'SpatialGraph\.InterceptableObservableGraph<TNode>\.TNode')[&gt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>'), [SpatialGraph\.IGraph&lt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[TNode](index.md#SpatialGraph.InterceptableObservableGraph_TNode_.TNode 'SpatialGraph\.InterceptableObservableGraph<TNode>\.TNode')[&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

| Constructors | |
| :--- | :--- |
| [InterceptableObservableGraph()](InterceptableObservableGraph_TNode_.md#SpatialGraph.InterceptableObservableGraph_TNode_.InterceptableObservableGraph() 'SpatialGraph\.InterceptableObservableGraph<TNode>\.InterceptableObservableGraph()') | Start an empty graph\. |
| [InterceptableObservableGraph(IReadOnlyGraph&lt;TNode&gt;)](InterceptableObservableGraph_TNode_.md#SpatialGraph.InterceptableObservableGraph_TNode_.InterceptableObservableGraph(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.InterceptableObservableGraph<TNode>\.InterceptableObservableGraph(SpatialGraph\.IReadOnlyGraph<TNode>)') | Start graph from a pre-existing graph\. |
| [InterceptableObservableGraph(Dictionary&lt;uint,TNode&gt;, Dictionary&lt;uint,Edge&gt;)](InterceptableObservableGraph_TNode_.md#SpatialGraph.InterceptableObservableGraph_TNode_.InterceptableObservableGraph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_) 'SpatialGraph\.InterceptableObservableGraph<TNode>\.InterceptableObservableGraph(System\.Collections\.Generic\.Dictionary<uint,TNode>, System\.Collections\.Generic\.Dictionary<uint,SpatialGraph\.Edge>)') | Start a graph from pre-existing dictionaries of nodes and edges\. |

| Methods | |
| :--- | :--- |
| [ApplyChangeSet(GraphChangeSet&lt;TNode&gt;)](ApplyChangeSet(GraphChangeSet_TNode_).md 'SpatialGraph\.InterceptableObservableGraph<TNode>\.ApplyChangeSet(SpatialGraph\.GraphChangeSet<TNode>)') | Perform multiple operations at once with a [GraphChangeSet&lt;TNode&gt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')\. Existing [INode](../INode/index.md 'SpatialGraph\.INode') or [Edge](../Edge/index.md 'SpatialGraph\.Edge')s with a corresponding ID in the graph will be replaced\. Nodes and edges can share the same ID\. |
| [RemoveEdge(uint)](RemoveEdge(uint).md 'SpatialGraph\.InterceptableObservableGraph<TNode>\.RemoveEdge(uint)') | Remove an [Edge](../Edge/index.md 'SpatialGraph\.Edge') in the graph using its corresponding ID\. Nodes and edges can share the same ID, this will remove only the edge with the corresponding ID\. |
| [RemoveNode(uint)](RemoveNode(uint).md 'SpatialGraph\.InterceptableObservableGraph<TNode>\.RemoveNode(uint)') | Remove a [INode](../INode/index.md 'SpatialGraph\.INode') in the graph using its correspinding ID\. Connecting [Edge](../Edge/index.md 'SpatialGraph\.Edge') referencing this node will not be removed\. Nodes and edges can share the same ID, this will remove only the node with the corresponding ID\. |
| [UpsertEdge(Edge)](UpsertEdge(Edge).md 'SpatialGraph\.InterceptableObservableGraph<TNode>\.UpsertEdge(SpatialGraph\.Edge)') | Add a new [Edge](../Edge/index.md 'SpatialGraph\.Edge') or modify an [Edge](../Edge/index.md 'SpatialGraph\.Edge') with its corresponding ID\. |
| [UpsertNode(TNode)](UpsertNode(TNode).md 'SpatialGraph\.InterceptableObservableGraph<TNode>\.UpsertNode(TNode)') | Add a new [INode](../INode/index.md 'SpatialGraph\.INode') or modify one with their corresponding ID\. Nodes and edges can share the same ID\. |

| Events | |
| :--- | :--- |
| [OnGraphModificationInit](OnGraphModificationInit.md 'SpatialGraph\.InterceptableObservableGraph<TNode>\.OnGraphModificationInit') | Event for incoming changes\. Invokes with a GraphChangeLog which contains the modifications being performed\. Modifications can be changed via the GraphChangeLog before being applied to the graph\. |
| [OnGraphModified](OnGraphModified.md 'SpatialGraph\.InterceptableObservableGraph<TNode>\.OnGraphModified') | Event for changes applied\. Invokes with an IReadOnlyModificationLog, which contains the changes in the graph after it is modified\. |
