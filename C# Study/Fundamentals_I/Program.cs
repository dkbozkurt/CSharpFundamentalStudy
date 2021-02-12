//Dogukan Kaan Bozkurt

using System;

namespace Fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //PRINT

            Console.WriteLine("Hello World!");  //Basic print func.

            Console.ReadKey();  //Waiting for a key to close cmd.

            //VARIABLES


            /*
            int - whole numbers
            long - whole numbers ( bigger range)
            flaot - floating-point numbers
            double - monetary values
            char - single character
            bool - boolena
            DataTime - moments in time
            string - sequence of characters
             */

            int num1 = 3;
            long num2 = 95;
            float num3 = 3.4f;  //Float variables must have 'f' at the end of the value.
            double num4 = 5.23;
            decimal money = 2.222M;
            char character = 'a';
            bool isittrue = false;
            DateTime tarih = DateTime.Now;  //The time of now.
            string metin = "Hello Word!";

            Console.WriteLine(money);
            Console.WriteLine(num3);
            Console.WriteLine(tarih);

            Console.ReadLine();

            //OPERATORS

            //++, -- 
            //*=...

            float numm = num1 + num2; //double==float
            Console.WriteLine(numm);
            numm++;
            numm--;
            numm--;
            Console.WriteLine("Edited numm is : " + numm);   //Print of cout in C#
            Console.ReadKey();

            //TYPE TRANSFORM

            int say = 5;
            long greatersay = 9;

            long say3 = say;    //There is no probnlem while transforming smaller variable to higher one.
            int say5 = (int)greatersay; //Type transform needed.

            //CONVERT
            string a = "3";
            string b = "9";

            int top = Convert.ToInt32(a) + Convert.ToInt32(b);  //Conver a and b to int than calculate the sum.
            Console.WriteLine(a + b);
            Console.WriteLine(top);
            Console.ReadKey();

        }
    }
}
