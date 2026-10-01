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

Implements [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[SpatialGraph\.Traversal\.TraversalInfo&lt;](index.md 'SpatialGraph\.Traversal\.TraversalInfo\<TNode\>')[TNode](index.md#SpatialGraph.Traversal.TraversalInfo_TNode_.TNode 'SpatialGraph\.Traversal\.TraversalInfo\<TNode\>\.TNode')[&gt;](index.md 'SpatialGraph\.Traversal\.TraversalInfo\<TNode\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [TraversalInfo\(uint, Nullable&lt;uint&gt;, Nullable&lt;uint&gt;\)](TraversalInfo(uint,Nullable_uint_,Nullable_uint_).md 'SpatialGraph\.Traversal\.TraversalInfo\<TNode\>\.TraversalInfo\(uint, System\.Nullable\<uint\>, System\.Nullable\<uint\>\)') | Provides traversal info for a specific node\. |

| Properties | |
| :--- | :--- |
| [EdgeUsedForTraversal](EdgeUsedForTraversal.md 'SpatialGraph\.Traversal\.TraversalInfo\<TNode\>\.EdgeUsedForTraversal') | Edge where the current node was found\. |
| [NodeID](NodeID.md 'SpatialGraph\.Traversal\.TraversalInfo\<TNode\>\.NodeID') | Current node ID\. |
| [OriginNodeID](OriginNodeID.md 'SpatialGraph\.Traversal\.TraversalInfo\<TNode\>\.OriginNodeID') | Node where the current node was found\. |
