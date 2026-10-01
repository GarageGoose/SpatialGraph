## NodeAdjacency\<TNode\> Class

Records adjecent nodes and edges from a node in a graph\.

```csharp
public class NodeAdjacency<TNode> : SpatialGraph.Metadata.GraphReadOnlyPlugin<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.Metadata.NodeAdjacency_TNode_.TNode'></a>

`TNode`

Node which the base class uses\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [SpatialGraph\.Metadata\.GraphReadOnlyPlugin&lt;](../GraphReadOnlyPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>')[TNode](index.md#SpatialGraph.Metadata.NodeAdjacency_TNode_.TNode 'SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>\.TNode')[&gt;](../GraphReadOnlyPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>') → NodeAdjacency\<TNode\>

| Constructors | |
| :--- | :--- |
| [NodeAdjacency\(IReadOnlyTrackedGraph&lt;TNode&gt;\)](NodeAdjacency(IReadOnlyTrackedGraph_TNode_).md 'SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>\.NodeAdjacency\(SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>\)') | Creates a new instance of NodeAdjacency\. |

| Methods | |
| :--- | :--- |
| [ConnectedEdges\(uint\)](ConnectedEdges(uint).md 'SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>\.ConnectedEdges\(uint\)') | Get connecting edges from a node\. |
| [ConnectedEdgesCount\(uint\)](ConnectedEdgesCount(uint).md 'SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>\.ConnectedEdgesCount\(uint\)') | Get the amount of edges connected in a node\. |
| [ConnectedNodes\(uint\)](ConnectedNodes(uint).md 'SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>\.ConnectedNodes\(uint\)') | Get connected nodes from a node\. |
| [OnGraphUpdate\(object, IReadOnlyModificationLog&lt;TNode&gt;\)](OnGraphUpdate(object,IReadOnlyModificationLog_TNode_).md 'SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>\.OnGraphUpdate\(object, SpatialGraph\.IReadOnlyModificationLog\<TNode\>\)') | Emits when a modification occurs in the base graph\. |
