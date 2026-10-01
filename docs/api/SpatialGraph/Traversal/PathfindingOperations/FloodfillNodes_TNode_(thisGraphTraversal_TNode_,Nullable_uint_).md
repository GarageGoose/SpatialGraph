## PathfindingOperations\.FloodfillNodes<TNode>(this GraphTraversal<TNode>, Nullable<uint>) Method

Get all the connected nodes connected from the source node\.

```csharp
public static System.Collections.Generic.List<uint> FloodfillNodes<TNode>(this SpatialGraph.Traversal.GraphTraversal<TNode> graphTraversal, System.Nullable<uint> limitNodes=null)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Traversal.PathfindingOperations.FloodfillNodes_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_,System.Nullable_uint_).TNode'></a>

`TNode`

Node type\.
#### Parameters

<a name='SpatialGraph.Traversal.PathfindingOperations.FloodfillNodes_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_,System.Nullable_uint_).graphTraversal'></a>

`graphTraversal` [SpatialGraph\.Traversal\.GraphTraversal&lt;](../GraphTraversal_TNode_/index.md 'SpatialGraph\.Traversal\.GraphTraversal<TNode>')[TNode](FloodfillNodes_TNode_(thisGraphTraversal_TNode_,Nullable_uint_).md#SpatialGraph.Traversal.PathfindingOperations.FloodfillNodes_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_,System.Nullable_uint_).TNode 'SpatialGraph\.Traversal\.PathfindingOperations\.FloodfillNodes<TNode>(this SpatialGraph\.Traversal\.GraphTraversal<TNode>, System\.Nullable<uint>)\.TNode')[&gt;](../GraphTraversal_TNode_/index.md 'SpatialGraph\.Traversal\.GraphTraversal<TNode>')

Traversal algorithm to use\.

<a name='SpatialGraph.Traversal.PathfindingOperations.FloodfillNodes_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_,System.Nullable_uint_).limitNodes'></a>

`limitNodes` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

Limit discovered nodes to a specific amount\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
List of NodeIDs connected to the source node\.