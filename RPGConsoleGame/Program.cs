using RPGConsoleGame.Character;

namespace RPGConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type in which class you would like to select: \n");
            Console.WriteLine("Warrior\nMage\nRogue\nRanger\n");
            string input = Console.ReadLine();

            Warrior warrior;
            Mage mage;
            Rogue rogue;
            Ranger ranger;

            if (input == "Warrior")
            {
                warrior = new(Name());

            } 
            else if (input == "Mage")
            {
                mage = new(Name());
            } 
            else if (input == "Rogue")
            {
                rogue = new(Name());
            } else if (input == "Ranger")
            {
                ranger = new(Name());
            } else
            {
                Console.WriteLine("Sorry this was not an option.");
            }

            
            

        }

        static string Name ()
        {
            Console.WriteLine("Please enter your character name\n");
            string charName = Console.ReadLine();

            return charName;
        }

    }
}