## GraphReadOnlyPlugin<TNode> Class

Base class for plugins which can observe changes either in [IReadOnlyObservableGraph&lt;TNode&gt;](../../IReadOnlyObservableGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyObservableGraph<TNode>') or another plugin\.

```csharp
public abstract class GraphReadOnlyPlugin<TNode> : SpatialGraph.IReadOnlyObservableGraph<TNode>, SpatialGraph.IReadOnlyGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.TNode'></a>

`TNode`

Type of node used in the base graph\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → GraphReadOnlyPlugin<TNode>

Derived  
↳ [GraphHistory&lt;TNode&gt;](../GraphHistory_TNode_/index.md 'SpatialGraph\.Metadata\.GraphHistory<TNode>')  
↳ [NodeAdjacency&lt;TNode&gt;](../NodeAdjacency_TNode_/index.md 'SpatialGraph\.Metadata\.NodeAdjacency<TNode>')  
↳ [OrderedEdgesByAngle2D](../OrderedEdgesByAngle2D/index.md 'SpatialGraph\.Metadata\.OrderedEdgesByAngle2D')  
↳ [QuadTreeNode](../QuadTreeNode/index.md 'SpatialGraph\.Metadata\.QuadTreeNode')

Implements [SpatialGraph\.IReadOnlyObservableGraph&lt;](../../IReadOnlyObservableGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyObservableGraph<TNode>')[TNode](index.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.TNode')[&gt;](../../IReadOnlyObservableGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyObservableGraph<TNode>'), [SpatialGraph\.IReadOnlyGraph&lt;](../../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[TNode](index.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.TNode')[&gt;](../../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')

### See Also
- [GraphPlugin&lt;TNode&gt;](../GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>')

| Constructors | |
| :--- | :--- |
| [GraphReadOnlyPlugin(IInterceptableObservableGraph&lt;TNode&gt;, ReadOnlyGraphPluginListenerForTrackedGraph)](GraphReadOnlyPlugin_TNode_.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IInterceptableObservableGraph_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForTrackedGraph) 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.GraphReadOnlyPlugin(SpatialGraph\.IInterceptableObservableGraph<TNode>, SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForTrackedGraph)') | Listens to a [IInterceptableObservableGraph&lt;TNode&gt;](../../IInterceptableObservableGraph_TNode_/index.md 'SpatialGraph\.IInterceptableObservableGraph<TNode>') when an update occurs\. |
| [GraphReadOnlyPlugin(IReadOnlyObservableGraph&lt;TNode&gt;)](GraphReadOnlyPlugin_TNode_.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IReadOnlyObservableGraph_TNode_) 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.GraphReadOnlyPlugin(SpatialGraph\.IReadOnlyObservableGraph<TNode>)') | Listens to a TrackedGraph when an update occurs\. An update is invoked when the base graph is modified by adding, modifying, and removing any of its elements\. |
| [GraphReadOnlyPlugin(GraphPlugin&lt;TNode&gt;, ReadOnlyGraphPluginListenerForPlugin)](GraphReadOnlyPlugin_TNode_.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin) 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.GraphReadOnlyPlugin(SpatialGraph\.Metadata\.GraphPlugin<TNode>, SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForPlugin)') | Listens to a [GraphPlugin&lt;TNode&gt;](../GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>') when an update occurs\. |
| [GraphReadOnlyPlugin(GraphReadOnlyPlugin&lt;TNode&gt;, ReadOnlyGraphPluginListenerForPlugin)](GraphReadOnlyPlugin_TNode_.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin) 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.GraphReadOnlyPlugin(SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>, SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForPlugin)') | Listens to a [GraphReadOnlyPlugin&lt;TNode&gt;](index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>') when an update occurs\. |

| Properties | |
| :--- | :--- |
| [Edges](Edges.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.Edges') | Edges stored in this graph\. Elements such as edges are referenced be their unique ID\. Nodes and edges can share the same ID\. |
| [Nodes](Nodes.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.Nodes') | Nodes stored in this graph\. Elements such as nodes are referenced be their unique ID\. Nodes and edges can share the same ID\. |

| Methods | |
| :--- | :--- |
| [GenerateID()](GenerateID().md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.GenerateID()') | Generate unique ID for the elements of the graph\. Nodes and edges can share the same ID\. |
| [OnGraphUpdate(object, IReadOnlyModificationLog&lt;TNode&gt;)](OnGraphUpdate(object,IReadOnlyModificationLog_TNode_).md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.OnGraphUpdate(object, SpatialGraph\.IReadOnlyModificationLog<TNode>)') | Emits when a modification occurs in the base graph\. |

| Events | |
| :--- | :--- |
| [OnGraphModified](OnGraphModified.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.OnGraphModified') | Event for changes applied\. Invokes with an IReadOnlyModificationLog, which contains the changes in the graph after it is modified\. |
| [OnGraphPluginInit](OnGraphPluginInit.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.OnGraphPluginInit') | Emits after the plugin starts logging changes\. |
| [OnGraphPluginUpdated](OnGraphPluginUpdated.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>\.OnGraphPluginUpdated') | Emits before the plugin starts logging changes\. |
