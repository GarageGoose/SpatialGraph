## ElementModified\(TElement, TElement, uint\) Constructor

Single log of an element which is modified\. Used in a ModificationLog\.

```csharp
public ElementModified(TElement NewElement, TElement OldElement, uint ID);
```
#### Parameters

<a name='SpatialGraph.ElementModified_TElement_.ElementModified(TElement,TElement,uint).NewElement'></a>

`NewElement` [TElement](SpatialGraph.ElementModified_TElement_.md#SpatialGraph.ElementModified_TElement_.TElement 'SpatialGraph\.ElementModified\<TElement\>\.TElement')

The new value of the element after it was modified\.

<a name='SpatialGraph.ElementModified_TElement_.ElementModified(TElement,TElement,uint).OldElement'></a>

`OldElement` [TElement](SpatialGraph.ElementModified_TElement_.md#SpatialGraph.ElementModified_TElement_.TElement 'SpatialGraph\.ElementModified\<TElement\>\.TElement')

The old value of the element before it was modified\.

<a name='SpatialGraph.ElementModified_TElement_.ElementModified(TElement,TElement,uint).ID'></a>

`ID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

Identifier of the element\.