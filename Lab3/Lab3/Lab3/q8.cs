using c = System.Console;

namespace Lab3
{
    internal class q8
    {
        public static int add(int x, params int[] arr)
        {
            int s = x;
            for(int i=0;i<arr.Length; i++)
                s += arr[i];
            return s;
        }
        public static void Main()
        {
            int a = 1;
            int sum = add(a, 2, 3, 4, 5);
            c.WriteLine("The sum is: " + sum);
            c.ReadLine();
        }
    }
}
