## SpatialGraph\.Metadata Namespace

Plugins for documenting additional information in graphs\.

| Classes | |
| :--- | :--- |
| [GraphHistory&lt;TNode&gt;](GraphHistory_TNode_/index.md 'SpatialGraph\.Metadata\.GraphHistory<TNode>') | Records changes from a graph\. |
| [GraphPlugin&lt;TNode&gt;](GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>') | Base class for plugins which can observe and modify changes either in a graph or another plugin (only GraphPlugins)\. |
| [GraphReadOnlyPlugin&lt;TNode&gt;](GraphReadOnlyPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>') | Base class for plugins which can observe changes either in a graph or another plugin\. |
| [NodeAdjacency&lt;TNode&gt;](NodeAdjacency_TNode_/index.md 'SpatialGraph\.Metadata\.NodeAdjacency<TNode>') | Records adjecent nodes and edges from a node in a graph\. |
| [OrderedEdgesByAngle2D](OrderedEdgesByAngle2D/index.md 'SpatialGraph\.Metadata\.OrderedEdgesByAngle2D') | Records the order and adjacency of edges in a node including the angles between them\. |
| [QuadTreeNode](QuadTreeNode/index.md 'SpatialGraph\.Metadata\.QuadTreeNode') | Quadtree implementation for nodes in a graph\. Enables spatial indexing for nodes\. |

| Structs | |
| :--- | :--- |
| [GraphSnapshot&lt;TNode&gt;](GraphSnapshot_TNode_/index.md 'SpatialGraph\.Metadata\.GraphSnapshot<TNode>') | Reconstructed graph from a specific modification step\. Used in GraphHistory\. |

| Enums | |
| :--- | :--- |
| [GraphPluginSubscription](GraphPluginSubscription/index.md 'SpatialGraph\.Metadata\.GraphPluginSubscription') | Determines an event to subscribe to from a GraphPlugin in a GraphPlugin\. |
| [ReadOnlyGraphPluginListenerForPlugin](ReadOnlyGraphPluginListenerForPlugin/index.md 'SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForPlugin') | Determines an event to subscribe to from a Plugin (GraphPlugin/GraphReadOnlyPlugin) in a GraphReadOnlyPlugin\. |
| [ReadOnlyGraphPluginListenerForTrackedGraph](ReadOnlyGraphPluginListenerForTrackedGraph/index.md 'SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForTrackedGraph') | Determines an event to subscribe to from a TrackedGraph in a GraphReadOnlyPlugin\. |
