## ElementRemoved\<TElement\> Struct

Single log of an element which is removed\. Used in a ModificationLog\.

```csharp
public readonly record struct ElementRemoved<TElement> : System.IEquatable<SpatialGraph.ElementRemoved<TElement>>
    where TElement : struct
```
#### Type parameters

<a name='SpatialGraph.ElementRemoved_TElement_.TElement'></a>

`TElement`

Type of an element which is/will be removed\. Typically an edge or a type of node\.

Implements [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[SpatialGraph\.ElementRemoved&lt;](index.md 'SpatialGraph\.ElementRemoved\<TElement\>')[TElement](index.md#SpatialGraph.ElementRemoved_TElement_.TElement 'SpatialGraph\.ElementRemoved\<TElement\>\.TElement')[&gt;](index.md 'SpatialGraph\.ElementRemoved\<TElement\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [ElementRemoved\(TElement, uint\)](ElementRemoved(TElement,uint).md 'SpatialGraph\.ElementRemoved\<TElement\>\.ElementRemoved\(TElement, uint\)') | Single log of an element which is removed\. Used in a ModificationLog\. |

| Properties | |
| :--- | :--- |
| [Element](Element.md 'SpatialGraph\.ElementRemoved\<TElement\>\.Element') | Value of an element which is/will be removed\. |
| [ID](ID.md 'SpatialGraph\.ElementRemoved\<TElement\>\.ID') | Identifier of the element\. |
