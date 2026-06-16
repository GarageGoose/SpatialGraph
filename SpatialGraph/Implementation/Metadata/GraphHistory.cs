namespace GG.SpatialGraph.Metadata;

/// <summary>
/// Records history of a graph from accumulated ModificationLogs.
/// </summary>
/// <typeparam name="TNode">Nodes to be used, either Node2D or Node3D (or a custom one with a base Node) depending on the dimensions of the graph.</typeparam>
public class GraphHistory<TNode> : GraphMetadata<TNode> where TNode : struct, INode
{
    //Mod step is a single iteration of a modification of the base graph
    public int ModStep => modHistory.Count - 1;

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
        if(modStep <= ModStep && modStep >= 0)
        {
            //Find the closest earlier snapshot to the modStep to base the changes from.
            int BaseSnapshotIndex = 0;
            int snapshotModStep = 0;
            while(BaseSnapshotIndex < graphSnapshot.Count && snapshotModStep < modStep)
            {
                BaseSnapshotIndex++;
                snapshotModStep = graphSnapshot[BaseSnapshotIndex].ModStep;
            }


            Graph<TNode> newSnapshot = new(graphSnapshot[BaseSnapshotIndex].Snapshot);
            BatchedModifications<TNode> modsAfterSnapshot = new();
            HashSet<uint> isNodeRecorded = new();
            HashSet<uint> isEdgeRecorded = new();

            //Grabs the newest modification from each node and edges from the initial mod step of the base snapshot to the required mod step.
            //Iterate modifications from the required mod step back to the mod step just after the base snapshot
            for(int i = modStep; i > snapshotModStep; i--)
            {
                foreach(KeyValuePair<uint, ElementModificationLog<TNode>> nodeMod in modHistory[i].NodeMods)
                {
                    //Check if the current node is already recorded, if not, record it.
                    //Since we are iterating from the newest mod log to the oldest, this should ensure that only the latest modification is recorded.
                    if (!isNodeRecorded.Contains(nodeMod.Key))
                    {
                        isNodeRecorded.Add(nodeMod.Key);
                        if(nodeMod.Value.NewElement == null)
                        {
                            modsAfterSnapshot.RemoveNode(nodeMod.Key);
                            continue;
                        }
                        modsAfterSnapshot.UpsertNode((TNode)nodeMod.Value.NewElement);
                    }
                }

                //Repeat for edges
                foreach(KeyValuePair<uint, ElementModificationLog<Edge>> edgeMod in modHistory[i].EdgeMods)
                {
                    if (!isEdgeRecorded.Contains(edgeMod.Key))
                    {
                        isEdgeRecorded.Add(edgeMod.Key);
                        if(edgeMod.Value.NewElement == null)
                        {
                            modsAfterSnapshot.RemoveEdge(edgeMod.Key);
                            continue;
                        }
                        modsAfterSnapshot.UpsertEdge((Edge)edgeMod.Value.NewElement);
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

    protected override void OnGraphUpdate(IReadOnlyModificationLog<TNode> modLog) => modHistory.Add(modLog);
}

public readonly record struct GraphSnapshot<TNode>(int ModStep, Graph<TNode> Snapshot) where TNode : struct, INode;