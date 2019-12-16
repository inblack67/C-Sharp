using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 7;
            var y = 0;
            Console.WriteLine("Div by Zero");
            try
            {
                var result = x / y;
                Console.WriteLine(result);
            }

            
            // most specific
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");
            }

            catch (ArithmeticException ex) { }
            // to most generic
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error has occured");
                // application won't crash now
            }


            Console.WriteLine();
            Console.WriteLine("Finally Demo");

            // finally will be called internally by clr -> dispose() by finally. 

            try
            {
                using (StreamReader s = new StreamReader("path"))
                {
                    s.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not this time bitch");
            }


            // manually calling finally and thus, dispose();

            //StreamReader streamReader = null;
            //try
            //{
            //    streamReader = new StreamReader("path");
            //    var content = streamReader.ReadToEnd();
            //    //throw new Exception(); to explicitly throw an exception
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An unexpected error has occured");
            //    // application won't crash now
            //}
            //// finally block will always be executed whether there are exceptions or not
            //finally
            //{
            //    if (streamReader != null)
            //        streamReader.Dispose();
            //}


            // CUSTOM EXCEPTIONS

            Console.WriteLine();
            Console.WriteLine("CUSTOM EXCEPTIONS");

            try
            {
                var ce = new CustomExceptions();
                ce.GetVideos("crap");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
