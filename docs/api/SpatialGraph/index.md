## SpatialGraph Namespace

Main namespace for the library\. Contains all the essentials for building and interacting with [IGraph&lt;TNode&gt;](IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')s\.

| Classes | |
| :--- | :--- |
| [Graph&lt;TNode&gt;](Graph_TNode_/index.md 'SpatialGraph\.Graph<TNode>') | Base class for graphs, can be built upon\. A graph stores [INode](INode/index.md 'SpatialGraph\.INode') and [Edge](Edge/index.md 'SpatialGraph\.Edge') within it, identified by their IDs\. |
| [GraphChangeLog&lt;TNode&gt;](GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog<TNode>') | Logs incoming changes for a [IGraph&lt;TNode&gt;](IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. Stores additional data: type of modification of an [IElement](IElement/index.md 'SpatialGraph\.IElement') (Add, Modify, Delete), old value of an [IElement](IElement/index.md 'SpatialGraph\.IElement') (if any), and new value of an [IElement](IElement/index.md 'SpatialGraph\.IElement') (if any)\. |
| [GraphIncomingChanges&lt;TNode&gt;](GraphIncomingChanges_TNode_/index.md 'SpatialGraph\.GraphIncomingChanges<TNode>') | Stores incoming changes for a graph\. |
| [InterceptableTrackedGraph&lt;TNode&gt;](InterceptableTrackedGraph_TNode_/index.md 'SpatialGraph\.InterceptableTrackedGraph<TNode>') | Graph which can modify incoming changes and track changed within it\. A graph stores [INode](INode/index.md 'SpatialGraph\.INode') and [Edge](Edge/index.md 'SpatialGraph\.Edge') within it, identified by their IDs\. Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements\. |
| [TrackedGraph&lt;TNode&gt;](TrackedGraph_TNode_/index.md 'SpatialGraph\.TrackedGraph<TNode>') | Graph which track changes within it\. A graph stores [INode](INode/index.md 'SpatialGraph\.INode') and [Edge](Edge/index.md 'SpatialGraph\.Edge') within it, identified by their IDs\. Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements\. |

| Structs | |
| :--- | :--- |
| [Edge](Edge/index.md 'SpatialGraph\.Edge') | A line segment which is formed from 2 [INode](INode/index.md 'SpatialGraph\.INode')\. |
| [ElementAdded&lt;TElement&gt;](ElementAdded_TElement_/index.md 'SpatialGraph\.ElementAdded<TElement>') | Log of an [IElement](IElement/index.md 'SpatialGraph\.IElement') which is added\. Used in a [GraphChangeLog&lt;TNode&gt;](GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog<TNode>')\. |
| [ElementID](ElementID/index.md 'SpatialGraph\.ElementID') | Generic [IElement](IElement/index.md 'SpatialGraph\.IElement') identifier\. |
| [ElementModified&lt;TElement&gt;](ElementModified_TElement_/index.md 'SpatialGraph\.ElementModified<TElement>') | Log of an [IElement](IElement/index.md 'SpatialGraph\.IElement') which is modified\. Used in a [GraphChangeLog&lt;TNode&gt;](GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog<TNode>')\. |
| [ElementRemoved&lt;TElement&gt;](ElementRemoved_TElement_/index.md 'SpatialGraph\.ElementRemoved<TElement>') | Log of an [IElement](IElement/index.md 'SpatialGraph\.IElement') which is removed\. Used in a [GraphChangeLog&lt;TNode&gt;](GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog<TNode>')\. |
| [Node2D](Node2D/index.md 'SpatialGraph\.Node2D') | Node with coordinate in 2 dimensions\. Used for 2D graphs\. |
| [Node3D](Node3D/index.md 'SpatialGraph\.Node3D') | Node with coordinate in 3 dimensions\. Used for 3D graphs\. |

| Interfaces | |
| :--- | :--- |
| [GraphChangeSet&lt;TNode&gt;](GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>') | Set of changes in a [IGraph&lt;TNode&gt;](IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. |
| [IElement](IElement/index.md 'SpatialGraph\.IElement') | Base interface for all elements\. |
| [IGraph&lt;TNode&gt;](IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') | Base interface for all graphs\. A graph stores [INode](INode/index.md 'SpatialGraph\.INode') and [Edge](Edge/index.md 'SpatialGraph\.Edge') within it, identified by their IDs\. Nodes and edges can share the same ID\. |
| [IInterceptableTrackedGraph&lt;TNode&gt;](IInterceptableTrackedGraph_TNode_/index.md 'SpatialGraph\.IInterceptableTrackedGraph<TNode>') | Base interface for all tracked graphs which can modify incoming changes and track changed within it\. A graph stores [INode](INode/index.md 'SpatialGraph\.INode') and [Edge](Edge/index.md 'SpatialGraph\.Edge') within it, identified by their IDs\. Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements\. |
| [INode](INode/index.md 'SpatialGraph\.INode') | Represents a node in a [IGraph&lt;TNode&gt;](IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. Base interface for all nodes\. |
| [IReadOnlyGraph&lt;TNode&gt;](IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>') | Read only interface of [IGraph&lt;TNode&gt;](IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. A graph stores [INode](INode/index.md 'SpatialGraph\.INode') and [Edge](Edge/index.md 'SpatialGraph\.Edge') within it, identified by their IDs\. |
| [IReadOnlyGraphIncomingChanges&lt;TNode&gt;](IReadOnlyGraphIncomingChanges_TNode_/index.md 'SpatialGraph\.IReadOnlyGraphIncomingChanges<TNode>') | Interface for objects which stores incoming changes for a graph\. |
| [IReadOnlyModificationLog&lt;TNode&gt;](IReadOnlyModificationLog_TNode_/index.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>') | Read only log for incoming changes for a [IGraph&lt;TNode&gt;](IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>')\. Stores additional data: type of modification of an [IElement](IElement/index.md 'SpatialGraph\.IElement') (Add, Modify, Delete), old value of an [IElement](IElement/index.md 'SpatialGraph\.IElement') (if any), and new value of an [IElement](IElement/index.md 'SpatialGraph\.IElement') (if any)\. |
| [IReadOnlyTrackedGraph&lt;TNode&gt;](IReadOnlyTrackedGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyTrackedGraph<TNode>') | Read only interface of [ITrackedGraph&lt;TNode&gt;](ITrackedGraph_TNode_/index.md 'SpatialGraph\.ITrackedGraph<TNode>')\. Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements\. |
| [ITrackedGraph&lt;TNode&gt;](ITrackedGraph_TNode_/index.md 'SpatialGraph\.ITrackedGraph<TNode>') | Base interface for all tracked graphs which track changes within it\. A graph stores [INode](INode/index.md 'SpatialGraph\.INode') and [Edge](Edge/index.md 'SpatialGraph\.Edge') within it, identified by their IDs\. Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements\. |

| Enums | |
| :--- | :--- |
| [ElementType](ElementType/index.md 'SpatialGraph\.ElementType') | Enum for classifying [IElement](IElement/index.md 'SpatialGraph\.IElement')\. |
| [ModificationType](ModificationType/index.md 'SpatialGraph\.ModificationType') | Holds type of modification an [IElement](IElement/index.md 'SpatialGraph\.IElement') has\. |
| [NodeInEdge](NodeInEdge/index.md 'SpatialGraph\.NodeInEdge') | An enum for identifying the [INode](INode/index.md 'SpatialGraph\.INode') in the first or second endpoint of an [Edge](Edge/index.md 'SpatialGraph\.Edge')\. |
