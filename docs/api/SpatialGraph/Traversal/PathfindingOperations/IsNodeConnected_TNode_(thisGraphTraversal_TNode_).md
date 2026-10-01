## PathfindingOperations\.IsNodeConnected<TNode>(this GraphTraversal<TNode>) Method

Check if two nodes were connected through edges\.

```csharp
public static bool IsNodeConnected<TNode>(this SpatialGraph.Traversal.GraphTraversal<TNode> graphTraversal)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Traversal.PathfindingOperations.IsNodeConnected_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_).TNode'></a>

`TNode`

Node type\.
#### Parameters

<a name='SpatialGraph.Traversal.PathfindingOperations.IsNodeConnected_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_).graphTraversal'></a>

`graphTraversal` [SpatialGraph\.Traversal\.GraphTraversal&lt;](../GraphTraversal_TNode_/index.md 'SpatialGraph\.Traversal\.GraphTraversal<TNode>')[TNode](IsNodeConnected_TNode_(thisGraphTraversal_TNode_).md#SpatialGraph.Traversal.PathfindingOperations.IsNodeConnected_TNode_(thisSpatialGraph.Traversal.GraphTraversal_TNode_).TNode 'SpatialGraph\.Traversal\.PathfindingOperations\.IsNodeConnected<TNode>(this SpatialGraph\.Traversal\.GraphTraversal<TNode>)\.TNode')[&gt;](../GraphTraversal_TNode_/index.md 'SpatialGraph\.Traversal\.GraphTraversal<TNode>')

Traversal algorithm to use\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
If path between the two nodes were found\.