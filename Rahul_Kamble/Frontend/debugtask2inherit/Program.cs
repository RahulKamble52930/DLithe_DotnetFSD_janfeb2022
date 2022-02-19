using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLithe
{
    public class A
    {
        public string Name;
        public void GetName()
        {
            Console.WriteLine("Name: {0}", Name);
        }
    }

    public class B : A
    {
        public string Location;
        public void GetLocation()
        {
            Console.WriteLine("Location: {0} ", Location);
        }
    }
    public class C : B
    {
        public int Age;
        private string v1;
        private string v2;
        private int v3;

      

        public void GetAge()
        {
            Console.WriteLine("Age: {0}", Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C("John Doe","Hyderabad",32);
            c.Name = "John Doe";
            c.Location = "Hyderabad";
            c.Age = 32;
            Console.WriteLine("\nPress Any Key to Exit..");
            Console.ReadLine();
            c.GetName();
            c.GetLocation();
            c.GetAge();
        }
    }
}
