using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Lists___Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            //*** ARRAYS TUTORIAL***

            string[] names = new string[2];// Number 2 size of Array

            names[0] = "Jhon Doe";// First item indexed as zero
            names[1] = "Jane Doe";

            foreach (string s in names)// Easiest Loop to do
                Console.WriteLine(s);

            Console.ReadLine();

            //Length property of the array to decide how many times
            //loop should iterate then counter (i)
            for (int i = 0; i < names.Length; i++)
                Console.WriteLine("Item number " + i + ": " + names[i]);


            // Another way of Populating an ARRAY
            //Much easier if small set of items

            int[] numbers = new int[5] { 4, 3, 8, 0, 5 };

            //Can be done shorter like this

            //One line created size of 5 filled with 5 integers
            int[] numbers1 = { 4, 3, 8, 0, 5 }; //Short and you don't have to specify size

            Array.Sort(numbers);//Takes out Arrays

            foreach (int i in numbers)
                Console.WriteLine(i);

            Console.ReadLine();


            //***ARRAYS PROGRAMMING TASK***

            //Q1
            int[] numbers2 = new int[30];

            //Q2        
            for (int i = 0; i < numbers.Length; i++)
                numbers2[i] = generator.Next(1, 101);

            //Q3
            Console.WriteLine("Q3-Values in Array");


            //Q4





            
        }
    }
}











