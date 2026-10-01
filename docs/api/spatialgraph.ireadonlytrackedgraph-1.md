# IReadOnlyTrackedGraph&lt;TNode&gt;

Namespace: SpatialGraph

Read only interface of a tracked graph. Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements.

```csharp
public interface IReadOnlyTrackedGraph<TNode> : IReadOnlyGraph`1 where TNode : struct, INode
```

#### Type Parameters

`TNode`<br>
Type of node to be used in the graph.

Implements IReadOnlyGraph&lt;TNode&gt;

## Events

### **OnGraphModified**

Event for changes applied. Invokes with an IReadOnlyModificationLog, which contains the changes in the graph after it is modified.

```csharp
event EventHandler<IReadOnlyModificationLog<TNode>>? OnGraphModified;
```
