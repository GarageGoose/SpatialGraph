## SpatialGraph\.Metadata Namespace

Provides plugins for storing and managing additional metadatas in [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')s\.

| Classes | |
| :--- | :--- |
| [GraphHistory&lt;TNode&gt;](GraphHistory_TNode_/index.md 'SpatialGraph\.Metadata\.GraphHistory<TNode>') | Records changes from a graph\. |
| [GraphPlugin&lt;TNode&gt;](GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>') | Base class for plugins which can observe and modify changes either in [IInterceptableObservableGraph&lt;TNode&gt;](../IInterceptableObservableGraph_TNode_/index.md 'SpatialGraph\.IInterceptableObservableGraph<TNode>') or another [GraphPlugin&lt;TNode&gt;](GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>')\. |
| [GraphReadOnlyPlugin&lt;TNode&gt;](GraphReadOnlyPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>') | Base class for plugins which can observe changes either in [IReadOnlyObservableGraph&lt;TNode&gt;](../IReadOnlyObservableGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyObservableGraph<TNode>') or another plugin\. |
| [NodeAdjacency&lt;TNode&gt;](NodeAdjacency_TNode_/index.md 'SpatialGraph\.Metadata\.NodeAdjacency<TNode>') | Records adjecent nodes and edges from a node in a graph\. |
| [OrderedEdgesByAngle2D](OrderedEdgesByAngle2D/index.md 'SpatialGraph\.Metadata\.OrderedEdgesByAngle2D') | Records the order and adjacency of edges in a node including the angles between them\. |
| [QuadTreeNode](QuadTreeNode/index.md 'SpatialGraph\.Metadata\.QuadTreeNode') | Quadtree implementation for nodes in a graph\. Enables spatial indexing for nodes\. |
| [QuadTreeNodeOperations](QuadTreeNodeOperations/index.md 'SpatialGraph\.Metadata\.QuadTreeNodeOperations') | Spatial indexing operations for a 2D node quadtree\. |

| Structs | |
| :--- | :--- |
| [GraphSnapshot&lt;TNode&gt;](GraphSnapshot_TNode_/index.md 'SpatialGraph\.Metadata\.GraphSnapshot<TNode>') | Reconstructed graph from a specific modification step\. Used in GraphHistory\. |

| Interfaces | |
| :--- | :--- |
| [IReadOnlyQuadTreeNodeCell](IReadOnlyQuadTreeNodeCell/index.md 'SpatialGraph\.Metadata\.IReadOnlyQuadTreeNodeCell') | A specific region in a quadtree which holds nodes or if subdivided, four sub quad trees each on the of the quadrant of the quadtree\. |

| Enums | |
| :--- | :--- |
| [GraphPluginSubscription](GraphPluginSubscription/index.md 'SpatialGraph\.Metadata\.GraphPluginSubscription') | Determines an event to subscribe to from a [GraphPlugin&lt;TNode&gt;](GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>') in a [GraphPlugin&lt;TNode&gt;](GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>')\. |
| [ReadOnlyGraphPluginListenerForPlugin](ReadOnlyGraphPluginListenerForPlugin/index.md 'SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForPlugin') | Determines an event to subscribe to from a Plugin ([GraphPlugin&lt;TNode&gt;](GraphPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphPlugin<TNode>')/[GraphReadOnlyPlugin&lt;TNode&gt;](GraphReadOnlyPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>')) in a [GraphReadOnlyPlugin&lt;TNode&gt;](GraphReadOnlyPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>')\. |
| [ReadOnlyGraphPluginListenerForTrackedGraph](ReadOnlyGraphPluginListenerForTrackedGraph/index.md 'SpatialGraph\.Metadata\.ReadOnlyGraphPluginListenerForTrackedGraph') | Determines an event to subscribe to from a [IObservableGraph&lt;TNode&gt;](../IObservableGraph_TNode_/index.md 'SpatialGraph\.IObservableGraph<TNode>') in a [GraphReadOnlyPlugin&lt;TNode&gt;](GraphReadOnlyPlugin_TNode_/index.md 'SpatialGraph\.Metadata\.GraphReadOnlyPlugin<TNode>')\. |
