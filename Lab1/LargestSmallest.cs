using System;

public class LargestSmallest
{
  public static void Main(String[] args)
  {
    int a = int.Parse(args[0]);
    int b = int.Parse(args[1]);
    int c = int.Parse(args[2]);
    Console.WriteLine("a= " + a + "\tb= " + b + "\tc= " + c + "\n");
    int largest = a > b ? (a > c ? a : c) : (b > c ? b : c);
    int smallest = a < b ? (a < c ? a : c) : (b < c ? b : c);

    Console.WriteLine("Largest Number: " + largest);
    Console.WriteLine("Smallest Number: " + smallest);
    Console.ReadKey();
  }
}