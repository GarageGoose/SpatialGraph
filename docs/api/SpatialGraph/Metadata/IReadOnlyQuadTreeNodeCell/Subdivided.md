## IReadOnlyQuadTreeNodeCell\.Subdivided Property

Indicated if a cell is subdivided\.
Subdivided cells contains four child cells on each of its quadrant\.
Note that Child cells are created lazily when a node is inserted into that quadrant\.
Else it contains nodes in it\.

```csharp
bool Subdivided { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')