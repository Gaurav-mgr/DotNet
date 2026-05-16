using System;
using System.Collections.Generic;
using System.Linq;
using c = System.Console;

namespace Lab8
{
    public struct Students
    {
        public string name, address, uni;
    }
    public class q3
    {
        public static void Main()
        {
            c.WriteLine("Enter how many students you want to enter: ");
            int n = int.Parse(c.ReadLine());

            Students[] s = new Students[n];
            for (int i = 0; i < n; i++)
            {
                c.WriteLine("Enter name: ");
                s[i].name = c.ReadLine();
                c.WriteLine("Enter address: ");
                s[i].address = c.ReadLine();
                c.WriteLine("Enter university: ");
                s[i].uni = c.ReadLine();
                c.WriteLine("\n");
            }

            var result = s.Where(data => data.address == "Kirtipur" && data.uni == "Patan Multiple Campus");
            c.WriteLine("\nList of Students from Kirtipur and Patan Multiple Campus: ");
            foreach (var ans in result)
            {
                c.WriteLine(ans.name);
            }

            c.ReadLine();
        }
    }
}
