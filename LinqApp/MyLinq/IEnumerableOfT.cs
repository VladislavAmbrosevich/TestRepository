namespace MyLinq
{
    public interface IEnumerableOfT<out T> : IEnumerable
    {
        IEnumeratorOfT<T> GetEnumerator();
    }
}