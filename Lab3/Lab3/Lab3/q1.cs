using c = System.Console;

namespace Lab3
{
    internal class q1
    {
        public static void Main()
        {
            c.Write("Enter size of Array: ");
            int size = int.Parse(c.ReadLine());
            int[] arr = new int[size];

            for(int i = 0; i < size; i++)
            {
                c.Write("Enter " + (i + 1) + " element: ");
                int element = int.Parse(c.ReadLine());
                arr[i] = element;
            }

            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    continue;
                sum += arr[i];
            }

            c.WriteLine("\nSum of odd numbers in the array of size "+size+" is: " + sum);
            c.ReadLine();
        }

    }
}
