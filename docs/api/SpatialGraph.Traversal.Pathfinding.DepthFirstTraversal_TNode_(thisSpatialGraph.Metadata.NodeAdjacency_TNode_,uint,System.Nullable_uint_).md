## Pathfinding\.DepthFirstTraversal\<TNode\>\(this NodeAdjacency\<TNode\>, uint, Nullable\<uint\>\) Method

Pathfinding algorithm wherein it explores a branch as deep as it can before backtracking\.

```csharp
public static SpatialGraph.Traversal.GraphTraversal<TNode> DepthFirstTraversal<TNode>(this SpatialGraph.Metadata.NodeAdjacency<TNode> baseGraph, uint nodeIDStart, System.Nullable<uint> targetNodeID=null)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Traversal.Pathfinding.DepthFirstTraversal_TNode_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).TNode'></a>

`TNode`

Type of nodes used in the base graph\.
#### Parameters

<a name='SpatialGraph.Traversal.Pathfinding.DepthFirstTraversal_TNode_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).baseGraph'></a>

`baseGraph` [SpatialGraph\.Metadata\.NodeAdjacency&lt;](SpatialGraph.Metadata.NodeAdjacency_TNode_.md 'SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>')[TNode](SpatialGraph.Traversal.Pathfinding.DepthFirstTraversal_TNode_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).md#SpatialGraph.Traversal.Pathfinding.DepthFirstTraversal_TNode_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).TNode 'SpatialGraph\.Traversal\.Pathfinding\.DepthFirstTraversal\<TNode\>\(this SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>, uint, System\.Nullable\<uint\>\)\.TNode')[&gt;](SpatialGraph.Metadata.NodeAdjacency_TNode_.md 'SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>')

Graph to perform the search\.

<a name='SpatialGraph.Traversal.Pathfinding.DepthFirstTraversal_TNode_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).nodeIDStart'></a>

`nodeIDStart` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to start the search\.

<a name='SpatialGraph.Traversal.Pathfinding.DepthFirstTraversal_TNode_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).targetNodeID'></a>

`targetNodeID` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

ID of the node to search, if any\.

#### Returns
[SpatialGraph\.Traversal\.GraphTraversal&lt;](SpatialGraph.Traversal.GraphTraversal_TNode_.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>')[TNode](SpatialGraph.Traversal.Pathfinding.DepthFirstTraversal_TNode_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).md#SpatialGraph.Traversal.Pathfinding.DepthFirstTraversal_TNode_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).TNode 'SpatialGraph\.Traversal\.Pathfinding\.DepthFirstTraversal\<TNode\>\(this SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>, uint, System\.Nullable\<uint\>\)\.TNode')[&gt;](SpatialGraph.Traversal.GraphTraversal_TNode_.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>')  
Graph traversal algorithm\.