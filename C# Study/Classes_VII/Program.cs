//Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

using System;


//CLASSES

namespace Classes_VII
{
    class Program
    {
        static void Main()
        {
            Animal cat = new Animal();
            cat.name = "Micir";
            cat.weight = 4;
            cat.gender = 1;
            Console.WriteLine(cat.GetAnimalProperties());

            Animal bird = new Animal();
            bird.name = "Kanarya";
            bird.weight = 1;
            bird.gender = 0;
            Console.WriteLine(bird.GetAnimalProperties());

            Animal dog = new Animal();
            Console.WriteLine(dog.GetAnimalProperties());
            Console.ReadLine();

        }
    }
}
