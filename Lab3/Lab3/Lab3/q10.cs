using c = System.Console;

namespace Lab3
{
    internal class q10
    {
        public static void Main()
        {
            int[,] mat = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            c.WriteLine("Matrix: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c.Write(mat[i, j] + " ");
                }
                c.WriteLine();
            }

            int det = mat[0, 0] * (mat[1, 1] * mat[2, 2] - mat[1, 2] * mat[2, 1]) -
                      mat[0, 1] * (mat[1, 0] * mat[2, 2] - mat[1, 2] * mat[2, 0]) -
                      mat[0, 2] * (mat[1, 0] * mat[2, 1] - mat[1, 1] * mat[2, 0]);
            c.Write("\nDeterminant of Matrix: "+det);
            c.ReadLine();
        }
    }
}
