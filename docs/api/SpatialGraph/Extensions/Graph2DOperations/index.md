## Graph2DOperations Class

Operations for basic modifications of [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')s\.

```csharp
public static class Graph2DOperations
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Graph2DOperations

| Methods | |
| :--- | :--- |
| [CollapseNode(this IGraph&lt;Node2D&gt;, NodeAdjacency&lt;Node2D&gt;, uint\[\])](CollapseNode(thisIGraph_Node2D_,NodeAdjacency_Node2D_,uint[]).md 'SpatialGraph\.Extensions\.Graph2DOperations\.CollapseNode(this SpatialGraph\.IGraph<SpatialGraph\.Node2D>, SpatialGraph\.Metadata\.NodeAdjacency<SpatialGraph\.Node2D>, uint\[\])') | Combine multiple [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')s into a single one\. |
| [CopyElementsToGraph(this IGraph&lt;Node2D&gt;, IEnumerable&lt;ElementID&gt;, IGraph&lt;Node2D&gt;, bool)](CopyElementsToGraph(thisIGraph_Node2D_,IEnumerable_ElementID_,IGraph_Node2D_,bool).md 'SpatialGraph\.Extensions\.Graph2DOperations\.CopyElementsToGraph(this SpatialGraph\.IGraph<SpatialGraph\.Node2D>, System\.Collections\.Generic\.IEnumerable<SpatialGraph\.ElementID>, SpatialGraph\.IGraph<SpatialGraph\.Node2D>, bool)') | Copy specified elements from one [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') to another\. |
| [CopyGraph(this IGraph&lt;Node2D&gt;, IGraph&lt;Node2D&gt;, bool)](CopyGraph(thisIGraph_Node2D_,IGraph_Node2D_,bool).md 'SpatialGraph\.Extensions\.Graph2DOperations\.CopyGraph(this SpatialGraph\.IGraph<SpatialGraph\.Node2D>, SpatialGraph\.IGraph<SpatialGraph\.Node2D>, bool)') | Copy entire [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') to another [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |
| [InsertNode(this IGraph&lt;Node2D&gt;, uint, Node2D)](InsertNode(thisIGraph_Node2D_,uint,Node2D).md 'SpatialGraph\.Extensions\.Graph2DOperations\.InsertNode(this SpatialGraph\.IGraph<SpatialGraph\.Node2D>, uint, SpatialGraph\.Node2D)') | Insert a new [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') in between an [Edge](../../Edge/index.md 'SpatialGraph\.Edge')\. |
