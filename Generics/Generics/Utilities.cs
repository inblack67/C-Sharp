using System;
namespace Generics
{
    public class Utilities<T> where T : IComparable,new()
    {
        public T Max(T x, T y)
        {
            return x.CompareTo(y) > 0 ? x : y;
        }

        public void Instantiate()
        {
            var obj = new T();
        }
    }
}
