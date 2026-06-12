namespace GG.SpatialGraph.Metadata;

/// <summary>
/// Records adjecent nodes or edges from a node in a graph.
/// </summary>
/// <typeparam name="TNode"></typeparam>
public class NodeAdjacency<TNode> : GraphMetadata<TNode> where TNode : struct, INode
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

    public NodeAdjacency(IReadOnlyTrackedGraph<TNode> baseGraph) : base(baseGraph)
    {
    }

    protected override void OnGraphUpdate(object? sender, IReadOnlyModificationLog<TNode> log)
    {
        foreach(KeyValuePair<uint, ElementModificationLog<TNode>> nodeLog in log.NodeMods)
        {
            switch (nodeLog.Value.ModType)
            {
                case ModificationType.Add:
                    connectedNodes.Add(nodeLog.Key, new());
                break;

                case ModificationType.Remove:
                    connectedNodes.Remove(nodeLog.Key);
                break;
            }
        }

        foreach(KeyValuePair<uint, ElementModificationLog<Edge>> edgeLog in log.EdgeMods)
        {
            switch (edgeLog.Value.ModType)
            {
                case ModificationType.Add:
                    AddEdge((Edge)edgeLog.Value.NewElement!);
                break;

                case ModificationType.Modify:
                    RemoveEdge((Edge)edgeLog.Value.OldElement!);
                    AddEdge((Edge)edgeLog.Value.NewElement!);
                break;

                case ModificationType.Remove:
                    RemoveEdge((Edge)edgeLog.Value.OldElement!);
                break;
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
}