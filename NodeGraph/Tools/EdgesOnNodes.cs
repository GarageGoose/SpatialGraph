using GG.NodeGraph.Plugin;

namespace GG.NodeGraph.Tools;

/// <summary>
/// A graph plugin that records connected edges on a node.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class EdgesOnNodes<TNode> : GraphPlugin<TNode> where TNode : struct, INode
{
    Dictionary<uint, HashSet<uint>> edgesOnNode = new();
    public IReadOnlyDictionary <uint, HashSet<uint>> EdgesOnNode;
    public EdgesOnNodes(GraphExtendable<TNode> graphToConnect, int pluginIndex = -1) : base(graphToConnect)
    {
        EdgesOnNode = edgesOnNode;
    }

    protected internal override void OnInitialize()
    {
        foreach(Edge edge in Graph.Edges.Values)
        {
            AddEdgeOnNode(edge);
        }
    }

    protected internal override void OnModificationFinished(IReadOnlyModificationLog<TNode> Log)
    {
        foreach(uint edgeKey in Log.ROEdges.Keys)
        {
            switch (Log.EdgeModificationType(edgeKey))
            {
                case ModificationType.Add:
                    AddEdgeOnNode((Edge)Log.ROEdges[edgeKey]!);
                    break;

                case ModificationType.Modify:
                    RemoveEdgeOnNode((Edge)Log.RetrieveInitialEdge(edgeKey)!);
                    AddEdgeOnNode((Edge)Log.ROEdges[edgeKey]!);
                    break;

                case ModificationType.Remove:
                    RemoveEdgeOnNode((Edge)Log.RetrieveInitialEdge(edgeKey)!);
                    break;

                default:
                    break;
            }
        }
    }

    void AddEdgeOnNode(Edge edge)
    {
        if(edgesOnNode.TryGetValue(edge.VertexID1, out HashSet<uint>? edgesOnNode1))
        {
            edgesOnNode1.Add(edge.ID);
        }
        else
        {
            HashSet<uint> newEdgesOnNode = [edge.ID];
            edgesOnNode[edge.VertexID1] = newEdgesOnNode;
        }

        if(edgesOnNode.TryGetValue(edge.VertexID2, out HashSet<uint>? edgesOnNode2))
        {
            edgesOnNode2.Add(edge.ID);
        }
        else
        {
            HashSet<uint> newEdgesOnNode = [edge.ID];
            edgesOnNode[edge.VertexID2] = newEdgesOnNode;
        }
    }

    void RemoveEdgeOnNode(Edge edge)
    {
        edgesOnNode[edge.VertexID1].Remove(edge.ID);
        if(edgesOnNode[edge.VertexID1].Count == 0)
        {
            edgesOnNode.Remove(edge.VertexID1);
        }

        edgesOnNode[edge.VertexID2].Remove(edge.ID);
        if(edgesOnNode[edge.VertexID2].Count == 0)
        {
            edgesOnNode.Remove(edge.VertexID2);
        }
    }
}
