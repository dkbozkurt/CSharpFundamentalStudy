//Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

using System;

namespace InheritanceVirtualAbstract_IX
{
    //INHERITANCE

    class Program
    { 
        static void Main()
        {
            Cat cat = new Cat() { w = 3, l = 5, n = "Kara" };
            cat.runSpeed = 20;
            cat.sound = "Miavv!";
            Console.WriteLine(cat.GetProperties());

            Bird bird = new Bird() { w = 1, l = 3, flyDistance = 2, flySpeed = 10, n = "Cafer" };
            Console.WriteLine(bird.GetProperties());

            Console.ReadKey();
        }
    }
}
