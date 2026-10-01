## PathfindingOps\.IsNodeConnected\<TNode\>\(this GraphTraversal\<TNode\>\) Method

Check if two nodes were connected through edges\.

```csharp
public static bool IsNodeConnected<TNode>(this SpatialGraph.Traversal.GraphTraversal<TNode> graphTraversal)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Traversal.PathfindingOps.IsNodeConnected_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_).TNode'></a>

`TNode`

Node type\.
#### Parameters

<a name='SpatialGraph.Traversal.PathfindingOps.IsNodeConnected_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_).graphTraversal'></a>

`graphTraversal` [SpatialGraph\.Traversal\.GraphTraversal&lt;](SpatialGraph.Traversal.GraphTraversal_TNode_.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>')[TNode](SpatialGraph.Traversal.PathfindingOps.IsNodeConnected_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_).md#SpatialGraph.Traversal.PathfindingOps.IsNodeConnected_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_).TNode 'SpatialGraph\.Traversal\.PathfindingOps\.IsNodeConnected\<TNode\>\(this SpatialGraph\.Traversal\.GraphTraversal\<TNode\>\)\.TNode')[&gt;](SpatialGraph.Traversal.GraphTraversal_TNode_.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>')

Traversal algorithm to use\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
If path between the two nodes were found\.