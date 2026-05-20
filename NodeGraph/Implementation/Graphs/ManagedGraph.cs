using GG.NodeGraph.Implementation;

namespace GG.NodeGraph;

/// <summary>
/// Graph with builtin checks and measures (like deleting connected edges to a deleted node) to prevent dangling references. Also tracks edges connected on nodes.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class ManagedGraph<TNode> : TrackedGraph<TNode> where TNode : struct, INode
{
    public readonly NodeAdjacency<TNode> NodeAdjacency;

    public ManagedGraph() : base()
    {
        NodeAdjacency = new(this);
    }

    public ManagedGraph(IReadOnlyGraph<TNode> graph) : base(graph)
    {
        NodeAdjacency = new(this);
    }

    public ManagedGraph(Dictionary<uint, TNode> nodes, Dictionary<uint, Edge> edges) : base(nodes, edges)
    {
        NodeAdjacency = new(this);
    }

    public override void ApplyBatchedModifications(BatchedModifications<TNode> modifications)
    {
        foreach(uint nodeID in modifications.NodesForRemoval())
        {
            foreach(uint edgeID in NodeAdjacency.ConnectedEdges(nodeID))
            {
                if (!modifications.Edges.ContainsKey(edgeID))
                {
                    modifications.Edges[edgeID] = null;
                }
            }
        }

        foreach(Edge edge in modifications.EdgesForUpsert())
        {
            bool edgeNode1Valid = Nodes.ContainsKey(edge.NodeID1) || (modifications.Nodes.TryGetValue(edge.NodeID1, out TNode? node1) && node1 != null);
            bool edgeNode2Valid = Nodes.ContainsKey(edge.NodeID2) || (modifications.Nodes.TryGetValue(edge.NodeID2, out TNode? node2) && node2 != null);
            if(!edgeNode1Valid && !edgeNode2Valid)
            {
                throw new Exception(); //New edge invalid
            }
        }
        base.ApplyBatchedModifications(modifications);
    }

    public override void UpsertEdge(Edge edge)
    {
        if(!Nodes.ContainsKey(edge.NodeID1) || !Nodes.ContainsKey(edge.NodeID2))
        {
            throw new Exception(); //New edge invalid
        }
        base.UpsertEdge(edge);
    }

    public override bool RemoveNode(uint ID)
    {
        if (!Nodes.ContainsKey(ID))
        {
            return false;
        }
        BatchedModifications<TNode> mods = new();
        mods.Nodes[ID] = null;
        foreach(uint edgeID in NodeAdjacency.ConnectedEdges(ID))
        {
            mods.Edges[edgeID] = null;
        }
        base.ApplyBatchedModifications(mods);
        return true;
    }
}
