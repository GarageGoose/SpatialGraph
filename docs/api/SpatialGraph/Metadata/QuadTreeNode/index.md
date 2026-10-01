## QuadTreeNode Class

Quadtree implementation for nodes in a graph\. Enables spatial indexing for nodes\.

```csharp
public class QuadTreeNode : SpatialGraph.Metadata.GraphReadOnlyPlugin<SpatialGraph.Node2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [SpatialGraph\.Metadata\.GraphReadOnlyPlugin&lt;](../GraphReadOnlyPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../GraphReadOnlyPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>') → QuadTreeNode

| Constructors | |
| :--- | :--- |
| [QuadTreeNode\(ITrackedGraph&lt;Node2D&gt;, int, Vector2, float, float\)](QuadTreeNode(ITrackedGraph_Node2D_,int,Vector2,float,float).md 'SpatialGraph\.Metadata\.QuadTreeNode\.QuadTreeNode\(SpatialGraph\.ITrackedGraph\<SpatialGraph\.Node2D\>, int, System\.Numerics\.Vector2, float, float\)') | New instance of a node quad tree\. |

| Methods | |
| :--- | :--- |
| [ParentCell\(\)](ParentCell().md 'SpatialGraph\.Metadata\.QuadTreeNode\.ParentCell\(\)') | Parent cell of the quadtree\. |
