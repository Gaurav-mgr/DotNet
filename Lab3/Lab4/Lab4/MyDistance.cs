using c = System.Console;

namespace Lab4
{
    public class Distance
    {
        private int feet, inch;
        public Distance(int f, int i)
        {
            feet = f;
            inch = i;
        }
        public Distance addDistance(Distance d1, Distance d2)
        {
            Distance temp = new Distance(0, 0);
            temp.feet = d1.feet + d2.feet;
            temp.inch = d1.inch + d2.inch;
            if(temp.inch >= 12)
            {
                temp.feet += 1;
                temp.inch -= 12;
            }
            return temp;
        }

        public void displayDistance()
        {
            c.WriteLine($"Distance: {feet}ft {inch}in");
        }
    }
    public class MyDistance
    {
        public static void Main()
        {
            Distance d1 = new Distance(5, 8);
            Distance d2 = new Distance(3, 11);
            d1.displayDistance();
            d2.displayDistance();

            c.WriteLine("\nAdded Distance: ");
            Distance d3 = d1.addDistance(d1, d2);
            d3.displayDistance();

            c.ReadLine();
        }
    }
}
