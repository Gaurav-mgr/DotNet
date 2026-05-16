using c = System.Console;

namespace Lab3
{
    internal class q9
    {
        public static bool IsPrime(int num)
        {
            bool isPrime = true;
            if (num < 2) isPrime = false;
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }
         public static void Main()
        {
            int[] arr = { 1, 2, 5, 6, 73, 64, 3, 7 };

            c.Write("Array Elements: ");
            foreach(int data in arr)
                c.Write(data + " ");

            c.WriteLine("\n\nPrime numbers in the array: ");
            foreach(int n in arr)
            {
                bool prime = IsPrime(n);
                if(prime)
                    c.WriteLine(n);
            }
            c.ReadLine();
        }
    }
}
