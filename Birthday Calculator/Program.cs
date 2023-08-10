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

            // Display various age information
            Console.WriteLine("\r\nYou're " + age.Days / 365 + " years old");
            Console.WriteLine("You're " + age.Days + " days old");
            Console.WriteLine("You're " + age.Days * 24 + " hours old");
            Console.WriteLine("You're " + age.Days * 1440 + " minutes old");
            Console.WriteLine("You're " + age.Days * 86400 + " seconds old");

            // Wait for user input before exiting
            Console.ReadLine();
        }
    }
}
