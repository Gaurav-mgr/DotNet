using System;

public class SwapValues
{
  public static void Main()
  {
    int a = 1, b = 2;
    //before swap
    Console.WriteLine("Value of a: " + a + "\nValue of b: " + b);

    //swap value using third variable
    int temp = a;
    a = b;
    b = temp;

    //after swap wtih third variable
    Console.WriteLine("\nValue of a: " + a + "\nValue of b: " + b);

    //swap without using third variable
    a = a + b;
    b = a - b;
    a = a - b;

    //after swap
    Console.WriteLine("\nValue of a: " + a + "\nValue of b: " + b);
  }
}