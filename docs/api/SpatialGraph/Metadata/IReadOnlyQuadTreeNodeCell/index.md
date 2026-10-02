## IReadOnlyQuadTreeNodeCell Interface

A specific region in a quadtree which holds nodes or if subdivided,
four sub quad trees each on the of the quadrant of the quadtree\.

```csharp
public interface IReadOnlyQuadTreeNodeCell
```

| Properties | |
| :--- | :--- |
| [CellCapacity](CellCapacity.md 'SpatialGraph\.Metadata\.IReadOnlyQuadTreeNodeCell\.CellCapacity') | Maximum amount of nodes allowed in this cell before being subdivied\. |
| [Center](Center.md 'SpatialGraph\.Metadata\.IReadOnlyQuadTreeNodeCell\.Center') | Center point of the cell\. |
| [East](East.md 'SpatialGraph\.Metadata\.IReadOnlyQuadTreeNodeCell\.East') | Rightmost border of the cell\. |
| [Height](Height.md 'SpatialGraph\.Metadata\.IReadOnlyQuadTreeNodeCell\.Height') | Height of the cell\. |
| [Nodes](Nodes.md 'SpatialGraph\.Metadata\.IReadOnlyQuadTreeNodeCell\.Nodes') | Nodes stored in this cell\. Set is empty if the cell is subdivided\. |
| [North](North.md 'SpatialGraph\.Metadata\.IReadOnlyQuadTreeNodeCell\.North') | Upper border of the cell\. |
| [South](South.md 'SpatialGraph\.Metadata\.IReadOnlyQuadTreeNodeCell\.South') | Lower border of the cell\. |
| [Subdivided](Subdivided.md 'SpatialGraph\.Metadata\.IReadOnlyQuadTreeNodeCell\.Subdivided') | Indicated if a cell is subdivided\. Subdivided cells contains four child cells on each of its quadrant\. Else it contains nodes in it\. |
| [West](West.md 'SpatialGraph\.Metadata\.IReadOnlyQuadTreeNodeCell\.West') | Leftmost border of the cell\. |
| [Width](Width.md 'SpatialGraph\.Metadata\.IReadOnlyQuadTreeNodeCell\.Width') | Width of the cell\. |

| Methods | |
| :--- | :--- |
| [LowerLeft()](LowerLeft().md 'SpatialGraph\.Metadata\.IReadOnlyQuadTreeNodeCell\.LowerLeft()') | Lower left (Southwest) quadrant of the cell\. |
| [LowerRight()](LowerRight().md 'SpatialGraph\.Metadata\.IReadOnlyQuadTreeNodeCell\.LowerRight()') | Lower right (Southeast) quadrant of the cell\. |
| [ParentCell()](ParentCell().md 'SpatialGraph\.Metadata\.IReadOnlyQuadTreeNodeCell\.ParentCell()') | Upper left (Northwest) quadrant of the cell\. |
| [UpperLeft()](UpperLeft().md 'SpatialGraph\.Metadata\.IReadOnlyQuadTreeNodeCell\.UpperLeft()') | Upper left (Northwest) quadrant of the cell\. |
| [UpperRight()](UpperRight().md 'SpatialGraph\.Metadata\.IReadOnlyQuadTreeNodeCell\.UpperRight()') | Upper right (Northeast) quadrant of the cell\. |
