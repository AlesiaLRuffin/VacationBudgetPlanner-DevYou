using System;
using System.Collections.Generic;
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
            Console.WriteLine("Welcome to the Vacation Budget Planner.");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.WriteLine("You've worked hard and deserve a great, stress free vacation!");
            Console.WriteLine("This planner will help with financial planning to make your vacation as smooth as possible.");
            Console.WriteLine();
            Console.WriteLine("Who do we have the privilage of working with?");
            string adventurerName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Welcome Adventurer " + adventurerName + ", where do you plan to go?");
            Console.WriteLine("1: Mountain biking in Blue Derby, Tasmania");
            Console.WriteLine("2: Ballroom Dancing on a cruise to Italy, Greek Isles and more?");
            DoOver:
            Console.WriteLine("Enter 1 or 2");
            string userValue = Console.ReadLine();

            // week 1 user destination choices
            if (userValue == "1")
            {
                string message = ($"WOW {adventurerName} you're a Mountain Mangler! You'll be shredding on mountain bike trails in Blue Derby, Tasmania");
                Console.WriteLine(message);

                Console.WriteLine($"How many days to do plan to be in Tasmania?");
                int numberOfDays = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"How much spending money are you planning to take with you?");
                double spendingMoney = Convert.ToDouble(Console.ReadLine());
                double perDiem = Math.Round(spendingMoney / numberOfDays, 2);

                Console.WriteLine($"Adventurer {adventurerName}, you are going mountain biking in Blue Derby, Tasmania" +
                    $" for {numberOfDays} days with {spendingMoney.ToString("C2", CultureInfo.CurrentCulture)} in spending money.");
                Console.WriteLine($"This allows for {perDiem.ToString("C2", CultureInfo.CurrentCulture)} to spend per day.");
                Console.WriteLine("Press enter to exit");
                //Console.ReadLine();
            }
            else if (userValue == "2")
            {
                string message = ($"Hey Twinkletoes {adventurerName}, you will be waltzing under the stars on a cruise to Italy, " +
                    "the Greek Isles and other exciting destinations.");
                Console.WriteLine(message);
           }
            else
            {
                string message = "Sorry, that option isn't available. Please choose 1 or 2";
                Console.WriteLine(message);
                goto DoOver;
            }
            Console.ReadLine();


            

        }
    }
}
