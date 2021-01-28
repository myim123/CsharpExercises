using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConditionalExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Exercise 1
            /// Write a program and ask the user to enter a number. 
            /// The number should be between 1 to 10. 
            /// If the user enters a valid number,
            /// display "Valid" on the console. 
            /// Otherwise, display "Invalid". 
            /// (This logic is used a lot in applications
            /// where values entered into input boxes need to be validated.)
            /// </summary>
            /// 
            //Console.WriteLine(Exercise1());

            /// <summary>
            /// Exercise 2
            /// Write a program which takes two numbers 
            /// from the console and displays 
            /// the maximum of the two.
            /// </summary>
            Console.WriteLine(Exercise2());

        }

        static string Exercise1()
        {
            Console.Write("Enter a number between 1 to 10: ");
            var input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace (input))
            {
                //convert number to Int32
                var number = Convert.ToInt32(input);
                if (number >= 1 && number <= 10)
                    return "Valid";
                else
                    return "Invalid";
            }

            return "";
        }

        static string Exercise2()
        {
            Console.Write("Ener 1st Number: ");
            var input = Console.ReadLine();
            var num1 = Convert.ToInt32(input);

            Console.Write("Ener 2nd Number: ");
            input = Console.ReadLine();
            var num2 = Convert.ToInt32(input);

            if (num1 > num2)
                return num1 + " is bigger than " + num2;
            else
                return num2 + " is bigger than " + num1;
        }
    }
}
