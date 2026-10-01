## Pathfinding Class

Pathfinding algorithims for graphs\.

```csharp
public static class Pathfinding
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Pathfinding

| Methods | |
| :--- | :--- |
| [BreadthFirstTraversal&lt;TNode&gt;\(this NodeAdjacency&lt;TNode&gt;, uint, Nullable&lt;uint&gt;\)](SpatialGraph.Traversal.Pathfinding.BreadthFirstTraversal_TNode_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).md 'SpatialGraph\.Traversal\.Pathfinding\.BreadthFirstTraversal\<TNode\>\(this SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>, uint, System\.Nullable\<uint\>\)') | Pathfinding algorithm wherein all edges at a node are explored first before proceding to the next node\. |
| [DepthFirstTraversal&lt;TNode&gt;\(this NodeAdjacency&lt;TNode&gt;, uint, Nullable&lt;uint&gt;\)](SpatialGraph.Traversal.Pathfinding.DepthFirstTraversal_TNode_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).md 'SpatialGraph\.Traversal\.Pathfinding\.DepthFirstTraversal\<TNode\>\(this SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>, uint, System\.Nullable\<uint\>\)') | Pathfinding algorithm wherein it explores a branch as deep as it can before backtracking\. |
| [WeightedTraversal&lt;TNode,TScore&gt;\(this NodeAdjacency&lt;TNode&gt;, Func&lt;NodeAdjacency&lt;TNode&gt;,uint,TScore&gt;, uint, Nullable&lt;uint&gt;\)](SpatialGraph.Traversal.Pathfinding.WeightedTraversal_TNode,TScore_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,System.Func_SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,TScore_,uint,System.Nullable_uint_).md 'SpatialGraph\.Traversal\.Pathfinding\.WeightedTraversal\<TNode,TScore\>\(this SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>, System\.Func\<SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>,uint,TScore\>, uint, System\.Nullable\<uint\>\)') | Pathfinding algorithm wherein each connected node to search from a node were weighted via a custom function\. The highest scoring node will be traversed to, backtracking when theres no more unvisited node from a node\. |
