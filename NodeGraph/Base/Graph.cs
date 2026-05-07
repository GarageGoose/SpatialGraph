namespace GG.NodeGraph;

/// <summary>
/// Base class for graphs.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph .</typeparam>
public class Graph<TNode> : IGraph<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Start an empty graph.
    /// </summary>
    public Graph()
    {
        Nodes = node;
        Edges = edge;
    }

    /// <summary>
    /// Start graph from a pre-exisitng graph.
    /// </summary>
    /// <param name="graph">Graph to replicate from.</param>
    public Graph(IReadOnlyGraph<TNode> graph)
    {
        Nodes = node;
        node = new(graph.Nodes);
        Edges = edge;
        edge = new(graph.Edges);

    }

    /// <summary>
    /// Start a graph from pre-exisiting dictionaries of nodes and edges.
    /// </summary>
    public Graph(Dictionary<uint, TNode> nodes, Dictionary<uint, Edge> edges)
    {
        node = new(nodes);
        Nodes = node;
        edge = new(edges);
        Edges = edge;
    }

    private Dictionary<uint, TNode> node = new();
    public IReadOnlyDictionary<uint, TNode> Nodes {get;}

    private Dictionary<uint, Edge> edge = new();
    public IReadOnlyDictionary<uint, Edge> Edges {get;}

    /// <summary>
    /// Add or replace a node with the same ID.
    /// </summary>
    /// <param name="Vertex">Node to add.</param>
    public virtual void SetNode(TNode Vertex) => node[Vertex.ID] = Vertex;

    /// <summary>
    /// Remove a node using its ID. Do note that edges connected to a node that is removed isn't autmatically removed.
    /// </summary>
    /// <param name="ID">ID of the node to remove.</param>
    /// <returns>True if the node was successfully removed, otherwise return False.</returns>
    public virtual bool RemoveNode(uint ID) => node.Remove(ID);

    /// <summary>
    /// Add or replace multiple nodes with the same ID.
    /// </summary>
    /// <param name="Nodes">Nodes to add.</param>
    public virtual void SetNode(IEnumerable<TNode> Nodes)
    {
        foreach(TNode Node in Nodes)
        {
            node[Node.ID] = Node;
        }
    }

    /// <summary>
    /// Remove multiple nodes using their IDs. Do note that edges connected to a node that is removed isn't autmatically removed.
    /// </summary>
    /// <param name="IDs">IDs of the nodes to remove.</param>
    public virtual void RemoveNode(IEnumerable<uint> IDs)
    {
        foreach(uint ID in IDs)
        {
            node.Remove(ID);
        }
    }

    /// <summary>
    /// Add or replace an edge with the same ID.
    /// </summary>
    /// <param name="Edge">Edge to add.</param>
    public virtual void SetEdge(Edge Edge) => edge[Edge.ID] = Edge;

    /// <summary>
    /// Remove an edge using its ID.
    /// </summary>
    /// <param name="ID">ID of the edge to remove.</param>
    /// <returns></returns>
    public virtual bool RemoveEdge(uint ID) => edge.Remove(ID);

    /// <summary>
    /// Add or replace multiple edge with the same IDs.
    /// </summary>
    /// <param name="Edges">Edges to add.</param>
    public virtual void SetEdge(IEnumerable<Edge> Edges)
    {
        foreach(Edge Edge in Edges)
        {
            edge[Edge.ID] = Edge;
        }
    }

    /// <summary>
    /// Remove multiple edges with the target IDs.
    /// </summary>
    /// <param name="IDs">IDs of the edges to remove.</param>
    public virtual void RemoveEdge(IEnumerable<uint> IDs)
    {
        foreach(uint ID in IDs)
        {
            edge.Remove(ID);
        }
    }

    //This should work under normal scenario unless accessed 2^32 times which is kinda extreme tbh
    uint currID = 0;
    public uint GenerateID() => currID++;
}
