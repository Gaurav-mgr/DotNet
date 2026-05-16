using c = System.Console;
using System;

namespace Lab7
{
    public class BalanceException : Exception
    {
        public BalanceException(string msg) : base(msg) { }
    }
    public class q6
    {
        public static void Main()
        {
            try
            {
                c.WriteLine("Enter the balance: ");
                double balance = double.Parse(c.ReadLine());


                c.WriteLine("Enter the amount to withdraw:");
                double withdrawAmount = double.Parse(c.ReadLine());

                if (withdrawAmount > balance)
                {
                    throw new BalanceException("Insufficient amount. Withdraw failed.");
                }
                else
                {
                    balance -= withdrawAmount;
                    c.WriteLine($"Withdrawal successful. Remaining balance: {balance}");
                }
            }
            catch (BalanceException ex)
            {
                c.WriteLine("Error: " + ex.Message);
            }

            c.ReadLine();
        }
    }
}
