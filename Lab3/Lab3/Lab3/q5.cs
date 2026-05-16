using c = System.Console;

namespace Lab3
{
    internal class q5
    {
        public static void Main()
        {
            int[][] jgarr = new int[2][] ;

            jgarr[0] = new int[3] { 1, 2, 3 };
            jgarr[1] = new int[2] { 4, 5 };

            c.WriteLine("The elements in the jagged array is: ");
            for(int i = 0; i < jgarr.Length; i++)
            {
                for(int j = 0; j < jgarr[i].Length; j++)
                    c.Write(jgarr[i][j] + " ");
                c.WriteLine();
            }
            c.ReadLine();
        }
    }
}
