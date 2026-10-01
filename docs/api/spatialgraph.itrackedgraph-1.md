# ITrackedGraph&lt;TNode&gt;

Namespace: SpatialGraph

Base interface for all tracked graphs. A graph stores nodes and edges within it, identified by their IDs.
 Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements.

```csharp
public interface ITrackedGraph<TNode> : IReadOnlyTrackedGraph`1, IReadOnlyGraph`1, IGraph`1 where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node to be used in the graph.

Implements IReadOnlyTrackedGraph&lt;TNode&gt;, IReadOnlyGraph&lt;TNode&gt;, IGraph&lt;TNode&gt;
