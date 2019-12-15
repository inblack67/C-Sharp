using System;
using System.Collections.Generic;

namespace LambdaExpressions
{
    public class Book
    {
        public float Price { get; set; }
        public string Title { get; set; }
    }

    public class BookRepo
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Title="Title 1", Price=5},
                new Book() { Title="Title 2", Price=7},
                new Book() { Title="Title 3", Price=17}
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int factor = 10;

            Func<int, int> squareWithLambda = n => n * n;
            Console.WriteLine("Square -> " + squareWithLambda(25));

            Func<int, int> fact = n => n * factor;
            Console.WriteLine("Factor -> " + fact(10));

            // write the code to return all the books cheaper than $10
            Console.WriteLine();
            var books = new BookRepo().GetBooks();

            //var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        //static bool IsCheaperThan10Dollars(Book book)
        //{
        //    return book.Price < 10;
        //}

        //public int Square(int n)
        //{
        //    return n ^ n;
        //}
    }
}
