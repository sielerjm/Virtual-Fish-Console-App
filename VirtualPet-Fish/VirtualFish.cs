using System;
using static System.Console;
namespace VirtualPet_Fish
{
    public class VirtualFish
    {

        // Field
        // public   = access modifier
        // string   = type
        // Name     = identifier
        public string Name;
        public int Age;
        public bool IsAwake;
        public double HealthLevel;
        public double EnergyLevel;
        public double HappyLevel;


        // Constructors
        public VirtualFish(string newName,
                            int newAge,
                            bool newIsAwake,
                            double newHealthLevel,
                            double newEnergyLevel,
                            double newHappyLevel
                            )
        {
            Name = newName;
            Age = 0;
            IsAwake = true;
            HealthLevel = 1.0;
            EnergyLevel = 1.0;
            HappyLevel = 1.0;

            WriteLine("Fish being constructed!");
        }


        // Method definition:
        public void Greet()
        {
            WriteLine($"\nFish");
            WriteLine($"- Name: {Name}");
            WriteLine($"- Age: {Age} days old");
            WriteLine($"- Awake: {IsAwake}");
            WriteLine($"- Health Level: {HealthLevel}");
            WriteLine($"- Energy Level: {EnergyLevel}");
            WriteLine($"- Happiness Level: {HappyLevel}");

        }


        public void Eat(string FoodName)
        {
            WriteLine($"{Name} is eating some {FoodName}.");
        }

        public void Sleep()
        {
            IsAwake = false;
            WriteLine($"Shhh! {Name} is sleeping... ZZZzzzz....");
        }
    }
}
