using c = System.Console;

namespace Lab5
{
    public class StudentInfo{
        private int roll;
        public string program, cname = "PMC";

        //read & write
        public int Roll
        {
            set { roll = value; }
            get { return roll; }
        }

        //write only 
        public string Program
        {
            set { program = value; }
        }

        //read only
        public string cName
        {
            get { return cname; }
        }

        //auto implemented
        public string Name { get; set; }
    }
    public class propertyTypes
    {
        public static void Main()
        {
            StudentInfo stin = new StudentInfo();
            stin.Roll = 20;
            stin.Program = "BCA";
            stin.Name = "Gaurav";
            c.WriteLine($"Name: {stin.Name}\nRoll No: {stin.Roll}\nCollege Name: {stin.cName}");
            c.ReadLine();
        }
    }
}
