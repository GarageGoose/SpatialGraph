## ElementModified\<TElement\> Struct

Single log of an element which is modified\. Used in a ModificationLog\.

```csharp
public readonly record struct ElementModified<TElement> : System.IEquatable<SpatialGraph.ElementModified<TElement>>
    where TElement : struct
```
#### Type parameters

<a name='SpatialGraph.ElementModified_TElement_.TElement'></a>

`TElement`

Type of an element which is modified\. Typically an edge or a type of node\.

Implements [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[SpatialGraph\.ElementModified&lt;](SpatialGraph.ElementModified_TElement_.md 'SpatialGraph\.ElementModified\<TElement\>')[TElement](SpatialGraph.ElementModified_TElement_.md#SpatialGraph.ElementModified_TElement_.TElement 'SpatialGraph\.ElementModified\<TElement\>\.TElement')[&gt;](SpatialGraph.ElementModified_TElement_.md 'SpatialGraph\.ElementModified\<TElement\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [ElementModified\(TElement, TElement, uint\)](SpatialGraph.ElementModified_TElement_.ElementModified(TElement,TElement,uint).md 'SpatialGraph\.ElementModified\<TElement\>\.ElementModified\(TElement, TElement, uint\)') | Single log of an element which is modified\. Used in a ModificationLog\. |

| Properties | |
| :--- | :--- |
| [ID](SpatialGraph.ElementModified_TElement_.ID.md 'SpatialGraph\.ElementModified\<TElement\>\.ID') | Identifier of the element\. |
| [NewElement](SpatialGraph.ElementModified_TElement_.NewElement.md 'SpatialGraph\.ElementModified\<TElement\>\.NewElement') | The new value of the element after it was modified\. |
| [OldElement](SpatialGraph.ElementModified_TElement_.OldElement.md 'SpatialGraph\.ElementModified\<TElement\>\.OldElement') | The old value of the element before it was modified\. |
