## BasicElementOperations\.WithID Method

| Overloads | |
| :--- | :--- |
| [WithID(this Edge, uint)](WithID.md#SpatialGraph.Extensions.BasicElementOperations.WithID(thisSpatialGraph.Edge,uint) 'SpatialGraph\.Extensions\.BasicElementOperations\.WithID(this SpatialGraph\.Edge, uint)') | Create a new copy of an edge with a different ID\. |
| [WithID(this Node2D, uint)](WithID.md#SpatialGraph.Extensions.BasicElementOperations.WithID(thisSpatialGraph.Node2D,uint) 'SpatialGraph\.Extensions\.BasicElementOperations\.WithID(this SpatialGraph\.Node2D, uint)') | Creates a new copy of a node with a different ID\. |
| [WithID(this Node3D, uint)](WithID.md#SpatialGraph.Extensions.BasicElementOperations.WithID(thisSpatialGraph.Node3D,uint) 'SpatialGraph\.Extensions\.BasicElementOperations\.WithID(this SpatialGraph\.Node3D, uint)') | Creates a new copy of a node with a different ID\. |

<a name='SpatialGraph.Extensions.BasicElementOperations.WithID(thisSpatialGraph.Edge,uint)'></a>

## BasicElementOperations\.WithID(this Edge, uint) Method

Create a new copy of an edge with a different ID\.

```csharp
public static SpatialGraph.Edge WithID(this SpatialGraph.Edge edge, uint newID);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicElementOperations.WithID(thisSpatialGraph.Edge,uint).edge'></a>

`edge` [Edge](../../Edge/index.md 'SpatialGraph\.Edge')

Edge to copy\.

<a name='SpatialGraph.Extensions.BasicElementOperations.WithID(thisSpatialGraph.Edge,uint).newID'></a>

`newID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID for the new edge\.

#### Returns
[Edge](../../Edge/index.md 'SpatialGraph\.Edge')  
Edge with new ID\.

<a name='SpatialGraph.Extensions.BasicElementOperations.WithID(thisSpatialGraph.Node2D,uint)'></a>

## BasicElementOperations\.WithID(this Node2D, uint) Method

Creates a new copy of a node with a different ID\.

```csharp
public static SpatialGraph.Node2D WithID(this SpatialGraph.Node2D node, uint newID);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicElementOperations.WithID(thisSpatialGraph.Node2D,uint).node'></a>

`node` [Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')

Node to copy\.

<a name='SpatialGraph.Extensions.BasicElementOperations.WithID(thisSpatialGraph.Node2D,uint).newID'></a>

`newID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID for the new node\.

#### Returns
[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')  
Node with new ID\.

<a name='SpatialGraph.Extensions.BasicElementOperations.WithID(thisSpatialGraph.Node3D,uint)'></a>

## BasicElementOperations\.WithID(this Node3D, uint) Method

Creates a new copy of a node with a different ID\.

```csharp
public static SpatialGraph.Node3D WithID(this SpatialGraph.Node3D node, uint newID);
```
#### Parameters

<a name='SpatialGraph.Extensions.BasicElementOperations.WithID(thisSpatialGraph.Node3D,uint).node'></a>

`node` [Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')

Node to copy\.

<a name='SpatialGraph.Extensions.BasicElementOperations.WithID(thisSpatialGraph.Node3D,uint).newID'></a>

`newID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

ID for the new node\.

#### Returns
[Node3D](../../Node3D/index.md 'SpatialGraph\.Node3D')  
Node with new ID\.