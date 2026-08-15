namespace GG.SpatialGraph.Metadata;

/// <summary>
/// Records adjecent nodes or edges from a node in a graph.
/// </summary>
/// <typeparam name="TNode"></typeparam>
public class NodeAdjacency<TNode> : GraphReadOnlyPlugin<TNode> where TNode : struct, INode
{
    Dictionary<uint, HashSet<uint>> connectedNodes = new();
    Dictionary<uint, HashSet<uint>> connectedEdges = new();

    /// <summary>
    /// Get connected nodes from a node.
    /// </summary>
    public IReadOnlySet<uint> ConnectedNodes(uint nodeID) => connectedNodes[nodeID];

    /// <summary>
    /// Get connecting edges from a node.
    /// </summary>
    public IReadOnlySet<uint> ConnectedEdges(uint nodeID) => connectedEdges[nodeID];

    public int ConnectedEdgesCount(uint nodeID) => connectedEdges[nodeID].Count;

    public NodeAdjacency(IReadOnlyTrackedGraph<TNode> baseGraph) : base(baseGraph)
    {
        foreach(uint nodeID in Nodes.Keys)
        {
            connectedNodes.Add(nodeID, new());
        }
        foreach(Edge edge in Edges.Values)
        {
            AddEdge(edge);
        }
    }

    protected override void OnGraphUpdate(object? sender, IReadOnlyModificationLog<TNode> log)
    {
        foreach(ElementAdded<TNode> node in log.NewNodes.Values)
        {
            connectedNodes.Add(node.ID, new());
        }

        foreach(ElementRemoved<TNode> node in log.RemovedNodes.Values)
        {
            connectedNodes.Remove(node.ID);
        }

        foreach(ElementAdded<Edge> edge in log.NewEdges.Values)
        {
            AddEdge(edge.Element);
        }

        foreach(ElementModified<Edge> edge in log.ModifiedEdges.Values)
        {
            AddEdge(edge.NewElement);
            RemoveEdge(edge.OldElement);
        }

        foreach(ElementRemoved<Edge> edge in log.RemovedEdges.Values)
        {
            RemoveEdge(edge.Element);
        }
    }

    void AddEdge(Edge edge)
    {
        connectedEdges[edge.NodeID1].Add(edge.ID);
        connectedEdges[edge.NodeID2].Add(edge.ID);

        connectedNodes[edge.NodeID1].Add(edge.GetConnectingNode(edge.NodeID1));
        connectedNodes[edge.NodeID2].Add(edge.GetConnectingNode(edge.NodeID2));
    }

    void RemoveEdge(Edge edge)
    {
        connectedEdges[edge.NodeID1].Remove(edge.ID);
        connectedEdges[edge.NodeID2].Remove(edge.ID);

        connectedNodes[edge.NodeID1].Remove(edge.GetConnectingNode(edge.NodeID1));
        connectedNodes[edge.NodeID2].Remove(edge.GetConnectingNode(edge.NodeID2));
    }
}