## Pathfinding\.WeightedTraversal\<TNode,TScore\>\(this NodeAdjacency\<TNode\>, Func\<NodeAdjacency\<TNode\>,uint,TScore\>, uint, Nullable\<uint\>\) Method

Pathfinding algorithm wherein each connected node to search from a node were weighted via a custom function\.
The highest scoring node will be traversed to, backtracking when theres no more unvisited node from a node\.

```csharp
public static SpatialGraph.Traversal.GraphTraversal<TNode> WeightedTraversal<TNode,TScore>(this SpatialGraph.Metadata.NodeAdjacency<TNode> baseGraph, System.Func<SpatialGraph.Metadata.NodeAdjacency<TNode>,uint,TScore> nodeScore, uint nodeIDStart, System.Nullable<uint> targetNodeID=null)
    where TNode : struct, SpatialGraph.INode
    where TScore : System.Numerics.INumber<TScore>;
```
#### Type parameters

<a name='SpatialGraph.Traversal.Pathfinding.WeightedTraversal_TNode,TScore_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,System.Func_SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,TScore_,uint,System.Nullable_uint_).TNode'></a>

`TNode`

Type of nodes used in the base graph\.

<a name='SpatialGraph.Traversal.Pathfinding.WeightedTraversal_TNode,TScore_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,System.Func_SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,TScore_,uint,System.Nullable_uint_).TScore'></a>

`TScore`

Type of INumber used for scoring\.
#### Parameters

<a name='SpatialGraph.Traversal.Pathfinding.WeightedTraversal_TNode,TScore_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,System.Func_SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,TScore_,uint,System.Nullable_uint_).baseGraph'></a>

`baseGraph` [SpatialGraph\.Metadata\.NodeAdjacency&lt;](SpatialGraph.Metadata.NodeAdjacency_TNode_.md 'SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>')[TNode](SpatialGraph.Traversal.Pathfinding.WeightedTraversal_TNode,TScore_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,System.Func_SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,TScore_,uint,System.Nullable_uint_).md#SpatialGraph.Traversal.Pathfinding.WeightedTraversal_TNode,TScore_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,System.Func_SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,TScore_,uint,System.Nullable_uint_).TNode 'SpatialGraph\.Traversal\.Pathfinding\.WeightedTraversal\<TNode,TScore\>\(this SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>, System\.Func\<SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>,uint,TScore\>, uint, System\.Nullable\<uint\>\)\.TNode')[&gt;](SpatialGraph.Metadata.NodeAdjacency_TNode_.md 'SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>')

Graph to perform the search\.

<a name='SpatialGraph.Traversal.Pathfinding.WeightedTraversal_TNode,TScore_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,System.Func_SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,TScore_,uint,System.Nullable_uint_).nodeScore'></a>

`nodeScore` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[SpatialGraph\.Metadata\.NodeAdjacency&lt;](SpatialGraph.Metadata.NodeAdjacency_TNode_.md 'SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>')[TNode](SpatialGraph.Traversal.Pathfinding.WeightedTraversal_TNode,TScore_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,System.Func_SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,TScore_,uint,System.Nullable_uint_).md#SpatialGraph.Traversal.Pathfinding.WeightedTraversal_TNode,TScore_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,System.Func_SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,TScore_,uint,System.Nullable_uint_).TNode 'SpatialGraph\.Traversal\.Pathfinding\.WeightedTraversal\<TNode,TScore\>\(this SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>, System\.Func\<SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>,uint,TScore\>, uint, System\.Nullable\<uint\>\)\.TNode')[&gt;](SpatialGraph.Metadata.NodeAdjacency_TNode_.md 'SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')[TScore](SpatialGraph.Traversal.Pathfinding.WeightedTraversal_TNode,TScore_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,System.Func_SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,TScore_,uint,System.Nullable_uint_).md#SpatialGraph.Traversal.Pathfinding.WeightedTraversal_TNode,TScore_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,System.Func_SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,TScore_,uint,System.Nullable_uint_).TScore 'SpatialGraph\.Traversal\.Pathfinding\.WeightedTraversal\<TNode,TScore\>\(this SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>, System\.Func\<SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>,uint,TScore\>, uint, System\.Nullable\<uint\>\)\.TScore')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-3 'System\.Func\`3')

Score of a connecting node from a node\.

<a name='SpatialGraph.Traversal.Pathfinding.WeightedTraversal_TNode,TScore_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,System.Func_SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,TScore_,uint,System.Nullable_uint_).nodeIDStart'></a>

`nodeIDStart` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to start the search\.

<a name='SpatialGraph.Traversal.Pathfinding.WeightedTraversal_TNode,TScore_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,System.Func_SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,TScore_,uint,System.Nullable_uint_).targetNodeID'></a>

`targetNodeID` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

ID of the node to search, if any\.

#### Returns
[SpatialGraph\.Traversal\.GraphTraversal&lt;](SpatialGraph.Traversal.GraphTraversal_TNode_.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>')[TNode](SpatialGraph.Traversal.Pathfinding.WeightedTraversal_TNode,TScore_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,System.Func_SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,TScore_,uint,System.Nullable_uint_).md#SpatialGraph.Traversal.Pathfinding.WeightedTraversal_TNode,TScore_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,System.Func_SpatialGraph.Metadata.NodeAdjacency_TNode_,uint,TScore_,uint,System.Nullable_uint_).TNode 'SpatialGraph\.Traversal\.Pathfinding\.WeightedTraversal\<TNode,TScore\>\(this SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>, System\.Func\<SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>,uint,TScore\>, uint, System\.Nullable\<uint\>\)\.TNode')[&gt;](SpatialGraph.Traversal.GraphTraversal_TNode_.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>')  
Graph traversal algorithm\.