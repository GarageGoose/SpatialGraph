## BasicGraphOperations\.UpsertNode Method

| Overloads | |
| :--- | :--- |
| [UpsertNode(this IGraph&lt;Node2D&gt;, uint, float, float)](UpsertNode.md#SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,float,float) 'SpatialGraph\.Extensions\.BasicGraphOperations\.UpsertNode(this SpatialGraph\.IGraph<SpatialGraph\.Node2D>, uint, float, float)') | Add or replace an existing [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') with the same ID in a 2D [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |
| [UpsertNode(this IGraph&lt;Node2D&gt;, uint, Vector2)](UpsertNode.md#SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,System.Numerics.Vector2) 'SpatialGraph\.Extensions\.BasicGraphOperations\.UpsertNode(this SpatialGraph\.IGraph<SpatialGraph\.Node2D>, uint, System\.Numerics\.Vector2)') | Add or replace an existing [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') with the same ID in a 2D [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |
| [UpsertNode(this IGraph&lt;Node3D&gt;, uint, float, float, float)](UpsertNode.md#SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,float,float,float) 'SpatialGraph\.Extensions\.BasicGraphOperations\.UpsertNode(this SpatialGraph\.IGraph<SpatialGraph\.Node3D>, uint, float, float, float)') | Add or replace an existing [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') with the same ID in a 3D [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |
| [UpsertNode(this IGraph&lt;Node3D&gt;, uint, Vector3)](UpsertNode.md#SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,System.Numerics.Vector3) 'SpatialGraph\.Extensions\.BasicGraphOperations\.UpsertNode(this SpatialGraph\.IGraph<SpatialGraph\.Node3D>, uint, System\.Numerics\.Vector3)') | Add or replace an existing [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') with the same ID in a 3D [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,float,float)'></a>

## BasicGraphOperations\.UpsertNode(this IGraph<Node2D>, uint, float, float) Method

Add or replace an existing [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') with the same ID in a 2D [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\.

```csharp
public static void UpsertNode(this SpatialGraph.IGraph<SpatialGraph.Node2D> graph, uint ID, float X, float Y);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,float,float).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

Graph to upsert a node\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,float,float).ID'></a>

`ID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to add/replace\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,float,float).X'></a>

`X` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

X position of the node\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,float,float).Y'></a>

`Y` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Y position of the node\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,System.Numerics.Vector2)'></a>

## BasicGraphOperations\.UpsertNode(this IGraph<Node2D>, uint, Vector2) Method

Add or replace an existing [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D') with the same ID in a 2D [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\.

```csharp
public static void UpsertNode(this SpatialGraph.IGraph<SpatialGraph.Node2D> graph, uint ID, System.Numerics.Vector2 Loc);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,System.Numerics.Vector2).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

Graph to upsert a node\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,System.Numerics.Vector2).ID'></a>

`ID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to add/replace\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,uint,System.Numerics.Vector2).Loc'></a>

`Loc` [System\.Numerics\.Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2 'System\.Numerics\.Vector2')

Location of the node\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,float,float,float)'></a>

## BasicGraphOperations\.UpsertNode(this IGraph<Node3D>, uint, float, float, float) Method

Add or replace an existing [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') with the same ID in a 3D [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\.

```csharp
public static void UpsertNode(this SpatialGraph.IGraph<SpatialGraph.Node3D> graph, uint ID, float X, float Y, float Z);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,float,float,float).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

Graph to upsert a node\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,float,float,float).ID'></a>

`ID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to add/replace\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,float,float,float).X'></a>

`X` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

X position of the node\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,float,float,float).Y'></a>

`Y` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Y position of the node\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,float,float,float).Z'></a>

`Z` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Z position of the node\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,System.Numerics.Vector3)'></a>

## BasicGraphOperations\.UpsertNode(this IGraph<Node3D>, uint, Vector3) Method

Add or replace an existing [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D') with the same ID in a 3D [IGraph&lt;TNode&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\.

```csharp
public static void UpsertNode(this SpatialGraph.IGraph<SpatialGraph.Node3D> graph, uint ID, System.Numerics.Vector3 Loc);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,System.Numerics.Vector3).graph'></a>

`graph` [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

Graph to upsert a node\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,System.Numerics.Vector3).ID'></a>

`ID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to add/replace\.

<a name='SpatialGraph.Extensions.BasicGraphOperations.UpsertNode(thisSpatialGraph.IGraph_SpatialGraph.Node3D_,uint,System.Numerics.Vector3).Loc'></a>

`Loc` [System\.Numerics\.Vector3](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector3 'System\.Numerics\.Vector3')

Location of the node\.