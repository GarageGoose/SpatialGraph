namespace SpatialGraph;

/// <summary>
/// Logs incoming changes for a <see cref="IGraph{TNode}"/>. Stores additional data: type of modification of an
/// <see cref="IElement"/> (Add, Modify, Delete), old value of an <see cref="IElement"/> (if any), and new value of an <see cref="IElement"/> (if any).
/// </summary>
/// <typeparam name="TNode">Node which the base graph uses.</typeparam>
public class GraphChangeLog<TNode> : IReadOnlyModificationLog<TNode> where TNode : struct, INode
{
    /// <inheritdoc/>
    public IReadOnlyGraph<TNode> BaseGraph {get;}

    Dictionary<uint, ModificationType> nodeModType = new();
    Dictionary<uint, ModificationType> edgeModType = new();

    Dictionary<uint, ElementAdded<TNode>> newNodes = new();
    Dictionary<uint, ElementAdded<Edge>> newEdges = new();

    Dictionary<uint, ElementModified<TNode>> modifiedNodes = new();
    Dictionary<uint, ElementModified<Edge>> modifiedEdges = new();

    Dictionary<uint, ElementRemoved<TNode>> removedNodes = new();
    Dictionary<uint, ElementRemoved<Edge>> removedEdges = new();

    /// <inheritdoc/>
    public IReadOnlyDictionary<uint, ModificationType> NodeModType {get;}

    /// <inheritdoc/>
    public IReadOnlyDictionary<uint, ModificationType> EdgeModType {get;}

    /// <inheritdoc/>
    public IReadOnlyDictionary<uint, ElementAdded<TNode>> NewNodes {get;}

    /// <inheritdoc/>
    public IReadOnlyDictionary<uint, ElementAdded<Edge>> NewEdges {get;}

    /// <inheritdoc/>
    public IReadOnlyDictionary<uint, ElementModified<TNode>> ModifiedNodes {get;}

    /// <inheritdoc/>
    public IReadOnlyDictionary<uint, ElementModified<Edge>> ModifiedEdges {get;}

    /// <inheritdoc/>
    public IReadOnlyDictionary<uint, ElementRemoved<TNode>> RemovedNodes {get;}


    /// <inheritdoc/>
    public IReadOnlyDictionary<uint, ElementRemoved<Edge>> RemovedEdges {get;}

    /// <summary>
    /// Create a <see cref="GraphChangeLog{TNode}"/> referencing a graph.
    /// </summary>
    /// <param name="baseGraph">Graph to reference the changes from.</param>
    public GraphChangeLog(IReadOnlyGraph<TNode> baseGraph)
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

    /// <summary>
    /// Duplicate a <see cref="GraphChangeLog{TNode}"/> from another <see cref="GraphChangeLog{TNode}"/>.
    /// </summary>
    /// <param name="baseGraph">ChangeLog to duplicate from.</param>
    public GraphChangeLog(IReadOnlyModificationLog<TNode> baseGraph)
    {
        BaseGraph = baseGraph.BaseGraph;

        newNodes = new(baseGraph.NewNodes);
        newEdges = new(baseGraph.NewEdges);
        NewNodes = newNodes;
        NewEdges = newEdges;

        modifiedNodes = new(baseGraph.ModifiedNodes);
        modifiedEdges = new(baseGraph.ModifiedEdges);
        ModifiedNodes = modifiedNodes;
        ModifiedEdges = modifiedEdges;

        removedEdges = new(baseGraph.RemovedEdges);
        removedNodes = new(baseGraph.RemovedNodes);
        RemovedNodes = removedNodes;
        RemovedEdges = removedEdges;

        nodeModType = new(baseGraph.NodeModType);
        edgeModType = new(baseGraph.EdgeModType);
        NodeModType = nodeModType;
        EdgeModType = edgeModType;
    }

    /// <summary>
    /// Create a ChangeLog referencing a <see cref="IGraph{TNode}"/> with changes from a <see cref="GraphChangeSet{TNode}"/>.
    /// </summary>
    /// <param name="baseGraph">Graph to reference the changes from.</param>
    /// <param name="changeSet">Set of changes to log.</param>
    public GraphChangeLog(IReadOnlyGraph<TNode> baseGraph, GraphChangeSet<TNode> changeSet)
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

        LogChangeSet(changeSet);
    }

    /// <summary>
    /// Log changes from a <see cref="GraphChangeSet{TNode}"/>.
    /// </summary>
    /// <param name="batchedMods">Contains set of changes for this graph.</param>
    public void LogChangeSet(GraphChangeSet<TNode> batchedMods)
    {
        foreach(TNode node in batchedMods.NodeUpserts())
        {
            NodeUpsert(node);
        }

        foreach(uint nodeID in batchedMods.NodeRemovals())
        {
            NodeRemoval(nodeID);
        }

        foreach(Edge edge in batchedMods.EdgeUpserts())
        {
            EdgeUpsert(edge);
        }

        foreach(uint edgeID in batchedMods.EdgeRemovals())
        {
            NodeRemoval(edgeID);
        }
    }

    /// <summary>
    /// Add a log for a new <see cref="Edge"/> or modify an <see cref="Edge"/> with its corresponding ID. This will not add it to the base <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="edge">Edge to upsert, identified by its ID.</param>
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

    /// <summary>
    /// Add a log for a new <see cref="INode"/> or modify a <see cref="INode"/> with its corresponding ID. This will not add it to the base <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="node">Node to upsert, identified by its ID.</param>
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

    /// <summary>
    /// Add a log for the removal of an <see cref="Edge"/> in the <see cref="IGraph{TNode}"/> using its corresponding ID. This will not remove it from the base <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="ID">ID of the edge to be removed.</param>
    public void EdgeRemoval(uint ID)
    {
        UnlogEdge(ID);
        if(BaseGraph.Edges.TryGetValue(ID, out Edge edge))
        {
            removedEdges[ID] = new(edge, ID);
        }
    }

    /// <summary>
    /// Add a log for the removal of a <see cref="INode"/> in the <see cref="IGraph{TNode}"/> using its corresponding ID. This will not remove it from the base <see cref="IGraph{TNode}"/>.
    /// </summary>
    /// <param name="ID">ID of the node to be removed.</param>
    public void NodeRemoval(uint ID)
    {
        UnlogNode(ID);
        if(BaseGraph.Nodes.TryGetValue(ID, out TNode node))
        {
            removedNodes[ID] = new(node, ID);
        }
    }

    /// <summary>
    /// Remove the log of a change in an <see cref="Edge"/>.
    /// </summary>
    /// <param name="ID">ID of the edge for its log to be removed.</param>
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

    /// <summary>
    /// Remove the log of a change in a <see cref="INode"/>.
    /// </summary>
    /// <param name="ID">ID of the node for its log to be removed.</param>
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

    /// <summary>
    /// Log of <see cref="INode"/>s to be upserted/has been upserted in the graph.
    /// </summary>
    public IEnumerable<TNode> NodeUpserts()
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

    /// <summary>
    /// Log of <see cref="Edge"/>s to be upserted/has been upserted in the graph.
    /// </summary>
    public IEnumerable<Edge> EdgeUpserts()
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

    /// <summary>
    /// Log of IDs of <see cref="INode"/>s to be removed/has been removed in the graph.
    /// </summary>
    public IEnumerable<uint> NodeRemovals()
    {
        foreach(ElementRemoved<TNode> node in RemovedNodes.Values)
        {
            yield return node.ID;
        }
    }

    /// <summary>
    /// Log of IDs of <see cref="Edge"/>s to be removed/has been removed in the graph.
    /// </summary>
    public IEnumerable<uint> EdgeRemovals()
    {
        foreach(ElementRemoved<Edge> edge in RemovedEdges.Values)
        {
            yield return edge.ID;
        }
    }
}

/// <summary>
/// Holds type of modification an <see cref="IElement"/> has.
/// </summary>
public enum ModificationType
{
    /// <summary>
    /// Adds new element to a graph.
    /// </summary>
    Add, 
    
    /// <summary>
    /// Modifies an element on a graph.
    /// </summary>
    Modify,
    
    /// <summary>
    /// Removes an elemet on a graph.
    /// </summary>
    Remove
}

/// <summary>
/// Read only log for incoming changes for a <see cref="IGraph{TNode}"/>. Stores additional data: type of modification of an
/// <see cref="IElement"/> (Add, Modify, Delete), old value of an <see cref="IElement"/> (if any), and new value of an <see cref="IElement"/> (if any).
/// </summary>
/// <typeparam name="TNode">Type of node used in the graph to log changes from.</typeparam>
public interface IReadOnlyModificationLog<TNode> : GraphChangeSet<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Graph to reference the changes from.
    /// </summary>
    IReadOnlyGraph<TNode> BaseGraph {get;}

    /// <summary>
    /// Dictionary for type of modifications (Add, Remove, Modify) each <see cref="INode"/> have.
    /// </summary>
    IReadOnlyDictionary<uint, ModificationType> NodeModType {get;}

    /// <summary>
    /// Dictionary for type of modifications (Add, Remove, Modify) each <see cref="Edge"/> have.
    /// </summary>
    IReadOnlyDictionary<uint, ModificationType> EdgeModType {get;}

    /// <summary>
    /// Dictionary for <see cref="INode"/>s which was/will be added.
    /// </summary>
    IReadOnlyDictionary<uint, ElementAdded<TNode>> NewNodes {get;}

    /// <summary>
    /// Dictionary for <see cref="Edge"/>s which was/will be added.
    /// </summary>
    IReadOnlyDictionary<uint, ElementAdded<Edge>> NewEdges {get;}

    /// <summary>
    /// Dictionary for <see cref="INode"/>s which was/will be modified. Contains the original and new value of the <see cref="INode"/>.
    /// </summary>
    IReadOnlyDictionary<uint, ElementModified<TNode>> ModifiedNodes {get;}

    /// <summary>
    /// Dictionary for <see cref="Edge"/>s which was/will be modified. Contains the original and new value of the <see cref="Edge"/>.
    /// </summary>
    IReadOnlyDictionary<uint, ElementModified<Edge>> ModifiedEdges {get;}

    /// <summary>
    /// Dictionary for <see cref="INode"/>s which was/will be removed. Contains its original value.
    /// </summary>
    IReadOnlyDictionary<uint, ElementRemoved<TNode>> RemovedNodes {get;}

    /// <summary>
    /// Dictionary for <see cref="Edge"/>s which was/will be removed. Contains its original value.
    /// </summary>
    IReadOnlyDictionary<uint, ElementRemoved<Edge>> RemovedEdges {get;}
}

/// <summary>
/// Log of an <see cref="IElement"/> which is modified. Used in a <see cref="GraphChangeLog{TNode}"/>.
/// </summary>
/// <typeparam name="TElement">Type of an element which is modified. Typically an edge or a type of node.</typeparam>
/// <param name="NewElement">The new value of the element after it was modified.</param>
/// <param name="OldElement">The old value of the element before it was modified.</param>
/// <param name="ID">Identifier of the element.</param>
public readonly record struct ElementModified<TElement>(TElement NewElement, TElement OldElement, uint ID) where TElement : struct;

/// <summary>
/// Log of an <see cref="IElement"/> which is removed. Used in a <see cref="GraphChangeLog{TNode}"/>.
/// </summary>
/// <typeparam name="TElement">Type of an element which is/will be removed. Typically an edge or a type of node.</typeparam>
/// <param name="Element">Value of an element which is/will be removed.</param>
/// <param name="ID">Identifier of the element.</param>
public readonly record struct ElementRemoved<TElement>(TElement Element, uint ID) where TElement : struct;

/// <summary>
/// Log of an <see cref="IElement"/> which is added. Used in a <see cref="GraphChangeLog{TNode}"/>.
/// </summary>
/// <typeparam name="TElement">Type of an element which is/will be added. Typically an edge or a type of node.</typeparam>
/// <param name="Element">Value of an element which is/will be added.</param>
/// <param name="ID">Identifier of the element.</param>
public readonly record struct ElementAdded<TElement>(TElement Element, uint ID) where TElement : struct;