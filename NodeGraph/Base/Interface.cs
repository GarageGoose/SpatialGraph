namespace GG.NodeGraph;

public interface IGraph<TNode> where TNode : Node
{
    TNode Node(uint ID);
    bool NodeContainsID(uint ID);
    IEnumerable<TNode> GetNodes();
    void SetNode(TNode Vertex);
    void SetNodes(IEnumerable<TNode> Vertices);
    bool RemoveNode(uint ID);

    Edge Edge(uint ID);
    bool EdgeContainsID(uint ID);
    IEnumerable<Edge> GetEdges();
    void SetEdge(Edge Edge);
    void SetEdges(IEnumerable<Edge> Edge);
    bool RemoveEdge(uint ID);
}

public interface IReadOnlyGraph<TNode> where TNode : Node
{
    TNode Node(uint ID);
    bool NodeContainsID(uint ID);
    IEnumerable<TNode> GetNodes();

    Edge Edge(uint ID);
    bool EdgeContainsID(uint ID);
    IEnumerable<Edge> GetEdges();
}