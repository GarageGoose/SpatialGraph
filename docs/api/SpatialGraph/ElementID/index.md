## ElementID Struct

Generic [IElement](../IElement/index.md 'SpatialGraph\.IElement') identifier\.

```csharp
public readonly record struct ElementID : System.IEquatable<SpatialGraph.ElementID>
```

Implements [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[ElementID](index.md 'SpatialGraph\.ElementID')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [ElementID(ElementType, uint)](ElementID(ElementType,uint).md 'SpatialGraph\.ElementID\.ElementID(SpatialGraph\.ElementType, uint)') | Generic [IElement](../IElement/index.md 'SpatialGraph\.IElement') identifier\. |

| Properties | |
| :--- | :--- |
| [ID](ID.md 'SpatialGraph\.ElementID\.ID') | ID of the element\. |
| [Type](Type.md 'SpatialGraph\.ElementID\.Type') | Type of element, either Node or Edge\. |
