namespace GG.NodeGraph;

public class Graph<TNode> : IGraph<TNode>, IReadOnlyGraph<TNode>  where TNode : Node
{
    public Graph(){}

    public Graph(IReadOnlyGraph<TNode> Node)
    {
        foreach(TNode NewVertex in Node.GetNodes())
        {
            node[NewVertex.ID] = NewVertex;
        }

        foreach(Edge NewEdge in Node.GetEdges())
        {
            edge[NewEdge.ID] = NewEdge;
        }
    }

    private Dictionary<uint, TNode> node = new();
    private Dictionary<uint, Edge> edge = new();

    public virtual TNode Node(uint ID) => node[ID];
    public bool NodeContainsID(uint ID) => node.ContainsKey(ID);
    public virtual IEnumerable<TNode> GetNodes() => node.Values;
    public virtual void SetNode(TNode Vertex) => node[Vertex.ID] = Vertex;
    public virtual bool RemoveNode(uint ID) => node.Remove(ID);
    public virtual void SetNodes(IEnumerable<TNode> Nodes)
    {
        foreach(TNode Node in Nodes)
        {
            node[Node.ID] = Node;
        }
    }

    public virtual Edge Edge(uint ID) => edge[ID];
    public bool EdgeContainsID(uint ID) => edge.ContainsKey(ID);
    public virtual IEnumerable<Edge> GetEdges() => edge.Values;
    public virtual void SetEdge(Edge Edge) => edge[Edge.ID] = Edge;
    public virtual bool RemoveEdge(uint ID) => edge.Remove(ID);
    public virtual void SetEdges(IEnumerable<Edge> Edges)
    {
        foreach(Edge Edge in Edges)
        {
            edge[Edge.ID] = Edge;
        }
    }
}
