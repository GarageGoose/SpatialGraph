## ElementModified<TElement> Struct

Log of an [IElement](../IElement/index.md 'SpatialGraph\.IElement') which is modified\. Used in a [GraphChangeLog&lt;TNode&gt;](../GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog<TNode>')\.

```csharp
public readonly record struct ElementModified<TElement> : System.IEquatable<SpatialGraph.ElementModified<TElement>>
    where TElement : struct
```
#### Type parameters

<a name='SpatialGraph.ElementModified_TElement_.TElement'></a>

`TElement`

Type of an element which is modified\. Typically an edge or a type of node\.

Implements [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[SpatialGraph\.ElementModified&lt;](index.md 'SpatialGraph\.ElementModified<TElement>')[TElement](index.md#SpatialGraph.ElementModified_TElement_.TElement 'SpatialGraph\.ElementModified<TElement>\.TElement')[&gt;](index.md 'SpatialGraph\.ElementModified<TElement>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [ElementModified(TElement, TElement, uint)](ElementModified(TElement,TElement,uint).md 'SpatialGraph\.ElementModified<TElement>\.ElementModified(TElement, TElement, uint)') | Log of an [IElement](../IElement/index.md 'SpatialGraph\.IElement') which is modified\. Used in a [GraphChangeLog&lt;TNode&gt;](../GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog<TNode>')\. |

| Properties | |
| :--- | :--- |
| [ID](ID.md 'SpatialGraph\.ElementModified<TElement>\.ID') | Identifier of the element\. |
| [NewElement](NewElement.md 'SpatialGraph\.ElementModified<TElement>\.NewElement') | The new value of the element after it was modified\. |
| [OldElement](OldElement.md 'SpatialGraph\.ElementModified<TElement>\.OldElement') | The old value of the element before it was modified\. |
