//Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

using System;
using System.Collections.Generic;   //Must be included while using List. !!!

namespace ArraysLists_V
{
    class Program
    {
        static void Main()
        {
//ARRAYS

            //int[] numbers = new int[10];    //SIZE of the array must be defined here.
            ////int[] numbers = {0,1,2,3,4,5,6,7,8,9};        //Possible too.
            //numbers[0] = 0;
            //numbers[3] = 15;

            //string[] names = { "Dogukan", "Kaan", "Bozkurt" };
            ////string[] names = new string[3];       //Possible too.

            //Console.WriteLine(names.Length);
            //Console.WriteLine(numbers[3]);
            //Console.ReadLine();


//LISTS

            //List<int> numbers = new List<int>();      //using System.Collections.Generic; must be included !!!
            //numbers.Add(3);
            //numbers.Add(5);
            //numbers.Add(7);
            //numbers.Add(9);

            //Console.WriteLine(numbers[2]);
            //numbers.Remove(3);      //Delete the value of 3.
            //numbers.RemoveAt(1);        //Delete the 1st index.
            //Console.WriteLine(numbers[1]);

            //int lenghtoflist = numbers.Count;   //.Count calculates the number of contents.
            //numbers.Clear();        //Clears the list.
            //numbers.Add(1);
            //if (numbers.Contains(1))
            //{
            //    Console.WriteLine("The list includes \'1\' value in it.");
            //}
            //Console.ReadLine();


//EXAMPLES

            //Bir dizideki en kucuk ve en buyuk sayiyi bulan program.

            //int size = 10;
            //int[] array = new int[size];
            //int minn = 0, maxn = 0;
            //Console.WriteLine("Please enter 10 integer value for an array.");

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = Convert.ToInt32(Console.ReadLine());

            //    if (i == 0)
            //    {
            //        minn = array[0];
            //        maxn = array[0];

            //    }

            //    if (minn > array[i])
            //    {
            //        minn = array[i];
            //    }

            //    if (maxn < array[i])
            //    {
            //        maxn = array[i];
            //    }

            //}
            //Console.WriteLine("{0} is the greatest and {1} is the smallest number in the array.", maxn, minn);
            //Console.ReadKey();


            //Girilen kelimeyi harf harf alt alta yazma programi.

            //Console.WriteLine("Please enter a message:");
            //string entry = Console.ReadLine();

            //foreach (char character in entry)
            //{
            //    Console.WriteLine(character);
            //}
            //Console.ReadKey();



        }
    }
}
