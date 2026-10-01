## PathfindingOperations\.ElementsOnTraversal\<TNode\>\(this GraphTraversal\<TNode\>, List\<uint\>, List\<uint\>\) Method

Get the elements traversed\.

```csharp
public static void ElementsOnTraversal<TNode>(this SpatialGraph.Traversal.GraphTraversal<TNode> graphTraversal, out System.Collections.Generic.List<uint> nodeIDs, out System.Collections.Generic.List<uint> edgeIDs)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Traversal.PathfindingOperations.ElementsOnTraversal_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_,System.Collections.Generic.List_uint_,System.Collections.Generic.List_uint_).TNode'></a>

`TNode`

Node type\.
#### Parameters

<a name='SpatialGraph.Traversal.PathfindingOperations.ElementsOnTraversal_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_,System.Collections.Generic.List_uint_,System.Collections.Generic.List_uint_).graphTraversal'></a>

`graphTraversal` [SpatialGraph\.Traversal\.GraphTraversal&lt;](SpatialGraph.Traversal.GraphTraversal_TNode_.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>')[TNode](SpatialGraph.Traversal.PathfindingOperations.ElementsOnTraversal_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_,System.Collections.Generic.List_uint_,System.Collections.Generic.List_uint_).md#SpatialGraph.Traversal.PathfindingOperations.ElementsOnTraversal_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_,System.Collections.Generic.List_uint_,System.Collections.Generic.List_uint_).TNode 'SpatialGraph\.Traversal\.PathfindingOperations\.ElementsOnTraversal\<TNode\>\(this SpatialGraph\.Traversal\.GraphTraversal\<TNode\>, System\.Collections\.Generic\.List\<uint\>, System\.Collections\.Generic\.List\<uint\>\)\.TNode')[&gt;](SpatialGraph.Traversal.GraphTraversal_TNode_.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>')

Traversal algorithm to use\.

<a name='SpatialGraph.Traversal.PathfindingOperations.ElementsOnTraversal_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_,System.Collections.Generic.List_uint_,System.Collections.Generic.List_uint_).nodeIDs'></a>

`nodeIDs` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

IDs of nodes traversed\.

<a name='SpatialGraph.Traversal.PathfindingOperations.ElementsOnTraversal_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_,System.Collections.Generic.List_uint_,System.Collections.Generic.List_uint_).edgeIDs'></a>

`edgeIDs` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

IDs of edges traversed\.