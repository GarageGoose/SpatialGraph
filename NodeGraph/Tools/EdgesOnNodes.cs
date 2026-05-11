using GG.NodeGraph.Plugin;

namespace GG.NodeGraph.Tools;

/*
/// <summary>
/// A graph plugin that records connected edges on a node.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph. wow ok</typeparam>
public class EdgesOnNodes<TNode> where TNode : struct, INode
{
    IReadOnlyTrackedGraph<TNode> baseGraph;
    Dictionary<uint, HashSet<uint>> edgesOnNode = new();
    public IReadOnlyDictionary <uint, HashSet<uint>> EdgesOnNode => edgesOnNode;
    public EdgesOnNodes(IReadOnlyTrackedGraph<TNode> baseGraph)
    {
        this.baseGraph = baseGraph;
        foreach(Edge edge in baseGraph.Edges.Values)
        {
            AddEdgeOnNode(edge);
        }
    }

    void OnModificationApplied(IReadOnlyModificationLog<TNode> Log)
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
        if(edgesOnNode.TryGetValue(edge.NodeID1, out HashSet<uint>? edgesOnNode1))
        {
            edgesOnNode1.Add(edge.ID);
        }
        else
        {
            HashSet<uint> newEdgesOnNode = [edge.ID];
            edgesOnNode[edge.NodeID1] = newEdgesOnNode;
        }

        if(edgesOnNode.TryGetValue(edge.NodeID2, out HashSet<uint>? edgesOnNode2))
        {
            edgesOnNode2.Add(edge.ID);
        }
        else
        {
            HashSet<uint> newEdgesOnNode = [edge.ID];
            edgesOnNode[edge.NodeID2] = newEdgesOnNode;
        }
    }

    void RemoveEdgeOnNode(Edge edge)
    {
        edgesOnNode[edge.NodeID1].Remove(edge.ID);
        if(edgesOnNode[edge.NodeID1].Count == 0)
        {
            edgesOnNode.Remove(edge.NodeID1);
        }

        edgesOnNode[edge.NodeID2].Remove(edge.ID);
        if(edgesOnNode[edge.NodeID2].Count == 0)
        {
            edgesOnNode.Remove(edge.NodeID2);
        }
    }
}*/
