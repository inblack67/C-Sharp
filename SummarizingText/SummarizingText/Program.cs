using System;
using System.Collections.Generic;

namespace SummarizingText
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var sentence = "pissin' our pants yet?";
            var summary = summarizeText(sentence);
            System.Console.WriteLine(summary);

            static string summarizeText(string sentence)
            {
                const int maxLength = 10;
                if (sentence.Length < maxLength)
                    return sentence;
                else
                {
                    var words = sentence.Split(' ');
                    var totalChar = 0;
                    var summaryWords = new List<string>();
                    foreach (var x in words)
                    {
                        summaryWords.Add(x);
                        totalChar += x.Length + 1;
                        if (totalChar > maxLength)
                            break;
                    }
                    var summary = String.Join(" ", summaryWords) + "...";
                    return summary;
                }
            }
        }
    }
}
