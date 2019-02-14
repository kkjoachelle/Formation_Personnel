using System;
namespace GENERICS
{
    // where T : IComparable
    // where T : Product
    // where T : Struct
    // where T : Class
    // where T : new()

    public class Utilities_where2<T> where T : IComparable
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        //creation avec un type generique
        public T Max(T a, T b) 
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}

    