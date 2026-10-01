## BasicGraphOperations\.AddNode Method

| Overloads | |
| :--- | :--- |
| [AddNode(this Graph&lt;Node2D&gt;, float, float)](AddNode.md#SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,float,float) 'SpatialGraph\.Extentions\.BasicGraphOperations\.AddNode(this SpatialGraph\.Graph<SpatialGraph\.Node2D>, float, float)') | Add a node in a 2D graph\. |
| [AddNode(this Graph&lt;Node2D&gt;, Vector2)](AddNode.md#SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,System.Numerics.Vector2) 'SpatialGraph\.Extentions\.BasicGraphOperations\.AddNode(this SpatialGraph\.Graph<SpatialGraph\.Node2D>, System\.Numerics\.Vector2)') | Add a node in a 2D graph\. |
| [AddNode(this Graph&lt;Node3D&gt;, float, float, float)](AddNode.md#SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,float,float,float) 'SpatialGraph\.Extentions\.BasicGraphOperations\.AddNode(this SpatialGraph\.Graph<SpatialGraph\.Node3D>, float, float, float)') | Add a node in a 3D graph\. |
| [AddNode(this Graph&lt;Node3D&gt;, Vector3)](AddNode.md#SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,System.Numerics.Vector3) 'SpatialGraph\.Extentions\.BasicGraphOperations\.AddNode(this SpatialGraph\.Graph<SpatialGraph\.Node3D>, System\.Numerics\.Vector3)') | Add a node in a 3D graph\. |

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,float,float)'></a>

## BasicGraphOperations\.AddNode(this Graph<Node2D>, float, float) Method

Add a node in a 2D graph\.

```csharp
public static uint AddNode(this SpatialGraph.Graph<SpatialGraph.Node2D> graph, float X, float Y);
```
#### Parameters

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,float,float).graph'></a>

`graph` [SpatialGraph\.Graph&lt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')

Graph to add a node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,float,float).X'></a>

`X` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

X position of the node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,float,float).Y'></a>

`Y` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Y position of the node\.

#### Returns
[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')  
ID of the new node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,System.Numerics.Vector2)'></a>

## BasicGraphOperations\.AddNode(this Graph<Node2D>, Vector2) Method

Add a node in a 2D graph\.

```csharp
public static uint AddNode(this SpatialGraph.Graph<SpatialGraph.Node2D> graph, System.Numerics.Vector2 Loc);
```
#### Parameters

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,System.Numerics.Vector2).graph'></a>

`graph` [SpatialGraph\.Graph&lt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')

Graph to add a node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,System.Numerics.Vector2).Loc'></a>

`Loc` [System\.Numerics\.Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2 'System\.Numerics\.Vector2')

Location of the node\.

#### Returns
[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')  
ID of the new node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,float,float,float)'></a>

## BasicGraphOperations\.AddNode(this Graph<Node3D>, float, float, float) Method

Add a node in a 3D graph\.

```csharp
public static uint AddNode(this SpatialGraph.Graph<SpatialGraph.Node3D> graph, float X, float Y, float Z);
```
#### Parameters

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,float,float,float).graph'></a>

`graph` [SpatialGraph\.Graph&lt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')[Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')[&gt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')

Graph to add a node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,float,float,float).X'></a>

`X` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

X position of the new node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,float,float,float).Y'></a>

`Y` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Y position of the new node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,float,float,float).Z'></a>

`Z` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Z position of the new node\.

#### Returns
[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')  
ID of the new node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,System.Numerics.Vector3)'></a>

## BasicGraphOperations\.AddNode(this Graph<Node3D>, Vector3) Method

Add a node in a 3D graph\.

```csharp
public static uint AddNode(this SpatialGraph.Graph<SpatialGraph.Node3D> graph, System.Numerics.Vector3 Loc);
```
#### Parameters

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,System.Numerics.Vector3).graph'></a>

`graph` [SpatialGraph\.Graph&lt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')[Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')[&gt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>')

Graph to add a node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.AddNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,System.Numerics.Vector3).Loc'></a>

`Loc` [System\.Numerics\.Vector3](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector3 'System\.Numerics\.Vector3')

Location of the node\.

#### Returns
[System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')  
ID of the new node\.