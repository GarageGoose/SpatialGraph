## ElementModified(TElement, TElement, uint) Constructor

Log of an [IElement](../IElement/index.md 'SpatialGraph\.IElement') which is modified\. Used in a [GraphChangeLog&lt;TNode&gt;](../GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog<TNode>')\.

```csharp
public ElementModified(TElement NewElement, TElement OldElement, uint ID);
```
#### Parameters

<a name='SpatialGraph.ElementModified_TElement_.ElementModified(TElement,TElement,uint).NewElement'></a>

`NewElement` [TElement](index.md#SpatialGraph.ElementModified_TElement_.TElement 'SpatialGraph\.ElementModified<TElement>\.TElement')

The new value of the element after it was modified\.

<a name='SpatialGraph.ElementModified_TElement_.ElementModified(TElement,TElement,uint).OldElement'></a>

`OldElement` [TElement](index.md#SpatialGraph.ElementModified_TElement_.TElement 'SpatialGraph\.ElementModified<TElement>\.TElement')

The old value of the element before it was modified\.

<a name='SpatialGraph.ElementModified_TElement_.ElementModified(TElement,TElement,uint).ID'></a>

`ID` [System\.UInt32](https://learn.microsoft.com/en-us/dotnet/api/system.uint32 'System\.UInt32')

Identifier of the element\.