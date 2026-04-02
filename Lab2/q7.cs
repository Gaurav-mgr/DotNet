using c = System.Console;

namespace Lab2
{
    internal class q7
    {
        public static void Main()
        {
            c.WriteLine("Enter any number: ");
            int n = int.Parse(c.ReadLine());
            int sum = 0;
            for(int i = 1; i <n; i++)
            {
                if (n % i != 0) continue;
                sum += i;
            }

            if(sum == n)
            {
                c.WriteLine(n + " is a Perfect Number.");
            }
            else
            {
                c.WriteLine(n + " is not a Perfect Number.");
            }
            c.ReadLine();
        }
    }
}
