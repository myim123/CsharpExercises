using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// Exercise 1
            /// Write a program and continuously ask the user
            /// to enter different names, until the user presses Enter 
            /// (without supplying a name). Depending on the number
            /// of names provided, display a message
            /// based on the above pattern.
            /// </summary>
            /// 
            //Console.WriteLine(Exercise1());

            /// <summary>
            /// Exercise 2
            /// Ask the user to enter their name. 
            /// Use an array to reverse the name 
            /// and then store the result in a new string. 
            /// Display the reversed name on the console.
            /// </summary>
            /// 
            //Console.WriteLine(Exercise2());

            /// <summary>
            /// Exercise 3
            /// Write a program and ask the user to enter 5 numbers. 
            /// If a number has been previously entered, display 
            /// an error message and ask the user to re-try. 
            /// Once the user successfully enters 5 unique numbers, sort them 
            /// and display the result on the console.
            /// </summary>
            /// 
            //Console.WriteLine(Exercise3());

            /// <summary>
            /// Exercise 4
            /// Write a program and ask the user
            /// to continuously enter a number
            /// or type "Quit" to exit. 
            /// The list of numbers may 
            /// include duplicates. 
            /// Display the unique numbers
            /// that the user has entered.
            /// </summary>
            /// 
            //Console.WriteLine(Exercise4());

            /// <summary>
            /// Exercise 5
            /// Write a program and ask the user to supply
            /// a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
            /// If the list is empty or includes less than 5 numbers,
            /// display "Invalid List" and ask the user to re-try;
            /// otherwise, display the 3 smallest numbers in the list.
            /// </summary>
            /// 
            //Console.WriteLine(Exercise5());

            //var name = "Mike";
            //char[] nameArr;
            //nameArr = name.ToArray();
            //foreach(var letter in nameArr)
            //    Console.WriteLine(letter);


            //string s = "You win some. You lose some.";
            ////string[] words = s.Split(' ', '.');
            //char[] delimiters = new char[] { ' ', '.' };
            //string[] subs = s.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            //foreach (var word in subs)
            //{
            //    Console.WriteLine($"Substring: {word}");
            //}

        }

        static string Exercise1()
        {
            //create name list to store the entered names
            var names = new List<string>();

            while (true)
            {
                Console.Write("Enter name or press 'Enter' key without name to quit: ");
                var nameInput = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(nameInput))
                    break;
                names.Add(nameInput);
            }

            string result;
            if (names.Count > 2)
                result = string.Format("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                result = string.Format("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                result = string.Format("{0} likes your post.", names[0]);
            else
                result = "";
            return result;
        }

        static string Exercise2()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            var nameList = new List<char>(name);
            var reverseName = "";
            var charCount = nameList.Count;
            for (int i = charCount - 1; i >= 0; i--)
            {
                reverseName += nameList[i];
            }

            return reverseName;
        }

        static string Exercise3()
        {
            var numbers = new List<int>();
            var maxCount = 5;
            //var numCount = 0;
            while (numbers.Count < maxCount)
            {

                Console.Write("Enter unique number: ");
                var input = Console.ReadLine();
                var numInput = Convert.ToInt32(input);
                if (numbers.Contains(numInput))
                {
                    Console.WriteLine("Duplicate number entered: " + numInput);
                    continue;
                }
                numbers.Add(numInput);
            }
            numbers.Sort();
            var result = "";
            foreach (var number in numbers)
            {
                result += number + " ";
            }
            return result;
        }

        static string Exercise4()
        {
            var numbers = new List<int>();
            //int number;
            string input;
            while (true)
            {
                Console.Write("Enter a number or 'Quit' to exit: ");
                input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }
                numbers.Add(Convert.ToInt32(input));
            }

            //Get unique numbers
            var uniqueNumbers = new List<int>();
            var result = "Unique Numbers Entered: ";
            foreach (var number in numbers)
            {
                if (!uniqueNumbers.Contains(number))
                {
                    uniqueNumbers.Add(number);
                    result += number + ",";
                }

            }
            //uniqueNumbers can be use to sort or do something else with list
            return result;
        }

        static string Exercise5()
        {
            Console.Write("Enter list of numbers(5 or more) separated by a comma: ");
            var input = Console.ReadLine();

            var elements = input.Split(',');
            if (elements.Length < 5)
            {
                return "Error. Please re-try.";
            }
            else
            {
                var numbers = new List<int>();
                //add elements to int list
                foreach (var number in elements)
                    numbers.Add(Convert.ToInt32(number));

                int minNum;
                var minNumbers = new List<int>();
                while (minNumbers.Count < 3)
                {
                    minNum = numbers[0];
                    foreach (var number in numbers)
                    {
                        if (number < minNum)
                        {
                            minNum = number;
                        }
                    }
                    numbers.Remove(minNum);
                    minNumbers.Add(minNum);
                }
                var result = "";
                foreach (var number in minNumbers)
                    result += number;
                return result;
            }
        }

    }
}
