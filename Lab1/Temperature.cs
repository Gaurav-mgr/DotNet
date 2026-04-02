using System;
public class Temperature
{
  public static void Main()
  {
    Console.Write("Enter Celsius:");
    float c = float.Parse(Console.ReadLine());
    float fer = 9 / 5 * c + 32;
    Console.WriteLine(c + " to Ferhenheit: " + fer);
    Console.ReadKey();
  }
}