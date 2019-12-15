using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Alex Turner";
            obj.GetHashCode();

            //REFLECTION
            //var methodInfo = obj.GetType().GetMethod("GetHashCode()");
            //methodInfo.Invoke(null,null);


            dynamic excelObject = "AM";
            excelObject.Optimize();
            //object excelObject = "AM";        
            //excelObject.Optimize();       // object class does'nt contain any Optimize() method

            dynamic name = "Me";
            //name++; // RuntimeBinderException
            name = 1;   // Python is not the only python in the industry bitch

            dynamic a = 10, b = 9;
            var c = a + b; // c ended up being a dynamic too

            int i = 5;
            dynamic d = i;      // d has become an integer

            long l = 10;
            d = l; //When converting from dynamic to static types,
            // if the runtime type of the dynamic object is implicitly convertible
            // to the target type, casting is not needed.


            

        }
    }
}
