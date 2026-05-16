using c = System.Console;

namespace Lab3
{
    internal class q7
    {
        //optional paramters
        public static void add(int x, int y=2, int z = 4)
        {
            int sum = x+y+z;
            c.WriteLine("Optional Parameters Example: ");
            c.WriteLine("Sum of x: " + x + " y: " + y + " and z: " + z + " is: " + sum);
        }

        //named parameters
        public static void Display(string name, int roll, string college)
        {
            c.WriteLine("\nNamed Parameters Example: ");
            c.WriteLine($"Name: {name}\nRoll: {roll}\nCollege: {college}");
        }
        public static void Main()
        {
            add(5);
            Display(name: "Gaurav", roll: 20, college: "Patan Multiple Campus");
            c.ReadLine();
        }
    }
}
