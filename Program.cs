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
            Console.WriteLine("** Winning Conditions:");
            Console.WriteLine("  - Population is greater than 2000 ");
            Console.WriteLine("  - Money is greater than 6000 and Population is greater than 1000");
            Console.WriteLine("** [NOTE] If happiness or money drops to 0 or less than 0, it is GAME OVER!");
            Console.WriteLine("Watch out for day-specific events along your journey!\n");
            // can add functionality like if statements to start game
            Console.WriteLine("Enter any key to Start your Kingdom Game! Let's see what you got.");

            // CHOICES or OPTION METHODS
            int money = 100;
            int happiness = 20;
            int population = 20;
            int day = 1;
            bool isFinished = false;
            string gameCondition = "";

            void HostBanquet()
            {
                money -= 200;
                happiness += 20;
            }
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
                // DAY-SPECIFIC EVENTS
                /*if (day == )*/

                // Check winning conditions/game conditions
                if (population == 2000)
                {
                    Console.WriteLine("YOU WIN! Your KINGDOM rose to the TOP!");
                    gameCondition = "W";
                }
            }

            // GAME LOOP 

            while (isFinished == false)
            {
                // GAME Choices UI - can be encapsulated in a method for getting input
                Console.WriteLine("Enter ");
                Console.WriteLine("A. Host a Banquet");
                Console.WriteLine("B. Create Jobs");
                Console.WriteLine("C. Hold a Festival");
                Console.WriteLine("D. Collect Emergency Taxes");
                Console.WriteLine("E. End Current Day");

                // Get user input (can create method)
                string input = Console.ReadLine();
                // CONDITIONAL FLOW LOGIC
                if (input.ToUpper() == "A")
                {
                    HostBanquet();
                }
                else if (input.ToUpper() == "B")
                {
                    CreateJobs();
                }
                else if (input.ToUpper() == "C")
                {
                    HoldFestival();
                }
                else if (input.ToUpper() == "D")
                {
                    CollectTax();
                }    
                else if (input.ToUpper() == "E")
                {
                    EndDay();
                    if (gameCondition == "W")
                    {
                        isFinished = true;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

            // END LOOP
            
        }
    }
}