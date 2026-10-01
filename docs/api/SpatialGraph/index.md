## SpatialGraph Namespace

| Classes | |
| :--- | :--- |
| [Graph&lt;TNode&gt;](Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>') | Base class for graphs, can be built upon\. |
| [GraphChangeLog&lt;TNode&gt;](GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog<TNode>') | Logs incoming changes for a graph\. Stores additional data: type of modification of an element (Add, Modify, Delete), old value of an element (if any), and new value of an element (if any)\. |
| [GraphIncomingChanges&lt;TNode&gt;](GraphIncomingChanges_TNode_/index.md 'SpatialGraph\.GraphIncomingChanges<TNode>') | Stores incoming changes for a graph\. |
| [InterceptableTrackedGraph&lt;TNode&gt;](InterceptableTrackedGraph_TNode_/index.md 'SpatialGraph\.InterceptableTrackedGraph<TNode>') | Graph which tracks and can modifiy incoming changes within it\. |
| [TrackedGraph&lt;TNode&gt;](TrackedGraph_TNode_/index.md 'SpatialGraph\.TrackedGraph<TNode>') | Graph which tracks changes within it\. |

| Structs | |
| :--- | :--- |
| [Edge](Edge/index.md 'SpatialGraph\.Edge') | A line segment which is formed from 2 nodes\. |
| [ElementAdded&lt;TElement&gt;](ElementAdded_TElement_/index.md 'SpatialGraph\.ElementAdded<TElement>') | Single log of an element which is added\. Used in a ModificationLog\. |
| [ElementID](ElementID/index.md 'SpatialGraph\.ElementID') | Generic element identifier\. |
| [ElementModified&lt;TElement&gt;](ElementModified_TElement_/index.md 'SpatialGraph\.ElementModified<TElement>') | Single log of an element which is modified\. Used in a ModificationLog\. |
| [ElementRemoved&lt;TElement&gt;](ElementRemoved_TElement_/index.md 'SpatialGraph\.ElementRemoved<TElement>') | Single log of an element which is removed\. Used in a ModificationLog\. |
| [Node2D](Node2D/index.md 'SpatialGraph\.Node2D') | Node with coordinate in 2 dimensions\. Used for 2D graphs\. |
| [Node3D](Node3D/index.md 'SpatialGraph\.Node3D') | Node with coordinate in 3 dimensions\. Used for 3D graphs\. |

| Interfaces | |
| :--- | :--- |
| [GraphChangeSet&lt;TNode&gt;](GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>') | Set of changes in a graph\. |
| [IElement](IElement/index.md 'SpatialGraph\.IElement') | Base interface for all elements\. |
| [IGraph&lt;TNode&gt;](IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') | Base interface for all graphs\. A graph stores nodes and edges within it, identified by their IDs\. Nodes and edges can share the same ID\. |
| [IInterceptableTrackedGraph&lt;TNode&gt;](IInterceptableTrackedGraph_TNode_/index.md 'SpatialGraph\.IInterceptableTrackedGraph<TNode>') | Base interface for all tracked graphs which can modifiy incoming changes\. A graph stores nodes and edges within it, identified by their IDs\. Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements\. |
| [INode](INode/index.md 'SpatialGraph\.INode') | Base interface for all nodes\. |
| [IReadOnlyGraph&lt;TNode&gt;](IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>') | Read only interface of a graph\. A graph stores nodes and edges within it, identified by their IDs\. |
| [IReadOnlyGraphIncomingChanges&lt;TNode&gt;](IReadOnlyGraphIncomingChanges_TNode_/index.md 'SpatialGraph\.IReadOnlyGraphIncomingChanges<TNode>') | Interface for objects which stores incoming changes for a graph\. |
| [IReadOnlyModificationLog&lt;TNode&gt;](IReadOnlyModificationLog_TNode_/index.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>') | Logs incoming changes for a graph\. Stores additional data: type of modification of an element (Add, Modify, Delete), old value of an element (if any), and new value of an element (if any)\. |
| [IReadOnlyQuadTreeNodeCell](IReadOnlyQuadTreeNodeCell/index.md 'SpatialGraph\.IReadOnlyQuadTreeNodeCell') | A specific region in a quadtree which holds nodes or if subdivided, four sub quad trees each on the of the quadrant of the quadtree\. |
| [IReadOnlyTrackedGraph&lt;TNode&gt;](IReadOnlyTrackedGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyTrackedGraph<TNode>') | Read only interface of a tracked graph\. Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements\. |
| [ITrackedGraph&lt;TNode&gt;](ITrackedGraph_TNode_/index.md 'SpatialGraph\.ITrackedGraph<TNode>') | Base interface for all tracked graphs\. A graph stores nodes and edges within it, identified by their IDs\. Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements\. |

| Enums | |
| :--- | :--- |
| [ElementType](ElementType/index.md 'SpatialGraph\.ElementType') | Enum for classifying elements\. |
| [ModificationType](ModificationType/index.md 'SpatialGraph\.ModificationType') | Holds type of modification each element has\. |
| [NodeInEdge](NodeInEdge/index.md 'SpatialGraph\.NodeInEdge') | An enum for identifying the first or second node in a Edge\. |
