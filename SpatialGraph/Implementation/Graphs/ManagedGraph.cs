using GG.SpatialGraph.Metadata;

namespace GG.SpatialGraph;

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
        //Remove nodes connected to nodes that is being removed
        foreach(uint nodeID in modifications.NodesForRemoval)
        {
            foreach(uint edgeID in NodeAdjacency.ConnectedEdges(nodeID))
            {
                modifications.RemoveEdge(edgeID);
            }
        }

        foreach(Edge edge in modifications.EdgesForUpsert.Values)
        {
            bool edgeNode1Valid = Nodes.ContainsKey(edge.NodeID1) || modifications.NodesForUpsert.ContainsKey(edge.NodeID1);
            bool edgeNode2Valid = Nodes.ContainsKey(edge.NodeID2) || modifications.NodesForUpsert.ContainsKey(edge.NodeID2);
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
        mods.RemoveNode(ID);
        foreach(uint edgeID in NodeAdjacency.ConnectedEdges(ID))
        {
            mods.RemoveEdge(edgeID);
        }
        base.ApplyBatchedModifications(mods);
        return true;
    }
}
