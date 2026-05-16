using System;
using c = System.Console;
using MySql.Data.MySqlClient;

namespace Lab8
{
    public class q5
    {
        static void Main()
        {
            string mySql = "server=localhost; user=root; database=bank; password=";
            MySqlConnection conn = new MySqlConnection(mySql);
            try
            {
                conn.Open();
                for(int i = 0; i < 3; i++)
                {
                    c.WriteLine("Enter details of customer "+(i+1)+":");
                    c.WriteLine("Enter Account Number:");
                    int accNo = int.Parse(c.ReadLine());
                    c.WriteLine("Enter Name: ");
                    string name = c.ReadLine();
                    c.WriteLine("Enter Address: ");
                    string address = c.ReadLine();
                    c.WriteLine("Enter amount to deposit: ");
                    int depamt = int.Parse(c.ReadLine());

                    string query = $"INSERT INTO customer (Account_no, Name, Address, Deposit_amount) VALUES(@accno, @name, @add, @depamt)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@accno", accNo);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@add", address);
                    cmd.Parameters.AddWithValue("@depamt", depamt);

                    int result = cmd.ExecuteNonQuery();
                    string summary = result > 0 ? "Data inserted successfully" : "Data insertion failed";
                    c.WriteLine("\n"+summary+"\n");
                }

                string query1 = "DELETE FROM customer WHERE Deposit_amount < 500";
                MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                int result1 = cmd1.ExecuteNonQuery();
                string summary1 = result1 > 0 ? "Data with deposit amount < 500 deleted successfully" : "Data deletion failed";
                c.WriteLine(summary1);
                c.ReadLine();
            }
            catch(Exception ex)
            {
                c.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
