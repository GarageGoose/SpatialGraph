# IInterceptableTrackedGraph&lt;TNode&gt;

Namespace: SpatialGraph

Base interface for all tracked graphs which can modifiy incoming changes. A graph stores nodes and edges within it, identified by their IDs.
 Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements.

```csharp
public interface IInterceptableTrackedGraph<TNode> : ITrackedGraph`1, IReadOnlyTrackedGraph`1, IReadOnlyGraph`1, IGraph`1 where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node to be used in the graph.

Implements ITrackedGraph&lt;TNode&gt;, IReadOnlyTrackedGraph&lt;TNode&gt;, IReadOnlyGraph&lt;TNode&gt;, IGraph&lt;TNode&gt;

## Events

### **OnGraphModificationInit**

Event for incoming changes. Invokes with a GraphChangeLog which contains the modifications being performed.
 Modifications can be changed via the GraphChangeLog before being applied to the graph.

```csharp
event EventHandler<GraphChangeLog<TNode>>? OnGraphModificationInit;
```
