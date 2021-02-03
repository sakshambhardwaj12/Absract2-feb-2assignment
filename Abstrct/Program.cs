using System;

namespace Abstrct
{

    public abstract class printing{

        public printing()
        {
            Console.WriteLine("This is constructor of abstract class");
        }
        public abstract void a_method();
        public void normalmethod()
        {
            Console.WriteLine("This is a normal method of abstract class");
        }

        }

    
public class SubClass : printing
{
    public override void a_method()
    {
            Console.WriteLine("This is abstract method");
    }
}
    class Program
    {
        static void Main(string[] args)
        {
            SubClass s = new SubClass();
            s.normalmethod();
            s.a_method();
        }
    }
}
