namespace GG.SpatialGraph;

/// <summary>
/// Logs incoming modifications for a graph.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class ModificationLog<TNode> : IReadOnlyModificationLog<TNode> where TNode : struct, INode
{
    public IReadOnlyGraph<TNode> BaseGraph {get;}

    Dictionary<uint, ModificationType> nodeModType = new();
    Dictionary<uint, ModificationType> edgeModType = new();

    Dictionary<uint, ElementAdded<TNode>> newNodes = new();
    Dictionary<uint, ElementAdded<Edge>> newEdges = new();

    Dictionary<uint, ElementModified<TNode>> modifiedNodes = new();
    Dictionary<uint, ElementModified<Edge>> modifiedEdges = new();

    Dictionary<uint, ElementRemoved<TNode>> removedNodes = new();
    Dictionary<uint, ElementRemoved<Edge>> removedEdges = new();

    /// <summary>
    /// Dictionary for type of modifications (Add, Remove, Modify) each node have.
    /// </summary>
    public IReadOnlyDictionary<uint, ModificationType> NodeModType {get;}

    /// <summary>
    /// Dictionary for type of modifications (Add, Remove, Modify) each edge have.
    /// </summary>
    public IReadOnlyDictionary<uint, ModificationType> EdgeModType {get;}

    //WIP!! XML COMMENTS

    public IReadOnlyDictionary<uint, ElementAdded<TNode>> NewNodes {get;}
    public IReadOnlyDictionary<uint, ElementAdded<Edge>> NewEdges {get;}

    public IReadOnlyDictionary<uint, ElementModified<TNode>> ModifiedNodes {get;}
    public IReadOnlyDictionary<uint, ElementModified<Edge>> ModifiedEdges {get;}

    public IReadOnlyDictionary<uint, ElementRemoved<TNode>> RemovedNodes {get;}
    public IReadOnlyDictionary<uint, ElementRemoved<Edge>> RemovedEdges {get;}

    public ModificationLog(IReadOnlyGraph<TNode> baseGraph)
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
    public ModificationLog(IReadOnlyModificationLog<TNode> baseGraph)
    {
        BaseGraph = baseGraph.BaseGraph;

        newNodes = new(baseGraph.NewNodes);
        NewNodes = newNodes;
        newEdges = new(baseGraph.NewEdges);
        NewEdges = newEdges;

        modifiedNodes = new(baseGraph.ModifiedNodes);
        ModifiedNodes = modifiedNodes;
        modifiedEdges = new(baseGraph.ModifiedEdges);
        ModifiedEdges = modifiedEdges;

        removedEdges = new(baseGraph.RemovedEdges);
        RemovedNodes = removedNodes;
        removedNodes = new(baseGraph.RemovedNodes);
        RemovedEdges = removedEdges;

        nodeModType = new(baseGraph.NodeModType);
        NodeModType = nodeModType;
        edgeModType = new(baseGraph.EdgeModType);
        EdgeModType = edgeModType;
    }

    public ModificationLog(IReadOnlyGraph<TNode> baseGraph, IReadOnlyBatchedMods<TNode> batchedMods)
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

        BatchedModifications(batchedMods);
    }

    public void BatchedModifications(IReadOnlyBatchedMods<TNode> batchedMods)
    {
        foreach(TNode node in batchedMods.GetNodeUpserts())
        {
            NodeUpsert(node);
        }

        foreach(uint nodeID in batchedMods.GetNodeRemovalIDs())
        {
            NodeRemoval(nodeID);
        }

        foreach(Edge edge in batchedMods.GetEdgeUpserts())
        {
            EdgeUpsert(edge);
        }

        foreach(uint edgeID in batchedMods.GetEdgeRemovalIDs())
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

    public IEnumerable<TNode> GetNodeUpserts()
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

    public IEnumerable<Edge> GetEdgeUpserts()
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

    public IEnumerable<uint> GetNodeRemovalIDs()
    {
        foreach(ElementRemoved<TNode> node in RemovedNodes.Values)
        {
            yield return node.ID;
        }
    }

    public IEnumerable<uint> GetEdgeRemovalIDs()
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

public interface IReadOnlyModificationLog<TNode> : IReadOnlyBatchedMods<TNode> where TNode : struct, INode
{
    public IReadOnlyGraph<TNode> BaseGraph {get;}
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