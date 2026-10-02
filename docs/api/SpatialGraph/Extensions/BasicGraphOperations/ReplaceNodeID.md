## BasicGraphOperations\.ReplaceNodeID Method

| Overloads | |
| :--- | :--- |
| [ReplaceNodeID(this IGraph&lt;Node2D&gt;, uint, uint)](ReplaceNodeID.md#SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodeID(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,uint) 'SpatialGraph\.Extensions\.BasicGraphOperations\.ReplaceNodeID(this SpatialGraph\.IGraph<SpatialGraph\.Node2D>, uint, uint)') | Replace the ID of a [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') with a new ID\. Existing [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') with the same ID as the new ID will be replaced\. |
| [ReplaceNodeID(this IGraph&lt;Node3D&gt;, uint, uint)](ReplaceNodeID.md#SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodeID(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,uint) 'SpatialGraph\.Extensions\.BasicGraphOperations\.ReplaceNodeID(this SpatialGraph\.IGraph<SpatialGraph\.Node3D>, uint, uint)') | Replace the ID of a [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') with a new ID\. Existing [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') with the same ID as the new ID will be replaced\. |

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodeID(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,uint)'></a>

## BasicGraphOperations\.ReplaceNodeID(this IGraph<Node2D>, uint, uint) Method

Replace the ID of a [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') with a new ID\. Existing [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') with the same ID as the new ID will be replaced\.

```csharp
public static void ReplaceNodeID(this SpatialGraph.IGraph<SpatialGraph.Node2D> graph, uint NodeID, uint NewNodeID);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodeID(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,uint).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

[IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') where to replace a [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') ID\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodeID(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,uint).NodeID'></a>

`NodeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

Current ID of the [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') to be replaced with a new ID\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodeID(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,uint).NewNodeID'></a>

`NewNodeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

New ID of the [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodeID(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,uint)'></a>

## BasicGraphOperations\.ReplaceNodeID(this IGraph<Node3D>, uint, uint) Method

Replace the ID of a [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') with a new ID\. Existing [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') with the same ID as the new ID will be replaced\.

```csharp
public static void ReplaceNodeID(this SpatialGraph.IGraph<SpatialGraph.Node3D> graph, uint NodeID, uint NewNodeID);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodeID(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,uint).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

[IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') where to replace a [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') ID\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodeID(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,uint).NodeID'></a>

`NodeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

Current ID of the [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') to be replaced with a new ID\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceNodeID(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,uint).NewNodeID'></a>

`NewNodeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

New ID of the [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')\.