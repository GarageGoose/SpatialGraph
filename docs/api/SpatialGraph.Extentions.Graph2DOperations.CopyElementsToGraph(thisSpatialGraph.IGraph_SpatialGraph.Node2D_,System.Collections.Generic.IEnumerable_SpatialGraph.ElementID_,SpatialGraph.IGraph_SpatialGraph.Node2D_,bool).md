## Graph2DOperations\.CopyElementsToGraph\(this IGraph\<Node2D\>, IEnumerable\<ElementID\>, IGraph\<Node2D\>, bool\) Method

Copy specified elements from one graph to another\.

```csharp
public static void CopyElementsToGraph(this SpatialGraph.IGraph<SpatialGraph.Node2D> copyFrom, System.Collections.Generic.IEnumerable<SpatialGraph.ElementID> elementsToCopy, SpatialGraph.IGraph<SpatialGraph.Node2D> pasteTo, bool preserveID);
```
#### Parameters

<a name='SpatialGraph.Extentions.Graph2DOperations.CopyElementsToGraph(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,System.Collections.Generic.IEnumerable_SpatialGraph.ElementID_,SpatialGraph.IGraph_SpatialGraph.Node2D_,bool).copyFrom'></a>

`copyFrom` [SpatialGraph\.IGraph&lt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')[Node2D](SpatialGraph.Node2D.md 'SpatialGraph\.Node2D')[&gt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')

Source graph to copy from\.

<a name='SpatialGraph.Extentions.Graph2DOperations.CopyElementsToGraph(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,System.Collections.Generic.IEnumerable_SpatialGraph.ElementID_,SpatialGraph.IGraph_SpatialGraph.Node2D_,bool).elementsToCopy'></a>

`elementsToCopy` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[ElementID](SpatialGraph.ElementID.md 'SpatialGraph\.ElementID')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

Elements to copy\.

<a name='SpatialGraph.Extentions.Graph2DOperations.CopyElementsToGraph(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,System.Collections.Generic.IEnumerable_SpatialGraph.ElementID_,SpatialGraph.IGraph_SpatialGraph.Node2D_,bool).pasteTo'></a>

`pasteTo` [SpatialGraph\.IGraph&lt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')[Node2D](SpatialGraph.Node2D.md 'SpatialGraph\.Node2D')[&gt;](SpatialGraph.IGraph_TNode_.md 'SpatialGraph\.IGraph\<TNode\>')

Target graph to paste the elements to\.

<a name='SpatialGraph.Extentions.Graph2DOperations.CopyElementsToGraph(thisSpatialGraph.IGraph_SpatialGraph.Node2D_,System.Collections.Generic.IEnumerable_SpatialGraph.ElementID_,SpatialGraph.IGraph_SpatialGraph.Node2D_,bool).preserveID'></a>

`preserveID` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Preserves the id of the elements from the source graph, do note that elements with same IDs will be replaced with
elements from the target graph\. If false, new ids will be generated for the elements in the target graph\.