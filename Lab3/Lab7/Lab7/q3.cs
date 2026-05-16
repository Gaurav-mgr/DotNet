using System;
using c = System.Console;

namespace Lab7
{
    public delegate void Msg(string msg);
    internal class q3
    {
        static void Main()
        {
            Action<string> print = (msg) => c.WriteLine(msg);
            print("Action returns nothing.");

            Func<int, int, int> add = (a, b) => a + b;
            int result = add(10, 5);
            c.WriteLine($"Func: 10 + 5 = {result}");

            Predicate<int> isEven = (n) => n % 2 == 0;
            c.WriteLine($"Predicate: Is 2 even? {isEven(2)}");

            c.ReadLine();
        }
    }
}
