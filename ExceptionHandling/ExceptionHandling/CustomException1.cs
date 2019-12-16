using System;
namespace ExceptionHandling
{
    public class CustomException1 : Exception
    {
        public CustomException1(string message,
            Exception innerException)
            :base(message,innerException)   // calling base ctor of Exception class
        {

        }
    }
}
