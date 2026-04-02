using c = System.Console;

namespace Lab2
{
    class q8
    {
        public static void Main()
        {
            c.WriteLine("Enter the term: ");
            int n = int.Parse(c.ReadLine());

            int a = 0, b = 1, fib = 0;

            if (n == 1) fib = a;
            else if (n == 2) fib = b;
            
            else
            {
                for (int i = 3; i <= n; i++)
                {
                    fib = a + b;
                    a = b;
                    b = fib;
                }
            }

            c.WriteLine("The " + n + "th Fibonacci term is: " + fib);
            c.ReadLine();
        }
    }
}
