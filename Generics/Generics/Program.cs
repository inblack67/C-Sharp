using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Books() {Isbn = "1111",Title = "The Call of the Wild", Price = 67};
            var numbers = new GenericList<int>();
            numbers.Add(5);
            var dict = new GenericDictionary<string,Books>();
            dict.Add("3323",new Books());
            var num = new Nullable<int>(5);
            Console.WriteLine(" has a value? " + num.HasValue);
            Console.WriteLine(" value itself: " + num.GetValueOrDefault());
        }
    }
}
