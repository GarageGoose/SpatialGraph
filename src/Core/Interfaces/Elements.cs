using System.Numerics;
namespace SpatialGraph;

/// <summary>
/// Base interface for all elements.
/// </summary>
public interface IElement
{
    /// <summary>
    /// Identifier for an element.
    /// </summary>
    /// <remarks>
    /// Used within <see cref="IGraph{TNode}"/>s.
    /// </remarks>
    uint ID {get;}
}

/// <summary>
/// Represents a node in a <see cref="IGraph{TNode}"/>. Base interface for all nodes.
/// </summary>
public interface INode : IElement;

/// <summary>
/// Represents a connection between 2 <see cref="INode"/> endpoints.
/// </summary>
/// <param name="ID">Identifier for the element.</param>
/// <param name="NodeID1">ID of the node for the first endpoint of the edge.</param>
/// <param name="NodeID2">ID of the node for the second endpoint of the edge.</param>
public readonly record struct Edge(uint ID, uint NodeID1, uint NodeID2) : IElement;

/// <summary>
/// An enum for identifying the <see cref="INode"/> in the first or second endpoint of an <see cref="Edge"/>.
/// </summary>
public enum NodeInEdge
{
    /// <summary>
    /// Refers to the <see cref="INode"/> in the first endpoint (<see cref="Edge.NodeID1"/>) of an edge.
    /// </summary>
    First,
    
    /// <summary>
    /// Refers to the <see cref="INode"/> in the second endpoint (<see cref="Edge.NodeID2"/>) of an edge.
    /// </summary>
    Second,
    
    /// <summary>
    /// Node is not in an edge.
    /// </summary>
    None
}

/// <summary>
/// Node with coordinate in 2 dimensions. Used for 2D graphs.
/// </summary>
/// <param name="ID">Identifier for the element.</param>
/// <param name="Loc">Location of the node.</param>
public readonly record struct Node2D(uint ID, Vector2 Loc) : INode;

/// <summary>
/// Node with coordinate in 3 dimensions. Used for 3D graphs.
/// </summary>
/// <param name="ID">Identifier for the element.</param>
/// <param name="Loc">Location of the node.</param>
public readonly record struct Node3D(uint ID, Vector3 Loc) : INode;

/// <summary>
/// Enum for classifying <see cref="IElement"/>.
/// </summary>
public enum ElementType
{
    /// <summary>
    /// <see cref="IElement"/> is a node.
    /// </summary>
    Node,
    
    /// <summary>
    /// <see cref="IElement"/> is an edge.
    /// </summary>
    Edge
}

/// <summary>
/// Generic <see cref="IElement"/> identifier.
/// </summary>
/// <param name="Type">Type of element, either Node or Edge.</param>
/// <param name="ID">ID of the element.</param>
public readonly record struct ElementID(ElementType Type, uint ID);