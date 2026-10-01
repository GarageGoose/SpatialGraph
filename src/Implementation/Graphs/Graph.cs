namespace SpatialGraph;

/// <summary>
/// Base class for graphs, can be built upon.
/// </summary>
/// <typeparam name="TNode">Type of node to be used in the graph.</typeparam>
public class Graph<TNode> : IGraph<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Start an empty graph.
    /// </summary>
    public Graph()
    {
    }

    /// <summary>
    /// Start graph from a pre-exisitng graph.
    /// </summary>
    /// <param name="graph">Graph to replicate from.</param>
    public Graph(IReadOnlyGraph<TNode> graph)
    {
        nodes = new(graph.Nodes);
        edges = new(graph.Edges);
    }

    /// <summary>
    /// Start a graph from pre-exisiting dictionaries of nodes and edges.
    /// </summary>
    public Graph(Dictionary<uint, TNode> nodes, Dictionary<uint, Edge> edges)
    {
        this.nodes = new(nodes);
        this.edges = new(edges);
    }

    /// <summary>
    /// Writable dictionary for nodes in the graph.
    /// </summary>
    protected Dictionary<uint, TNode> nodes = new();

    /// <inheritdoc/>
    public IReadOnlyDictionary<uint, TNode> Nodes => nodes;


    /// <summary>
    /// Writable dictionary for edges in the graph.
    /// </summary>
    protected Dictionary<uint, Edge> edges = new();

    /// <inheritdoc/>
    public IReadOnlyDictionary<uint, Edge> Edges => edges;

    /// <inheritdoc/>
    public virtual void UpsertNode(TNode Node) => nodes[Node.ID] = Node;
    
    /// <inheritdoc/>
    public virtual bool RemoveNode(uint ID) => nodes.Remove(ID);

    /// <inheritdoc/>
    public virtual void UpsertEdge(Edge Edge) => edges[Edge.ID] = Edge;

    /// <inheritdoc/>
    public virtual bool RemoveEdge(uint ID) => edges.Remove(ID);

    /// <inheritdoc/>
    public virtual void ApplyChangeSet(GraphChangeSet<TNode> mods)
    {
        foreach(TNode node in mods.NodeUpserts())
        {
            nodes[node.ID] = node;
        }
        
        foreach(Edge edge in mods.EdgeUpserts())
        {
            edges[edge.ID] = edge;
        }

        foreach(uint nodeID in mods.NodeRemovals())
        {
            nodes.Remove(nodeID);
        }

        foreach(uint edgeID in mods.EdgeRemovals())
        {
            edges.Remove(edgeID);
        }
    }

    uint currID = 0;

    /// <inheritdoc/>
    public virtual uint GenerateID()
    {
        currID++;
        while(Nodes.ContainsKey(currID) || Edges.ContainsKey(currID))
        {
            currID++;
        }
        return currID;
    }
}