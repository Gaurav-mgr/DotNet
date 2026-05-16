using c = System.Console;

namespace Lab7
{
    public delegate void MathOp(int n);
    internal class q1
    {
        static void Square(int n) => c.WriteLine($"Square: {n*n}");
        static void Cube(int n) => c.WriteLine($"Cube: {n*n*n}");
        static void Main()
        {
            MathOp op = Square;
            op += Cube;

            c.WriteLine("Multicast delegate:");
            op(3);

            op -= Square;
            c.WriteLine("\nSingleCast delegate:");
            op(2);

            c.ReadLine();

        }
    }
}
