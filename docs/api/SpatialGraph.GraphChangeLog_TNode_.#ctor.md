## GraphChangeLog\<TNode\> Constructors

| Overloads | |
| :--- | :--- |
| [GraphChangeLog\(IReadOnlyGraph&lt;TNode&gt;\)](SpatialGraph.GraphChangeLog_TNode_.#ctor.md#SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.GraphChangeLog\<TNode\>\.GraphChangeLog\(SpatialGraph\.IReadOnlyGraph\<TNode\>\)') | Create a ChangeLog referencing a graph\. |
| [GraphChangeLog\(IReadOnlyGraph&lt;TNode&gt;, GraphChangeSet&lt;TNode&gt;\)](SpatialGraph.GraphChangeLog_TNode_.#ctor.md#SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_,SpatialGraph.GraphChangeSet_TNode_) 'SpatialGraph\.GraphChangeLog\<TNode\>\.GraphChangeLog\(SpatialGraph\.IReadOnlyGraph\<TNode\>, SpatialGraph\.GraphChangeSet\<TNode\>\)') | Create a ChangeLog referencing a graph with changes from a ChangeSet\. |
| [GraphChangeLog\(IReadOnlyModificationLog&lt;TNode&gt;\)](SpatialGraph.GraphChangeLog_TNode_.#ctor.md#SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyModificationLog_TNode_) 'SpatialGraph\.GraphChangeLog\<TNode\>\.GraphChangeLog\(SpatialGraph\.IReadOnlyModificationLog\<TNode\>\)') | Duplicate a ChangeLog from another ChangeLog\. |

<a name='ctor.md#SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_)'></a>

## GraphChangeLog\(IReadOnlyGraph\<TNode\>\) Constructor

Create a ChangeLog referencing a graph\.

```csharp
public GraphChangeLog(SpatialGraph.IReadOnlyGraph<TNode> baseGraph);
```
#### Parameters

<a name='SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_).baseGraph'></a>

`baseGraph` [SpatialGraph\.IReadOnlyGraph&lt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](SpatialGraph.GraphChangeLog_TNode_.md#SpatialGraph.GraphChangeLog_TNode_.TNode 'SpatialGraph\.GraphChangeLog\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')

Graph to reference the changes from\.

<a name='ctor.md#SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_,SpatialGraph.GraphChangeSet_TNode_)'></a>

## GraphChangeLog\(IReadOnlyGraph\<TNode\>, GraphChangeSet\<TNode\>\) Constructor

Create a ChangeLog referencing a graph with changes from a ChangeSet\.

```csharp
public GraphChangeLog(SpatialGraph.IReadOnlyGraph<TNode> baseGraph, SpatialGraph.GraphChangeSet<TNode> changeSet);
```
#### Parameters

<a name='SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_,SpatialGraph.GraphChangeSet_TNode_).baseGraph'></a>

`baseGraph` [SpatialGraph\.IReadOnlyGraph&lt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')[TNode](SpatialGraph.GraphChangeLog_TNode_.md#SpatialGraph.GraphChangeLog_TNode_.TNode 'SpatialGraph\.GraphChangeLog\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyGraph_TNode_.md 'SpatialGraph\.IReadOnlyGraph\<TNode\>')

Graph to reference the changes from\.

<a name='SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_,SpatialGraph.GraphChangeSet_TNode_).changeSet'></a>

`changeSet` [SpatialGraph\.GraphChangeSet&lt;](SpatialGraph.GraphChangeSet_TNode_.md 'SpatialGraph\.GraphChangeSet\<TNode\>')[TNode](SpatialGraph.GraphChangeLog_TNode_.md#SpatialGraph.GraphChangeLog_TNode_.TNode 'SpatialGraph\.GraphChangeLog\<TNode\>\.TNode')[&gt;](SpatialGraph.GraphChangeSet_TNode_.md 'SpatialGraph\.GraphChangeSet\<TNode\>')

Set of changes to log\.

<a name='ctor.md#SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyModificationLog_TNode_)'></a>

## GraphChangeLog\(IReadOnlyModificationLog\<TNode\>\) Constructor

Duplicate a ChangeLog from another ChangeLog\.

```csharp
public GraphChangeLog(SpatialGraph.IReadOnlyModificationLog<TNode> baseGraph);
```
#### Parameters

<a name='SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyModificationLog_TNode_).baseGraph'></a>

`baseGraph` [SpatialGraph\.IReadOnlyModificationLog&lt;](SpatialGraph.IReadOnlyModificationLog_TNode_.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>')[TNode](SpatialGraph.GraphChangeLog_TNode_.md#SpatialGraph.GraphChangeLog_TNode_.TNode 'SpatialGraph\.GraphChangeLog\<TNode\>\.TNode')[&gt;](SpatialGraph.IReadOnlyModificationLog_TNode_.md 'SpatialGraph\.IReadOnlyModificationLog\<TNode\>')

ChangeLog to duplicate from\.