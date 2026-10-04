## GraphChangeLog<TNode> Constructors

| Overloads | |
| :--- | :--- |
| [GraphChangeLog(IReadOnlyGraph&lt;TNode&gt;)](GraphChangeLog_TNode_.md#SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_) 'SpatialGraph\.GraphChangeLog<TNode>\.GraphChangeLog(SpatialGraph\.IReadOnlyGraph<TNode>)') | Create a ChangeLog referencing a graph\. |
| [GraphChangeLog(IReadOnlyGraph&lt;TNode&gt;, GraphChangeSet&lt;TNode&gt;)](GraphChangeLog_TNode_.md#SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_,SpatialGraph.GraphChangeSet_TNode_) 'SpatialGraph\.GraphChangeLog<TNode>\.GraphChangeLog(SpatialGraph\.IReadOnlyGraph<TNode>, SpatialGraph\.GraphChangeSet<TNode>)') | Create a ChangeLog referencing a [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') with changes from a [GraphChangeSet&lt;TNode&gt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')\. |
| [GraphChangeLog(IReadOnlyModificationLog&lt;TNode&gt;)](GraphChangeLog_TNode_.md#SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyModificationLog_TNode_) 'SpatialGraph\.GraphChangeLog<TNode>\.GraphChangeLog(SpatialGraph\.IReadOnlyModificationLog<TNode>)') | Duplicate a ChangeLog from another ChangeLog\. |

<a name='SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_)'></a>

## GraphChangeLog(IReadOnlyGraph<TNode>) Constructor

Create a ChangeLog referencing a graph\.

```csharp
public GraphChangeLog(SpatialGraph.IReadOnlyGraph<TNode> baseGraph);
```
#### Parameters

<a name='SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_).baseGraph'></a>

`baseGraph` [SpatialGraph\.IReadOnlyGraph&lt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[TNode](index.md#SpatialGraph.GraphChangeLog_TNode_.TNode 'SpatialGraph\.GraphChangeLog<TNode>\.TNode')[&gt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')

Graph to reference the changes from\.

<a name='SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_,SpatialGraph.GraphChangeSet_TNode_)'></a>

## GraphChangeLog(IReadOnlyGraph<TNode>, GraphChangeSet<TNode>) Constructor

Create a ChangeLog referencing a [IGraph&lt;TNode&gt;](../IGraph_TNode_/index.md 'SpatialGraph\.IGraph<TNode>') with changes from a [GraphChangeSet&lt;TNode&gt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')\.

```csharp
public GraphChangeLog(SpatialGraph.IReadOnlyGraph<TNode> baseGraph, SpatialGraph.GraphChangeSet<TNode> changeSet);
```
#### Parameters

<a name='SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_,SpatialGraph.GraphChangeSet_TNode_).baseGraph'></a>

`baseGraph` [SpatialGraph\.IReadOnlyGraph&lt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')[TNode](index.md#SpatialGraph.GraphChangeLog_TNode_.TNode 'SpatialGraph\.GraphChangeLog<TNode>\.TNode')[&gt;](../IReadOnlyGraph_TNode_/index.md 'SpatialGraph\.IReadOnlyGraph<TNode>')

Graph to reference the changes from\.

<a name='SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyGraph_TNode_,SpatialGraph.GraphChangeSet_TNode_).changeSet'></a>

`changeSet` [SpatialGraph\.GraphChangeSet&lt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')[TNode](index.md#SpatialGraph.GraphChangeLog_TNode_.TNode 'SpatialGraph\.GraphChangeLog<TNode>\.TNode')[&gt;](../GraphChangeSet_TNode_/index.md 'SpatialGraph\.GraphChangeSet<TNode>')

Set of changes to log\.

<a name='SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyModificationLog_TNode_)'></a>

## GraphChangeLog(IReadOnlyModificationLog<TNode>) Constructor

Duplicate a ChangeLog from another ChangeLog\.

```csharp
public GraphChangeLog(SpatialGraph.IReadOnlyModificationLog<TNode> baseGraph);
```
#### Parameters

<a name='SpatialGraph.GraphChangeLog_TNode_.GraphChangeLog(SpatialGraph.IReadOnlyModificationLog_TNode_).baseGraph'></a>

`baseGraph` [SpatialGraph\.IReadOnlyModificationLog&lt;](../IReadOnlyModificationLog_TNode_/index.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>')[TNode](index.md#SpatialGraph.GraphChangeLog_TNode_.TNode 'SpatialGraph\.GraphChangeLog<TNode>\.TNode')[&gt;](../IReadOnlyModificationLog_TNode_/index.md 'SpatialGraph\.IReadOnlyModificationLog<TNode>')

ChangeLog to duplicate from\.