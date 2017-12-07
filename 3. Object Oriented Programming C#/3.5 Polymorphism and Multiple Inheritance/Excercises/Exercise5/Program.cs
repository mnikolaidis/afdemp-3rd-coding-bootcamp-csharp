using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("");
            Car c2 = null;

            bool r = c1.Equals(c2);
            Console.WriteLine("Hello World!");
        }
    }
}
