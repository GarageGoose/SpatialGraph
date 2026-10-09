## QuadTreeNode Class

Quadtree implementation for nodes in a graph\. Enables spatial indexing for nodes\.

```csharp
public class QuadTreeNode : SpatialGraph.Metadata.GraphReadOnlyPlugin<SpatialGraph.Node2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [SpatialGraph\.Metadata\.GraphReadOnlyPlugin&lt;](../GraphReadOnlyPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../GraphReadOnlyPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>') → QuadTreeNode

### See Also
- [QuadTreeNodeOperations](../QuadTreeNodeOperations/index.md 'SpatialGraph\.Metadata\.QuadTreeNodeOperations')

| Constructors | |
| :--- | :--- |
| [QuadTreeNode(IObservableGraph&lt;Node2D&gt;, int, Vector2, float, float, bool, int)](QuadTreeNode(IObservableGraph_Node2D_,int,Vector2,float,float,bool,int).md 'SpatialGraph\.Metadata\.QuadTreeNode\.QuadTreeNode(SpatialGraph\.IObservableGraph<SpatialGraph\.Node2D>, int, System\.Numerics\.Vector2, float, float, bool, int)') | New instance of a node quad tree\. |

| Fields | |
| :--- | :--- |
| [MaxDepth](MaxDepth.md 'SpatialGraph\.Metadata\.QuadTreeNode\.MaxDepth') | Maximum amount the cell is allowed to subdivide relative to the original depth\. Does not affect creating new parent cells when enlarging the quadtree\. |

| Methods | |
| :--- | :--- |
| [CurrentCellOfNode(uint)](CurrentCellOfNode(uint).md 'SpatialGraph\.Metadata\.QuadTreeNode\.CurrentCellOfNode(uint)') | Get the cell of a node\. |
| [ParentCell()](ParentCell().md 'SpatialGraph\.Metadata\.QuadTreeNode\.ParentCell()') | Parent cell of the quadtree\. |
