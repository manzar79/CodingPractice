using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Test
    {
        

        static void Main(string[] args)
        {
            Animal animal = new Cat();
            Console.WriteLine(animal.talk());
            

            Animal animalTwo = new Dog();
            Console.WriteLine(animalTwo.talk());

            Console.ReadLine();
            
        }

    }
}
