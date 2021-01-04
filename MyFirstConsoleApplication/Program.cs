using System;
using System.Globalization;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetUserNameAndLocation();
            p.ChristmasCountdown(DateTime.Now);
            GlazerApp.RunExample();
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }

        private void GetUserNameAndLocation() {
            Person person = new Person();
            Console.Write("What is your name? ");
            person.name = Console.ReadLine();
            Console.Write($"Hi {person.name}! Where are you from? ");
            person.location = Console.ReadLine();
            Console.WriteLine($"I have never been to {person.location}. I bet it is nice. Press any key to continue...");
            Console.ReadKey();
        }

        private void ChristmasCountdown(DateTime date)
        {       
            var christmas = new DateTime(2021, 12, 25);
            Console.WriteLine($"Today's date is: {date.ToString("D", CultureInfo.CreateSpecificCulture("en-US"))}");
            TimeSpan countdown = christmas - date.Date;
            Console.WriteLine($"There are {countdown.TotalDays} days until Christmas! Press any key to continue...");
            Console.ReadKey();
        }
    }
}
