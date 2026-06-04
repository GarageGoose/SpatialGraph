using System.Numerics;
namespace GG.NodeGraph.Implementation;

public class QuadTreePointCell
{
    public bool Subdivided {get; private set;} = false;
    public readonly Vector2 TopLeftCorner;
    public readonly Vector2 Center;
    public readonly Vector2 BottomRightCorner;
    public QuadTreePointCell(uint pointCapacity, Vector2 originTopLeft, uint width, uint height)
    {
        
    }

    public void AddPoint()
    {
        
    }
}

