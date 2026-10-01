## BasicGraphOperations\.UpsertNode Method

| Overloads | |
| :--- | :--- |
| [UpsertNode\(this Graph&lt;Node2D&gt;, uint, float, float\)](UpsertNode.md#SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,uint,float,float) 'SpatialGraph\.Extentions\.BasicGraphOperations\.UpsertNode\(this SpatialGraph\.Graph\<SpatialGraph\.Node2D\>, uint, float, float\)') | Add or replace a node with the same ID in a 2D graph\. |
| [UpsertNode\(this Graph&lt;Node2D&gt;, uint, Vector2\)](UpsertNode.md#SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,uint,System.Numerics.Vector2) 'SpatialGraph\.Extentions\.BasicGraphOperations\.UpsertNode\(this SpatialGraph\.Graph\<SpatialGraph\.Node2D\>, uint, System\.Numerics\.Vector2\)') | Add or replace a node with the same ID in a 2D graph\. |
| [UpsertNode\(this Graph&lt;Node3D&gt;, uint, float, float, float\)](UpsertNode.md#SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,uint,float,float,float) 'SpatialGraph\.Extentions\.BasicGraphOperations\.UpsertNode\(this SpatialGraph\.Graph\<SpatialGraph\.Node3D\>, uint, float, float, float\)') | Add or replace a node with the same ID in a 3D graph\. |
| [UpsertNode\(this Graph&lt;Node3D&gt;, uint, Vector3\)](UpsertNode.md#SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,uint,System.Numerics.Vector3) 'SpatialGraph\.Extentions\.BasicGraphOperations\.UpsertNode\(this SpatialGraph\.Graph\<SpatialGraph\.Node3D\>, uint, System\.Numerics\.Vector3\)') | Add or replace a node with the same ID in a 3D graph\. |

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,uint,float,float)'></a>

## BasicGraphOperations\.UpsertNode\(this Graph\<Node2D\>, uint, float, float\) Method

Add or replace a node with the same ID in a 2D graph\.

```csharp
public static void UpsertNode(this SpatialGraph.Graph<SpatialGraph.Node2D> graph, uint ID, float X, float Y);
```
#### Parameters

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,uint,float,float).graph'></a>

`graph` [SpatialGraph\.Graph&lt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph\<TNode\>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph\<TNode\>')

Graph to upsert a node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,uint,float,float).ID'></a>

`ID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to add/replace\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,uint,float,float).X'></a>

`X` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

X position of the node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,uint,float,float).Y'></a>

`Y` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Y position of the node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,uint,System.Numerics.Vector2)'></a>

## BasicGraphOperations\.UpsertNode\(this Graph\<Node2D\>, uint, Vector2\) Method

Add or replace a node with the same ID in a 2D graph\.

```csharp
public static void UpsertNode(this SpatialGraph.Graph<SpatialGraph.Node2D> graph, uint ID, System.Numerics.Vector2 Loc);
```
#### Parameters

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,uint,System.Numerics.Vector2).graph'></a>

`graph` [SpatialGraph\.Graph&lt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph\<TNode\>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph\<TNode\>')

Graph to upsert a node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,uint,System.Numerics.Vector2).ID'></a>

`ID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to add/replace\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node2D_,uint,System.Numerics.Vector2).Loc'></a>

`Loc` [System\.Numerics\.Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2 'System\.Numerics\.Vector2')

Location of the node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,uint,float,float,float)'></a>

## BasicGraphOperations\.UpsertNode\(this Graph\<Node3D\>, uint, float, float, float\) Method

Add or replace a node with the same ID in a 3D graph\.

```csharp
public static void UpsertNode(this SpatialGraph.Graph<SpatialGraph.Node3D> graph, uint ID, float X, float Y, float Z);
```
#### Parameters

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,uint,float,float,float).graph'></a>

`graph` [SpatialGraph\.Graph&lt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph\<TNode\>')[Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')[&gt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph\<TNode\>')

Graph to add a node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,uint,float,float,float).ID'></a>

`ID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to add/replace\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,uint,float,float,float).X'></a>

`X` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

X position of the node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,uint,float,float,float).Y'></a>

`Y` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Y position of the node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,uint,float,float,float).Z'></a>

`Z` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Z position of the node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,uint,System.Numerics.Vector3)'></a>

## BasicGraphOperations\.UpsertNode\(this Graph\<Node3D\>, uint, Vector3\) Method

Add or replace a node with the same ID in a 3D graph\.

```csharp
public static void UpsertNode(this SpatialGraph.Graph<SpatialGraph.Node3D> graph, uint ID, System.Numerics.Vector3 Loc);
```
#### Parameters

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,uint,System.Numerics.Vector3).graph'></a>

`graph` [SpatialGraph\.Graph&lt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph\<TNode\>')[Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')[&gt;](../../Graph_TNode_/index.md 'SpatialGraph\.Graph\<TNode\>')

Graph to add a node\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,uint,System.Numerics.Vector3).ID'></a>

`ID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID of the node to add/replace\.

<a name='SpatialGraph.Extentions.BasicGraphOperations.UpsertNode(thisSpatialGraph.Graph_SpatialGraph.Node3D_,uint,System.Numerics.Vector3).Loc'></a>

`Loc` [System\.Numerics\.Vector3](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector3 'System\.Numerics\.Vector3')

Location of the node\.