using System;
using c = System.Console;

namespace Lab5
{
    public class Information
    {
        string name;
        long phone;
        public object this[int index]
        {
            set
            {
                if(index == 0)
                {
                    name = value.ToString();
                }
                else if(index == 1)
                {
                    phone = (long)value;
                }
            }
            get
            {
                if (index == 0)
                {
                    return name;
                }
                else if(index == 1)
                {
                    return phone;
                }
                else
                {
                    return "Invalid input";
                }
            }
        }
    }
    public class CMS
    {
        public static void Main()
        {
            Information info = new Information();
            info[0] = "Gaurav";
            info[1] = 9841764658;
            c.WriteLine($"Name: {info[0]}\nPhone: {info[1]}");
            c.ReadLine();
        }
    }
}
