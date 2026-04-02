using c = System.Console;

namespace Lab2
{
    internal class q4
    {
        public static void Main()
        {
            c.WriteLine("Enter any number from 0-9: ");
            int n = int.Parse(c.ReadLine());

            switch (n)
            {
                case 0:
                    c.WriteLine(n + " = Zero");
                    break;
                case 1:
                    c.WriteLine(n + " = One");
                    break;
                case 2:
                    c.WriteLine(n + " = Two");
                    break;
                case 3:
                    c.WriteLine(n + " = Three");
                    break;
                case 4:
                    c.WriteLine(n + " = Four");
                    break;
                case 5: 
                    c.WriteLine(n + " = Five");
                    break;
                case 6: 
                    c.WriteLine(n + " = Six");
                    break;
                case 7:
                    c.WriteLine(n + " = Seven");
                    break;
                case 8:
                    c.WriteLine(n + " = Eight");
                    break;
                case 9:
                    c.WriteLine(n + " = Nine");
                    break;
                default:
                    c.WriteLine("Invalid input! Please enter a number from 0-9.");
                    break;
            }
            c.ReadKey();
        }
    }
}
