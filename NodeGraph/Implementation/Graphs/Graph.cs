namespace GG.NodeGraph;

/// <summary>
/// Base class for graphs, can be built upon.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class Graph<TNode> : IGraph<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Start an empty graph.
    /// </summary>
    public Graph()
    {
        Nodes = nodes;
        Edges = edges;
    }

    /// <summary>
    /// Start graph from a pre-exisitng graph.
    /// </summary>
    /// <param name="graph">Graph to replicate from.</param>
    public Graph(IReadOnlyGraph<TNode> graph)
    {
        nodes = new(graph.Nodes);
        Nodes = nodes;
        edges = new(graph.Edges);
        Edges = edges;
    }

    /// <summary>
    /// Start a graph from pre-exisiting dictionaries of nodes and edges.
    /// </summary>
    public Graph(Dictionary<uint, TNode> nodes, Dictionary<uint, Edge> edges)
    {
        this.nodes = new(nodes);
        Nodes = this.nodes;
        this.edges = new(edges);
        Edges = this.edges;
    }

    protected Dictionary<uint, TNode> nodes = new();
    public IReadOnlyDictionary<uint, TNode> Nodes {get;}

    protected Dictionary<uint, Edge> edges = new();
    public IReadOnlyDictionary<uint, Edge> Edges {get;}

    /// <summary>
    /// Add or replace multiple nodes with the same ID.
    /// </summary>
    /// <param name="Nodes">Nodes to add.</param>
    public virtual void UpsertNode(TNode Node) => nodes[Node.ID] = Node;

    /// <summary>
    /// Remove multiple nodes using their IDs. Do note that edges connected to a node that is removed isn't autmatically removed.
    /// </summary>
    /// <param name="IDs">IDs of the nodes to remove.</param>
    public virtual bool RemoveNode(uint ID) => nodes.Remove(ID);

    /// <summary>
    /// Add or replace multiple edge with the same IDs.
    /// </summary>
    /// <param name="Edges">Edges to add.</param>
    public virtual void UpsertEdge(Edge Edge) => edges[Edge.ID] = Edge;

    /// <summary>
    /// Remove multiple edges with the target IDs.
    /// </summary>
    /// <param name="IDs">IDs of the edges to remove.</param>
    public virtual bool RemoveEdge(uint ID) => edges.Remove(ID);

    public virtual void ApplyBatchedModifications(BatchedModifications<TNode> modifications)
    {
        ElementModificationsByType<TNode> nodeMods = modifications.SortedNodeModifications();
        ElementModificationsByType<Edge> edgeMods = modifications.SortedEdgeModifications();

        foreach(TNode node in nodeMods.Upsert)
        {
            nodes[node.ID] = node;
        }
        
        foreach(Edge edge in edgeMods.Upsert)
        {
            edges[edge.ID] = edge;
        }

        foreach(uint nodeID in nodeMods.Removal)
        {
            nodes.Remove(nodeID);
        }

        foreach(uint edgeID in edgeMods.Removal)
        {
            edges.Remove(edgeID);
        }
    }

    uint currID = 0;
    /// <summary>
    /// Generate IDs without duplication. Do note that it should be used with this graph only and not for other graphs as duplicates may occur.
    /// </summary>
    public virtual uint GenerateID(out uint ID)
    {
        currID++;
        while(Nodes.ContainsKey(currID) || Edges.ContainsKey(currID))
        {
            currID++;
        }
        ID = currID;
        return currID;
    }
}