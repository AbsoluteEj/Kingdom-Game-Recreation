using System;

namespace Kingdom_Game_Recreation
{
    class Program
    {
        static void Main(string[] args)
        {
            // UI
            Console.WriteLine("* *** WELCOME TO KINGDOM GAME! *** *\n");
            Console.WriteLine("Please read the instructions below for the game mechanics.");
            Console.WriteLine("");

            // Get user input (can create method)
            string input = Console.ReadLine();

            // CONDITIONAL FLOW LOGIC
             if (input.ToUpper() == "A")
            {
                HostBanquet();
            }

            // CHOICES or OPTION METHODS
            int money = 100;
            int happiness = 20;
            int population = 20;
            int day = 1;

            void CreateJobs()
            {
                money -= 50;
                population += 5;
            }
            void HoldFestival()
            {
                money -= 500;
                happiness += 15;
                population += 40;
            }
            void CollectTax()
            {
                money += population * 5;
                happiness -= Convert.ToInt32(Math.Floor(population * 0.2));
            }
            void EndDay()
            {
                day++;
                // Check winning conditions
                // if ()
            }

            // DAY-SPECIFIC EVENTS
            /*if (day == )*/
        }
            private static void HostBanquet()
            {
                money -= 200;
                happiness += 20;
            }
    }
}