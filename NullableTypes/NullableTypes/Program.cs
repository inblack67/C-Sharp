using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            //Nullable<DateTime> date = null;

            Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            // Console.WriteLine("Value: " + date.Value); // exception GetValueOrDefault() must be used instead of this

            //DateTime date2 = date; error
            Console.WriteLine();
            DateTime date2 = date.GetValueOrDefault(); //oka
            Console.WriteLine(date2);

            Console.WriteLine();
            DateTime? date3 = date2;        // value type can easily be converted to a nullable
            Console.WriteLine("Value type converted to nullable: " + date3.GetValueOrDefault());

            Console.WriteLine();
            DateTime date4 = date ?? DateTime.Now;
            Console.WriteLine("ShortHand of tertiary operator: " + date4);




        }
    }
}
