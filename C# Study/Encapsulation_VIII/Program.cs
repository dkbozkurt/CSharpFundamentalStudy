//Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

using System;
using System.Collections.Generic;
using System.Text;

//ENCAPSULATE

namespace Encapsulation_VIII
{
    class Program
    {
        static void Main()
        {
            Rectangle rect = new Rectangle();
            rect.a = -1;
            rect.b = 5;


            Console.WriteLine(rect.CalculateArea());
            Console.ReadKey();
            
        }
    }
}
