using RPGConsoleGame.Character;

namespace RPGConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Type in which class you would like to select: ");
            Console.WriteLine("Warrior\nMage\nRogue\nRanger");
            string input = Console.ReadLine();

            if (input == "Warrior")
            {
                Warrior character = new(Name());
                Console.WriteLine("Created new Warrior: " + character.name);
            } else if (input == "Mage")
            {
                Mage character = new(Name());
                Console.WriteLine("Created new Mage: " + character.name);
            } else if (input == "Rogue")
            {
                Rogue character = new(Name());
                Console.WriteLine("Created new Rogue: " + character.name);
            } else if (input == "Ranger")
            {
                Ranger character = new(Name());
                Console.WriteLine("Created new Ranger: " + character.name);
            } else
            {
                Console.WriteLine("Sorry this was not an option.");
            }
            

        }

        static string Name ()
        {
            Console.WriteLine("Please enter your character name");
            string charName = Console.ReadLine();

            return charName;
        }
    }
}