## TraversalInfo\<TNode\> Struct

Provides traversal info for a specific node\.

```csharp
public readonly record struct TraversalInfo<TNode> : System.IEquatable<SpatialGraph.Traversal.TraversalInfo<TNode>>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.Traversal.TraversalInfo_TNode_.TNode'></a>

`TNode`

Node type\.

Implements [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[SpatialGraph\.Traversal\.TraversalInfo&lt;](SpatialGraph.Traversal.TraversalInfo_TNode_.md 'SpatialGraph\.Traversal\.TraversalInfo\<TNode\>')[TNode](SpatialGraph.Traversal.TraversalInfo_TNode_.md#SpatialGraph.Traversal.TraversalInfo_TNode_.TNode 'SpatialGraph\.Traversal\.TraversalInfo\<TNode\>\.TNode')[&gt;](SpatialGraph.Traversal.TraversalInfo_TNode_.md 'SpatialGraph\.Traversal\.TraversalInfo\<TNode\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [TraversalInfo\(uint, Nullable&lt;uint&gt;, Nullable&lt;uint&gt;\)](SpatialGraph.Traversal.TraversalInfo_TNode_.TraversalInfo(uint,System.Nullable_uint_,System.Nullable_uint_).md 'SpatialGraph\.Traversal\.TraversalInfo\<TNode\>\.TraversalInfo\(uint, System\.Nullable\<uint\>, System\.Nullable\<uint\>\)') | Provides traversal info for a specific node\. |

| Properties | |
| :--- | :--- |
| [EdgeUsedForTraversal](SpatialGraph.Traversal.TraversalInfo_TNode_.EdgeUsedForTraversal.md 'SpatialGraph\.Traversal\.TraversalInfo\<TNode\>\.EdgeUsedForTraversal') | Edge where the current node was found\. |
| [NodeID](SpatialGraph.Traversal.TraversalInfo_TNode_.NodeID.md 'SpatialGraph\.Traversal\.TraversalInfo\<TNode\>\.NodeID') | Current node ID\. |
| [OriginNodeID](SpatialGraph.Traversal.TraversalInfo_TNode_.OriginNodeID.md 'SpatialGraph\.Traversal\.TraversalInfo\<TNode\>\.OriginNodeID') | Node where the current node was found\. |
