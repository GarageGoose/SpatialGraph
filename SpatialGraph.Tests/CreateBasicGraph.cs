using System.Numerics;
using GG.SpatialGraph;

namespace SpatialGraph.Tests;

public class UnitTest1
{
    [Fact]
    public void BasicGraphGeneric()
    {
        Graph<Node2D> graph2D = new();
        graph2D.UpsertNode(new(1, new(0, 0)));
        graph2D.UpsertNode(new(2, new(0, 1)));
        graph2D.UpsertEdge(new(3, 1, 2));
        Assert.Equal(new Vector2(0, 0), graph2D.GetFirstNodeOfEdge(3).Loc);
        Assert.Equal(new Vector2(0, 1), graph2D.GetSecondNodeOfEdge(3).Loc);

        Graph<Node3D> graph3D = new();
        graph3D.UpsertNode(new(1, new(0, 0, 0)));
        graph3D.UpsertNode(new(2, new(0, 1, 0)));
        graph3D.UpsertEdge(new(3, 1, 2));
        Assert.Equal(new Vector3(0, 0, 0), graph3D.GetFirstNodeOfEdge(3).Loc);
        Assert.Equal(new Vector3(0, 1, 0), graph3D.GetSecondNodeOfEdge(3).Loc);
    }

    [Fact]
    public void BasicGraph()
    {
        Graph2D graph2D = new();
        uint NodeID1 = graph2D.AddNode(0, 1);
        uint NodeID2 = graph2D.AddNode(0, 0);
        uint EdgeID = graph2D.AddEdge(NodeID1, NodeID2);
        Assert.Equal(new Vector2(0, 1), graph2D.GetFirstNodeOfEdge(EdgeID).Loc);
        Assert.Equal(new Vector2(0, 0), graph2D.GetSecondNodeOfEdge(EdgeID).Loc);

        Graph3D graph3D = new();
        NodeID1 = graph3D.AddNode(0, 1, 0);
        NodeID2 = graph3D.AddNode(0, 0, 0);
        EdgeID = graph3D.AddEdge(NodeID1, NodeID2);
        Assert.Equal(new Vector3(0, 1, 0), graph3D.GetFirstNodeOfEdge(EdgeID).Loc);
        Assert.Equal(new Vector3(0, 0, 0), graph3D.GetSecondNodeOfEdge(EdgeID).Loc);
    }

    [Fact]
    public void BatchedModificationTest()
    {
        Graph<Node2D> graph2D = new();

        BatchedModifications<Node2D> ModBatch = new();

        ModBatch.UpsertNode(new(1, new(0, 1)));
        ModBatch.UpsertNode(new(2, new(2, 0)));
        ModBatch.UpsertEdge(new(3, 1, 2));

        graph2D.ApplyBatchedModifications(ModBatch);

        Assert.Equal(new Vector2(0, 1), graph2D.GetFirstNodeOfEdge(3).Loc);
        Assert.Equal(new Vector2(2, 0), graph2D.GetSecondNodeOfEdge(3).Loc);
    }
}
