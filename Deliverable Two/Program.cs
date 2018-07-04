using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user for first input.
            Console.WriteLine("Please enter a date as MM/DD/YYYY:");
            string userInputOne = Console.ReadLine();
            
            // If user input is not a valid date, ask to re-enter the date.
            while (UserInputValidity(userInputOne) == false)
            { 
                Console.WriteLine("I'm sorry, that is not a valid date format. Please enter a date as MM/DD/YYYY:");
                userInputOne = Console.ReadLine();
            }

            // Converts user input string into DateTime.
            DateTime userDateOne = DateTime.Parse(userInputOne);

            // Asks user for second input.
            Console.WriteLine("Please enter another date MM/DD/YYYY that differs from the first date:");
            string userInputTwo = Console.ReadLine();

            // If second user input is not a valid date, asks to re-enter the date.
            while (UserInputValidity(userInputTwo) == false)
            {
                Console.WriteLine("I'm sorry, that is not a valid date format. Please enter a date as MM/DD/YYYY:");
                userInputTwo = Console.ReadLine();
            }

            // Converts second user input string into DateTime.
            DateTime userDateTwo = DateTime.Parse(userInputTwo);

            // Stores the difference between the two dates input by user.
            TimeSpan differenceBetweenDates = userDateOne - userDateTwo;

            // Stores the difference between the two dates as an absolute value of days, hours, and minutes.
            double Days = Math.Abs(differenceBetweenDates.TotalDays);
            double Hours = Math.Abs(differenceBetweenDates.TotalHours);
            double Minutes = Math.Abs(differenceBetweenDates.TotalMinutes);

            // Prints the number of days, hours, and minutes between the two dates to the console.
            Console.WriteLine("The number of days between the two dates is {0}", Days);
            Console.WriteLine("The number of hours between the two dates is {0}", Hours);
            Console.WriteLine("The number of minutes between the two dates is {0}", Minutes);

            Console.ReadKey();
        }

        /// <summary>
        /// Checks if user input is a valid date
        /// </summary>
        /// <param name="userInput">Any user input</param>
        /// <returns>If input is not a valid date format, prints false, otherwise prints true.</returns>
        public static bool UserInputValidity(string userInput)
        {
            if (DateTime.TryParse(userInput, out DateTime userDate) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

