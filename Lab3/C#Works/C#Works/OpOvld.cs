using c = System.Console;

namespace C_Works
{
    public class Time
    {
        int hour, minute, second;
        public Time(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }
        public static Time operator +(Time t1, Time t2)
        {
            Time temp = new Time(0, 0, 0);
            temp.hour = t1.hour + t2.hour;
            temp.minute = t1.minute + t2.minute;
            temp.second = t1.second + t2.second;
            if (temp.second >= 60)
            {
                temp.minute += 1;
                temp.second -= 60;
            }
            if (temp.minute >= 60)
            {
                temp.hour += 1;
                temp.minute -= 60;
            }
            return temp;
        }

        public static Time operator -(Time t1, Time t2)
        {
            Time temp = new Time(0, 0, 0);
            temp.hour = t1.hour - t2.hour;
            temp.minute = t1.minute - t2.minute;
            temp.second = t1.second - t2.second;
            if(temp.second < 0)
            {
                temp.second += 60;
                temp.minute--;
            }
            if(temp.minute < 0)
            {
                temp.minute += 60;
                temp.hour--;
            }
            return temp;
        }

        public static bool operator !=(Time t1, Time t2)
        {
            if (t1.hour != t2.hour && t1.minute != t2.minute && t1.second != t2.second)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Time t1, Time t2)
        {
            if (t1.hour == t2.hour && t1.minute == t2.minute && t1.second == t2.second)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayTime()
        {
            c.WriteLine($"Time: {hour}: {minute}:{second}");
        }

        public static void Main()
        {
            Time t1 = new Time(5, 23, 34); 
            Time t2 = new Time(4, 22, 53);
            t1.displayTime();
            t2.displayTime();

            c.WriteLine("\nAddition of both Time: ");
            Time t3 = t1 + t2;
            t3.displayTime();

            c.WriteLine("\nSubtraction of both Time: ");
            Time t4 = t1 - t2;
            t4.displayTime();

            if (t1 != t2)
            {
                c.WriteLine("\nBoth time are not equal");
            }
            c.ReadKey();
        }
    }
}
