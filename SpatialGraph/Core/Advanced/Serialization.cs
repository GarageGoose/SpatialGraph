namespace GG.SpatialGraph.Serializable;

//Should be good enough, ill expand it eventually when needed.
/// <summary>
/// Common interface for serialization/deserialization.
/// </summary>
/// <typeparam name="T">Type of the class implementing this.</typeparam>
public interface IGraphSerializable<T>
{
    static abstract T Load(string data);
    public string Save();
}