namespace GG.NodeGraph;

/// <summary>
/// Read only interface of the graph.
/// </summary>
/// <typeparam name="TNode">Vertices to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public interface IReadOnlyGraph<TNode> where TNode : struct, Node
{
    IReadOnlyDictionary<uint, TNode> Nodes {get;}
    IReadOnlyDictionary<uint, Edge> Edges {get;}
}

public interface IGraph<TNode> : IReadOnlyGraph<TNode> where TNode : struct, Node
{
    void SetNode(TNode Vertex);
    void SetNode(IEnumerable<TNode> Nodes);
    bool RemoveNode(uint ID);
    void RemoveNode(IEnumerable<uint> IDs);

    void SetEdge(Edge Edge);
    void SetEdge(IEnumerable<Edge> Edges);
    bool RemoveEdge(uint ID);
    void RemoveEdge(IEnumerable<uint> IDs);

    uint GenerateID();
}