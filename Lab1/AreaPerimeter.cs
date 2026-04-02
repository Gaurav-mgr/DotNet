using System;

public class AreaPerimeter
{
  public static void Main()
  {
    Console.WriteLine("Enter length of rectangle: ");
    int l = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter breadth of rectangle: ");
    int b = int.Parse(Console.ReadLine());

    int area = l * b;
    int per = 2 * (l + b);

    Console.WriteLine("Area: " + area);
    Console.WriteLine("Perimeter: " + per);
    Console.ReadKey();
  }
}