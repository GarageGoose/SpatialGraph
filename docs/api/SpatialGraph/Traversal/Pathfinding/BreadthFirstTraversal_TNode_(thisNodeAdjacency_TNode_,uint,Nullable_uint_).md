## Pathfinding\.BreadthFirstTraversal\<TNode\>\(this NodeAdjacency\<TNode\>, uint, Nullable\<uint\>\) Method

Pathfinding algorithm wherein all edges at a node are explored first before proceding to the next node\.

```csharp
public static SpatialGraph.Traversal.GraphTraversal<TNode> BreadthFirstTraversal<TNode>(this SpatialGraph.Metadata.NodeAdjacency<TNode> baseGraph, uint nodeIDStart, System.Nullable<uint> targetNodeID=null)
    where TNode : struct, SpatialGraph.INode;
```
#### Type parameters

<a name='SpatialGraph.Traversal.Pathfinding.BreadthFirstTraversal_TNode_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).TNode'></a>

`TNode`

Type of nodes used in the base graph\.
#### Parameters

<a name='SpatialGraph.Traversal.Pathfinding.BreadthFirstTraversal_TNode_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).baseGraph'></a>

`baseGraph` [SpatialGraph\.Metadata\.NodeAdjacency&lt;](../../Metadata/NodeAdjacency_TNode_/index.md 'SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>')[TNode](BreadthFirstTraversal_TNode_(thisNodeAdjacency_TNode_,uint,Nullable_uint_).md#SpatialGraph.Traversal.Pathfinding.BreadthFirstTraversal_TNode_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).TNode 'SpatialGraph\.Traversal\.Pathfinding\.BreadthFirstTraversal\<TNode\>\(this SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>, uint, System\.Nullable\<uint\>\)\.TNode')[&gt;](../../Metadata/NodeAdjacency_TNode_/index.md 'SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>')

Graph to perform the search\.

<a name='SpatialGraph.Traversal.Pathfinding.BreadthFirstTraversal_TNode_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).nodeIDStart'></a>

`nodeIDStart` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to start the search\.

<a name='SpatialGraph.Traversal.Pathfinding.BreadthFirstTraversal_TNode_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).targetNodeID'></a>

`targetNodeID` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

ID of the node to search, if any\.

#### Returns
[SpatialGraph\.Traversal\.GraphTraversal&lt;](../GraphTraversal_TNode_/index.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>')[TNode](BreadthFirstTraversal_TNode_(thisNodeAdjacency_TNode_,uint,Nullable_uint_).md#SpatialGraph.Traversal.Pathfinding.BreadthFirstTraversal_TNode_(thisSpatialGraph.Metadata.NodeAdjacency_TNode_,uint,System.Nullable_uint_).TNode 'SpatialGraph\.Traversal\.Pathfinding\.BreadthFirstTraversal\<TNode\>\(this SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>, uint, System\.Nullable\<uint\>\)\.TNode')[&gt;](../GraphTraversal_TNode_/index.md 'SpatialGraph\.Traversal\.GraphTraversal\<TNode\>')  
Graph traversal algorithm\.