using c = System.Console;

namespace Lab2
{
    internal class q5
    {
        public static void Main()
        {
            c.WriteLine("Enter any number: ");
            int n = int.Parse(c.ReadLine());
            bool isPrime = true;

            if (n < 2)
            {
                isPrime = false;
            }
            for(int i = 2; i <= n; i++)
            {
                if(n%i == 0 && n % i == 1)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                c.WriteLine(n + " is a Prime Number.");
            }
            else
            {
                c.WriteLine(n + " is not a Prime Number.");
            }
            c.ReadLine();

        }
    }
}
