## GraphTraversal\<TNode\> Struct

Graph traversal algorithms\.

```csharp
public readonly record struct GraphTraversal<TNode> : System.IEquatable<SpatialGraph.Traversal.GraphTraversal<TNode>>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.Traversal.GraphTraversal_TNode_.TNode'></a>

`TNode`

Node type\.

Implements [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[SpatialGraph\.Traversal\.GraphTraversal&lt;](SpatialGraph.Traversal.GraphTraversal_TNode_.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>')[TNode](SpatialGraph.Traversal.GraphTraversal_TNode_.md#SpatialGraph.Traversal.GraphTraversal_TNode_.TNode 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>\.TNode')[&gt;](SpatialGraph.Traversal.GraphTraversal_TNode_.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [GraphTraversal\(IEnumerable&lt;TraversalInfo&lt;TNode&gt;&gt;, NodeAdjacency&lt;TNode&gt;, uint, Nullable&lt;uint&gt;\)](SpatialGraph.Traversal.GraphTraversal_TNode_.GraphTraversal(System.Collections.Generic.IEnumerable_SpatialGraph.Traversal.TraversalInfo_TNode__,SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>\.GraphTraversal\(System\.Collections\.Generic\.IEnumerable\<SpatialGraph\.Traversal\.TraversalInfo\<TNode\>\>, SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>, uint, System\.Nullable\<uint\>\)') | Graph traversal algorithms\. |

| Properties | |
| :--- | :--- |
| [BaseGraph](SpatialGraph.Traversal.GraphTraversal_TNode_.BaseGraph.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>\.BaseGraph') | Graph to traverse\. |
| [StartingNodeID](SpatialGraph.Traversal.GraphTraversal_TNode_.StartingNodeID.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>\.StartingNodeID') | Node to start traversal\. |
| [TagretNodeID](SpatialGraph.Traversal.GraphTraversal_TNode_.TagretNodeID.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>\.TagretNodeID') | Node to find when travering\. |
| [Traverse](SpatialGraph.Traversal.GraphTraversal_TNode_.Traverse.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>\.Traverse') | Traverse the graph\. |
