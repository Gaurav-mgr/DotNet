using c = System.Console;

namespace Lab6
{
    public class Sum
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)

        {
            return a + b;
        }
    }
    public class MethodOverloadingEx
    {
        public static void Main()
        {
            Sum s = new Sum();
            c.WriteLine("Sum of two integers is: " + s.Add(2, 3));
            c.WriteLine("Sum of three integers is: " + s.Add(2, 3, 4));
            c.WriteLine("Sum of two doubles is: " + s.Add(2.5, 3.5));
            c.ReadLine();
        }
    }
}
