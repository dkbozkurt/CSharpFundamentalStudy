//Dogukan Kaan Bozkurt
//      github.com/dkbozkurt

// I/O
// File writing and file reading

using System;
using System.IO;    //When we are dealing with files, we should import it.

namespace IO_XI
{
    class Program
    {
        static void Main(string[] args)
        {
            // WRITING !
            // write to a text file
            StreamWriter output = null;

            try
            {
                // create stream writer object
                output = File.CreateText("One.txt");

                //write a few lines
                output.WriteLine("Everything ");
                output.WriteLine("is ");
                output.WriteLine("allright!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // always close output file.
                if (output != null)
                {
                    output.Close();
                }
            }

            // READING !!!
            // read from the text file
            StreamReader input = null;
            try
            {
                // create stream reader object
                input = File.OpenText("One.txt");

                // read and echo lines until end of file
                string line = input.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = input.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // always close input file.
                if (input != null)
                {
                    input.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
