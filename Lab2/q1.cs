using c = System.Console;

namespace Lab2
{
    internal class q1
    {
        static void Main()
        {
            c.WriteLine("Enter any number: ");
            int n = int.Parse(c.ReadLine());
            string check = (n%2 == 0) ? "Even" : "Odd";
            c.WriteLine("Entered Number "+n+" is "+check);
            c.ReadKey();
        }
    }
}
