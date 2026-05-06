using System.Collections.ObjectModel;
namespace GG.NodeGraph.Plugin;

public abstract class GraphPlugin<TNode> where TNode : Node
{
    public bool CurrentlyConnectedToNode {get; private set;} = false;
    protected IReadOnlyGraph<TNode>? ConnectedNode {get; private set;}
    protected ObservableCollection<GraphPlugin<TNode>>? ConnectedNodePlugins {get; private set;}
    private GraphExtendable<TNode>? CurrentNode;

    internal void InvokeOnConnection(GraphExtendable<TNode> Node)
    {
        CurrentlyConnectedToNode = true;
        CurrentNode = Node;
        ConnectedNode = Node;
        ConnectedNodePlugins = Node.Plugins;
        OnConnection(Node);
    }
    internal void InvokeOnDisconnection()
    {
        OnDisconnection();
        CurrentlyConnectedToNode = false;
        CurrentNode = null;
        ConnectedNode = null;
        ConnectedNodePlugins = null;
    }

    protected virtual void OnConnection(GraphExtendable<TNode> Node){}
    protected virtual void OnDisconnection(){}
    protected internal virtual void OnModificationInitialize(GraphPlugin<TNode>? InitiatiatorPlugin){}
    protected internal virtual void OnModification(ModificationLog<TNode> Log, GraphPlugin<TNode>? InitiatiatorPlugin){}
    protected internal virtual void OnModificationFinished(ModificationLog<TNode> Log, GraphPlugin<TNode>? InitiatiatorPlugin){}
    protected void NodeModification(ModificationLog<TNode> Modification)
    {
        if(CurrentlyConnectedToNode)
        {
            CurrentNode!.ModificationInitiate(Modification, this);
        }
    }
}