# Graph2DOperations

Namespace: SpatialGraph

Basic modification for 2D graphs.

```csharp
public static class Graph2DOperations
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object) → [Graph2DOperations](./spatialgraph.graph2doperations.md)<br>
Attributes [NullableContextAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullablecontextattribute), [NullableAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.nullableattribute), [ExtensionAttribute](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.extensionattribute)

## Methods

### **CopyElementsToGraph(IGraph&lt;Node2D&gt;, IEnumerable&lt;ElementID&gt;, IGraph&lt;Node2D&gt;, Boolean)**

Copy specified elements from one graph to another.

```csharp
public static void CopyElementsToGraph(IGraph<Node2D> copyFrom, IEnumerable<ElementID> elementsToCopy, IGraph<Node2D> pasteTo, bool preserveID)
```

#### Parameters

`copyFrom` [IGraph&lt;Node2D&gt;](./spatialgraph.igraph-1.md)<br>
Source graph to copy from.

`elementsToCopy` [IEnumerable&lt;ElementID&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)<br>
Elements to copy.

`pasteTo` [IGraph&lt;Node2D&gt;](./spatialgraph.igraph-1.md)<br>
Target graph to paste the elements to.

`preserveID` [Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Preserves the id of the elements from the source graph, do note that elements with same IDs will be replaced with
 elements from the target graph. If false, new ids will be generated for the elements in the target graph.

### **CopyGraph(IGraph&lt;Node2D&gt;, IGraph&lt;Node2D&gt;, Boolean)**

Copy entire graph to another graph.

```csharp
public static void CopyGraph(IGraph<Node2D> copyFrom, IGraph<Node2D> pasteTo, bool preserveID)
```

#### Parameters

`copyFrom` [IGraph&lt;Node2D&gt;](./spatialgraph.igraph-1.md)<br>
Source graph to copy.

`pasteTo` [IGraph&lt;Node2D&gt;](./spatialgraph.igraph-1.md)<br>
Target graph to paste the source graph to.

`preserveID` [Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean)<br>
Preserves the id of the elements from the source graph, do note that elements with same IDs will be replaced with
 elements from the target graph. If false, new ids will be generated for the elements in the target graph.

### **InsertNode(IGraph&lt;Node2D&gt;, UInt32, Node2D)**

Insert a new node in between an edge.

```csharp
public static void InsertNode(IGraph<Node2D> baseGraph, uint edgeID, Node2D newNode)
```

#### Parameters

`baseGraph` [IGraph&lt;Node2D&gt;](./spatialgraph.igraph-1.md)<br>
Graph to perform the operation.

`edgeID` [UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
ID of target edge.

`newNode` [Node2D](./spatialgraph.node2d.md)<br>
Node to insert.

### **CollapseNode(IGraph&lt;Node2D&gt;, NodeAdjacency&lt;Node2D&gt;, params UInt32[])**

Combine multiple nodes into a single one.

```csharp
public static void CollapseNode(IGraph<Node2D> baseGraph, NodeAdjacency<Node2D> adjacency, params UInt32[] nodeIDsToCollapse)
```

#### Parameters

`baseGraph` [IGraph&lt;Node2D&gt;](./spatialgraph.igraph-1.md)<br>
Graph to perform the operation.

`adjacency` [NodeAdjacency&lt;Node2D&gt;](./spatialgraph.metadata.nodeadjacency-1.md)<br>
Elements adjacency plugin for baseGraph.

`params` `nodeIDsToCollapse` [UInt32[]](https://learn.microsoft.com/en-us/dotnet/api/system.uint32)<br>
IDs of the node to collapse to a single node. The first in the array will be the new node.
