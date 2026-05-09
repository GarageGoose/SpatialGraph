namespace GG.NodeGraph.Plugin;

/// <summary>
/// Stores modifications.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class BatchedModifications<TNode> where TNode : struct, INode
{
    public Dictionary<uint, TNode?> Nodes = new();
    public Dictionary<uint, Edge?> Edges = new();
}

/// <summary>
/// Stores possible modification on a graph.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class ModificationLog<TNode> : BatchedModifications<TNode>, IReadOnlyModificationLog<TNode> where TNode : struct, INode
{
    internal Graph<TNode> baseGraph;
    public ModificationLog(IReadOnlyGraph<TNode> baseGraph)
    {
        this.baseGraph = new(baseGraph);
        RONodes = Nodes;
        ROEdges = Edges;
    }

    public ModificationLog(IReadOnlyGraph<TNode> baseGraph, BatchedModifications<TNode> baseModifications)
    {
        this.baseGraph = new(baseGraph);
        Nodes = new(baseModifications.Nodes);
        RONodes = Nodes;
        Edges = new(baseModifications.Edges);
        ROEdges = Edges;
    }

    public IReadOnlyDictionary<uint, TNode?> RONodes {get;}
    public IReadOnlyDictionary<uint, Edge?> ROEdges {get;}

    public ModificationType NodeModificationType(uint ID)
    {
        if(Nodes.ContainsKey(ID))
        {
            if (baseGraph.Nodes.ContainsKey(ID))
            {
                return ModificationType.Modify;
            }
            else if(Nodes[ID] == null)
            {
                return ModificationType.Remove;
            }
            return ModificationType.Add;
        }
        return ModificationType.None;
    }

    public TNode? RetrieveInitialNode(uint ID) => baseGraph.Nodes[ID];

    public ModificationType EdgeModificationType(uint ID)
    {
        if(Edges.ContainsKey(ID))
        {
            if (baseGraph.Edges.ContainsKey(ID))
            {
                return ModificationType.Modify;
            }
            else if(Edges[ID] == null)
            {
                return ModificationType.Remove;
            }
            return ModificationType.Add;
        }
        return ModificationType.None;
    }

    public Edge? RetrieveInitialEdge(uint ID) => baseGraph.Edges[ID];
}

public interface IReadOnlyModificationLog<TNode> where TNode : struct, INode
{
    IReadOnlyDictionary<uint, TNode?> RONodes {get;}
    IReadOnlyDictionary<uint, Edge?> ROEdges {get;}
    ModificationType NodeModificationType(uint ID);
    TNode? RetrieveInitialNode(uint ID);
    ModificationType EdgeModificationType(uint ID);
    public Edge? RetrieveInitialEdge(uint ID);
    
}
public enum ModificationType
{
    Add, Modify, Remove, None
}