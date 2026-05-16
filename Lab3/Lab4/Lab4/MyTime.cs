using c = System.Console;

namespace Lab4
{
    public class Time
    {
        int hours, minutes, seconds;
        public Time(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }
        public Time addTime(Time t1, Time t2)
        {
            Time temp = new Time(0, 0, 0);
            temp.hours = t1.hours + t2.hours;
            temp.minutes = t1.minutes + t2.minutes;
            temp.seconds = t1.seconds + t2.seconds;

            if(temp.seconds >= 60)
            {
                temp.minutes += 1;
                temp.seconds -= 60;
            }
            if(temp.minutes >= 60)
            {
                temp.hours += 1;
                temp.minutes -= 60;
            }
            return temp;
        }

        public Time subTime(Time t1, Time t2)
        {
            Time temp = new Time(0, 0, 0);
            temp.hours = t1.hours - t2.hours;
            temp.minutes = t1.minutes - t2.minutes;
            temp.seconds = t1.seconds - t2.seconds;
            if (temp.seconds < 0)
            {
                temp.seconds += 60;
                temp.minutes -= 1;
            }
            if(temp.minutes < 0)
            {
                temp.minutes += 60;
                temp.hours -= 1;
            }
            return temp;
        }

        public void displayTime()
        {
            int hourLen = hours.ToString().Length;
            int minuteLen = minutes.ToString().Length;
            int secondLen = seconds.ToString().Length;
            c.WriteLine($"Time: {(hourLen == 1 ? "0" : "")}{hours}:{(minuteLen == 1 ? "0" : "")}{minutes}:{(secondLen == 1 ? "0" : "")}{seconds}");
        }
    }
    public class MyTime
    {
        public static void Main()
        {
            Time t1 = new Time(2, 45, 20);
            Time t2 = new Time(1, 20, 50);
            t1.displayTime();
            t2.displayTime();

            c.WriteLine("\nAdded Time:");
            Time t3 = t1.addTime(t1, t2);
            t3.displayTime();

            c.WriteLine("\nSubtracted Time:");
            Time t4 = t1.subTime(t1, t2);
            t4.displayTime();

            c.ReadLine();
        }
    }
}
