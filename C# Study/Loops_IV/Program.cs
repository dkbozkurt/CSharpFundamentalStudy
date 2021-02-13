//Dogukan Kaan Bozkurt
//  github.com/dkbozkurt
using System;

namespace Loops_IV
{
    class Program
    {
        static void Main()
        {
//FOR

            //int j = 0;
            //for (int i = 1000; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //    if(i%5 == 0 )
            //    {
            //        j++;
            //        if (j == 11)
            //        {
            //            Console.WriteLine("11th number that can be divide to 5 is " + i);
            //        }
            //    } 
            //}
            //Console.ReadKey();


//FOREACH

            //int[] numbers = new int[] { 0, 1, 2, 3, 4, 5 }; //Defining array and creating an empty one.

            //foreach(int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.ReadLine();

//WHILE

            //int say = 0;
            //while (say < 5)
            //{
            //    Console.WriteLine(say);
            //    say++;
            //}
            //Console.ReadLine();


//DO-WHILE

            //int x = 0;
            //do
            //{
            //    Console.WriteLine(x);
            //    x++;

            //} while (x < 5);
            //Console.ReadLine();

//

            //string id = "admin";
            //string inputid;

            //do
            //{
            //    Console.Clear();        //.Clear() cleans the console !!!
            //    Console.WriteLine("ID: ");
            //    inputid = Console.ReadLine();
            //    if(inputid != id)
            //    {
            //        Console.WriteLine("Access Denied!\n Wrong ID ! Try Again...");
            //    }
            //} while (inputid != id);
            //Console.WriteLine("Access Successful!");
            //Console.ReadLine();

//LOOP EXAMPLE

            //->Ust hesaplayan programi yaziniz.

            //Console.WriteLine("Please enter a base value: ");
            //float b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter a exponent value: ");
            //float exp = Convert.ToInt32(Console.ReadLine());
            //float res=1;
            //Console.WriteLine(b + "^(" +exp+")=");

            //for(int i=1;i <= exp; i++)
            //{
            //    res *= b;
            //}
            //Console.WriteLine("Result: " + res);
            //Console.ReadLine();

//RANDOM

            //->Guessing game.

            //Random rnd = new Random();  //Random class defined.
            //int guess = rnd.Next(1, 10);    //1 ile 10 arasinda random bir sayi.

            //for (int i =0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter your guess: ");
            //    int ug = Convert.ToInt32(Console.ReadLine());
            //    if (guess == ug)
            //    {
            //        Console.WriteLine("Your guess is correct! Congrats !!!");
            //        break;
            //    }
            //    if (guess != ug && i==2)
            //        Console.WriteLine("Computer guessed: " + guess + "\nYou Lose!");
            //}
            //Console.ReadLine();

//EXAMPLE

            //->Girilen bir sayinin 2 sayinin karesi yoplami seklinde yazilip yazilmayacagini bulma. 8 = 2*2+2*2

            //Console.WriteLine("Please enter a nubmer: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //bool didfind = false;

            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < num; j++)
            //    {
            //        if (i * i + j * j == num)
            //        {
            //            didfind = true;
            //            //Console.WriteLine(i + "*" + i + "+" + j + "*" + j + "="+num);
            //            Console.WriteLine("{0}*{0}+{1}*{1}={2}",i,j,num);       //Gibi de yazilabilir. !!!
            //        }
            //    }
            //}
            //if (!didfind)
            //    Console.WriteLine("There is no match for {0}", num);
            //Console.ReadLine();
        }
    }
}
