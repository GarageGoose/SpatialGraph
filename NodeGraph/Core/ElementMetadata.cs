namespace GG.NodeGraph;

public readonly record struct EdgeWeight(float Weight);

public readonly record struct ConnectedNodes(IReadOnlySet<uint> NodeIDs);

public readonly record struct ConnectedEdges(IReadOnlySet<uint> EdgeIDs);