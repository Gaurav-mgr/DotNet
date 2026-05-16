using System;
using c = System.Console;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    public class q2
    {
        struct Employee
        {
            public string name;
            public int id;
        };
        public static void Main()
        {
            c.WriteLine("Enter how many employees you want to enter");
            int n = int.Parse(c.ReadLine());
            Employee[] emp = new Employee[n];

            for (int i = 0; i< n; i++)
            {
                c.WriteLine("Enter name of employee");
                emp[i].name = c.ReadLine();
                c.WriteLine("Enter id number of employee");
                emp[i].id = int.Parse(c.ReadLine());
            }

            var result = from data in emp
                         orderby data.name descending
                         select data;

            c.WriteLine("\nEmployees in descending order of their names are:\n");
            foreach (var ans in result)
            {
                c.WriteLine($"Id: {ans.id}\nName: {ans.name}\n");
            }

            c.ReadLine();

        }
    }
}
