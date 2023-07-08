using RPGConsoleGame.PrimaryAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame.Character
{
    internal class Warrior : Character
    {
        public Warrior(string name) : base(name, 5, 2, 1) 
        {
            Console.WriteLine("Warrior: {0} has been created. \nYou are level {1}", name, getLevel());
        }

        public void levelUp()
        {
            LevelUp(3, 2, 1);
        }




    }
}
