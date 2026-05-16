using c = System.Console;

namespace Lab4
{
    public static class StaticEx
    {
        static int x;
        static StaticEx(){
            c.WriteLine("Yay! Static constructor called successfully!");
        }
        public static void Main()
        {
            StaticEx.x = 10;
            c.WriteLine("Value of x is: " + StaticEx.x);

            c.ReadLine();
        }
    }
}
