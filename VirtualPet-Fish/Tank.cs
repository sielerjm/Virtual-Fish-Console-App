using System;
using static System.Console;

namespace VirtualPet_Fish
{
    public class Tank
    {
        public string Title = "Virtual Fish";
        public string Description = "Take care of your very own virtual fish!";
        public string TitleArt = (@"
 __        __   _                            _             
 \ \      / /__| | ___ ___  _ __ ___   ___  | |_ ___       
  \ \ /\ / / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \      
   \ V  V /  __/ | (_| (_) | | | | | |  __/ | || (_) |     
 __ \_/\_/_\___|_|\___\___/|_| |_| |_|\___|_ \__\___/    _ 
 \ \   / (_)_ __| |_ _   _  __ _| | | |  ___(_)___| |__ | |
  \ \ / /| | '__| __| | | |/ _` | | | | |_  | / __| '_ \| |
   \ V / | | |  | |_| |_| | (_| | | | |  _| | \__ \ | | |_|
    \_/  |_|_|   \__|\__,_|\__,_|_|_| |_|   |_|___/_| |_(_)

                     ^
                   //          ___   ___
                 (*)     '0'  /  _   _  \
                (*)             / \ / \
               (*)    '0'      |   |   |    |\
              //               |O  |O  |___/  \     ++
            //                  \_/ \_/    \   | ++
            //               _/       __    \  \
            /     /|   /\   (________ / __ | _ /
                 / |  |  |      (___ /  |    |\
                / /  /   |        \     \|    | ___ /|
               |  | |   /          \_________      _ / ++++
              /   | |  |        ++            \    |
             |   / /   |                  ++   |   / +++
            /   /  |   |                   ++ / __ /
            ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~+++~~~~~\n");

        public void Run()
        {
            // Trick to set the background color for the whole console using Clear.
            //BackgroundColor = ConsoleColor.White;
            Clear();

            // Display the welcome screen for the game.
            //ForegroundColor = ConsoleColor.Blue;
            WriteLine(TitleArt);

            // We can use "escape sequences" to display things like newlines and tabs by starting 
            // with a forward slash:
            // https://docs.microsoft.com/en-us/cpp/c-language/escape-sequences?view=vs-2019
            //WriteLine("\n\n");

            //ForegroundColor = ConsoleColor.DarkMagenta;
            WriteLine("~~~ Welcome to " + Title + " ~~~");
            WriteLine(Description);

            // Create the fish and welcome them.
            Write("What is the name of your fish? Enter here: ");
            string FishName = ReadLine();
            VirtualFish fishA = new VirtualFish(FishName, 6, true, 1.0, 1.0, 1.0);
            fishA.Greet();

            // Start Game
            bool KeepPlaying = true;
            Game currentGame = new Game();

            // Play game while KeepPlaying == true
            do
            {
                currentGame.Play();

                WriteLine("Do you wish to keep playing? Press (y) to continue or any other key to exit.");

                string UserChoice = ReadLine();
                if (UserChoice == "y" || UserChoice == "Y")
                {
                    KeepPlaying = true;
                } else
                {
                    KeepPlaying = false;
                }

            }
            while(KeepPlaying);

            // Exit Game
            WriteLine("\nThanks for playing! Come back soon.");
            WriteLine("Press any key to close terminal...");
            ReadKey();

        }
    }
}
