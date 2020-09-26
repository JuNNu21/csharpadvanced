using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp1
{
    class Ex04
    {
        static void Main(string[] args)
        {
            string[] names = new string[2];
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine("Enter a name please : ");
            //    names[i] = Console.ReadLine();
            //}
            //foreach (string item in names)
            //{
            //    Console.WriteLine("Welcome "+item);
            //}

            //multidimensional array
            //int[,] TwoD = new int[,] { { 2, 3, 4 }, { 3, 5, 5 }, { 4, 5, 6 } }; //3x3, Rank gives the dimensions
            //Console.WriteLine("Dimensions : " + TwoD.Rank);
            //Console.WriteLine("First Dimension : " + TwoD.GetLength(0));
            //Console.WriteLine("Second Dimension : " + TwoD.GetLength(1));

            //for (int i = 0; i < TwoD.GetLength(0); i++)
            //{ 
            //    for (int j = 0; j < TwoD.GetLength(1); j++)
            //    {
            //        Console.Write(TwoD[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Jagged arrays : array of arrays

            int[][] School = new int[5][]; //Rows are 5....
            School[0] = new int[] { 45, 55, 65, 44, 23};
            School[1] = new int[] { 45, 55, 68};
            School[2] = new int[] { 90, 98, 78, 78, 85};
            School[3] = new int[] { 45, 11};
            School[4] = new int[] { 45, 55, 98, 65};

            for (int i = 0; i < School.Length; i++)
            {
                foreach (int no in School[i])
                {
                    Console.Write(no + " ");
                }
                Console.WriteLine();
            }




        }
    }
}
