using c = System.Console;

namespace Lab2
{
    internal class q2
    {
        public static void Main()
        {
            c.WriteLine("Enter any number: ");
            int n = int.Parse(c.ReadLine());
            if (n > 0)
            {
                c.WriteLine("Entered Number "+n+" is Positive");
            }
            else if(n < 0)
            {
                c.WriteLine("Entered Number "+n+" is Negative");
            }
            else
            {
                c.WriteLine("Entered Number is Zero");
            }
            c.ReadLine();
        }
    }
}
