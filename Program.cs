using System;
using System.Collections.Generic;
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
            Console.WriteLine("Enter 1 or 2");
            string userValue = Console.ReadLine();

            if (userValue == "1")
            {
                string message = "WOW you're a Mountain Mangler! You'll be shredding on mountain bike trails in Blue Derby, Tasmania";
                Console.WriteLine(message);
            }
            else if (userValue == "2")
            {
                string message = "Hey Twinkletoes, you will be waltzing under the stars on a cruise to Italy, " +
                    "the Greek Isles and other exciting destinations.";
                Console.WriteLine(message);
           }
            else
            {
                string message = "Sorry, that option isn't available. Please choose 1 or 2";
                Console.WriteLine(message);
            }
            Console.ReadLine();


        }
    }
}
