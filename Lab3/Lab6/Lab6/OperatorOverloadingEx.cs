using c = System.Console;

namespace Lab6
{
    public class Number
    {
        double num;
        public Number(double n)
        {
            num = n;
        }

        //Auto increment and decrement
        public static Number operator ++(Number n)
        {
            return new Number(n.num+1);
        }
        public static Number operator --(Number n)
        {
            return new Number(n.num-1);
        }
        public double displayAuto()
        {
            return num;
        }

        //binary operator
        public static Number operator *(Number n1, Number n2)
        {
            return new Number(n1.num * n2.num);
        }
        public static Number operator /(Number n1, Number n2)
        {
            if(n2.num > 0)
            {
                return new Number(n1.num / n2.num);
            }
            else
            {
                c.WriteLine("Error: Division by zero is not allowed.");
                return new Number(0);
            }
        }
        public double displayBiny()
        {
            return num;
        }

        //Realational Operator
        public static bool operator ==(Number n1, Number n2)
        {
            return n1.num == n2.num;
        }
        public static bool operator !=(Number n1, Number n2)
        {
            return n1.num != n2.num;
        }
    }
    public class OperatorOverloadingEx
    {
        public static void Main()
        {
            c.Write("Enter a number to perform auto increment and decrement:");
            double num = double.Parse(c.ReadLine());
            Number n1 = new Number(num);

            //Auto increment and decrement
            Number inc = n1++;
            c.WriteLine($"Incremented Value: {inc.displayAuto()}");
            Number dec = n1--;
            c.WriteLine($"Decremented Value: {dec.displayAuto()}");

            c.Write("\nEnter second number to perform binary operations:");
            double num2 = double.Parse(c.ReadLine());
            Number n2 = new Number(num2);

            //Binary operator
            Number mul = n1 * n2;
            c.WriteLine($"Multiplication: {mul.displayBiny()}");
            Number div = n1 / n2;
            c.WriteLine($"Division: {div.displayBiny()}");

            //Relational operator
            if(n1 == n2)
            {
                c.WriteLine("\nBoth numbers are equal.");
            }
            else
            {
                c.WriteLine("\nBoth numbers are not equal.");
            }
            c.ReadLine();
        }
    }
}
