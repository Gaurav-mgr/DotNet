using System;
using c = System.Console;

namespace Lab7
{
    public delegate void Message(int n);
    internal class q2
    {
        static void Main()
        {
            Func<int, int> square = delegate(int x) { return x * x; };
            Func<int, int> cube = x => x * x * x;

            c.Write("Anonymous Method: "+square(5));
            c.Write("\nLambda Method: "+cube(4));

            c.ReadLine();
        }
    }
}
