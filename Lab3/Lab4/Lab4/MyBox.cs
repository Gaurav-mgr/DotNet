using con = System.Console;

namespace Lab4
{
    public class Box
    {
        private int width, height, depth;
        public Box(int w, int h, int d)
        {
            width = w;
            height = h;
            depth = d;
        }
        public int findVolume()
        {
            return width * height * depth;
        }
        public int findSurfaceArea()
        {
            return 2 * (width * height + width * depth + height * depth);
        }
    }
    public class MyBox
    {
        public static void Main()
        {
            Box b1 = new Box(2, 3, 4);
            Box b2 = new Box(5, 6, 7);

            con.WriteLine("Box 1:");
            con.WriteLine("Volume of first box: " + b1.findVolume());
            con.WriteLine("Surface Area of first box: "+b1.findSurfaceArea());

            con.WriteLine("\nBox 2:");
            con.WriteLine("Volume of second box: " + b2.findVolume());
            con.WriteLine("Surface Area of second box: " + b2.findSurfaceArea());

            con.ReadLine();
        }
    }
}
