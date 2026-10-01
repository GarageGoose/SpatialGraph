## Graph\<TNode\> Class

Base class for graphs, can be built upon\.

```csharp
public class Graph<TNode> : SpatialGraph.IGraph<TNode>, SpatialGraph.IReadOnlyGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.Graph_TNode_.TNode'></a>

`TNode`

Type of node to be used in the graph\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Graph\<TNode\>

Derived  
↳ [InterceptableTrackedGraph&lt;TNode&gt;](SpatialGraph.InterceptableTrackedGraph_TNode_.md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>')  
↳ [TrackedGraph&lt;TNode&gt;](SpatialGraph.TrackedGraph_TNode_.md 'SpatialGraph\.TrackedGraph\<TNode\>')

Implements [SpatialGraph\.IGraph&lt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')[TNode](SpatialGraph.Graph_TNode_.md#SpatialGraph.Graph_TNode_.TNode 'SpatialGraph\.Graph\<TNode\>\.TNode')[&gt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>'), [SpatialGraph\.IReadOnlyGraph&lt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](SpatialGraph.Graph_TNode_.md#SpatialGraph.Graph_TNode_.TNode 'SpatialGraph\.Graph\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')

| Constructors | |
| :--- | :--- |
| [Graph\(\)](SpatialGraph.Graph_TNode_.#ctor.md#SpatialGraph.Graph_TNode_.Graph() 'SpatialGraph\.Graph\<TNode\>\.Graph\(\)') | Start an empty graph\. |
| [Graph\(IReadOnlyGraph&lt;TNode&gt;\)](SpatialGraph.Graph_TNode_.#ctor.md#SpatialGraph.Graph_TNode_.Graph(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.Graph\<TNode\>\.Graph\(SpatialGraph\.IReadOnlyGraph\<TNode\>\)') | Start graph from a pre\-exisitng graph\. |
| [Graph\(Dictionary&lt;uint,TNode&gt;, Dictionary&lt;uint,Edge&gt;\)](SpatialGraph.Graph_TNode_.#ctor.md#SpatialGraph.Graph_TNode_.Graph(System.Collections.Generic.Dictionary_uint,TNode_,System.Collections.Generic.Dictionary_uint,SpatialGraph.Edge_) 'SpatialGraph\.Graph\<TNode\>\.Graph\(System\.Collections\.Generic\.Dictionary\<uint,TNode\>, System\.Collections\.Generic\.Dictionary\<uint,SpatialGraph\.Edge\>\)') | Start a graph from pre\-exisiting dictionaries of nodes and edges\. |
