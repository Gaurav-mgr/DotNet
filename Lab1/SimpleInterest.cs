using System;
public class SimpleInterst
{
  public static void Main()
  {
    Console.Write("Enter Principle: ");
    int p = int.Parse(Console.ReadLine());
    Console.Write("Enter Time: ");
    int t = int.Parse(Console.ReadLine());
    Console.Write("Enter Rate: ");
    int r = int.Parse(Console.ReadLine());

    int si = p * t * r / 100;
    Console.WriteLine("Simple Interest: " + si);
  }
}