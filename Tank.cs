using System;
using static System.Console;
using System.Diagnostics;  // Why do I not use "static" in front?  #QUESTION

namespace VirtualPet_Fish
{
    public class Tank
    {
        // Field
        public double CleanLevel;
        public bool IsDirty;

        // Constructor
        public Tank()
        {
            CleanLevel = 1.0;
            IsDirty = false;
        }
        
        public void Create()
        {
            
            // Create the fish and welcome them.
            Write("What is the name of your fish? Enter here: ");
            string FishName = ReadLine();
            VirtualFish fishA = new VirtualFish(FishName, 6, true, 1.0, 1.0, 1.0);
            fishA.Greet();


            bool fishAlive = fishA.Alive;
            // Play game while fishAlive == true
            do
            {
                //WriteLine($"Is {fishA.Name} alive?: {fishA.Alive}");  // #TEST



                // Check time: https://stackoverflow.com/q/14019510
                // Each action reduces energy for X minutes played               
                // Check that fish is alive, health > 0
                // Increment tank cleanLevel X minutes played
                // Check tank cleanliness
                // Set tank to dirty if dirty
                // Adjust fish happiness level and health accordingly
                // Increment fish age


            }
            while (fishAlive);

            // Exit Game
            WriteLine("\nThanks for playing! Come back soon.");
            WriteLine("Press any key to close terminal...");
            ReadKey();


        }
    }
}
