using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Get the current date and time
            DateTime today = DateTime.Now;

            // Prompt user for date of birth
            Console.WriteLine("Date of birth:");

            // Prompt and read user input for the birth month
            Console.WriteLine("\r\nMonth (m)");
            int months = Convert.ToInt32(Console.ReadLine());

            // Prompt and read user input for the birth day
            Console.WriteLine("\r\nDay (dd)");
            int days = Convert.ToInt32(Console.ReadLine());

            // Prompt and read user input for the birth year
            Console.WriteLine("\r\nYear (yyyy)");
            int years = Convert.ToInt32(Console.ReadLine());

            // Create a DateTime object for the user's birthdate
            DateTime birthday = new DateTime(years, months, days);

            // Calculate the time span between birthdate and today
            TimeSpan age = today - birthday;

            // Calculate the age in years and days
            int yearsOld = age.Days / 365;
            int daysOld = age.Days % 365;

            // Display the age information in years and days
            Console.WriteLine($"\r\nYou're {yearsOld} years and {daysOld} days old");

            // Wait for user input before exiting
            Console.ReadLine();
        }
    }
}
