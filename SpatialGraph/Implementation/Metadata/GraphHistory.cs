namespace GG.SpatialGraph.Metadata;

/// <summary>
/// Records history of a graph from accumulated ModificationLogs.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class GraphHistory<TNode> : GraphReadOnlyPlugin<TNode> where TNode : struct, INode
{
    //Mod step is a single iteration of a modification of the base graph
    public int ModStepMax => modHistory.Count - 1;

    private List<IReadOnlyModificationLog<TNode>> modHistory = new();
    public IReadOnlyList<IReadOnlyModificationLog<TNode>> ModHistory => modHistory;

    private List<GraphSnapshot<TNode>> graphSnapshot = new();
    public IReadOnlyList<GraphSnapshot<TNode>> GraphSnapshot => graphSnapshot;
    private Dictionary<int, GraphSnapshot<TNode>> snapshotDict = new();

    public GraphHistory(IReadOnlyTrackedGraph<TNode> baseGraph) : base(baseGraph)
    {
        GraphSnapshot<TNode> snapshot = new(0, new(baseGraph));
        graphSnapshot.Add(snapshot);
        snapshotDict.Add(0, snapshot);
    }

    public GraphSnapshot<TNode> TakeSnapshot(int modStep)
    {
        if(snapshotDict.TryGetValue(modStep, out GraphSnapshot<TNode> graphSnapshotModStep))
        {
            return graphSnapshotModStep;
        }

        if(modStep <= ModStepMax && modStep >= 0)
        {
            //Find the closest earlier snapshot to the modStep to base the changes from.
            int BaseSnapshotIndex = 0;
            int snapshotModStep = 0;
            while(BaseSnapshotIndex < graphSnapshot.Count && snapshotModStep < modStep)
            {
                BaseSnapshotIndex++;
                snapshotModStep = graphSnapshot[BaseSnapshotIndex].ModStep;
            }

            //closest earlier snapshot to the modStep
            Graph<TNode> newSnapshot = new(graphSnapshot[BaseSnapshotIndex].Snapshot);

            //Stores latest modifications succedding the snapshot
            BatchedModifications<TNode> modsAfterSnapshot = new();

            //Logs when an element is already recorded to ensure only the latest change is applied.
            HashSet<uint> isNodeRecorded = new();
            HashSet<uint> isEdgeRecorded = new();

            //Grabs the newest modification from each node and edges from the initial mod step of the base snapshot to the required mod step.
            //Iterate modifications from the required mod step back to the mod step just after the base snapshot
            for(int i = modStep; i > snapshotModStep; i--)
            {
                //Check if the current node is already recorded, if not, record it.
                //Since we are iterating from the newest mod log to the oldest, this should ensure that only the latest modification is recorded.
                //Repeats for every operation/elements.
                foreach(TNode node in modHistory[i].GetUpsertedNodes())
                {
                    if (!isNodeRecorded.Contains(node.ID))
                    {
                        isNodeRecorded.Add(node.ID);
                        modsAfterSnapshot.UpsertNode(node);
                    }
                }

                foreach(uint iD in modHistory[i].GetNodeRemovalID())
                {
                    if (!isNodeRecorded.Contains(iD))
                    {
                        isNodeRecorded.Add(iD);
                        modsAfterSnapshot.RemoveNode(iD);
                    }
                }

                foreach(Edge edge in modHistory[i].GetUpsertedEdges())
                {
                    if (!isEdgeRecorded.Contains(edge.ID))
                    {
                        isEdgeRecorded.Add(edge.ID);
                        modsAfterSnapshot.UpsertEdge(edge);
                    }
                }

                foreach(uint iD in modHistory[i].GetEdgeRemovalID())
                {
                    if (!isEdgeRecorded.Contains(iD))
                    {
                        isEdgeRecorded.Add(iD);
                        modsAfterSnapshot.RemoveEdge(iD);
                    }
                }
            }

            //Apply the recorded modifications to the base snapshot
            newSnapshot.ApplyBatchedModifications(modsAfterSnapshot);
            GraphSnapshot<TNode> graphSnapshotFinal = new(modStep, newSnapshot);
            snapshotDict.Add(modStep, graphSnapshotFinal);
            return graphSnapshotFinal;
        }

        //WIP: throw error, for now just return an empty graph
        return new();
    }

    protected override void OnGraphUpdate(object? sender, IReadOnlyModificationLog<TNode> modLog) => modHistory.Add(modLog);
}

public readonly record struct GraphSnapshot<TNode>(int ModStep, Graph<TNode> Snapshot) where TNode : struct, INode;