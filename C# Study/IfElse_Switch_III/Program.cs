//Dogukan Kaan Bozkurt
//  github.com/dkbozkurt

using System;

namespace IfElse_Switch_III
{
    class Program
    {
        static void Main()
        {
            //If-Else


            //Console.WriteLine("Enter an integer:");
            //int sayi = Convert.ToInt32(Console.ReadLine()) ;
            //if (sayi > 10)
            //{
            //    Console.WriteLine("The number is greater than 10");
            //}
            //else if (sayi < 10)
            //{
            //    Console.WriteLine("The number is less than 10");
            //}
            //else
            //{
            //    Console.WriteLine("The number is 10 !");
            //}
            //Console.ReadKey();


            //Switch,Goto

            //Console.WriteLine("Enter a number in range 1-3:");
            //int num = Convert.ToInt32(Console.ReadLine());

            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("The number is 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("The number is 2");
            //        goto case 3;        //Goto structure
            //        //break;            //Don't need to use with goto.
            //    case 3:
            //        Console.WriteLine("The number is 3");
            //        break;
            //    default:
            //        Console.WriteLine("The number is out of range."); //If non of the cases are provided. This line will work.
            //        break;
            //}
            //Console.ReadKey();


            //If-Else Example

            //Console.WriteLine("Please enter 3 sides' lenght of a triangle respectively: ");
            //float s1 = Convert.ToInt32(Console.ReadLine());
            //float s2 = Convert.ToInt32(Console.ReadLine());
            //float s3 = Convert.ToInt32(Console.ReadLine());

            //if (s2 + s3 > s1 && s1 >Math.Abs((s2-s3)))        //Math.Abs() is calculation of abs.
            //{
            //    Console.WriteLine("The triangle has valid values!");
            //}
            //else
            //{
            //    Console.WriteLine("The triangle has invalid values.");
            //}


            //Switch Example


            //float total = 0;
            //Console.WriteLine("Please enter two differente valeus:");
            //float num1 = Convert.ToInt32(Console.ReadLine());
            //float num2 = Convert.ToInt32(Console.ReadLine());
            
            //Console.WriteLine("Please select the calculation type:\n1-Summation\n2-Substraction\n3-Multiplication\n4-Division");
            //int selection=Convert.ToInt32(Console.ReadLine());

            //switch(selection) {
            //    case 1:
            //        total = num1 + num2;
            //        Console.WriteLine(num1+" + "+num2+" = "+total);
            //        break;
            //    case 2:
            //        total = num1 - num2;
            //        Console.WriteLine(num1+" - "+num2+" = "+total);
            //        break;
            //    case 3:
            //        total = num1 * num2;
            //        Console.WriteLine(num1 + " * " + num2 + " = " + total);
            //        break;
            //    case 4:
            //        total = num1 / num2;
            //        Console.WriteLine(num1 + " / " + num1 + " = " + total);
            //        break;
            //    default:
            //        Console.WriteLine("The selection is out of range.");
            //        break;
            //}

            //Console.ReadKey();

        }
    }
}
