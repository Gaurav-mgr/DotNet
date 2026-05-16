using c = System.Console;

namespace Lab6
{
    public class Animal
    {
        public virtual void Sound()
        {
            c.WriteLine("Animal makes sound");
        }
    }
    public class Dog : Animal
    {
        public override void Sound()
        {
            c.WriteLine("Dog barks");
        }
    }
    public class MethodOverridingEx
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.Sound();
            c.ReadLine();
        }
    }
}
