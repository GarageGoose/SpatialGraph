namespace SpatialGraph;

/// <summary>
/// Base class for graphs, can be built upon. A graph stores <see cref="INode"/> and <see cref="Edge"/> within it, identified by their IDs.
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
    /// Start graph from a pre-existing graph.
    /// </summary>
    /// <param name="graph">Graph to replicate from.</param>
    public Graph(IReadOnlyGraph<TNode> graph)
    {
        _Nodes = new(graph.Nodes);
        _Edges = new(graph.Edges);
    }

    /// <summary>
    /// Start a graph from pre-existing dictionaries of nodes and edges.
    /// </summary>
    public Graph(Dictionary<uint, TNode> nodes, Dictionary<uint, Edge> edges)
    {
        _Nodes = new(nodes);
        _Edges = new(edges);
    }

    /// <summary>
    /// Writable dictionary for nodes in the graph.
    /// </summary>
    protected Dictionary<uint, TNode> _Nodes = new();

    /// <inheritdoc/>
    public IReadOnlyDictionary<uint, TNode> Nodes => _Nodes;


    /// <summary>
    /// Writable dictionary for edges in the graph.
    /// </summary>
    protected Dictionary<uint, Edge> _Edges = new();

    /// <inheritdoc/>
    public IReadOnlyDictionary<uint, Edge> Edges => _Edges;

    /// <inheritdoc/>
    public virtual void UpsertNode(TNode Node) => _Nodes[Node.ID] = Node;
    
    /// <inheritdoc/>
    public virtual bool RemoveNode(uint ID) => _Nodes.Remove(ID);

    /// <inheritdoc/>
    public virtual void UpsertEdge(Edge Edge) => _Edges[Edge.ID] = Edge;

    /// <inheritdoc/>
    public virtual bool RemoveEdge(uint ID) => _Edges.Remove(ID);

    /// <inheritdoc/>
    public virtual void ApplyChangeSet(GraphChangeSet<TNode> mods)
    {
        foreach(TNode node in mods.NodeUpserts())
        {
            _Nodes[node.ID] = node;
        }
        
        foreach(Edge edge in mods.EdgeUpserts())
        {
            _Edges[edge.ID] = edge;
        }

        foreach(uint nodeID in mods.NodeRemovals())
        {
            _Nodes.Remove(nodeID);
        }

        foreach(uint edgeID in mods.EdgeRemovals())
        {
            _Edges.Remove(edgeID);
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