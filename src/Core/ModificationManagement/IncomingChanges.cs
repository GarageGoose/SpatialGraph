namespace SpatialGraph;

/// <summary>
/// Stores incoming changes for a graph.
/// </summary>
/// <typeparam name="TNode">Type of node used in the graph.</typeparam>
public class GraphIncomingChanges<TNode> : IReadOnlyGraphIncomingChanges<TNode> where TNode : struct, INode
{
    Dictionary<uint, TNode> nodesForUpsert = new();
    HashSet<uint> nodesForRemoval = new();
    Dictionary<uint, Edge> edgesForUpsert = new();
    HashSet<uint> edgesForRemoval = new();

    /// <inheritdoc/>
    public IReadOnlyDictionary<uint, TNode> NodesForUpsert {get;}

    /// <inheritdoc/>
    public IReadOnlySet<uint> NodesForRemoval {get;}

    /// <inheritdoc/>
    public IReadOnlyDictionary<uint, Edge> EdgesForUpsert {get;}

    /// <inheritdoc/>
    public IReadOnlySet<uint> EdgesForRemoval {get;}

    /// <summary>
    /// Create a new empty instance.
    /// </summary>
    public GraphIncomingChanges()
    {
        edgesForUpsert = new();
        nodesForUpsert = new();
        nodesForRemoval = new();
        edgesForRemoval = new();
        NodesForUpsert = nodesForUpsert;
        NodesForRemoval = nodesForRemoval;
        EdgesForUpsert = edgesForUpsert;
        EdgesForRemoval = edgesForRemoval;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="batchedMods"></param>
    public GraphIncomingChanges(IReadOnlyGraphIncomingChanges<TNode> batchedMods)
    {
        edgesForUpsert = new(batchedMods.EdgesForUpsert);
        nodesForUpsert = new(batchedMods.NodesForUpsert);
        nodesForRemoval = [.. batchedMods.NodesForRemoval];
        edgesForRemoval = [.. batchedMods.EdgesForRemoval];
        NodesForUpsert = nodesForUpsert;
        NodesForRemoval = nodesForRemoval;
        EdgesForUpsert = edgesForUpsert;
        EdgesForRemoval = edgesForRemoval;
    }
    
    /// <summary>
    /// Add a new node or modify one with their corresponding ID.
    /// </summary>
    /// <param name="node">Node to upsert.</param>
    public void UpsertNode(TNode node)
    {
        nodesForUpsert.Add(node.ID, node);
        nodesForRemoval.Remove(node.ID);
    }

    /// <summary>
    /// Remove a node with its ID.
    /// </summary>
    /// <param name="nodeID">ID of the node to remove.</param>
    public void RemoveNode(uint nodeID)
    {
        nodesForUpsert.Remove(nodeID);
        nodesForRemoval.Add(nodeID);
    }

    /// <summary>
    /// Remove pending changes to a node.
    /// </summary>
    /// <param name="nodeID">ID of the node.</param>
    public void RemoveNodeChange(uint nodeID)
    {
        nodesForUpsert.Remove(nodeID);
        nodesForRemoval.Remove(nodeID);
    }

    /// <summary>
    /// Add a new edge or modify one with their corresponding ID.
    /// </summary>
    /// <param name="edge">Edge to upsert.</param>
    public void UpsertEdge(Edge edge)
    {
        edgesForUpsert.Add(edge.ID, edge);
        edgesForRemoval.Remove(edge.ID);
    }

    /// <summary>
    /// Remove pending changes to a node.
    /// </summary>
    /// <param name="edgeID">ID of the node.</param>
    public void RemoveEdge(uint edgeID)
    {
        edgesForUpsert.Remove(edgeID);
        edgesForRemoval.Add(edgeID);
    }

    /// <summary>
    /// Remove pending changes to an edge.
    /// </summary>
    /// <param name="edgeID">ID of the node.</param>
    public void RemoveEdgeChange(uint edgeID)
    {
        edgesForUpsert.Remove(edgeID);
        edgesForRemoval.Remove(edgeID);
    }

    /// <summary>
    /// Union between two GraphIncomingChanges.
    /// </summary>
    /// <param name="GraphIncomingChanges">GraphIncomingChanges to perform the union to.</param>
    public void Union(GraphIncomingChanges<TNode> GraphIncomingChanges)
    {
        //WIP!!!
        nodesForUpsert = new(nodesForUpsert.Union(GraphIncomingChanges.nodesForUpsert));
        nodesForRemoval.UnionWith(GraphIncomingChanges.nodesForRemoval);
        edgesForUpsert = new(edgesForUpsert.Union(GraphIncomingChanges.edgesForUpsert));
        edgesForRemoval.UnionWith(GraphIncomingChanges.edgesForRemoval);
    }

    /// <summary>
    /// Intersect between two GraphIncomingChanges.
    /// </summary>
    /// <param name="GraphIncomingChanges">GraphIncomingChanges to perform the intersection to.</param>
    public void Intersect(GraphIncomingChanges<TNode> GraphIncomingChanges)
    {
        //WIP!!!
        nodesForUpsert = new(nodesForUpsert.Intersect(GraphIncomingChanges.nodesForUpsert));
        nodesForRemoval.IntersectWith(GraphIncomingChanges.nodesForRemoval);
        edgesForUpsert = new(edgesForUpsert.Intersect(GraphIncomingChanges.edgesForUpsert));
        edgesForRemoval.IntersectWith(GraphIncomingChanges.edgesForRemoval);
    }

    /// <inheritdoc/>
    public IEnumerable<TNode> NodeUpserts() => NodesForUpsert.Values;

    /// <inheritdoc/>
    public IEnumerable<Edge> EdgeUpserts() => EdgesForUpsert.Values;

    /// <inheritdoc/>
    public IEnumerable<uint> NodeRemovals() => NodesForRemoval;

    /// <inheritdoc/>
    public IEnumerable<uint> EdgeRemovals() => EdgesForRemoval;
}

/// <summary>
/// Interface for objects which stores incoming changes for a graph.
/// </summary>
/// <typeparam name="TNode">Type of node used in the graph.</typeparam>
public interface IReadOnlyGraphIncomingChanges<TNode> : GraphChangeSet<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Nodes to be added or modified (replaced with identical IDs) in a graph.
    /// </summary>
    IReadOnlyDictionary<uint, TNode> NodesForUpsert {get;}

    /// <summary>
    /// Nodes to be removed in a graph.
    /// </summary>
    IReadOnlySet<uint> NodesForRemoval {get;}

    /// <summary>
    /// Edges to be added or modified (replaced with identical IDs) in a graph.
    /// </summary>
    IReadOnlyDictionary<uint, Edge> EdgesForUpsert {get;}

    /// <summary>
    /// Edges to be removed in a graph.
    /// </summary>
    IReadOnlySet<uint> EdgesForRemoval {get;}
}