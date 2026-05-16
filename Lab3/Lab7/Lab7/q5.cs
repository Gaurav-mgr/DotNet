using System;
using c = System.Console;

namespace Lab7
{
    public class q5
    {
        static void Main()
        {
            c.WriteLine("Divide By Zero Exception Handling:");
            try
            {
                int a = 10, b = 0;
                int result = a / b;
            } 
            catch (DivideByZeroException ex)
            {
                c.WriteLine($"Error: {ex.Message}");
            }

            c.WriteLine("\nIndex Out of Range Exception Handling:");
            try
            {
                int[] num = {1, 2, 3};
                c.WriteLine(num[3]);
            }catch(IndexOutOfRangeException ex)
            {
                c.WriteLine($"Error: {ex.Message}");
            }

            c.WriteLine("\nInvalid Cast Exception Handling:");
            try
            {
                object obj = "Hello";
                int num = (int)obj;
            }catch(InvalidCastException ex)
            {
                c.WriteLine($"Error: {ex.Message}");
            }

            c.ReadLine();
        }
    }
}
