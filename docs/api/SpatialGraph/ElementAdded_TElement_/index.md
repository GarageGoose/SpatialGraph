## ElementAdded<TElement> Struct

Log of an [IElement](../IElement/index.md 'SpatialGraph\.IElement') which is added\. Used in a [GraphChangeLog&lt;TNode&gt;](../GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog<TNode>')\.

```csharp
public readonly record struct ElementAdded<TElement> : System.IEquatable<SpatialGraph.ElementAdded<TElement>>
    where TElement : struct
```
#### Type parameters

<a name='SpatialGraph.ElementAdded_TElement_.TElement'></a>

`TElement`

Type of an element which is/will be added\. Typically an edge or a type of node\.

Implements [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[SpatialGraph\.ElementAdded&lt;](index.md 'SpatialGraph\.ElementAdded<TElement>')[TElement](index.md#SpatialGraph.ElementAdded_TElement_.TElement 'SpatialGraph\.ElementAdded<TElement>\.TElement')[&gt;](index.md 'SpatialGraph\.ElementAdded<TElement>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [ElementAdded(TElement, uint)](ElementAdded(TElement,uint).md 'SpatialGraph\.ElementAdded<TElement>\.ElementAdded(TElement, uint)') | Log of an [IElement](../IElement/index.md 'SpatialGraph\.IElement') which is added\. Used in a [GraphChangeLog&lt;TNode&gt;](../GraphChangeLog_TNode_/index.md 'SpatialGraph\.GraphChangeLog<TNode>')\. |

| Properties | |
| :--- | :--- |
| [Element](Element.md 'SpatialGraph\.ElementAdded<TElement>\.Element') | Value of an element which is/will be added\. |
| [ID](ID.md 'SpatialGraph\.ElementAdded<TElement>\.ID') | Identifier of the element\. |
