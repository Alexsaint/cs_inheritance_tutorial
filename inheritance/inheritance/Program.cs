using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("All animals eat");
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Dog objDog = new Dog();
            objDog.bark();

            objDog.Eat();

            Console.WriteLine( "//////////////////////////// ");

            cat objCat = new cat();
            objCat.Meow();
            objCat.Eat();
        }
    }
}
