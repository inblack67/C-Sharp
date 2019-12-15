using System;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "What? Was the joke that bad";
            var result = str.ShortenString(5);
            Console.WriteLine(result + "...");

        }
    }

    public static class StringExtensions
    {
        public static string ShortenString(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("Words need to exist positively");
            if (numberOfWords == 0)
                return "";
            var words = str.Split(" ");
            if (words.Length < numberOfWords)
                return str;

            return String.Join(" ", words.Take(numberOfWords));
            // take the number of words and join them with spaces in between

        }
    }
}
