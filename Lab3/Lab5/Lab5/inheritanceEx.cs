using c = System.Console;

namespace Lab5
{
    // base class
    public class Person
    {
        string name, address;
        public void setName(string n)
        {
            name = n;
        }
        public string getName()
        {
            return name;
        }
        public void setAddress(string a)
        {
            address = a;
        }
        public string getAddress()
        {
            return address;
        }
    }

    //single level inheritance
    public class Student:Person
    {
        int roll;
        public void setRoll(int r)
        {
            roll = r;
        }
        public int getRoll()
        {
            return roll;
        }
    }

    //multi level inheritance
    public class CollegeStudent : Student
    {
        string collegeName;
        public void setColName(string cn)
        {
            collegeName = cn;
        }
        public string getColName()
        {
            return collegeName;
        }
    }

    //hierarchical inheritance
    public class Employee : Person
    {
        string department;
        int Eid;    
        public void setDep(string d)
        {
            department = d;
        }
        public string getDep()
        {
            return department;
        }
        public void setEid(int eid)
        {
            Eid = eid;
        }
        public int getEid()
        {
            return Eid;
        }
    }

    //multiple inheritance
    interface Area
    {
        double findArea();
    }
    interface Circumference
    {
        double findCircumference();
    }

    public class Circle: Area, Circumference
    {
        double radius, pi = 3.14;
        public Circle(double r)
        {
            radius = r;
        }
        public double findArea()
        {
            return pi * radius * radius;
        }
        public double findCircumference()
        {
            return 2 * pi * radius;
        }
    }

    public class inheritanceEx
    {
        public static void Main()
        {
            c.WriteLine("Single Level Inheritance:");
            Student st = new Student();
            st.setName("Rajesh");
            st.setRoll(10);
            st.setAddress("Lalitpur");
            c.WriteLine($"Name: {st.getName()}\nRoll No: {st.getRoll()}\nAddress: {st.getAddress()} ");

            c.WriteLine("\nMulti Level Inheritance:");
            CollegeStudent cst = new CollegeStudent();
            cst.setName("Gaurav");
            cst.setRoll(20);
            cst.setAddress("Lalitpur");
            cst.setColName("Patan Multiple Campus");
            c.WriteLine($"Name: {cst.getName()}\nRoll No: {cst.getRoll()}\nAddress: {cst.getAddress()} \nCollege Name: {cst.getColName()}");

            c.WriteLine("\nHiearchical Inheritance:");
            Employee emp = new Employee();
            emp.setName("Ram");
            emp.setAddress("Kathmandu");
            emp.setEid(101);
            emp.setDep("IT");
            c.WriteLine($"Name: {emp.getName()}\nAddress: {emp.getAddress()}\nEmployee ID: {emp.getEid()}\nDepartment: {emp.getDep()}");

            c.WriteLine("\nMultiple Inheritance:");
            Circle cir = new Circle(5);
            c.WriteLine("Area of Circle: " + cir.findArea());
            c.WriteLine("Circumference of Circle: " + cir.findCircumference());
            c.ReadLine();
        }
    }
}
