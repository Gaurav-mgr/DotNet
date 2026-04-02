using System;
public class CalculationUsingCommandLineInput
{
  public static void Main(string[] args)
  {
    if (args.Length < 2)
    {
      Console.WriteLine("Please input two numbers using command line");
      return;
    }
    int a = int.Parse(args[0]);
    int b = int.Parse(args[1]);

    Console.WriteLine("Input values: \na= " + a + "\nb= " + b + "\n");
    int add = a + b;
    int mul = a * b;
    int div = a / b;
    int sub = a - b;
    Console.WriteLine("Addition: " + add);
    Console.WriteLine("Subtraction: " + sub);
    Console.WriteLine("Division: " + div);
    Console.WriteLine("Multiplication: " + mul);
    Console.ReadKey();
  }
}