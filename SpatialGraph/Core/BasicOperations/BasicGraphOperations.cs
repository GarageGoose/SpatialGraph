using System.Numerics;
namespace GG.SpatialGraph;

public static class BasicGraphOperations
{
    public static void UpsertNode(this Graph<Node2D> graph, uint ID, float X, float Y) => graph.UpsertNode(new(ID, new(X, Y)));

    public static void UpsertNode(this Graph<Node2D> graph, uint ID, Vector2 Loc) => graph.UpsertNode(new(ID, Loc));

    public static uint AddNode(this Graph<Node2D> graph, float X, float Y)
    {
        uint ID = graph.GenerateID();
        graph.UpsertNode(new(ID, new(X, Y)));
        return ID;
    }

    public static uint AddNode(this Graph<Node2D> graph, Vector2 Loc)
    {
        uint ID = graph.GenerateID();
        graph.UpsertNode(new(ID, Loc));
        return ID;
    }

    public static void UpsertNode(this Graph<Node3D> graph, uint ID, float X, float Y, float Z) => graph.UpsertNode(new(ID, new(X, Y, Z)));
    public static void UpsertNode(this Graph<Node3D> graph, uint ID, Vector3 Loc) => graph.UpsertNode(new(ID, Loc));

    public static uint AddNode(this Graph<Node3D> graph, float X, float Y, float Z)
    {
        uint ID = graph.GenerateID();
        graph.UpsertNode(new(ID, new(X, Y, Z)));
        return ID;
    }

    public static uint AddNode(this Graph<Node3D> graph, Vector3 Loc)
    {
        uint ID = graph.GenerateID();
        graph.UpsertNode(new(ID, Loc));
        return ID;
    }
}