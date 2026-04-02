using c = System.Console;


namespace Lab2
{
    internal class q9
    {
        public static void Main()
        {
            int sum = 0;
            while (true)
            {
                c.Write("Enter a number: ");
                int n = int.Parse(c.ReadLine());
                if (n < 0)
                {
                    break;
                }
                sum += n;
                c.WriteLine("Sum: " + sum + "\n");
            }
            c.WriteLine("\nFound Negative Number Input. Exiting...");
            c.ReadLine();
        }
    }
}
