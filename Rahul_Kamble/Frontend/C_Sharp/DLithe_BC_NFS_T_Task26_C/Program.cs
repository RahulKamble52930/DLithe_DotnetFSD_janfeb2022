
using System;

namespace Sort_1DArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1D array example (reversing)");
            int[] num = { 22, 50, 11, 2, 49 };
            Array.Reverse(num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i] + " ");
            }



            Console.WriteLine("*************************************");
            Console.WriteLine("2D array example");
            // create 2D array of strings.
            string[,] array = new string[,]
            {
            {"cat", "dog" },{"bird","fish"}
       ,
            };
            //  access (and print) values.
            Console.WriteLine(array[0, 0]);
            Console.WriteLine(array[0, 1]);
            Console.WriteLine(array[1, 0]);
            Console.WriteLine(array[1, 1]);




            Console.WriteLine("*************************************");
            Console.WriteLine("2D array example");
            // create a jagged array
            int[][] jaggedArray = {
                 new int[] {1, 3, 5},
                 new int[] {2, 4},
              };

            // print elements of jagged array
            Console.WriteLine("jaggedArray[1][0]: " + jaggedArray[1][0]);
            Console.WriteLine("jaggedArray[1][1]: " + jaggedArray[1][1]);

            Console.WriteLine("jaggedArray[0][2]: " + jaggedArray[0][2]);

            Console.ReadLine();

        }
    }
}