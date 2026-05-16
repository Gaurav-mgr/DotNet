using c = System.Console;

namespace Lab5
{
    public abstract class Shape
    {
        public int dim1, dim2;
        public Shape(int d1, int d2)
        {
            dim1= d1;
            dim2= d2;
        }
        public abstract int Area();
    }

    public class Rectangle: Shape
    {
        public Rectangle(int l, int b) : base(l, b) { }
        public override int Area()
        {
            return dim1 * dim2;
        }
    }
    public class AbstractEx
    {
        public static void Main()
        {
            Rectangle r = new Rectangle(4, 5);
            c.WriteLine("Area of Rectangle: " + r.Area());
            c.ReadLine();
        }
    }
}