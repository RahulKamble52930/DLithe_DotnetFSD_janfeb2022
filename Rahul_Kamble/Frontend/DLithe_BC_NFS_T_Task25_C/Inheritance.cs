using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLithe_BC_NFS_T_Task25_C
{
    internal class Inheritance
    {

        // base class
        class Animal
        {
            protected void eat()// protected method
            { 
                Console.WriteLine("I can eat");
                
            }
            private void colour()// protected method
            {
                Console.WriteLine("brown");

            }
        }

        // derived class of Animal 
        class Dog : Animal
        {
            static void Main1(string[] args)
            {

                Dog labrador = new Dog();

                // access protected method from base class
                labrador.eat();
             // labrador.colour();  ---------------  private method cannot be accessed

                Console.ReadLine();
            }
        }
    }
}

