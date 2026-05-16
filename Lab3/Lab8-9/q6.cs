using System;
using c = System.Console;
using MySql.Data.MySqlClient;

namespace Lab8
{
    public class q6
    {
        static void Main()
        {
            string mysql = "server=localhost; user=root; database=bank; password=";
            MySqlConnection conn = new MySqlConnection(mysql);
            try
            {
                conn.Open();
                string selquery = "SELECT * FROM customer";
                MySqlCommand cmd = new MySqlCommand(selquery, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    c.WriteLine("Account Number: " + reader["Account_no"]);
                    c.WriteLine("Name: " + reader["Name"]);
                    c.WriteLine("Address: " + reader["Address"]);
                    c.WriteLine("Deposit Amount: " + reader["Deposit_amount"]);
                    c.WriteLine();
                }
                reader.Close();

                string upquery = "UPDATE customer SET Address = 'Kathmandu' WHERE Account_no = 1234";
                MySqlCommand upcmd = new MySqlCommand(upquery, conn);
                int result = upcmd.ExecuteNonQuery();
                string summary = result > 0 ? "Data updated successfully" : "Data updation failed";
                c.WriteLine(summary);
                c.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
                conn.Close();
            }
        }
    }
}
