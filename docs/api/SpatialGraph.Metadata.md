## SpatialGraph\.Metadata Namespace

| Classes | |
| :--- | :--- |
| [GraphHistory&lt;TNode&gt;](SpatialGraph.Metadata.GraphHistory_TNode_.md 'SpatialGraph\.Metadata\.GraphHistory\<TNode\>') | Records changes from a graph\. |
| [GraphPlugin&lt;TNode&gt;](SpatialGraph.Metadata.GraphPlugin_TNode_.md 'SpatialGraph\.Metadata\.GraphPlugin\<TNode\>') | Base class for plugins which can observe and modify changes either in a graph or another plugin \(only GraphPlugins\)\. |
| [GraphReadOnlyPlugin&lt;TNode&gt;](SpatialGraph.Metadata.GraphReadOnlyPlugin_TNode_.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin\<TNode\>') | Base class for plugins which can observe changes either in a graph or another plugin\. |
| [NodeAdjacency&lt;TNode&gt;](SpatialGraph.Metadata.NodeAdjacency_TNode_.md 'SpatialGraph\.Metadata\.NodeAdjacency\<TNode\>') | Records adjecent nodes and edges from a node in a graph\. |
| [OrderedEdgesByAngle2D](SpatialGraph.Metadata.OrderedEdgesByAngle2D.md 'SpatialGraph\.Metadata\.OrderedEdgesByAngle2D') | Records the order and adjacency of edges in a node including the angles between them\. |
| [QuadTreeNode](SpatialGraph.Metadata.QuadTreeNode.md 'SpatialGraph\.Metadata\.QuadTreeNode') | Quadtree implementation for nodes in a graph\. Enables spatial indexing for nodes\. |

| Structs | |
| :--- | :--- |
| [GraphSnapshot&lt;TNode&gt;](SpatialGraph.Metadata.GraphSnapshot_TNode_.md 'SpatialGraph\.Metadata\.GraphSnapshot\<TNode\>') | Reconstructed graph from a specific modification step\. Used in GraphHistory\. |

| Enums | |
| :--- | :--- |
| [GraphPluginSubscription](SpatialGraph.Metadata.GraphPluginSubscription.md 'SpatialGraph\.Metadata\.GraphPluginSubscription') | Determines an event to subscribe to from a GraphPlugin in a GraphPlugin\. |
| [ReadOnlyGraphPluginListenerForPlugin](SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForPlugin.md 'SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForPlugin') | Determines an event to subscribe to from a Plugin \(GraphPlugin/GraphReadOnlyPlugin\) in a GraphReadOnlyPlugin\. |
| [ReadOnlyGraphPluginListenerForTrackedGraph](SpatialGraph.Metadata.ReadOnlyGraphPluginListenerForTrackedGraph.md 'SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForTrackedGraph') | Determines an event to subscribe to from a TrackedGraph in a GraphReadOnlyPlugin\. |
