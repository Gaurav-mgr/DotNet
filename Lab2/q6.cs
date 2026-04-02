using c = System.Console;

namespace Lab2
{
    internal class q6
    {
        public static void Main()
        {
            c.WriteLine("Enter any number combination: ");
            int n = int.Parse(c.ReadLine());

            int original = n, arm = 0 ;
            int len = n.ToString().Length;
            while (n>0)
            { 
                int digit = n % 10;
                int pow = 1;
                for(int i = 0; i < len; i++)
                {
                    pow *= digit;
                }
                arm += pow;
                n /= 10;
            }
            if(original == arm) {
                c.WriteLine(original + " is an Armstrong Number.");
            }
            else
            {
                c.WriteLine(original + " is not an Armstrong Number.");
            }
            c.ReadLine();
        }
    }
}
