using System.Numerics;
namespace GG.NodeGraph;

/// <summary>
/// A line segment from 2 nodes.
/// </summary>
public readonly struct Edge
{
    public Edge(uint ID, uint NodeID1, uint NodeID2)
    {
        this.ID = ID;
        this.NodeID1 = NodeID1;
        this.NodeID2 = NodeID2;
    }

    public readonly uint ID;

    /// <summary>
    /// ID of the first to to connect to.
    /// </summary>
    public readonly uint NodeID1;

    /// <summary>
    /// ID of the second node to connect to.
    /// </summary>
    public readonly uint NodeID2;
}

/// <summary>
/// Base interface for nodes.
/// </summary>
public interface INode
{
    uint ID {get;}
}

/// <summary>
/// Node without spatial data. Used for non spatial graphs.
/// </summary>
public readonly struct Node : INode
{
    public Node(uint ID)
    {
        this.ID = ID;
    }
    public uint ID {get;}
}

/// <summary>
/// Node with coordinate in 2 dimensions. Used for 2D graphs.
/// </summary>
public readonly struct Node2D : INode
{
    public Node2D(uint ID, Vector2 Loc)
    {
        this.ID = ID;
        loc = Loc;
    }
    public uint ID {get;}

    //Prevent mutation
    private readonly Vector2 loc;
    public Vector2 Loc => loc;
}

/// <summary>
/// Node with coordinate in 3 dimensions. Used for 3D graphs.
/// </summary>
public readonly struct Node3D : INode
{
    public Node3D(uint ID, Vector3 Loc)
    {
        this.ID = ID;
        loc = Loc;
    }
    public uint ID {get;}

    //Prevent mutation
    private readonly Vector3 loc;
    public Vector3 Loc => loc;
}