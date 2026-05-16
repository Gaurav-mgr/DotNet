using c = System.Console;

namespace Lab3
{
    internal class q6
    {
        //pass by value
        public static void sum(int a)
        {
            a +=  5;
            c.WriteLine("Inside sum method: a="+a);
        }

        //pass by reference
        public static void dec(ref int b)
        {
            b -= 5;
            c.WriteLine("Inside dec method: b="+b);
        }
        public static void Main()
        {
            //pass by value
            int a = 5;
            c.WriteLine("Call by Value Example: ");
            c.WriteLine("Before call by value: a = "+ a);
            sum(a);
            c.WriteLine("After call by value: a = "+ a);

            //pass by reference 
            int b = 10;
            c.WriteLine("\nCall by Reference Example: ");
            c.WriteLine("Before call by reference: b = "+ b);
            dec(ref b);
            c.WriteLine("After call by reference: b = "+ b);

            c.ReadLine();

        }
    }
}
