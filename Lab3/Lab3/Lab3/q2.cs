using c = System.Console;

namespace Lab3
{
    internal class q2
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

            int max = arr[0];
            int min = arr[0];

            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
                else if (arr[i] < min)
                    min = arr[i];
            }

            c.WriteLine("\nMaximum element in the array of size "+size+" is: " + max);
            c.WriteLine("Minimum element in the array of size " + size + " is: " + min);
            c.ReadLine();
        }
    }
}
