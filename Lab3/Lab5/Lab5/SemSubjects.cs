using c = System.Console;

namespace Lab5
{
    public class Subjects
    {
        string[] subjects = {"DotNet Technology", "Compture Graphics", "Computer Network", "Principle of Management", "MIS & E-Business"};
        public object this[int index]
        {
            get
            {
                for(int i=0;i<subjects.Length; i++)
                {
                    if (i == index)
                    {
                        return subjects[i];
                    }
                }
                return "Invalid Index";
            }
        }
    }
    public class SemSubjects
    {
        public static void Main()
        {
            Subjects s = new Subjects();
            c.WriteLine("Index\tSubject");
            for (int i = 0; i < 6; i++)
            {
                c.WriteLine($"{i + 1}\t{s[i]}");
            }
            c.ReadLine();
        }
    }
}
