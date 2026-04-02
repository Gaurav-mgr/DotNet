using System;
public class BitwiseOp
{
  public static void Main(string[] args)
  {
    int a = int.Parse(args[0]);
    int b = int.Parse(args[1]);

    Console.WriteLine("Input values: a = " + a + ", b = " + b + "\n");

    // Bitwise operations
    Console.WriteLine("a & b (AND) = " + (a & b));
    Console.WriteLine("a | b (OR) = " + (a | b));
    Console.WriteLine("a ^ b (XOR) = " + (a ^ b));
    Console.WriteLine("~a (NOT a) = " + (~a));
    Console.WriteLine("~b (NOT b) = " + (~b));
    Console.WriteLine("a << 1 (Left Shift) = " + (a << 1));
    Console.WriteLine("b << 1 (Left Shift) = " + (b << 1));
    Console.WriteLine("a >> 1 (Right Shift) = " + (a >> 1));
    Console.WriteLine("b >> 1 (Right Shift) = " + (b >> 1));

    Console.ReadKey();

  }
}