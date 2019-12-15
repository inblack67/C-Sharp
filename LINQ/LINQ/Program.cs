using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }

    }

    public class BookRepo
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){ Title="Tim Buchalka", Price=5},
                new Book(){ Title="Mosh Hamedani", Price=9.99F},
                new Book(){ Title="Bucky Roberts", Price=12},
                new Book(){ Title="Brad Traversy", Price=7},
                new Book(){ Title="Abdul Bari", Price=9},
                new Book(){ Title="Mosh Hamedani", Price=9.0F},
            };
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepo().GetBooks();
            //var cheapBooks = books.Where(b => b.Price < 10); // awesome!
            //var cheapBooks = books.Where(b => b.Price < 10).OrderBy(b => b.Title);

            //LINQ QUERY OPERATOR
            Console.WriteLine("Linq Query Operator");
            var cheapBooksAgain = from b in books
                                  where (b.Price < 10)
                                  orderby (b.Title)
                                  select (b.Title);

            Console.WriteLine("LINQ QUERY OPERATOR");

            foreach (var x in cheapBooksAgain)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();

            //LINQ EXTENSION METHODS
            var cheapBooks = books
                            .Where(b => b.Price < 10)
                            .OrderBy(b => b.Title)
                            .Select(b => b.Title);

            Console.WriteLine("LINQ EXTENSION METHODS");
            Console.WriteLine("CHEAP");
            foreach (var book in cheapBooks)
            {
                //Console.WriteLine("Less than 10 dollars " + book.Title + " " + book.Price);
                Console.WriteLine(book);
            }

            Console.WriteLine();

            Console.WriteLine("Single/Default");
            var singleOrDefault = books.SingleOrDefault(b => b.Title == "Abdul Bari");
            Console.WriteLine(singleOrDefault != null); // True, i.e. yes the book is in there

            Console.WriteLine();

            Console.WriteLine("First/Default");
            //var first = books.First();
            var first = books.First(b => b.Title == "Mosh Hamedani");
            Console.WriteLine(first.Title + " " + first.Price);
            var firstOrDefault = books.FirstOrDefault(b => b.Title == "Mosh Hamedani");
            Console.WriteLine(firstOrDefault.Title + " " + firstOrDefault.Price);

            Console.WriteLine();
            Console.WriteLine("Skip/Take");
            var skipTake = books.Skip(2).Take(3);
            foreach(var x in skipTake)
                Console.WriteLine(x.Title + " " + x.Price);

            Console.WriteLine();
            Console.WriteLine("MIN/MAX");
            var minPrice = books.Min(b => b.Price);
            Console.WriteLine(minPrice);
            var maxPrice = books.Max(b => b.Price);
            Console.WriteLine(maxPrice);

            Console.WriteLine();
            Console.WriteLine("Sum");
            var totalPrices = books.Sum(b => b.Price);
            Console.WriteLine(totalPrices);

            Console.WriteLine();
            Console.WriteLine("Average Price");
            var avgPrice = books.Average(b => b.Price);
            Console.WriteLine(avgPrice);

            // filter collections

            // without LINQ
            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if (book.Price < 10)
            //    {
            //        cheapBooks.Add(book);
            //    }
            //}




        }
    }
}
