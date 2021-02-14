//Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

using System;

namespace Methods_Functions__VI
{
    class Program
    {
//FUNCTIONS

        //Methods have introduction and body.
        static void Main()
        {
            //Console.WriteLine("addition operator by using methods.\nplease enter two integers for addition:");
            //Console.WriteLine("4+5= " + Additionnums(4, 5));
            //Console.WriteLine("5^2= " + Squarenums(5));
            //int numc = 6;                                       //related with ref!!!
            //Console.WriteLine("6^3= " + Cubenums(ref numc));     //related with ref!!!
            //Console.ReadKey();


//EXAMPLE 1'S MAIN

            //int num1,num2;
            //int total=0;

            //Console.WriteLine("Please enter 2 numbers for calculation");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("{0} + {1} = {2}", num1, num2, AddOp(num1,num2,total));
            //Console.ReadLine();


//EXAMPLE 2'S MAIN

            //Console.WriteLine("Please enter a sentence:");
            //string intxt = Console.ReadLine();
            //int keynum = WordCounter(intxt);
            //Console.WriteLine("Total words in the sentence is {0}", keynum);
            //Console.ReadLine();


//PARAMS example

            //int addparams = AddParams(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);   //We can type as much as we want here while using params
            //Console.WriteLine("Total of the numbers in AddParams func is :" + addparams);
            //Console.ReadLine();

        }
        static int Additionnums(int num1, int num2)     //methods must be specified to purpose so it shouldnt be that much complex.
        {
            return num1 + num2;
        }
        static int Squarenums(int num3)
        {
            return num3 * num3;
        }


//REF********

        static int Cubenums(ref int num4)       //giren sayının bır kopyası olusup func. da kullanılması yerıne ref kullanarak dırekt o sayıyı kullandırttık.
        {
            return num4 * num4 * num4;
        }


//EXAMPLES

//EXAMPLE 1: 2 sayiyi kullanicandan alip toplayan func.

        static float AddOp (int n1, int n2, int ttl)
        {
            ttl = n1 + n2;
            return ttl;
        }


//EXAMPLE 2:Meyin icerisinde kac tane cumle oldugunu bulan func.

        static int WordCounter(string it)
        {
            int count=1;
            foreach(char a in it)
            {
                if(a== ' ')
                {
                    count++;
                }
            }
            return count;
        }


//PARAMS*************

        static int AddParams(params int[] sayi)
            {
            int top = 0;
            for (int i = 0; i < sayi.Length; i++)
            {
                top += sayi[i];
            }
            return top;
            }
        
    }
}
