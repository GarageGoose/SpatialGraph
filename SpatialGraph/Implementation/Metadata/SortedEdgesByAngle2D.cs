using System.Numerics;
using GG.SpatialGraph;
namespace GG.SpatialGraph.Metadata;

public class SortedEdgesByAngle2D : GraphReadOnlyPlugin<Node2D>
{
    //node id, edge id, angle from node
    Dictionary<uint, SortedList<uint, float>> SortedEdges = new();
    public IDictionary<uint, float> EdgesAnglesOnNode(uint nodeID) => SortedEdges[nodeID];

    public uint NextEdgeFromEdge(uint nodeID, uint edgeID)
    {
        int EdgeIndex = SortedEdges[nodeID].IndexOfKey(nodeID);
        if(EdgeIndex != SortedEdges.Count - 1)
        {
            return (uint)EdgeIndex + 1;
        }
        return 0;
    }

    public uint PreviousEdgeFromEdge(uint nodeID, uint edgeID)
    {
        int EdgeIndex = SortedEdges[nodeID].IndexOfKey(nodeID);
        if(EdgeIndex != 0)
        {
            return (uint)EdgeIndex - 1;
        }
        return (uint)SortedEdges.Count - 1;
    }

    public float AngleBetweenNextEdge(uint nodeID, uint edgeID)
    {
        uint NextEdgeID = NextEdgeFromEdge(nodeID, edgeID);
        float radBetweenEdge = MathF.Abs(EdgesAnglesOnNode(nodeID)[edgeID] - EdgesAnglesOnNode(nodeID)[NextEdgeID]);
        return MathF.Min(radBetweenEdge, 2 * MathF.PI - radBetweenEdge);
    }

    public float AngleBetweenPreviousEdge(uint nodeID, uint edgeID)
    {
        uint PrevEdgeID = PreviousEdgeFromEdge(nodeID, edgeID);
        float radBetweenEdge = MathF.Abs(EdgesAnglesOnNode(nodeID)[edgeID] - EdgesAnglesOnNode(nodeID)[PrevEdgeID]);
        return MathF.Min(radBetweenEdge, 2 * MathF.PI - radBetweenEdge);
    }

    public SortedEdgesByAngle2D(IReadOnlyTrackedGraph<Node2D> baseGraph) : base(baseGraph)
    {
        foreach(Node2D node in baseGraph.Nodes.Values)
        {
            SortedEdges.Add(node.ID , new());
        }
        foreach(Edge edge in BaseGraph.Edges.Values)
        {
            AddEdge(edge);
        }
    }

    protected override void OnGraphUpdate(object? sender, IReadOnlyModificationLog<Node2D> modLog)
    {
        foreach(ElementAdded<Node2D> node in modLog.NewNodes.Values)
        {
            SortedEdges.Add(node.ID , new());
        } 
        foreach(ElementRemoved<Node2D> node in modLog.RemovedNodes.Values)
        {
            SortedEdges.Remove(node.ID);
        }

        foreach(ElementAdded<Edge> edge in modLog.NewEdges.Values)
        {
            AddEdge(edge.Element);
        }

        foreach(ElementModified<Edge> edge in modLog.ModifiedEdges.Values)
        {
            RemoveEdge(edge.OldElement);
            AddEdge(edge.NewElement);
        }

        foreach(ElementRemoved<Edge> edge in modLog.RemovedEdges.Values)
        {
            RemoveEdge(edge.Element);
        }
    }

    void AddEdge(Edge edge)
    {
        SortedEdges[edge.NodeID1].Add(edge.ID, this.EdgeAngleFromNode(edge.ID, edge.NodeID1));
        SortedEdges[edge.NodeID2].Add(edge.ID, this.EdgeAngleFromNode(edge.ID, edge.NodeID2));
    }

    void RemoveEdge(Edge edge)
    {
        SortedEdges[edge.NodeID1].Remove(edge.ID);
        SortedEdges[edge.NodeID2].Remove(edge.ID);
    }
}