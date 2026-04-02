using c = System.Console;

namespace Lab2
{
    internal class q10
    {
        public static void Main()
        {
            c.Write("Enter a positive number: ");
            int n = int.Parse(c.ReadLine());

            int i = 1;

            here:
            if (i <= n)
            {
                int cube = i * i * i;
                c.WriteLine("Cube of " + i + " = " + cube);
                i++;
                goto here;
            }

            c.ReadLine();
        }
    }
}
