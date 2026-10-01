## GraphPlugin\<TNode\> Class

Base class for plugins which can observe and modify changes either in a graph or another plugin \(only GraphPlugins\)\.

```csharp
public abstract class GraphPlugin<TNode> : SpatialGraph.IInterceptableTrackedGraph<TNode>, SpatialGraph.ITrackedGraph<TNode>, SpatialGraph.IReadOnlyTrackedGraph<TNode>, SpatialGraph.IReadOnlyGraph<TNode>, SpatialGraph.IGraph<TNode>
    where TNode : struct, SpatialGraph.INode
```
#### Type parameters

<a name='SpatialGraph.Metadata.GraphPlugin_TNode_.TNode'></a>

`TNode`

Type of node used in the base graph\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → GraphPlugin\<TNode\>

Implements [SpatialGraph\.IInterceptableTrackedGraph&lt;](SpatialGraph.IInterceptableTrackedGraph_TNode_.md 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>')[TNode](SpatialGraph.Metadata.GraphPlugin_TNode_.md#SpatialGraph.Metadata.GraphPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.TNode')[&gt;](SpatialGraph.IInterceptableTrackedGraph_TNode_.md 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>'), [SpatialGraph\.ITrackedGraph&lt;](SpatialGraph.ITrackedGraph_TNode_.md 'SpatialGraph\.ITrackedGraph\<TNode\>')[TNode](SpatialGraph.Metadata.GraphPlugin_TNode_.md#SpatialGraph.Metadata.GraphPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.TNode')[&gt;](SpatialGraph.ITrackedGraph_TNode_.md 'SpatialGraph\.ITrackedGraph\<TNode\>'), [SpatialGraph\.IReadOnlyTrackedGraph&lt;](SpatialGraph.IReadOnlyTrackedGraph_TNode_.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>')[TNode](SpatialGraph.Metadata.GraphPlugin_TNode_.md#SpatialGraph.Metadata.GraphPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyTrackedGraph_TNode_.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>'), [SpatialGraph\.IReadOnlyGraph&lt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](SpatialGraph.Metadata.GraphPlugin_TNode_.md#SpatialGraph.Metadata.GraphPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>'), [SpatialGraph\.IGraph&lt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')[TNode](SpatialGraph.Metadata.GraphPlugin_TNode_.md#SpatialGraph.Metadata.GraphPlugin_TNode_.TNode 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.TNode')[&gt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')

| Constructors | |
| :--- | :--- |
| [GraphPlugin\(IInterceptableTrackedGraph&lt;TNode&gt;\)](SpatialGraph.Metadata.GraphPlugin_TNode_.#ctor.md#SpatialGraph.Metadata.GraphPlugin_TNode_.GraphPlugin(SpatialGraph.IInterceptableTrackedGraph_TNode_) 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.GraphPlugin\(SpatialGraph\.IInterceptableTrackedGraph\<TNode\>\)') | Listens to a graph when an update occurs\. An update is invoked when the base graph is modified by adding, modifying, and removing any of its elements\. |
| [GraphPlugin\(GraphPlugin&lt;TNode&gt;, GraphPluginSubscription\)](SpatialGraph.Metadata.GraphPlugin_TNode_.#ctor.md#SpatialGraph.Metadata.GraphPlugin_TNode_.GraphPlugin(SpatialGraph.Metadata.GraphPlugin_TNode_,SpatialGraph.Metadata.GraphPluginSubscription) 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.GraphPlugin\(SpatialGraph\.Metadata\.GraphPlugin\<TNode\>, SpatialGraph\.Metadata\.GraphPluginSubscription\)') | Listens to the plugin when an update occurs\. An update is invoked when the base graph is modified by adding, modifying, and removing any of its elements\. |

| Properties | |
| :--- | :--- |
| [Edges](SpatialGraph.Metadata.GraphPlugin_TNode_.Edges.md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.Edges') | Edges stored in this graph\. Elements such as edges are referenced be their unique ID\. Nodes and edges can share the same ID\. |
| [Nodes](SpatialGraph.Metadata.GraphPlugin_TNode_.Nodes.md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.Nodes') | Nodes stored in this graph\. Elements such as nodes are referenced be their unique ID\. Nodes and edges can share the same ID\. |

| Methods | |
| :--- | :--- |
| [ApplyChangeSet\(GraphChangeSet&lt;TNode&gt;\)](SpatialGraph.Metadata.GraphPlugin_TNode_.ApplyChangeSet(SpatialGraph.GraphChangeSet_TNode_).md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.ApplyChangeSet\(SpatialGraph\.GraphChangeSet\<TNode\>\)') | Perform multiple operations at once with a GraphChangeSet\. Existing nodes or edges with a corresponding ID in the graph will be replaced\. Nodes and edges can share the same ID\. |
| [GenerateID\(\)](SpatialGraph.Metadata.GraphPlugin_TNode_.GenerateID().md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.GenerateID\(\)') | Generate unique ID for the elements of the graph\. Nodes and edges can share the same ID\. |
| [OnGraphUpdate\(object, GraphChangeLog&lt;TNode&gt;\)](SpatialGraph.Metadata.GraphPlugin_TNode_.OnGraphUpdate(object,SpatialGraph.GraphChangeLog_TNode_).md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.OnGraphUpdate\(object, SpatialGraph\.GraphChangeLog\<TNode\>\)') | Emits when a modification occurs in the base graph\. |
| [RemoveEdge\(uint\)](SpatialGraph.Metadata.GraphPlugin_TNode_.RemoveEdge(uint).md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.RemoveEdge\(uint\)') | Remove an edge in the graph using its corresponding ID\. Nodes and edges can share the same ID, this will remove only the edge with the corresponding ID\. |
| [RemoveNode\(uint\)](SpatialGraph.Metadata.GraphPlugin_TNode_.RemoveNode(uint).md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.RemoveNode\(uint\)') | Remove a node in the graph using its correspinding ID\. Connecting edges referencing this node will not be removed\. Nodes and edges can share the same ID, this will remove only the node with the corresponding ID\. |
| [UpsertEdge\(Edge\)](SpatialGraph.Metadata.GraphPlugin_TNode_.UpsertEdge(SpatialGraph.Edge).md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.UpsertEdge\(SpatialGraph\.Edge\)') | Add a new edge or modify an edge with its corresponding ID\. |
| [UpsertNode\(TNode\)](SpatialGraph.Metadata.GraphPlugin_TNode_.UpsertNode(TNode).md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.UpsertNode\(TNode\)') | Add a new node or modify one with their corresponding ID\. Nodes and edges can share the same ID\. |

| Events | |
| :--- | :--- |
| [OnGraphModificationInit](SpatialGraph.Metadata.GraphPlugin_TNode_.OnGraphModificationInit.md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.OnGraphModificationInit') | Event for incoming changes\. Invokes with a GraphChangeLog which contains the modifications being performed\. Modifications can be changed via the GraphChangeLog before being applied to the graph\. |
| [OnGraphModified](SpatialGraph.Metadata.GraphPlugin_TNode_.OnGraphModified.md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.OnGraphModified') | Event for changes applied\. Invokes with an IReadOnlyModificationLog, which contains the changes in the graph after it is modified\. |
| [OnGraphPluginInit](SpatialGraph.Metadata.GraphPlugin_TNode_.OnGraphPluginInit.md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.OnGraphPluginInit') | Emits before the plugin starts logging changes\. |
| [OnGraphPluginUpdated](SpatialGraph.Metadata.GraphPlugin_TNode_.OnGraphPluginUpdated.md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>\.OnGraphPluginUpdated') | Emits after the plugin starts logging changes\. |
