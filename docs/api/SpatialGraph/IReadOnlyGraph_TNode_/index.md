## IReadOnlyGraph<TNode> Interface

Read only interface of [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. A graph stores [INode](../INode/index.md 'SpatialGraph\.INode') and [Edge](../Edge/index.md 'SpatialGraph\.Edge') within it, identified by their IDs\.

```csharp
public interface IReadOnlyGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.IReadOnlyGraph_TNode_.TNode'></a>

`TNode`

Type of node to be used in the graph\.

Derived  
↳ [Graph&lt;TNode&gt;](../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')  
↳ [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')  
↳ [IInterceptableTrackedGraph&lt;TNode&gt;](../IInterceptableTrackedGraph_TNode_/index.md 'SpatialGraph\.IInterceptableTrackedGraph<TNode>')  
↳ [InterceptableTrackedGraph&lt;TNode&gt;](../InterceptableTrackedGraph_TNode_/index.md 'SpatialGraph\.InterceptableTrackedGraph<TNode>')  
↳ [IReadOnlyTrackedGraph&lt;TNode&gt;](../IReadOnlyTrackedGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyTrackedGraph<TNode>')  
↳ [ITrackedGraph&lt;TNode&gt;](../ITrackedGraph_TNode_/index.md 'SpatialGraph\.ITrackedGraph<TNode>')  
↳ [GraphPlugin&lt;TNode&gt;](../Metadata/GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>')  
↳ [GraphReadOnlyPlugin&lt;TNode&gt;](../Metadata/GraphReadOnlyPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>')  
↳ [TrackedGraph&lt;TNode&gt;](../TrackedGraph_TNode_/index.md 'SpatialGraph\.TrackedGraph<TNode>')

| Properties | |
| :--- | :--- |
| [Edges](Edges.md 'SpatialGraph\.IReadOnlyGraph<TNode>\.Edges') | Edges stored in this graph\. Elements such as edges are referenced be their unique ID\. Nodes and edges can share the same ID\. |
| [Nodes](Nodes.md 'SpatialGraph\.IReadOnlyGraph<TNode>\.Nodes') | Nodes stored in this graph\. Elements such as nodes are referenced be their unique ID\. Nodes and edges can share the same ID\. |

| Methods | |
| :--- | :--- |
| [GenerateID()](GenerateID().md 'SpatialGraph\.IReadOnlyGraph<TNode>\.GenerateID()') | Generate unique ID for the elements of the graph\. Nodes and edges can share the same ID\. |
