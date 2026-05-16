using System.Collections;
using c = System.Console;

namespace Lab3
{
    internal class q3
    {
        public static void Main()
        {
            int[,] arr = new int[3, 3] { {1, 2, 3}, { 4, 5, 6}, { 7, 8, 9} };
            int sum = 0;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    if (i == j)
                        sum += arr[i, j];
                }
            }

            c.WriteLine("The elements in 3x3 array is: ");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++) 
                    c.Write(arr[i, j] + " ");
                c.WriteLine();
            }

            c.WriteLine("\nSum of diagonal elements in the 3x3 array is: " + sum);
            c.ReadLine();
        }
    }
}
