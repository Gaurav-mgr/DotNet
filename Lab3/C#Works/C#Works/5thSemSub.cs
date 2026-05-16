using c = System.Console;
namespace C_Works
{
    public class SemSubject
    {
        private string[] subject = new string[5] { "DotNet Technology", "Computer Grahpics", "Computer Network", "Introduction to Management", "MIS and E-Business" };
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return subject[0];
                else if(index == 1)
                    return subject[1];
                else if (index == 2)
                    return subject[2];
                else if (index == 3)
                    return subject[3];
                else if (index == 4)
                    return subject[4];
                else
                    return "Invalid input";
            }
        }
    }
    public class _5thSemSub
    {
        public static void Main()
        {
            SemSubject sub = new SemSubject();
            c.WriteLine("Subjects of 5th Semester are:\n");
            for (int i = 0; i < 5; i++)
            {
                c.WriteLine($"{i+1}. {sub[i]}");
            }
            c.ReadKey();
        }
    }
}
