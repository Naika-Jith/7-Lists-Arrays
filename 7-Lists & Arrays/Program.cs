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
            int evenCount = 0;
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

            //Q1 - Create Array
            int[] numbers2 = new int[30];

            //Q2 - Creates fills array with random values 1 -1100
            for (int i = 0; i < numbers.Length; i++)
                numbers2[i] = generator.Next(1, 101);

            //Q3 - Display array contents
            Console.WriteLine("Q3-Values in Array");
           for (int i = 0;i < numbers2.Length; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            //Q4a - Count even numbers
            for (int i = 0; i <= numbers2.Length; i++)
                if (numbers2[i] % 2 == 0)
                    evenCount += 1;
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //Q4b - Display multiples of 5 
            Console.WriteLine("Q4b - Values in array that are multiples of 5:");
            for (int i = 0; i < numbers2.Length; i++)
                if (numbers[i] % 5 == 0)
                    Console.WriteLine(numbers[i] + " ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //Q4c - Double every second value 
            for (int i = 0; i < numbers2.Length; i += 2)
                numbers[i] *= 2;

            //Q4d - Re-print list
            Console.WriteLine("Q4d - print list with doubles values");
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i] + " ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //Q5 - Determine largest and smallest value

            //If the list is sorted, the first index will have the smallest value,
            //and the last index will have the greatest value
            
            Array.Sort(numbers2);
            Console.WriteLine($"Q5 - Min; {numbers2[0]}, Max: {numbers2[numbers.Length - 1]}");


            //*** LISTS TUTORIAL***

            //How you make lists of common data types
            List<int> numbers3 = new List<int>();
            List<string> names1 = new List<string>();
            List<double> prices = new List<double>();

            //Add items to a list at time of creation
            // List<strings> names1 = new List<string>() {"Arthur Dent", "Marvin");


            //also add items to a list one at any time during the run
            //of your program using the Add() method

            names1.Add("Trillian");
            names1.Add("Ford Prefect");

            //Count property tells how many times items are in list

            Console.WriteLine(names1[0]); //First item
            Console.WriteLine(names1[names1.Count - 1]); //Last item

            //You can change the value stored at an index with this line 

            names1[0] = "Arthur";
            Console.WriteLine(names1[0]);

            //Once List is initialized, we can begin inserting numbers

            List<int> numbers4 = new List<int>();
            numbers4.Add(1);
            numbers4.Add(2);
            numbers4.Add(3);

            //We can also add a whole array to a list
            List<int>numbers5 = new List<int>();
            int[] array = new int[] { 1, 2, 3, };
            numbers4.AddRange(array);

            //Use Remove to Remove an item
            List<string> fruits = new List<string>();
            // add fruits
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("orange");

            //Now remove the banana
            fruits.Remove("banana");
            Console.WriteLine(fruits.Count);

            //We can use AddRange to join between lists
            List<string> food = new List<string>();
            food.Add("apple");
            food.Add("banana");

            List<string> vegetables = new List<string>();
            vegetables.Add("tomato");
            vegetables.Add("carrot");

            food.AddRange(vegetables);
            Console.WriteLine(food.Count);

            // Contains(T) determines whether an elements in the list<T>
            //Add Range Adds the elements of the specified collection to the end of the List

           
            //Here is for loop that you can use to iterate through names
          //  for (int i = 0; i < names.Count; i++)
          //Console.WriteLine(names[i]);

            //You can also use a foreach loop to iterate though a list
            //foreach (string name in names)
            //Console.WriteLine(name);

        }
    }
}











