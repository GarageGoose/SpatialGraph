## GraphTraversal(IEnumerable<TraversalInfo<TNode>>, NodeAdjacency<TNode>, uint, Nullable<uint>) Constructor

Graph traversal algorithms\.

```csharp
public GraphTraversal(System.Collections.Generic.IEnumerable<SpatialGraph.Traversal.TraversalInfo<TNode>> Traverse, SpatialGraph.Metadata.NodeAdjacency<TNode> BaseGraph, uint StartingNodeID, System.Nullable<uint> TagretNodeID);
```
#### Parameters

<a name='SpatialGraph.Traversal.GraphTraversal_TNode_.GraphTraversal(System.Collections.Generic.IEnumerable_SpatialGraph.Traversal.TraversalInfo_TNode__,SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).Traverse'></a>

`Traverse` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[SpatialGraph\.Traversal\.TraversalInfo&lt;](../TraversalInfo_TNode_/index.md 'SpatialGraph\.Traversal\.TraversalInfo<TNode>')[TNode](index.md#SpatialGraph.Traversal.GraphTraversal_TNode_.TNode 'SpatialGraph\.Traversal\.GraphTraversal<TNode>\.TNode')[&gt;](../TraversalInfo_TNode_/index.md 'SpatialGraph\.Traversal\.TraversalInfo<TNode>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Traverse the graph\.

<a name='SpatialGraph.Traversal.GraphTraversal_TNode_.GraphTraversal(System.Collections.Generic.IEnumerable_SpatialGraph.Traversal.TraversalInfo_TNode__,SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).BaseGraph'></a>

`BaseGraph` [SpatialGraph\.Metadata\.NodeAdjacency&lt;](../../Metadata/NodeAdjacency_TNode_/index.md 'SpatialGraph\.Metadata\.NodeAdjacency<TNode>')[TNode](index.md#SpatialGraph.Traversal.GraphTraversal_TNode_.TNode 'SpatialGraph\.Traversal\.GraphTraversal<TNode>\.TNode')[&gt;](../../Metadata/NodeAdjacency_TNode_/index.md 'SpatialGraph\.Metadata\.NodeAdjacency<TNode>')

Graph to traverse\.

<a name='SpatialGraph.Traversal.GraphTraversal_TNode_.GraphTraversal(System.Collections.Generic.IEnumerable_SpatialGraph.Traversal.TraversalInfo_TNode__,SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).StartingNodeID'></a>

`StartingNodeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

Node to start traversal\.

<a name='SpatialGraph.Traversal.GraphTraversal_TNode_.GraphTraversal(System.Collections.Generic.IEnumerable_SpatialGraph.Traversal.TraversalInfo_TNode__,SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).TagretNodeID'></a>

`TagretNodeID` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

Node to find when travering\.