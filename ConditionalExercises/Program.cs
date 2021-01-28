using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExercises
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
            //Console.WriteLine(Exercise2());

            /// <summary>
            /// Exercise 3
            /// Write a program and ask the user
            /// to enter the width and height
            /// of an image. Then tell if the image 
            /// is landscape or portrait.
            /// </summary>
            //Console.WriteLine(Exercise3());

            /// <summary>
            /// Your job is to write a program for a speed camera. 
            /// For simplicity, ignore the details such as camera, sensors, 
            /// etc and focus purely on the logic. Write a program 
            /// that asks the user to enter the speed limit. Once set, 
            /// the program asks for the speed of a car. 
            /// If the user enters a value less than the speed limit, 
            /// program should display Ok on the console. 
            /// If the value is above the speed limit, 
            /// the program should calculate the number of 
            /// demerit points. For every 5km/hr above the speed limit, 
            /// 1 demerit points should be incurred and displayed on 
            /// the console. If the number of demerit points
            /// is above 12, the program should display License Suspended.
            /// </summary>
            Console.WriteLine(Exercise4());
        }

        static string Exercise1()
        {
            Console.Write("Enter a number between 1 to 10: ");
            var input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                //convert number to Int32
                var number = Convert.ToInt32(input);
                //var number = Int32.Parse(input);
                if (number >= 1 && number <= 10)
                    return "Valid";
                else
                    return "Invalid";
            }
            else
                return "Invalid";
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
            else if (num2 > num1)
                return num2 + " is bigger than " + num1;
            else
                return "Two numbers are equal.";
        }

        static string Exercise3()
        {
            var input="";
            Console.Write("Enter Image Width: ");
            input = Console.ReadLine();
            var imageWidth = Convert.ToInt32(input);
            Console.Write("Enter Image Height: ");
            input = Console.ReadLine();
            var imageHeight = Convert.ToInt32(input);

            //if (imageWidth > imageHeight)
            //    return "Landscape";
            //else
            //    return "Portait";
            var result = imageWidth > imageHeight ? "Landscape" : "Portait";
            return result;
            
        }

        static string Exercise4()
        {
            var input = "";
            Console.Write("Enter speed limit: ");
            input = Console.ReadLine();
            var speedLimit = Convert.ToInt32(input);
            Console.Write("Enter the speed of the car: ");
            input = Console.ReadLine();
            var carSpeed = Convert.ToInt32(input);

            if (carSpeed <= speedLimit)
                return "OK";
            else
            {
                var demeritRate = 5;
                var demeritPoint = (carSpeed - speedLimit) / demeritRate;
                if (demeritPoint < 12)
                    return "Demerit Points: " + demeritPoint;
                else
                    return "Demerit Points: " + demeritPoint + " (License Suspended)";
            }
        }
    }
}
