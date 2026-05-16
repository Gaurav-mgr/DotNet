using System;
using c = System.Console;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    public class q1
    {
        public static void Main()
        {
            List<int> list = new List<int>();
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(int data in arr)
            {
                list.Add(data);
            }

            c.WriteLine("Odd list element divisible by 3 are:");
            var result = from elem in list
                         where elem % 2 != 0 && elem % 3 == 0
                         select elem;
            foreach(var ans in result)
            {
                c.WriteLine(ans);
            }

            c.ReadKey();
        }
    }
}
