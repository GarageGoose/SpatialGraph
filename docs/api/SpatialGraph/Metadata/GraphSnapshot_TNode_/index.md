## GraphSnapshot<TNode> Struct

Reconstructed graph from a specific modification step\. Used in GraphHistory\.

```csharp
public readonly record struct GraphSnapshot<TNode> : System.IEquatable<SpatialGraph.Metadata.GraphSnapshot<TNode>>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.Metadata.GraphSnapshot_TNode_.TNode'></a>

`TNode`

Type of node used in the graph\.

Implements [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[SpatialGraph\.Metadata\.GraphSnapshot&lt;](index.md 'SpatialGraph\.Metadata\.GraphSnapshot<TNode>')[TNode](index.md#SpatialGraph.Metadata.GraphSnapshot_TNode_.TNode 'SpatialGraph\.Metadata\.GraphSnapshot<TNode>\.TNode')[&gt;](index.md 'SpatialGraph\.Metadata\.GraphSnapshot<TNode>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [GraphSnapshot(int, Graph&lt;TNode&gt;)](GraphSnapshot(int,Graph_TNode_).md 'SpatialGraph\.Metadata\.GraphSnapshot<TNode>\.GraphSnapshot(int, SpatialGraph\.Graph<TNode>)') | Reconstructed graph from a specific modification step\. Used in GraphHistory\. |

| Properties | |
| :--- | :--- |
| [ModStep](ModStep.md 'SpatialGraph\.Metadata\.GraphSnapshot<TNode>\.ModStep') | Modification step which this graph is recreated from\. |
| [Snapshot](Snapshot.md 'SpatialGraph\.Metadata\.GraphSnapshot<TNode>\.Snapshot') | Reconstructed graph\. |
