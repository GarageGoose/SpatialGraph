## BasicGraphOperations\.AddNode Method

| Overloads | |
| :--- | :--- |
| [AddNode(this IGraph&lt;Node2D&gt;, float, float)](AddNode.md#SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,float,float) 'SpatialGraph\.Extensions\.BasicGraphOperations\.AddNode(this SpatialGraph\.IGraph<SpatialGraph\.Node2D>, float, float)') | Add a [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') in a 2D [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |
| [AddNode(this IGraph&lt;Node2D&gt;, Vector2)](AddNode.md#SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,System.Numerics.Vector2) 'SpatialGraph\.Extensions\.BasicGraphOperations\.AddNode(this SpatialGraph\.IGraph<SpatialGraph\.Node2D>, System\.Numerics\.Vector2)') | Add a [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') in a 2D [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |
| [AddNode(this IGraph&lt;Node3D&gt;, float, float, float)](AddNode.md#SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,float,float,float) 'SpatialGraph\.Extensions\.BasicGraphOperations\.AddNode(this SpatialGraph\.IGraph<SpatialGraph\.Node3D>, float, float, float)') | Add a [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') in a 3D [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |
| [AddNode(this IGraph&lt;Node3D&gt;, Vector3)](AddNode.md#SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,System.Numerics.Vector3) 'SpatialGraph\.Extensions\.BasicGraphOperations\.AddNode(this SpatialGraph\.IGraph<SpatialGraph\.Node3D>, System\.Numerics\.Vector3)') | Add a [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') in a 3D [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,float,float)'></a>

## BasicGraphOperations\.AddNode(this IGraph<Node2D>, float, float) Method

Add a [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') in a 2D [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\.

```csharp
public static uint AddNode(this SpatialGraph.IGraph<SpatialGraph.Node2D> graph, float X, float Y);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,float,float).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

[IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') to add a [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,float,float).X'></a>

`X` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

X position of the [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,float,float).Y'></a>

`Y` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Y position of the [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')\.

#### Returns
[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')  
ID of the new node\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,System.Numerics.Vector2)'></a>

## BasicGraphOperations\.AddNode(this IGraph<Node2D>, Vector2) Method

Add a [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') in a 2D [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\.

```csharp
public static uint AddNode(this SpatialGraph.IGraph<SpatialGraph.Node2D> graph, System.Numerics.Vector2 Loc);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,System.Numerics.Vector2).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

[IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') to add a [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,System.Numerics.Vector2).Loc'></a>

`Loc` [System\.Numerics\.Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2 'System\.Numerics\.Vector2')

Location of the [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')\.

#### Returns
[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')  
ID of the new [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,float,float,float)'></a>

## BasicGraphOperations\.AddNode(this IGraph<Node3D>, float, float, float) Method

Add a [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') in a 3D [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\.

```csharp
public static uint AddNode(this SpatialGraph.IGraph<SpatialGraph.Node3D> graph, float X, float Y, float Z);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,float,float,float).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

[IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') to add a [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,float,float,float).X'></a>

`X` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

X position of the new [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,float,float,float).Y'></a>

`Y` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Y position of the new [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,float,float,float).Z'></a>

`Z` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Z position of the new [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')\.

#### Returns
[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')  
ID of the new [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,System.Numerics.Vector3)'></a>

## BasicGraphOperations\.AddNode(this IGraph<Node3D>, Vector3) Method

Add a [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') in a 3D [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\.

```csharp
public static uint AddNode(this SpatialGraph.IGraph<SpatialGraph.Node3D> graph, System.Numerics.Vector3 Loc);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,System.Numerics.Vector3).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

[IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') to add a [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.AddNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,System.Numerics.Vector3).Loc'></a>

`Loc` [System\.Numerics\.Vector3](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector3 'System\.Numerics\.Vector3')

Location of the [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')\.

#### Returns
[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')  
ID of the new [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')\.