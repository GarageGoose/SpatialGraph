# Pathfinding

Namespace: SpatialGraph.Traversal

```csharp
public static class Pathfinding
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [Pathfinding](./spatialgraph.traversal.pathfinding.md)<br>
Attributes [ExtensionAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.extensionattribute)

## Methods

### **BreadthFirstTraversal&lt;TNode&gt;(NodeAdjacency&lt;TNode&gt;, UInt32, UInt32?)**

```csharp
public static GraphTraversal<TNode> BreadthFirstTraversal<TNode>(NodeAdjacency<TNode> baseGraph, uint nodeIDStart, uint? targetNodeID = null) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>

#### Parameters

`baseGraph` NodeAdjacency&lt;TNode&gt;<br>

`nodeIDStart` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

`targetNodeID` [UInt32?](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

GraphTraversal&lt;TNode&gt;<br>

### **DepthFirstTraversal&lt;TNode&gt;(NodeAdjacency&lt;TNode&gt;, UInt32, UInt32?)**

```csharp
public static GraphTraversal<TNode> DepthFirstTraversal<TNode>(NodeAdjacency<TNode> baseGraph, uint nodeIDStart, uint? targetNodeID = null) where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>

#### Parameters

`baseGraph` NodeAdjacency&lt;TNode&gt;<br>

`nodeIDStart` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

`targetNodeID` [UInt32?](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

GraphTraversal&lt;TNode&gt;<br>

### **WeightedTraversal&lt;TNode, TScore&gt;(NodeAdjacency&lt;TNode&gt;, Func&lt;NodeAdjacency&lt;TNode&gt;, UInt32, TScore&gt;, UInt32, UInt32?)**

```csharp
public static GraphTraversal<TNode> WeightedTraversal<TNode, TScore>(NodeAdjacency<TNode> baseGraph, Func<NodeAdjacency<TNode>, uint, TScore> nodeScore, uint nodeIDStart, uint? targetNodeID = null) where TNode : struct, INode where TScore : INumber<TScore>
```

#### Type Parameters

`TNode`<br>

`TScore`<br>

#### Parameters

`baseGraph` NodeAdjacency&lt;TNode&gt;<br>

`nodeScore` Func&lt;NodeAdjacency&lt;TNode&gt;, UInt32, TScore&gt;<br>

`nodeIDStart` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>

`targetNodeID` [UInt32?](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1)<br>

#### Returns

GraphTraversal&lt;TNode&gt;<br>
