using System;
using System.Collections.Generic;
using System.Text;

namespace MultiDimensionalArrays
{
    class Program
    {
        //string[,] matrix;   // 2d
        //string[,,] threeD;      // 3d
        public static void Main(string[] args)
        {
            int[,] array2D = {   // 1d bracket
                {1,2,3},   // 2d bracket   // row 0
                {4,5,6},      // row 1
                {7,8,9}        // row 2
            };
            //int[,] array2D2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } }; another way
            Console.WriteLine(array2D[1, 1]);        // 5
            Console.WriteLine(array2D[2, 0]);         // 7

            int[,,] array3D = {
                    {
                        {1,2 },
                        {3,4 }
                    },
                    {
                        { 5,6},
                        { 7,8}
                    }
                };
            Console.WriteLine(array3D[0, 0, 0]);

            int dimension1 = array2D.Rank;
            int dimension2 = array3D.Rank;
            Console.WriteLine("Rank of arr1 = " + dimension1);
            Console.WriteLine("Rank of arr2 = " + dimension2);
        }

    }
}
