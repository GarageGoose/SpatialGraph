## PathfindingOperations Class

Extention functions for graph traversal algorithms\.

```csharp
public static class PathfindingOperations
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → PathfindingOperations

| Methods | |
| :--- | :--- |
| [EdgesTraversed&lt;TNode&gt;\(this GraphTraversal&lt;TNode&gt;, Nullable&lt;uint&gt;\)](EdgesTraversed_TNode_(thisGraphTraversal_TNode_,Nullable_uint_).md 'SpatialGraph\.Traversal\.PathfindingOperations\.EdgesTraversed\<TNode\>\(this SpatialGraph\.Traversal\.GraphTraversal\<TNode\>, System\.Nullable\<uint\>\)') | Get the edges traversed\. |
| [ElementsOnTraversal&lt;TNode&gt;\(this GraphTraversal&lt;TNode&gt;, List&lt;uint&gt;, List&lt;uint&gt;\)](ElementsOnTraversal_TNode_(thisGraphTraversal_TNode_,List_uint_,List_uint_).md 'SpatialGraph\.Traversal\.PathfindingOperations\.ElementsOnTraversal\<TNode\>\(this SpatialGraph\.Traversal\.GraphTraversal\<TNode\>, System\.Collections\.Generic\.List\<uint\>, System\.Collections\.Generic\.List\<uint\>\)') | Get the elements traversed\. |
| [Floodfill&lt;TNode&gt;\(this GraphTraversal&lt;TNode&gt;, List&lt;uint&gt;, List&lt;uint&gt;\)](Floodfill_TNode_(thisGraphTraversal_TNode_,List_uint_,List_uint_).md 'SpatialGraph\.Traversal\.PathfindingOperations\.Floodfill\<TNode\>\(this SpatialGraph\.Traversal\.GraphTraversal\<TNode\>, System\.Collections\.Generic\.List\<uint\>, System\.Collections\.Generic\.List\<uint\>\)') | Get connected elements from the source node\. |
| [FloodfillEdges&lt;TNode&gt;\(this GraphTraversal&lt;TNode&gt;, Nullable&lt;uint&gt;\)](FloodfillEdges_TNode_(thisGraphTraversal_TNode_,Nullable_uint_).md 'SpatialGraph\.Traversal\.PathfindingOperations\.FloodfillEdges\<TNode\>\(this SpatialGraph\.Traversal\.GraphTraversal\<TNode\>, System\.Nullable\<uint\>\)') | Get all the connected edges from the source node\. |
| [FloodfillNodes&lt;TNode&gt;\(this GraphTraversal&lt;TNode&gt;, Nullable&lt;uint&gt;\)](FloodfillNodes_TNode_(thisGraphTraversal_TNode_,Nullable_uint_).md 'SpatialGraph\.Traversal\.PathfindingOperations\.FloodfillNodes\<TNode\>\(this SpatialGraph\.Traversal\.GraphTraversal\<TNode\>, System\.Nullable\<uint\>\)') | Get all the connected nodes connected from the source node\. |
| [IsNodeConnected&lt;TNode&gt;\(this GraphTraversal&lt;TNode&gt;\)](IsNodeConnected_TNode_(thisGraphTraversal_TNode_).md 'SpatialGraph\.Traversal\.PathfindingOperations\.IsNodeConnected\<TNode\>\(this SpatialGraph\.Traversal\.GraphTraversal\<TNode\>\)') | Check if two nodes were connected through edges\. |
| [Pathfind&lt;TNode&gt;\(this GraphTraversal&lt;TNode&gt;, Stack&lt;uint&gt;, Stack&lt;uint&gt;\)](Pathfind_TNode_(thisGraphTraversal_TNode_,Stack_uint_,Stack_uint_).md 'SpatialGraph\.Traversal\.PathfindingOperations\.Pathfind\<TNode\>\(this SpatialGraph\.Traversal\.GraphTraversal\<TNode\>, System\.Collections\.Generic\.Stack\<uint\>, System\.Collections\.Generic\.Stack\<uint\>\)') | Find path between two nodes\. |
| [PathfindEdges&lt;TNode&gt;\(this GraphTraversal&lt;TNode&gt;, Stack&lt;uint&gt;\)](PathfindEdges_TNode_(thisGraphTraversal_TNode_,Stack_uint_).md 'SpatialGraph\.Traversal\.PathfindingOperations\.PathfindEdges\<TNode\>\(this SpatialGraph\.Traversal\.GraphTraversal\<TNode\>, System\.Collections\.Generic\.Stack\<uint\>\)') | Find path between two nodes\. |
| [PathfindNodes&lt;TNode&gt;\(this GraphTraversal&lt;TNode&gt;, Stack&lt;uint&gt;\)](PathfindNodes_TNode_(thisGraphTraversal_TNode_,Stack_uint_).md 'SpatialGraph\.Traversal\.PathfindingOperations\.PathfindNodes\<TNode\>\(this SpatialGraph\.Traversal\.GraphTraversal\<TNode\>, System\.Collections\.Generic\.Stack\<uint\>\)') | Find path between two nodes\. |
