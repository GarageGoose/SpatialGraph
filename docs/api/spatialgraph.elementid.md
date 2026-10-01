## ElementID Struct

Generic element identifier\.

```csharp
public readonly record struct ElementID : System.IEquatable<SpatialGraph.ElementID>
```

Implements [System\.IEquatable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')[ElementID](SpatialGraph.ElementID.md 'SpatialGraph\.ElementID')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.iequatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [ElementID\(ElementType, uint\)](SpatialGraph.ElementID.ElementID(SpatialGraph.ElementType,uint).md 'SpatialGraph\.ElementID\.ElementID\(SpatialGraph\.ElementType, uint\)') | Generic element identifier\. |

| Properties | |
| :--- | :--- |
| [ID](SpatialGraph.ElementID.ID.md 'SpatialGraph\.ElementID\.ID') | ID of the element\. |
| [Type](SpatialGraph.ElementID.Type.md 'SpatialGraph\.ElementID\.Type') | Type of element, either Node or Edge\. |
