namespace GG.SpatialGraph;

/// <summary>
/// Stores and logs modifications for a speficific base graph.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class ModificationLog<TNode> : IReadOnlyModificationLog<TNode> where TNode : struct, INode
{
    public readonly IReadOnlyGraph<TNode> BaseGraph;

    internal Dictionary<uint, ElementModificationLog<TNode>> nodeMods = new();
    internal Dictionary<uint, ElementModificationLog<Edge>> edgeMods = new();

    public IReadOnlyDictionary<uint, ElementModificationLog<TNode>> NodeMods {get;}
    public IReadOnlyDictionary<uint, ElementModificationLog<Edge>> EdgeMods {get;}

    public ModificationLog(IReadOnlyGraph<TNode> baseGraph)
    {
        BaseGraph = baseGraph;
        NodeMods = nodeMods;
        EdgeMods = edgeMods;
    }

    public ModificationLog(IReadOnlyGraph<TNode> baseGraph, BatchedModifications<TNode> batchedMods)
    {
        BaseGraph = baseGraph;
        NodeMods = nodeMods;
        EdgeMods = edgeMods;
        BatchedModifications(batchedMods);
    }

    public void BatchedModifications(BatchedModifications<TNode> batchedMods)
    {
        foreach(KeyValuePair<uint, TNode?> node in batchedMods.Nodes)
        {
            if(node.Value == null)
            {
                NodeRemoval(node.Key);
                continue;
            }
            NodeUpsert((TNode)node.Value);
        }

        foreach(KeyValuePair<uint, Edge?> edge in batchedMods.Edges)
        {
            if(edge.Value == null)
            {
                EdgeRemoval(edge.Key);
                continue;
            }
            EdgeUpsert((Edge)edge.Value);
        }
    }

    public void Union(ModificationLog<TNode> baseGraph)
    {
        if(BaseGraph == baseGraph)
        {
            nodeMods.Union(baseGraph.nodeMods);
            edgeMods.Union(baseGraph.edgeMods);
        }
    }

    public void NodeUpsert(TNode node)
    {
        if(BaseGraph.Nodes.TryGetValue(node.ID, out TNode oldNode))
        {
            nodeMods[node.ID] = new(node, oldNode, ModificationType.Modify);
            return;
        }
        nodeMods[node.ID] = new(node, null, ModificationType.Add);
    }

    public void EdgeUpsert(Edge edge)
    {
        if(BaseGraph.Edges.TryGetValue(edge.ID, out Edge oldEdge))
        {
            edgeMods[edge.ID] = new(edge, oldEdge, ModificationType.Modify);
            return;
        }
        edgeMods[edge.ID] = new(edge, null, ModificationType.Add);
    }

    //Assumes the node already exists in the base graph.
    public void NodeRemoval(uint ID) => nodeMods[ID] = new(null, BaseGraph.Nodes[ID], ModificationType.Remove);

    //Assumes the edge already exists in the base graph.
    public void EdgeRemoval(uint ID) => edgeMods[ID] = new(null, BaseGraph.Edges[ID], ModificationType.Remove);

    public void RemoveNodeModification(uint ID) => nodeMods.Remove(ID);

    public void RemoveEdgeModification(uint ID) => edgeMods.Remove(ID);

    public BatchedModifications<TNode> GetBatchedModifications()
    {
        BatchedModifications<TNode> batchedModifications = new();
        foreach(KeyValuePair<uint, ElementModificationLog<TNode>> node in nodeMods)
        {
            batchedModifications.Nodes.Add(node.Key, node.Value.NewElement);
        }
        foreach(KeyValuePair<uint, ElementModificationLog<Edge>> edge in edgeMods)
        {
            batchedModifications.Edges.Add(edge.Key, edge.Value.NewElement);
        }
        return batchedModifications;
    }
}

public interface IReadOnlyModificationLog<TNode> where TNode : struct, INode
{
    IReadOnlyDictionary<uint, ElementModificationLog<TNode>> NodeMods {get;}
    IReadOnlyDictionary<uint, ElementModificationLog<Edge>> EdgeMods {get;}
}

public enum ModificationType
{
    Add, Modify, Remove
}

public readonly record struct ElementModificationLog<TElement>(TElement? NewElement, TElement? OldElement, ModificationType ModType) where TElement : struct;