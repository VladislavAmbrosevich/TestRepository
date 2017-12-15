using System;

namespace MyLinq
{
    public interface IEnumeratorOfT<out T> : IEnumerator, IDisposable
    {
        T Current { get; }
    }
}