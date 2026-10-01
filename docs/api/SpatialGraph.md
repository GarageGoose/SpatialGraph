## SpatialGraph Namespace

| Classes | |
| :--- | :--- |
| [Graph&lt;TNode&gt;](SpatialGraph.Graph_TNode_.md 'SpatialGraph\.Graph\<TNode\>') | Base class for graphs, can be built upon\. |
| [GraphChangeLog&lt;TNode&gt;](SpatialGraph.GraphChangeLog_TNode_.md 'SpatialGraph\.GraphChangeLog\<TNode\>') | Logs incoming changes for a graph\. Stores additional data: type of modification of an element \(Add, Modify, Delete\), old value of an element \(if any\), and new value of an element \(if any\)\. |
| [GraphIncomingChanges&lt;TNode&gt;](SpatialGraph.GraphIncomingChanges_TNode_.md 'SpatialGraph\.GraphIncomingChanges\<TNode\>') | Stores incoming changes for a graph\. |
| [InterceptableTrackedGraph&lt;TNode&gt;](SpatialGraph.InterceptableTrackedGraph_TNode_.md 'SpatialGraph\.InterceptableTrackedGraph\<TNode\>') | Graph which tracks and can modifiy incoming changes within it\. |
| [TrackedGraph&lt;TNode&gt;](SpatialGraph.TrackedGraph_TNode_.md 'SpatialGraph\.TrackedGraph\<TNode\>') | Graph which tracks changes within it\. |

| Structs | |
| :--- | :--- |
| [Edge](SpatialGraph.Edge.md 'SpatialGraph\.Edge') | A line segment which is formed from 2 nodes\. |
| [ElementAdded&lt;TElement&gt;](SpatialGraph.ElementAdded_TElement_.md 'SpatialGraph\.ElementAdded\<TElement\>') | Single log of an element which is added\. Used in a ModificationLog\. |
| [ElementID](SpatialGraph.ElementID.md 'SpatialGraph\.ElementID') | Generic element identifier\. |
| [ElementModified&lt;TElement&gt;](SpatialGraph.ElementModified_TElement_.md 'SpatialGraph\.ElementModified\<TElement\>') | Single log of an element which is modified\. Used in a ModificationLog\. |
| [ElementRemoved&lt;TElement&gt;](SpatialGraph.ElementRemoved_TElement_.md 'SpatialGraph\.ElementRemoved\<TElement\>') | Single log of an element which is removed\. Used in a ModificationLog\. |
| [Node2D](SpatialGraph.Node2D.md 'SpatialGraph\.Node2D') | Node with coordinate in 2 dimensions\. Used for 2D graphs\. |
| [Node3D](SpatialGraph.Node3D.md 'SpatialGraph\.Node3D') | Node with coordinate in 3 dimensions\. Used for 3D graphs\. |

| Interfaces | |
| :--- | :--- |
| [GraphChangeSet&lt;TNode&gt;](SpatialGraph.GraphChangeSet_TNode_.md 'SpatialGraph\.GraphChangeSet\<TNode\>') | Set of changes in a graph\. |
| [IElement](SpatialGraph.IElement.md 'SpatialGraph\.IElement') | Base interface for all elements\. |
| [IGraph&lt;TNode&gt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>') | Base interface for all graphs\. A graph stores nodes and edges within it, identified by their IDs\. Nodes and edges can share the same ID\. |
| [IInterceptableTrackedGraph&lt;TNode&gt;](SpatialGraph.IInterceptableTrackedGraph_TNode_.md 'SpatialGraph\.IInterceptableTrackedGraph\<TNode\>') | Base interface for all tracked graphs which can modifiy incoming changes\. A graph stores nodes and edges within it, identified by their IDs\. Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements\. |
| [INode](SpatialGraph.INode.md 'SpatialGraph\.INode') | Base interface for all nodes\. |
| [IReadOnlyGraph&lt;TNode&gt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>') | Read only interface of a graph\. A graph stores nodes and edges within it, identified by their IDs\. |
| [IReadOnlyGraphIncomingChanges&lt;TNode&gt;](SpatialGraph.IReadOnlyGraphIncomingChanges_TNode_.md 'SpatialGraph\.IReadOnlyGraphIncomingChanges\<TNode\>') | Interface for objects which stores incoming changes for a graph\. |
| [IReadOnlyModificationLog&lt;TNode&gt;](SpatialGraph.IReadOnlyModificationLog_TNode_.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>') | Logs incoming changes for a graph\. Stores additional data: type of modification of an element \(Add, Modify, Delete\), old value of an element \(if any\), and new value of an element \(if any\)\. |
| [IReadOnlyQuadTreeNodeCell](SpatialGraph.IReadOnlyQuadTreeNodeCell.md 'SpatialGraph\.IReadOnlyQuadTreeNodeCell') | A specific region in a quadtree which holds nodes or if subdivided, four sub quad trees each on the of the quadrant of the quadtree\. |
| [IReadOnlyTrackedGraph&lt;TNode&gt;](SpatialGraph.IReadOnlyTrackedGraph_TNode_.md 'SpatialGraph\.IReadOnlyTrackedGraph\<TNode\>') | Read only interface of a tracked graph\. Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements\. |
| [ITrackedGraph&lt;TNode&gt;](SpatialGraph.ITrackedGraph_TNode_.md 'SpatialGraph\.ITrackedGraph\<TNode\>') | Base interface for all tracked graphs\. A graph stores nodes and edges within it, identified by their IDs\. Tracked graphs returns read only modification logs when it is modified by adding, modifying, and removing any of its elements\. |

| Enums | |
| :--- | :--- |
| [ElementType](SpatialGraph.ElementType.md 'SpatialGraph\.ElementType') | Enum for classifying elements\. |
| [ModificationType](SpatialGraph.ModificationType.md 'SpatialGraph\.ModificationType') | Holds type of modification each element has\. |
| [NodeInEdge](SpatialGraph.NodeInEdge.md 'SpatialGraph\.NodeInEdge') | An enum for identifying the first or second node in a Edge\. |
