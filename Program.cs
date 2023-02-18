using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1();
            Problem3();
            Problem5();

        }

        static void Problem1()
        {
            Console.WriteLine("This program will determine all numbers devisible by 3 between 1 and 100 ");

            for(int i = 1; i <= 100; i++) //This for loop sweeps across 1 to 100 and returns numbers that are divisible by 3.
            {
                if (i % 3 == 0) //this number can be changed to check divisiblity.
                {
                    Console.WriteLine("This number is divisible by 3: " + i);
                }
            }
        }
        static void Problem3()
        {
            Console.WriteLine("This program will determine the factorial of a user selected number ");
            int num;
            int factorial = 1; //variable intialized because C# is annoying.

            Console.WriteLine("Enter a number: \n"); //User input for factorial checking.
            num = Convert.ToInt32(Console.ReadLine()); //Conversion from string to int.

            if (num < 0)
                Console.WriteLine("Cannot find the factorial of a negative number"); //Error check to make sure negative numbers are not entered.

            else if (num <= 1) //The factorial of 0 or 1 is always 1 so that is excluded from factorial checks.
                Console.WriteLine("{0}! = {1}", num, factorial);

            else
            {
                for (int counter = num; counter >= 2; counter--) //Sets the counter as the number entered and counts downward to 2 to solve factorial.
                {
                    factorial = factorial * counter; //The equation used.

                }

                Console.WriteLine("{0}! = {1}", num, factorial); //Output formatting.
            }

        }
        static void Problem5()
        {
            Console.WriteLine("This program will determine the largest number in an array ");

            int[] value = new int[5]; //Array initialization.
            int largeEle = 0; //Variable for the largest element found. Again, it's initialized because C# lives to annoy me.

            for (int i = 0; i < value.Length; i++) //Standard for loop. Will loop for each element in the array. In this case: 5 times.
            {
                Console.WriteLine("Please enter a number: "); //User input.
                value[i] = int.Parse(Console.ReadLine()); //Converting string to Int.
                if (value[i] > largeEle) //Argument that compares each number in the array
                {
                    largeEle = value[i]; //The actual comparison. Behold!
                }
            }
            Console.WriteLine("The largest number in the array is: " + largeEle.ToString()); //The largest element in the array, converted from int to string.

        }
    }
}

