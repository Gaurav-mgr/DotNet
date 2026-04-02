using c = System.Console;

namespace Lab2
{
    internal class q3
    {
        public static void Main()
        {
            c.WriteLine("Enter first number: ");
            int n1 = int.Parse(c.ReadLine());
            c.WriteLine("Enter second number: ");
            int n2 = int.Parse(c.ReadLine());
            c.WriteLine("Enter third number: ");
            int n3 = int.Parse(c.ReadLine());

            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    c.WriteLine("First number "+n1+" is the largest.");
                }
                else
                {
                    c.WriteLine("Third number "+n3+" is the largest.");
                }
            }
            else
            {
                if (n2 > n3)
                {
                    c.WriteLine("Second number "+n2+" is the largest.");
                }
                else
                {
                    c.WriteLine("Third number "+n3+" is the largest.");
                }
            }
            c.ReadLine();
        }
    }
}
