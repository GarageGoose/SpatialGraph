using System.Numerics;
namespace GG.SpatialGraph;

/// <summary>
/// Base interface for all elements.
/// </summary>
public interface IElement
{
    /// <summary>
    /// Unique identifier for an element.
    /// </summary>
    uint ID {get;}
}

/// <summary>
/// Base interface for all nodes.
/// </summary>
public interface INode : IElement;

/// <summary>
/// A line segment which is formed from 2 nodes.
/// </summary>
public readonly record struct Edge(uint ID, uint NodeID1, uint NodeID2) : IElement;

/// <summary>
/// An enum for identifying the first or second node in a Edge.
/// </summary>
public enum NodeInEdge
{
    /// <summary>
    /// Refers to the first node (NodeID1) in an edge.
    /// </summary>
    First,
    
    /// <summary>
    /// Refers to the second node (NodeID1) in an edge.
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
public readonly record struct Node2D(uint ID, Vector2 Loc) : INode;

/// <summary>
/// Node with coordinate in 3 dimensions. Used for 3D graphs.
/// </summary>
public readonly record struct Node3D(uint ID, Vector3 Loc) : INode;

/// <summary>
/// Enum for classifying elements.
/// </summary>
public enum ElementType
{
    /// <summary>
    /// Element is a node.
    /// </summary>
    Node,
    
    /// <summary>
    /// Element is an edge.
    /// </summary>
    Edge
}

/// <summary>
/// Generic element identifier.
/// </summary>
/// <param name="Type">Type of element, either Node or Edge.</param>
/// <param name="ID">ID of the element.</param>
public readonly record struct ElementID(ElementType Type, uint ID);