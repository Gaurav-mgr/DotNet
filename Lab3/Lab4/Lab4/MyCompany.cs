using c = System.Console;

namespace Lab4
{
    public struct Company
    {
        string name, address;
        long phone;
        double salary;
        public Company(string n, string ad, long ph, double s)
        {
            name = n;
            address = ad;
            phone = ph;
            salary = s;
        }

        public void Display()
        {
            c.WriteLine($"Company Info:\nName: {name}\nAddress: {address}\nPhone: {phone}\nSalary: {salary}");
        }
    };
    public class MyCompany
    {
        public static void Main()
        {
            Company com = new Company("Niche Rank", "Lalitpur", 9761796965, 50034.23);
            com.Display();
            c.ReadLine();
        }
    }
}
