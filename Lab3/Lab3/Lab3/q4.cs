using c = System.Console;

namespace Lab3
{
    internal class q4
    {
        public static void Main()
        {
            int[,] arr1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] arr2 = new int[3, 3] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
            int[,] mulmat = new int[3, 3];

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    mulmat[i, j] = 0;
                    for(int k = 0; k < 3; k++)
                        mulmat[i, j] += arr1[i, k] * arr2[k, j];
                }
            }

            c.WriteLine("The first 3x3 matrix is: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    c.Write(arr1[i, j] + " ");
                c.WriteLine();
            }

            c.WriteLine("\nThe second 3x3 matrix is: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    c.Write(arr2[i, j] + " ");
                c.WriteLine();
            }

            c.WriteLine("\nThe multiplication of two 3x3 matrix is: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    c.Write(mulmat[i, j] + " ");
                c.WriteLine();
            }

            c.ReadLine();

        }
    }
}
