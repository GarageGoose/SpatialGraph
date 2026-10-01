## QuadTreeNode Class

Quadtree implementation for nodes in a graph\. Enables spatial indexing for nodes\.

```csharp
public class QuadTreeNode : SpatialGraph.Metadata.GraphReadOnlyPlugin<SpatialGraph.Node2D>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [SpatialGraph\.Metadata\.GraphReadOnlyPlugin&lt;](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>')[Node2D](SpatialGraph.Node2D.md 'SpatialGraph\.Node2D')[&gt;](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>') → QuadTreeNode

| Constructors | |
| :--- | :--- |
| [QuadTreeNode\(ITrackedGraph&lt;Node2D&gt;, int, Vector2, float, float\)](SpatialGraph.Metadata.QuadTreeNode.QuadTreeNode(SpatialGraph.ITrackedGraph_SpatialGraph.Node2D_,int,System.Numerics.Vector2,float,float).md 'SpatialGraph\.Metadata\.QuadTreeNode\.QuadTreeNode\(SpatialGraph\.ITrackedGraph\<SpatialGraph\.Node2D\>, int, System\.Numerics\.Vector2, float, float\)') | New instance of a node quad tree\. |

| Methods | |
| :--- | :--- |
| [ParentCell\(\)](SpatialGraph.Metadata.QuadTreeNode.ParentCell().md 'SpatialGraph\.Metadata\.QuadTreeNode\.ParentCell\(\)') | Parent cell of the quadtree\. |
