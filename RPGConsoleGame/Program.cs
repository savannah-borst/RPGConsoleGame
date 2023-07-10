using RPGConsoleGame.Character;

namespace RPGConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CreateCharacter();




        }

        static void CreateCharacter()
        {
            Console.WriteLine("Type in which class you would like to select: \n");
            Console.WriteLine("1. Warrior\n2. Mage\n3. Rogue\n4. Ranger\n");
            string input = Console.ReadLine().ToLower();

            Warrior warrior;
            Mage mage;
            Rogue rogue;
            Ranger ranger;

            if (input == "warrior" || input == "1")
            {
                warrior = new(Name());
            }
            else if (input == "mage" || input == "2")
            {
                mage = new(Name());
            }
            else if (input == "rogue" || input == "3")
            {
                rogue = new(Name());
            }
            else if (input == "ranger" || input == "4")
            {
                ranger = new(Name());
            }
            else
            {
                Console.WriteLine("Sorry this was not an option.");
            }
        }


        static string Name()
        {
            Console.WriteLine("\nPlease enter your character name\n");
            string charName = Console.ReadLine();

            return charName;
        }

        static void WhatToDo()
        {
            Console.WriteLine("What would you like to do?\n");
            Console.WriteLine("1. Fight");
            Console.WriteLine("2. See stats");
            //Console.WriteLine("3. see bestiary");
            //Console.WriteLine("3. See equipment");
        }

        static void Fight()
        {
            Console.WriteLine("Which level monster would you like to fight?");

            // randomize 5 enemies
            // from a pool of several enemies. with always a random lvl.
            // need to figure out stats for different opponenets
        }
    }
}