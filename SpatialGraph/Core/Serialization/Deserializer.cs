namespace GG.SpatialGraph.Serializable;

public static class DeserializeGraph
{
    public static DeserializedGraph<TGraph, TNode> Deserialize<TGraph, TNode>() where TNode : struct, INode where TGraph : IGraph<TNode>
    {
        return new();
    }
}

public readonly record struct DeserializedGraph<TGraph, TNode>(TGraph Graph, object[] Plugins) where TNode : struct, INode where TGraph : IGraph<TNode>;