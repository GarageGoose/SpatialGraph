using GG.NodeGraph;
using System.Numerics;

internal class QTCell<TNode, TElement> where TNode : struct, INode
{
    public bool IsSplit = false;

    public Vector2 TopLeftBoundary;
    public Vector2 BottomRightBoundary;

    public List<TElement> CellElements = new();

    public QTCell<TNode, TElement>? Quad1;
    public QTCell<TNode, TElement>? Quad2;
    public QTCell<TNode, TElement>? Quad3;
    public QTCell<TNode, TElement>? Quad4;

    public void SplitCell()
    {
        
    }
}