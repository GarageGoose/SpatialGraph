## ElementAdded\<TElement\> Struct

Single log of an element which is added\. Used in a ModificationLog\.

```csharp
public readonly record struct ElementAdded<TElement> : System.IEquatable<SpatialGraph.ElementAdded<TElement>>
    where TElement : struct
```
#### Type parameters

<a name='SpatialGraph.ElementAdded_TElement_.TElement'></a>

`TElement`

Type of an element which is/will be added\. Typically an edge or a type of node\.

Implements [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[SpatialGraph\.ElementAdded&lt;](SpatialGraph.ElementAdded_TElement_.md 'SpatialGraph\.ElementAdded\<TElement\>')[TElement](SpatialGraph.ElementAdded_TElement_.md#SpatialGraph.ElementAdded_TElement_.TElement 'SpatialGraph\.ElementAdded\<TElement\>\.TElement')[&gt;](SpatialGraph.ElementAdded_TElement_.md 'SpatialGraph\.ElementAdded\<TElement\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [ElementAdded\(TElement, uint\)](SpatialGraph.ElementAdded_TElement_.ElementAdded(TElement,uint).md 'SpatialGraph\.ElementAdded\<TElement\>\.ElementAdded\(TElement, uint\)') | Single log of an element which is added\. Used in a ModificationLog\. |

| Properties | |
| :--- | :--- |
| [Element](SpatialGraph.ElementAdded_TElement_.Element.md 'SpatialGraph\.ElementAdded\<TElement\>\.Element') | Value of an element which is/will be added\. |
| [ID](SpatialGraph.ElementAdded_TElement_.ID.md 'SpatialGraph\.ElementAdded\<TElement\>\.ID') | Identifier of the element\. |
