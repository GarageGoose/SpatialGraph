using System.Numerics;
namespace GG.NodeGraph;

public struct Edge
{
    public Edge(uint ID, uint VertexID1, uint VertexID2)
    {
        this.ID = ID;
        this.VertexID1 = VertexID1;
        this.VertexID2 = VertexID2;
    }

    public uint ID;
    public uint VertexID1;
    public uint VertexID2;
}

public interface Node
{
    uint ID {get; set;}
}

public struct Node2D : Node
{
    public Node2D(uint ID, Vector2 Loc)
    {
        this.ID = ID;
        this.Loc = Loc;
    }
    public uint ID {get; set;}
    public Vector2 Loc;
}

public struct Node3D : Node
{
    public Node3D(uint ID, Vector3 Loc)
    {
        this.ID = ID;
        this.Loc = Loc;
    }
    public uint ID {get; set;}
    public Vector3 Loc;
}