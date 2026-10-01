## GraphReadOnlyPlugin\<TNode\> Class

Base class for plugins which can observe changes either in a graph or another plugin\.

```csharp
public abstract class GraphReadOnlyPlugin<TNode> : SpatialGraph.IReadOnlyTrackedGraph<TNode>, SpatialGraph.IReadOnlyGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.TNode'></a>

`TNode`

Type of node used in the base graph\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → GraphReadOnlyPlugin\<TNode\>

Derived  
↳ [GraphHistory&lt;TNode&gt;](SpatialGraph.Metadata.GraphHistory_TNode_.md 'SpatialGraph\.Metadata\.GraphHistory\<TNode\>')  
↳ [NodeAdjacency&lt;TNode&gt;](SpatialGraph.Metadata.NodeAdjacency_TNode_.md 'SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>')  
↳ [OrderedEdgesByAngle2D](SpatialGraph.Metadata.OrderedEdgesByAngle2D.md 'SpatialGraph\.Metadata\.OrderedEdgesByAngle2D')  
↳ [QuadTreeNode](SpatialGraph.Metadata.QuadTreeNode.md 'SpatialGraph\.Metadata\.QuadTreeNode')

Implements [SpatialGraph\.IReadOnlyTrackedGraph&lt;](SpatialGraph.IReadOnlyTrackedGraph_TNode_.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>')[TNode](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyTrackedGraph_TNode_.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>'), [SpatialGraph\.IReadOnlyGraph&lt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')

| Constructors | |
| :--- | :--- |
| [GraphReadOnlyPlugin\(IInterceptableTrackedGraph&lt;TNode&gt;, ReadOnlyGraphPluginListenerForTrackedGraph\)](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.#ctor.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IInterceptableTrackedGraph_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForTrackedGraph) 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.GraphReadOnlyPlugin\(SpatialGraph\.IInterceptableTrackedGraph\<TNode\>, SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForTrackedGraph\)') | Listens to a TrackedGraphInterceptable when an update occurs\. |
| [GraphReadOnlyPlugin\(IReadOnlyTrackedGraph&lt;TNode&gt;\)](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.#ctor.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.IReadOnlyTrackedGraph_TNode_) 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.GraphReadOnlyPlugin\(SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>\)') | Listens to a TrackedGraph when an update occurs\. An update is the |
| [GraphReadOnlyPlugin\(GraphPlugin&lt;TNode&gt;, ReadOnlyGraphPluginListenerForPlugin\)](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.#ctor.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin) 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.GraphReadOnlyPlugin\(SpatialGraph\.Metadata\.GraphPlugin\<TNode\>, SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForPlugin\)') | Listens to a GraphPlugin when an update occurs\. |
| [GraphReadOnlyPlugin\(GraphReadOnlyPlugin&lt;TNode&gt;, ReadOnlyGraphPluginListenerForPlugin\)](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.#ctor.md#SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GraphReadOnlyPlugin(SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_,SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin) 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.GraphReadOnlyPlugin\(SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>, SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForPlugin\)') | Listens to a GraphReadOnlyPlugin when an update occurs\. |

| Properties | |
| :--- | :--- |
| [Edges](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.Edges.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.Edges') | Edges stored in this graph\. Elements such as edges are referenced be their unique ID\. Nodes and edges can share the same ID\. |
| [Nodes](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.Nodes.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.Nodes') | Nodes stored in this graph\. Elements such as nodes are referenced be their unique ID\. Nodes and edges can share the same ID\. |

| Methods | |
| :--- | :--- |
| [GenerateID\(\)](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.GenerateID().md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.GenerateID\(\)') | Generate unique ID for the elements of the graph\. Nodes and edges can share the same ID\. |
| [OnGraphUpdate\(object, IReadOnlyModificationLog&lt;TNode&gt;\)](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.OnGraphUpdate(object,SpatialGraph.IReadOnlyModificationLog_TNode_).md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.OnGraphUpdate\(object, SpatialGraph\.IReadOnlyModificationLog\<TNode\>\)') | Emits when a modification occurs in the base graph\. |

| Events | |
| :--- | :--- |
| [OnGraphModified](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.OnGraphModified.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.OnGraphModified') | Event for changes applied\. Invokes with an IReadOnlyModificationLog, which contains the changes in the graph after it is modified\. |
| [OnGraphPluginInit](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.OnGraphPluginInit.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.OnGraphPluginInit') | Emits after the plugin starts logging changes\. |
| [OnGraphPluginUpdated](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.OnGraphPluginUpdated.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>\.OnGraphPluginUpdated') | Emits before the plugin starts logging changes\. |
