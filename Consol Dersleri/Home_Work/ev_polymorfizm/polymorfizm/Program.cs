using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace polymorfizm
{
    internal class Program
    {
        abstract class Animal
        {
            // Abstract method (does not have a body)
            public  void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
            // Regular method
            public void sleep()
            {
                Console.WriteLine("Zzz");
            }
        }

        // Derived class (inherit from Animal)
        class Pig : Animal
        {
            //public override void animalSound()
            //{
            //    // The body of animalSound() is provided here
                
            //}
        }

        static void Main(string[] args)
        {
            Pig myPig = new Pig(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method
            Console.ReadLine();
        }
    }
}
