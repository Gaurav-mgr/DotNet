using con = System.Console;

namespace Lab4
{
    public class Circle
    {
        private float radius;
        private float Pi = 3.14f;
        public Circle(float r)
        {
            radius = r;
        }
        public float findArea()
        {
            return Pi * radius * radius;
        }
        public float findCircumference()
        {
            return 2* Pi * radius;
        }
    }
    public class MyCircle
    {
        public static void Main()
        {
            Circle c = new Circle(4);
            con.WriteLine("Area of circle: " + c.findArea());
            con.WriteLine("Circumference of circle: " + c.findCircumference());
            con.ReadLine();
        }
    }
}
