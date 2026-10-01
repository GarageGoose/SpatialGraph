## QuadTreeNode\(ITrackedGraph\<Node2D\>, int, Vector2, float, float\) Constructor

New instance of a node quad tree\.

```csharp
public QuadTreeNode(SpatialGraph.ITrackedGraph<SpatialGraph.Node2D> graph, int cellCapacity, System.Numerics.Vector2 originTopLeft, float width, float height);
```
#### Parameters

<a name='SpatialGraph.Metadata.QuadTreeNode.QuadTreeNode(SpatialGraph.ITrackedGraph_SpatialGraph.Node2D_,int,System.Numerics.Vector2,float,float).graph'></a>

`graph` [SpatialGraph\.ITrackedGraph&lt;](../../ITrackedGraph_TNode_/index.md 'SpatialGraph\.ITrackedGraph\<TNode\>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../ITrackedGraph_TNode_/index.md 'SpatialGraph\.ITrackedGraph\<TNode\>')

Graph to record the nodes from\.

<a name='SpatialGraph.Metadata.QuadTreeNode.QuadTreeNode(SpatialGraph.ITrackedGraph_SpatialGraph.Node2D_,int,System.Numerics.Vector2,float,float).cellCapacity'></a>

`cellCapacity` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

Maximum amount of nodes in a cell before subdividing\.

<a name='SpatialGraph.Metadata.QuadTreeNode.QuadTreeNode(SpatialGraph.ITrackedGraph_SpatialGraph.Node2D_,int,System.Numerics.Vector2,float,float).originTopLeft'></a>

`originTopLeft` [System\.Numerics\.Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2 'System\.Numerics\.Vector2')

Top left corner of the parent cell\.

<a name='SpatialGraph.Metadata.QuadTreeNode.QuadTreeNode(SpatialGraph.ITrackedGraph_SpatialGraph.Node2D_,int,System.Numerics.Vector2,float,float).width'></a>

`width` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Width of the cell\.

<a name='SpatialGraph.Metadata.QuadTreeNode.QuadTreeNode(SpatialGraph.ITrackedGraph_SpatialGraph.Node2D_,int,System.Numerics.Vector2,float,float).height'></a>

`height` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Height of the cell\.