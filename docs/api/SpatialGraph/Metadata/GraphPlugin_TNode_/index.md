## GraphPlugin<TNode> Class

Base class for plugins which can observe and modify changes either in a graph or another plugin (only GraphPlugins)\.

```csharp
public abstract class GraphPlugin<TNode> : SpatialGraph.IInterceptableTrackedGraph<TNode>, SpatialGraph.ITrackedGraph<TNode>, SpatialGraph.IReadOnlyTrackedGraph<TNode>, SpatialGraph.IReadOnlyGraph<TNode>, SpatialGraph.IGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.Metadata.GraphPlugin_TNode_.TNode'></a>

`TNode`

Type of node used in the base graph\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → GraphPlugin<TNode>

Implements [SpatialGraph\.IInterceptableTrackedGraph&lt;](../../IInterceptableTrackedGraph_TNode_/index.md 'SpatialGraph\.IInterceptableTrackedGraph<TNode>')[TNode](index.md#SpatialGraph.Metadata.GraphPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.TNode')[&gt;](../../IInterceptableTrackedGraph_TNode_/index.md 'SpatialGraph\.IInterceptableTrackedGraph<TNode>'), [SpatialGraph\.ITrackedGraph&lt;](../../ITrackedGraph_TNode_/index.md 'SpatialGraph\.ITrackedGraph<TNode>')[TNode](index.md#SpatialGraph.Metadata.GraphPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.TNode')[&gt;](../../ITrackedGraph_TNode_/index.md 'SpatialGraph\.ITrackedGraph<TNode>'), [SpatialGraph\.IReadOnlyTrackedGraph&lt;](../../IReadOnlyTrackedGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyTrackedGraph<TNode>')[TNode](index.md#SpatialGraph.Metadata.GraphPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.TNode')[&gt;](../../IReadOnlyTrackedGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyTrackedGraph<TNode>'), [SpatialGraph\.IReadOnlyGraph&lt;](../../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[TNode](index.md#SpatialGraph.Metadata.GraphPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.TNode')[&gt;](../../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>'), [SpatialGraph\.IGraph&lt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')[TNode](index.md#SpatialGraph.Metadata.GraphPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.TNode')[&gt;](../../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')

| Constructors | |
| :--- | :--- |
| [GraphPlugin(IInterceptableTrackedGraph&lt;TNode&gt;)](GraphPlugin_TNode_.md#SpatialGraph.Metadata.GraphPlugin_TNode_.GraphPlugin(SpatialGraph.IInterceptableTrackedGraph_TNode_) 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.GraphPlugin(SpatialGraph\.IInterceptableTrackedGraph<TNode>)') | Listens to a graph when an update occurs\. An update is invoked when the base graph is modified by adding, modifying, and removing any of its elements\. |
| [GraphPlugin(GraphPlugin&lt;TNode&gt;, GraphPluginSubscription)](GraphPlugin_TNode_.md#SpatialGraph.Metadata.GraphPlugin_TNode_.GraphPlugin(SpatialGraph.Metadata.GraphPlugin_TNode_,SpatialGraph.Metadata.GraphPluginSubscription) 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.GraphPlugin(SpatialGraph\.Metadata\.GraphPlugin<TNode>, SpatialGraph\.Metadata\.GraphPluginSubscription)') | Listens to the plugin when an update occurs\. An update is invoked when the base graph is modified by adding, modifying, and removing any of its elements\. |

| Properties | |
| :--- | :--- |
| [Edges](Edges.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.Edges') | Edges stored in this graph\. Elements such as edges are referenced be their unique ID\. Nodes and edges can share the same ID\. |
| [Nodes](Nodes.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.Nodes') | Nodes stored in this graph\. Elements such as nodes are referenced be their unique ID\. Nodes and edges can share the same ID\. |

| Methods | |
| :--- | :--- |
| [ApplyChangeSet(GraphChangeSet&lt;TNode&gt;)](ApplyChangeSet(GraphChangeSet_TNode_).md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.ApplyChangeSet(SpatialGraph\.GraphChangeSet<TNode>)') | Perform multiple operations at once with a [GraphChangeSet&lt;TNode&gt;](../../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')\. Existing [INode](../../INode/index.md 'SpatialGraph\.INode') or [Edge](../../Edge/index.md 'SpatialGraph\.Edge')s with a corresponding ID in the graph will be replaced\. Nodes and edges can share the same ID\. |
| [GenerateID()](GenerateID().md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.GenerateID()') | Generate unique ID for the elements of the graph\. Nodes and edges can share the same ID\. |
| [OnGraphUpdate(object, GraphChangeLog&lt;TNode&gt;)](OnGraphUpdate(object,GraphChangeLog_TNode_).md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.OnGraphUpdate(object, SpatialGraph\.GraphChangeLog<TNode>)') | Emits when a modification occurs in the base graph\. |
| [RemoveEdge(uint)](RemoveEdge(uint).md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.RemoveEdge(uint)') | Remove an [Edge](../../Edge/index.md 'SpatialGraph\.Edge') in the graph using its corresponding ID\. Nodes and edges can share the same ID, this will remove only the edge with the corresponding ID\. |
| [RemoveNode(uint)](RemoveNode(uint).md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.RemoveNode(uint)') | Remove a [INode](../../INode/index.md 'SpatialGraph\.INode') in the graph using its correspinding ID\. Connecting [Edge](../../Edge/index.md 'SpatialGraph\.Edge') referencing this node will not be removed\. Nodes and edges can share the same ID, this will remove only the node with the corresponding ID\. |
| [UpsertEdge(Edge)](UpsertEdge(Edge).md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.UpsertEdge(SpatialGraph\.Edge)') | Add a new [Edge](../../Edge/index.md 'SpatialGraph\.Edge') or modify an [Edge](../../Edge/index.md 'SpatialGraph\.Edge') with its corresponding ID\. |
| [UpsertNode(TNode)](UpsertNode(TNode).md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.UpsertNode(TNode)') | Add a new [INode](../../INode/index.md 'SpatialGraph\.INode') or modify one with their corresponding ID\. Nodes and edges can share the same ID\. |

| Events | |
| :--- | :--- |
| [OnGraphModificationInit](OnGraphModificationInit.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.OnGraphModificationInit') | Event for incoming changes\. Invokes with a GraphChangeLog which contains the modifications being performed\. Modifications can be changed via the GraphChangeLog before being applied to the graph\. |
| [OnGraphModified](OnGraphModified.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.OnGraphModified') | Event for changes applied\. Invokes with an IReadOnlyModificationLog, which contains the changes in the graph after it is modified\. |
| [OnGraphPluginInit](OnGraphPluginInit.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.OnGraphPluginInit') | Emits before the plugin starts logging changes\. |
| [OnGraphPluginUpdated](OnGraphPluginUpdated.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>\.OnGraphPluginUpdated') | Emits after the plugin starts logging changes\. |
