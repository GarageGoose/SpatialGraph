## QuadTreeNode(IObservableGraph<Node2D>, int, Vector2, float, float, bool, int) Constructor

New instance of a node quad tree\.

```csharp
public QuadTreeNode(SpatialGraph.IObservableGraph<SpatialGraph.Node2D> graph, int cellCapacity, System.Numerics.Vector2 originTopLeft, float width, float height, bool cellMinBoundingBox=true, int maxDepth=10);
```
#### Parameters

<a name='SpatialGraph.Metadata.QuadTreeNode.QuadTreeNode(SpatialGraph.IObservableGraph_SpatialGraph.Node2D_,int,System.Numerics.Vector2,float,float,bool,int).graph'></a>

`graph` [SpatialGraph\.IObservableGraph&lt;](../../IObservableGraph_TNode_/index.md 'SpatialGraph\.IObservableGraph<TNode>')[Node2D](../../Node2D/index.md 'SpatialGraph\.Node2D')[&gt;](../../IObservableGraph_TNode_/index.md 'SpatialGraph\.IObservableGraph<TNode>')

Graph to record the nodes from\.

<a name='SpatialGraph.Metadata.QuadTreeNode.QuadTreeNode(SpatialGraph.IObservableGraph_SpatialGraph.Node2D_,int,System.Numerics.Vector2,float,float,bool,int).cellCapacity'></a>

`cellCapacity` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

Maximum amount of nodes in a cell before subdividing\.

<a name='SpatialGraph.Metadata.QuadTreeNode.QuadTreeNode(SpatialGraph.IObservableGraph_SpatialGraph.Node2D_,int,System.Numerics.Vector2,float,float,bool,int).originTopLeft'></a>

`originTopLeft` [System\.Numerics\.Vector2](https://learn.microsoft.com/en-us/dotnet/api/system.numerics.vector2 'System\.Numerics\.Vector2')

Top left corner of the parent cell\.

<a name='SpatialGraph.Metadata.QuadTreeNode.QuadTreeNode(SpatialGraph.IObservableGraph_SpatialGraph.Node2D_,int,System.Numerics.Vector2,float,float,bool,int).width'></a>

`width` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Width of the cell\.

<a name='SpatialGraph.Metadata.QuadTreeNode.QuadTreeNode(SpatialGraph.IObservableGraph_SpatialGraph.Node2D_,int,System.Numerics.Vector2,float,float,bool,int).height'></a>

`height` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')

Height of the cell\.

<a name='SpatialGraph.Metadata.QuadTreeNode.QuadTreeNode(SpatialGraph.IObservableGraph_SpatialGraph.Node2D_,int,System.Numerics.Vector2,float,float,bool,int).cellMinBoundingBox'></a>

`cellMinBoundingBox` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Generate minimum bounding box of the points contained in a cell\. Optimizes operations for certain lookups but has performance penalty for point insertion/deletion\.

<a name='SpatialGraph.Metadata.QuadTreeNode.QuadTreeNode(SpatialGraph.IObservableGraph_SpatialGraph.Node2D_,int,System.Numerics.Vector2,float,float,bool,int).maxDepth'></a>

`maxDepth` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

Maximum amount the cell is allowed to subdivide relative to the original depth\. Does not affect creating new parent cells when enlarging the quadtree\.