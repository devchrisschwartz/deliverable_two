using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a date as MM/DD/YYYY:");
            if (DateTime.TryParseExact(Console.ReadLine(), "MM/dd/yyyy",
                          CultureInfo.InvariantCulture,
                          DateTimeStyles.None, out birthDay)
{
                // Your input string can (and will) be parsed with MM/dd/yyyy format.
            }
            else
            {
                // Invalid format or value.
            }
            Console.ReadKey();
        }

        // public static DateTime UserDateInput()
    }
}
