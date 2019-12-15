using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Alex Turner";
            obj.GetHashCode();
            Console.WriteLine(obj.GetHashCode());
        }
    }
}
