using System;
using System.Collections.Generic;
using System.IO;

namespace GenericsIntro
{
    public class Book
    {
        public string Name { get; set; }
        public int NumberOfBooks { get; set; }
        public double Price { get; set; }

        public Book() { }

    }

    public class GenericList<T>
    {
        public void Add(T value)
        {

        }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }

    public class Utilities<T> where T : IComparable, new() // helps in instantiating T
        // class itself
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // Generic Version

        public T Max(T a, T b) //where T : IComparable
        {

            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomethang(T value)
        {
            var obj = new T(); // intantiating intance of T
        }
    }

    public class BookStock<T> where T : Book
    {
        public float CountTheBooks(T stock)
        {
            return stock.NumberOfBooks;
        }
    }

    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;
            return default(T);
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {
            var numberOfBooks = new GenericList<int>();
            numberOfBooks.Add(57);

            var listOfBooks = new GenericList<Book>();
            listOfBooks.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());

            var num = new Nullable<int>(5);
            Console.WriteLine("Has a value ? " + num.HasValue);
            Console.WriteLine("Value " + num.GetValueOrDefault());
        }
    }
}

