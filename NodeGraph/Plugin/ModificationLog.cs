namespace GG.NodeGraph.Plugin;

public class ModificationLog<TNode> where TNode : Node
{
    public Dictionary<uint, TNode?> Nodes = new();
    public Dictionary<uint, Edge?> Edges = new();
}