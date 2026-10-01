## IReadOnlyQuadTreeNodeCell Interface

A specific region in a quadtree which holds nodes or if subdivided,
four sub quad trees each on the of the quadrant of the quadtree\.

```csharp
public interface IReadOnlyQuadTreeNodeCell
```

| Properties | |
| :--- | :--- |
| [CellCapacity](SpatialGraph.IReadOnlyQuadTreeNodeCell.CellCapacity.md 'SpatialGraph\.IReadOnlyQuadTreeNodeCell\.CellCapacity') | Maximum amount of nodes allowed in this cell before being subdivied\. |
| [Center](SpatialGraph.IReadOnlyQuadTreeNodeCell.Center.md 'SpatialGraph\.IReadOnlyQuadTreeNodeCell\.Center') | Center point of the cell\. |
| [East](SpatialGraph.IReadOnlyQuadTreeNodeCell.East.md 'SpatialGraph\.IReadOnlyQuadTreeNodeCell\.East') | Rightmost border of the cell\. |
| [Height](SpatialGraph.IReadOnlyQuadTreeNodeCell.Height.md 'SpatialGraph\.IReadOnlyQuadTreeNodeCell\.Height') | Height of the cell\. |
| [Nodes](SpatialGraph.IReadOnlyQuadTreeNodeCell.Nodes.md 'SpatialGraph\.IReadOnlyQuadTreeNodeCell\.Nodes') | Nodes stored in this cell\. Set is empty if the cell is subdivided\. |
| [North](SpatialGraph.IReadOnlyQuadTreeNodeCell.North.md 'SpatialGraph\.IReadOnlyQuadTreeNodeCell\.North') | Upper border of the cell\. |
| [South](SpatialGraph.IReadOnlyQuadTreeNodeCell.South.md 'SpatialGraph\.IReadOnlyQuadTreeNodeCell\.South') | Lower border of the cell\. |
| [Subdivided](SpatialGraph.IReadOnlyQuadTreeNodeCell.Subdivided.md 'SpatialGraph\.IReadOnlyQuadTreeNodeCell\.Subdivided') | Indicated if a cell is subdivided\. Subdivided cells contains four child cells on each of its quadrant\. Else it contains nodes in it\. |
| [West](SpatialGraph.IReadOnlyQuadTreeNodeCell.West.md 'SpatialGraph\.IReadOnlyQuadTreeNodeCell\.West') | Leftmost border of the cell\. |
| [Width](SpatialGraph.IReadOnlyQuadTreeNodeCell.Width.md 'SpatialGraph\.IReadOnlyQuadTreeNodeCell\.Width') | Width of the cell\. |

| Methods | |
| :--- | :--- |
| [LowerLeft\(\)](SpatialGraph.IReadOnlyQuadTreeNodeCell.LowerLeft().md 'SpatialGraph\.IReadOnlyQuadTreeNodeCell\.LowerLeft\(\)') | Lower left \(Southwest\) quadrant of the cell\. |
| [LowerRight\(\)](SpatialGraph.IReadOnlyQuadTreeNodeCell.LowerRight().md 'SpatialGraph\.IReadOnlyQuadTreeNodeCell\.LowerRight\(\)') | Lower right \(Southeast\) quadrant of the cell\. |
| [ParentCell\(\)](SpatialGraph.IReadOnlyQuadTreeNodeCell.ParentCell().md 'SpatialGraph\.IReadOnlyQuadTreeNodeCell\.ParentCell\(\)') | Upper left \(Northwest\) quadrant of the cell\. |
| [UpperLeft\(\)](SpatialGraph.IReadOnlyQuadTreeNodeCell.UpperLeft().md 'SpatialGraph\.IReadOnlyQuadTreeNodeCell\.UpperLeft\(\)') | Upper left \(Northwest\) quadrant of the cell\. |
| [UpperRight\(\)](SpatialGraph.IReadOnlyQuadTreeNodeCell.UpperRight().md 'SpatialGraph\.IReadOnlyQuadTreeNodeCell\.UpperRight\(\)') | Upper right \(Northeast\) quadrant of the cell\. |
