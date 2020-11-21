using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vacation Budget Planner.\n\n");
            Console.WriteLine("You've worked hard and deserve a great, stress free vacation!");
            Console.WriteLine("This planner will help with financial planning to make your vacation as smooth as possible.");
            Console.WriteLine("Enter your password to continue");

            int loginAttempts = 0;
            for (int i = 0; i < 3; i++)
            {
                string pass = "Vaca4Me!";
                string guess = Console.ReadLine();

                if (guess == pass)
                {
                    Console.WriteLine("You may enter");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry Try Again");
                    loginAttempts++;
                    if (loginAttempts == 3)
                    {
                        Console.WriteLine("Login Failure");
                        Environment.Exit(3);
                    }
                }
            }

            const int hours = 24;
            const int minutes = 60;


            Console.WriteLine();
            Console.WriteLine("Who do we have the privilage of working with?");
            string adventurerName = Console.ReadLine();
            Console.WriteLine();
        BeginAgain:
            Console.WriteLine("Welcome Adventurer " + adventurerName + ", where do you plan to go?");
            Console.WriteLine("1: Mountain biking in Blue Derby, Tasmania");
            Console.WriteLine("2: Ballroom Dancing on a cruise to Italy, Greek Isles and more?\n");
        DoOver:
            Console.WriteLine("Enter 1 or 2");
            string userValue = Console.ReadLine();
            Console.WriteLine();
            // week 1 user destination choices
            switch (userValue)
            {
                case "1":
                    Console.WriteLine($"WOW {adventurerName} you're a Mountain Mangler! You'll be shredding on mountain bike trails in Blue Derby, Tasmania");
                    Console.WriteLine("*************\n");
                    Console.WriteLine($"How many days to do plan to be in Tasmania?");
                    int numberOfDays = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"How much spending money in USD(United States Dollars) are you planning to take with you?");
                    int hoursOnTrip = numberOfDays * hours;
                    int minutesOnTrip = hoursOnTrip * minutes;
                    double spendingMoney = Convert.ToDouble(Console.ReadLine());
                    double ausBucks = spendingMoney * 1.37;
                    double perDiem = Math.Round(spendingMoney / numberOfDays, 2);
                    double ausPerDiem = ausBucks / numberOfDays;
                    Console.WriteLine();
                    Console.WriteLine($"Adventurer {adventurerName}, you are going mountain biking in Blue Derby, Tasmania" +
                        $" for {numberOfDays} days\nthat's {hoursOnTrip} hours or {minutesOnTrip} minutes, just for funsies\n" +
                        $"with {spendingMoney.ToString("C2", CultureInfo.CurrentCulture)} in spending money.\n");
                    Console.WriteLine($"This allows for {perDiem.ToString("C2", CultureInfo.CurrentCulture)} USD to spend per day.");
                    Console.WriteLine($"After currency exchange you will have {ausBucks:C} Australian Dollars total.\nThat averages to {ausPerDiem:C} AUD to spend per day.\n");
                    Console.WriteLine("Enjoy your mountain biking trip in Blue Derby, Tasmania. Be Safe!\n");

                    break;

                case "2":
                    Console.WriteLine($"Hey Twinkletoes {adventurerName}, you will be waltzing under the stars on a cruise to Italy, " +
                         "the Greek Isles and other exciting destinations.");
                    Console.WriteLine("*************");
                    Console.WriteLine($"How many days will you be cruising?");
                    int cruiseDays = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"How much spending money in USD(United States Dollars) are you planning to take with you?");
                    int cruiseHours = cruiseDays * hours;
                    int cruiseMinutes = cruiseHours * minutes;
                    double cruiseMoney = Convert.ToDouble(Console.ReadLine());
                    double euroBucks = cruiseMoney * 1.18;
                    double cruisePerDiem = Math.Round(cruiseMoney / cruiseDays, 2);
                    double euroPerDiem = euroBucks / cruiseDays;
                    Console.WriteLine();
                    Console.WriteLine($"Adventurer {adventurerName}, you are cruising the Greek Isles, Italy and other Mediterranean ports for {cruiseDays} days\n" +
                        $" - fun fact - that's equal to {cruiseHours} hours or {cruiseMinutes} minutes.\n" +
                        $"You will have {cruiseMoney.ToString("C2", CultureInfo.CurrentCulture)} USD in spending money.");
                    Console.WriteLine($"This allows for {cruisePerDiem.ToString("C2", CultureInfo.CurrentCulture)} to spend per day.");
                    Console.WriteLine($"Your USD converts to a total of {euroBucks:C} Euro or a daily maximum of {euroPerDiem:C}" +
                        $" to spend.\n");
                    Console.WriteLine($"Don't forget the dramamine and your dance shoes! Have fun on your {cruiseDays} day cruise!\n");

                    break;

                default:
                    Console.WriteLine("Sorry, that option isn't available. Please choose 1 or 2");
                    goto DoOver;

            }
            Console.WriteLine("Would you like to start over? Y or N\n");
            char newTrip = Convert.ToChar(Console.ReadLine());
            if (newTrip == 'Y')
            {
                goto BeginAgain;
            }
            else
            { }
        }
    }
}       
