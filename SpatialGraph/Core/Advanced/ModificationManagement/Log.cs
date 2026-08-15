using System.Diagnostics.CodeAnalysis;

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
        foreach(TNode node in batchedMods.NodesForUpsert.Values)
        {
            NodeUpsert(node);
        }

        foreach(uint nodeID in batchedMods.NodesForRemoval)
        {
            NodeRemoval(nodeID);
        }

        foreach(Edge edge in batchedMods.EdgesForUpsert.Values)
        {
            EdgeUpsert(edge);
        }

        foreach(uint edgeID in batchedMods.EdgesForRemoval)
        {
            NodeRemoval(edgeID);
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

    //Assumes the edge already exists in the base graph
    public void EdgeRemoval(uint ID) => edgeMods[ID] = new(null, BaseGraph.Edges[ID], ModificationType.Remove);

    public void RemoveNodeModification(uint ID) => nodeMods.Remove(ID);

    public void RemoveEdgeModification(uint ID) => edgeMods.Remove(ID);

    public BatchedModifications<TNode> GetBatchedModifications()
    {
        BatchedModifications<TNode> batchedMods = new();
        foreach(KeyValuePair<uint, ElementModificationLog<TNode>> node in nodeMods)
        {
            if(node.Value.NewElement == null)
            {
                batchedMods.RemoveNode(node.Key);
                continue;
            }
            batchedMods.UpsertNode((TNode)node.Value.NewElement);
        }
        foreach(KeyValuePair<uint, ElementModificationLog<Edge>> edge in edgeMods)
        {
            if(edge.Value.NewElement == null)
            {
                batchedMods.RemoveEdge(edge.Key);
                continue;
            }
            batchedMods.UpsertEdge((Edge)edge.Value.NewElement);
        }
        return batchedMods;
    }
}

public interface IReadOnlyModificationLog<TNode> where TNode : struct, INode
{
    IReadOnlyDictionary<uint, ElementModificationLog<TNode>> NodeMods {get;}
    IReadOnlyDictionary<uint, ElementModificationLog<Edge>> EdgeMods {get;}
    BatchedModifications<TNode> GetBatchedModifications();
}

public readonly record struct ElementModificationLog<TElement>(TElement? NewElement, TElement? OldElement, ModificationType ModType) where TElement : struct;

public class NewModificationLog<TNode> : IReadOnlyModificationLog2<TNode> where TNode : struct, INode
{
    public readonly IReadOnlyGraph<TNode> BaseGraph;

    Dictionary<uint, ModificationType> nodeModType = new();
    public IReadOnlyDictionary<uint, ModificationType> NodeModType {get;}
    Dictionary<uint, ModificationType> edgeModType = new();
    public IReadOnlyDictionary<uint, ModificationType> EdgeModType {get;}

    Dictionary<uint, ElementAdded<TNode>> newNodes = new();
    public IReadOnlyDictionary<uint, ElementAdded<TNode>> NewNodes {get;}
    Dictionary<uint, ElementAdded<Edge>> newEdges = new();
    public IReadOnlyDictionary<uint, ElementAdded<Edge>> NewEdges {get;}

    Dictionary<uint, ElementModified<TNode>> modifiedNodes = new();
    public IReadOnlyDictionary<uint, ElementModified<TNode>> ModifiedNodes {get;}
    Dictionary<uint, ElementModified<Edge>> modifiedEdges = new();
    public IReadOnlyDictionary<uint, ElementModified<Edge>> ModifiedEdges {get;}

    Dictionary<uint, ElementRemoved<TNode>> removedNodes = new();
    public IReadOnlyDictionary<uint, ElementRemoved<TNode>> RemovedNodes {get;}
    Dictionary<uint, ElementRemoved<Edge>> removedEdges = new();
    public IReadOnlyDictionary<uint, ElementRemoved<Edge>> RemovedEdges {get;}

    public NewModificationLog(IReadOnlyGraph<TNode> baseGraph)
    {
        BaseGraph = baseGraph;

        NewNodes = newNodes;
        NewEdges = newEdges;

        ModifiedNodes = modifiedNodes;
        ModifiedEdges = modifiedEdges;

        RemovedNodes = removedNodes;
        RemovedEdges = removedEdges;

        NodeModType = nodeModType;
        EdgeModType = edgeModType;
    }

    public void BatchedModifications(BatchedModifications<TNode> batchedMods)
    {
        foreach(TNode node in batchedMods.NodesForUpsert.Values)
        {
            NodeUpsert(node);
        }

        foreach(uint nodeID in batchedMods.NodesForRemoval)
        {
            NodeRemoval(nodeID);
        }

        foreach(Edge edge in batchedMods.EdgesForUpsert.Values)
        {
            EdgeUpsert(edge);
        }

        foreach(uint edgeID in batchedMods.EdgesForRemoval)
        {
            NodeRemoval(edgeID);
        }
    }

    public void EdgeUpsert(Edge edge)
    {
        UnlogEdge(edge.ID);
        if (BaseGraph.Edges.TryGetValue(edge.ID, out Edge oldEdge))
        {
            modifiedEdges[edge.ID] = new(edge, oldEdge, edge.ID);
            edgeModType[edge.ID] = ModificationType.Modify;
            return;
        }
        newEdges[edge.ID] = new(edge, edge.ID);
        edgeModType[edge.ID] = ModificationType.Add;
    }

    public void NodeUpsert(TNode node)
    {
        UnlogNode(node.ID);
        if (BaseGraph.Nodes.TryGetValue(node.ID, out TNode oldNode))
        {
            modifiedNodes[node.ID] = new(node, oldNode, node.ID);
            nodeModType[node.ID] = ModificationType.Modify;
            return;
        }
        newNodes[node.ID] = new(node, node.ID);
        nodeModType[node.ID] = ModificationType.Add;
    }

    public void EdgeRemoval(uint ID)
    {
        UnlogEdge(ID);
        if(BaseGraph.Edges.TryGetValue(ID, out Edge edge))
        {
            removedEdges[ID] = new(edge, ID);
        }
    }

    public void NodeRemoval(uint ID)
    {
        UnlogNode(ID);
        if(BaseGraph.Nodes.TryGetValue(ID, out TNode node))
        {
            removedNodes[ID] = new(node, ID);
        }
    }

    public void UnlogEdge(uint ID)
    {
        if(edgeModType.TryGetValue(ID, out ModificationType edgeMod))
        {
            switch (edgeMod)
            {
                case ModificationType.Add:
                    newEdges.Remove(ID);
                break;

                case ModificationType.Modify:
                    modifiedEdges.Remove(ID);
                break;

                case ModificationType.Remove:
                    removedEdges.Remove(ID);
                break;
            }
        }
    }

    public void UnlogNode(uint ID)
    {
        if(nodeModType.TryGetValue(ID, out ModificationType nodeMod))
        {
            switch (nodeMod)
            {
                case ModificationType.Add:
                    newNodes.Remove(ID);
                break;

                case ModificationType.Modify:
                    modifiedNodes.Remove(ID);
                break;

                case ModificationType.Remove:
                    removedNodes.Remove(ID);
                break;
            }
        }
    }

    public IEnumerable<TNode> NodeUpsert()
    {
        foreach(ElementAdded<TNode> node in NewNodes.Values)
        {
            yield return node.Element;
        }
        foreach(ElementModified<TNode> node in ModifiedNodes.Values)
        {
            yield return node.NewElement;
        }
    }

    public IEnumerable<Edge> EdgeUpsert()
    {
        foreach(ElementAdded<Edge> edge in NewEdges.Values)
        {
            yield return edge.Element;
        }
        foreach(ElementModified<Edge> edge in ModifiedEdges.Values)
        {
            yield return edge.NewElement;
        }
    }

    public IEnumerable<uint> NodeRemovalID()
    {
        foreach(ElementRemoved<TNode> node in RemovedNodes.Values)
        {
            yield return node.ID;
        }
    }

    public IEnumerable<uint> EdgeRemovalID()
    {
        foreach(ElementRemoved<Edge> edge in RemovedEdges.Values)
        {
            yield return edge.ID;
        }
    }
}

public enum ModificationType
{
    Add, Modify, Remove
}

public interface IReadOnlyModificationLog2<TNode> : IBatchedMods<TNode> where TNode : struct, INode
{
    public IReadOnlyDictionary<uint, ModificationType> NodeModType {get;}
    public IReadOnlyDictionary<uint, ModificationType> EdgeModType {get;}
    public IReadOnlyDictionary<uint, ElementAdded<TNode>> NewNodes {get;}
    public IReadOnlyDictionary<uint, ElementAdded<Edge>> NewEdges {get;}
    public IReadOnlyDictionary<uint, ElementModified<TNode>> ModifiedNodes {get;}
    public IReadOnlyDictionary<uint, ElementModified<Edge>> ModifiedEdges {get;}
    public IReadOnlyDictionary<uint, ElementRemoved<TNode>> RemovedNodes {get;}
    public IReadOnlyDictionary<uint, ElementRemoved<Edge>> RemovedEdges {get;}
}

public readonly record struct ElementModified<TElement>(TElement NewElement, TElement OldElement, uint ID) where TElement : struct;
public readonly record struct ElementRemoved<TElement>(TElement Element, uint ID) where TElement : struct;
public readonly record struct ElementAdded<TElement>(TElement Element, uint ID) where TElement : struct;