using System.Numerics;
namespace GG.NodeGraph;

/// <summary>
/// Base interface for all elements.
/// </summary>
public interface IElement
{
    uint ID {get;}
}

/// <summary>
/// Base interface for all nodes.
/// </summary>
public interface INode : IElement;

/// <summary>
/// A line segment from 2 nodes.
/// </summary>
public readonly record struct Edge(uint ID, uint NodeID1, uint NodeID2);

/// <summary>
/// An enum for identifying if a node is the 1st or 2nd node in an edge (or even if its in an edge at all).
/// </summary>
public enum NodeEdgeAssignment
{
    Node1, Node2, None
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
    Node, Edge
}

/// <summary>
/// Generic element identifier.
/// </summary>
/// <param name="Type">Type of element, either Node or Edge.</param>
/// <param name="ID">ID of the element.</param>
public readonly record struct ElementID(ElementType Type, uint ID);