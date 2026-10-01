## PathfindingOperations\.Pathfind\<TNode\>\(this GraphTraversal\<TNode\>, Stack\<uint\>, Stack\<uint\>\) Method

Find path between two nodes\.

```csharp
public static bool Pathfind<TNode>(this SpatialGraph.Traversal.GraphTraversal<TNode> graphTraversal, out System.Collections.Generic.Stack<uint> edgeIDs, out System.Collections.Generic.Stack<uint> nodeIDs)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Traversal.PathfindingOperations.Pathfind_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_,System.Collections.Generic.Stack_uint_,System.Collections.Generic.Stack_uint_).TNode'></a>

`TNode`

Node type\.
#### Parameters

<a name='SpatialGraph.Traversal.PathfindingOperations.Pathfind_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_,System.Collections.Generic.Stack_uint_,System.Collections.Generic.Stack_uint_).graphTraversal'></a>

`graphTraversal` [SpatialGraph\.Traversal\.GraphTraversal&lt;](../GraphTraversal_TNode_/index.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>')[TNode](Pathfind_TNode_(thisGraphTraversal_TNode_,Stack_uint_,Stack_uint_).md#SpatialGraph.Traversal.PathfindingOperations.Pathfind_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_,System.Collections.Generic.Stack_uint_,System.Collections.Generic.Stack_uint_).TNode 'SpatialGraph\.Traversal\.PathfindingOperations\.Pathfind\<TNode\>\(this SpatialGraph\.Traversal\.GraphTraversal\<TNode\>, System\.Collections\.Generic\.Stack\<uint\>, System\.Collections\.Generic\.Stack\<uint\>\)\.TNode')[&gt;](../GraphTraversal_TNode_/index.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>')

Traversal algorithm to use\.

<a name='SpatialGraph.Traversal.PathfindingOperations.Pathfind_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_,System.Collections.Generic.Stack_uint_,System.Collections.Generic.Stack_uint_).edgeIDs'></a>

`edgeIDs` [System\.Collections\.Generic\.Stack&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1 'System\.Collections\.Generic\.Stack\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1 'System\.Collections\.Generic\.Stack\`1')

IDs of edges connecting the source and target nodes\.

<a name='SpatialGraph.Traversal.PathfindingOperations.Pathfind_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_,System.Collections.Generic.Stack_uint_,System.Collections.Generic.Stack_uint_).nodeIDs'></a>

`nodeIDs` [System\.Collections\.Generic\.Stack&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1 'System\.Collections\.Generic\.Stack\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1 'System\.Collections\.Generic\.Stack\`1')

IDs of nodes connecting the source and target nodes\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
If path between the two nodes were found\.