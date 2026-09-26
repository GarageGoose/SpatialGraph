namespace GG.SpatialGraph.Metadata;

/// <summary>
/// Records changes from a graph.
/// </summary>
/// <typeparam name="TNode">Node which the base graph uses.</typeparam>
public class GraphHistory<TNode> : GraphReadOnlyPlugin<TNode> where TNode : struct, INode
{
    /// <summary>
    /// Amount of snapshots taken since the plugin was created.
    /// </summary>
    public int ModSnapshotCount => modSnapshots.Count - 1;

    /// <summary>
    /// List of graph modification snapshots. A modification snapshot is a ModificationLog which is taken every time the graph is updated, with index 0 being the oldest/first snapshot.
    /// </summary>
    public IReadOnlyList<IReadOnlyModificationLog<TNode>> ModSnapshots => modSnapshots;
    private List<IReadOnlyModificationLog<TNode>> modSnapshots = new();

    /// <summary>
    /// List of graph snapshots. A graph snapshot is a reconstructed Graph from accumulated ModificationLogs. Taken and stored in this list with TakeSnapshot().
    /// </summary>
    public IReadOnlyList<GraphSnapshot<TNode>> GraphSnapshot => graphSnapshot;
    private List<GraphSnapshot<TNode>> graphSnapshot = new();

    private Dictionary<int, GraphSnapshot<TNode>> snapshotDict = new();

    /// <summary>
    /// Create a graph history from a graph.
    /// </summary>
    /// <param name="baseGraph">Graph to record changes from.</param>
    public GraphHistory(IReadOnlyTrackedGraph<TNode> baseGraph) : base(baseGraph)
    {
        GraphSnapshot<TNode> snapshot = new(0, new(baseGraph));
        graphSnapshot.Add(snapshot);
        snapshotDict.Add(0, snapshot);
    }

    /// <summary>
    /// Reconstruct a graph from a specific modification step. A modification snapshot is a ModificationLog which is taken every time the graph is updated with each one counting as a single modStep, with index 0 being the oldest/first snapshot.
    /// </summary>
    /// <param name="modStep">Modification step to reconstruct a graph from.</param>
    /// <returns>Reconstructed graph.</returns>
    public GraphSnapshot<TNode> TakeSnapshot(int modStep)
    {
        if(snapshotDict.TryGetValue(modStep, out GraphSnapshot<TNode> graphSnapshotModStep))
        {
            return graphSnapshotModStep;
        }

        if(modStep <= ModSnapshotCount && modStep >= 0)
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
                foreach(TNode node in modSnapshots[i].GetNodeUpserts())
                {
                    if (!isNodeRecorded.Contains(node.ID))
                    {
                        isNodeRecorded.Add(node.ID);
                        modsAfterSnapshot.UpsertNode(node);
                    }
                }

                foreach(uint iD in modSnapshots[i].GetNodeRemovalIDs())
                {
                    if (!isNodeRecorded.Contains(iD))
                    {
                        isNodeRecorded.Add(iD);
                        modsAfterSnapshot.RemoveNode(iD);
                    }
                }

                foreach(Edge edge in modSnapshots[i].GetEdgeUpserts())
                {
                    if (!isEdgeRecorded.Contains(edge.ID))
                    {
                        isEdgeRecorded.Add(edge.ID);
                        modsAfterSnapshot.UpsertEdge(edge);
                    }
                }

                foreach(uint iD in modSnapshots[i].GetEdgeRemovalIDs())
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

    protected override void OnGraphUpdate(object? sender, IReadOnlyModificationLog<TNode> modLog) => modSnapshots.Add(modLog);
}

public readonly record struct GraphSnapshot<TNode>(int ModStep, Graph<TNode> Snapshot) where TNode : struct, INode;