## BasicGraphOperations\.ReplaceLocationOfNode Method

| Overloads | |
| :--- | :--- |
| [ReplaceLocationOfNode(this IGraph&lt;Node2D&gt;, uint, Vector2)](ReplaceLocationOfNode.md#SpatialGraph.Extensions.BasicGraphOperations.ReplaceLocationOfNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,System.Numerics.Vector2) 'SpatialGraph\.Extensions\.BasicGraphOperations\.ReplaceLocationOfNode(this SpatialGraph\.IGraph<SpatialGraph\.Node2D>, uint, System\.Numerics\.Vector2)') | Replace the location of a [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') in a [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |
| [ReplaceLocationOfNode(this IGraph&lt;Node3D&gt;, uint, Vector3)](ReplaceLocationOfNode.md#SpatialGraph.Extensions.BasicGraphOperations.ReplaceLocationOfNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,System.Numerics.Vector3) 'SpatialGraph\.Extensions\.BasicGraphOperations\.ReplaceLocationOfNode(this SpatialGraph\.IGraph<SpatialGraph\.Node3D>, uint, System\.Numerics\.Vector3)') | Replace the location of a [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') in a [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceLocationOfNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,System.Numerics.Vector2)'></a>

## BasicGraphOperations\.ReplaceLocationOfNode(this IGraph<Node2D>, uint, Vector2) Method

Replace the location of a [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') in a [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\.

```csharp
public static void ReplaceLocationOfNode(this SpatialGraph.IGraph<SpatialGraph.Node2D> graph, uint NodeID, System.Numerics.Vector2 NewLoc);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceLocationOfNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,System.Numerics.Vector2).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

[IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') with the [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') to replace its location\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceLocationOfNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,System.Numerics.Vector2).NodeID'></a>

`NodeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') to replace its location\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceLocationOfNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,System.Numerics.Vector2).NewLoc'></a>

`NewLoc` [System\.Numerics\.Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2 'System\.Numerics\.Vector2')

New location of the [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceLocationOfNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,System.Numerics.Vector3)'></a>

## BasicGraphOperations\.ReplaceLocationOfNode(this IGraph<Node3D>, uint, Vector3) Method

Replace the location of a [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') in a [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\.

```csharp
public static void ReplaceLocationOfNode(this SpatialGraph.IGraph<SpatialGraph.Node3D> graph, uint NodeID, System.Numerics.Vector3 NewLoc);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceLocationOfNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,System.Numerics.Vector3).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

[IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') with the [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') to replace its location\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceLocationOfNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,System.Numerics.Vector3).NodeID'></a>

`NodeID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') to replace its location\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.ReplaceLocationOfNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,System.Numerics.Vector3).NewLoc'></a>

`NewLoc` [System\.Numerics\.Vector3](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector3 'System\.Numerics\.Vector3')

New location of the [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')\.