namespace GG.SpatialGraph.Serializable;

//Should be good enough, ill expand it eventually when needed.
public interface IGraphSerializable<T>
{
    static abstract T Load(string data);
    public string Save();
}