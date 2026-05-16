using System;
using c = System.Console;

namespace Lab7
{
    public class NameException : Exception
    {
        public NameException(string msg) : base(msg) { }
    }
    public class q7
    {
        static void Main()
        {
            try
            {
                c.WriteLine("Enter your name: ");
                string name = c.ReadLine();
                c.WriteLine($"\nEntered Name: {name}");

                if (name.Length > 10)
                {
                    throw new NameException("Name cannot be longer than 10 characters.");
                }
                else
                {
                    c.WriteLine("Name is valid.");
                }
            }
            catch (NameException ex)
            {
                c.WriteLine("Error: " + ex.Message);
            }

            c.ReadLine();
        }
    }
}
