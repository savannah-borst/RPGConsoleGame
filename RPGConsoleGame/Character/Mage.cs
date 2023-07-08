using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame.Character
{
    internal class Mage : Character
    {
        public Mage(string name) : base(name, 1, 1, 8) 
        {
            Console.WriteLine("Mage: {0} has been created. \nYou are level {1}", name, getLevel());
        }
        public void levelUp()
        {
            LevelUp(1, 1, 5);
        }

    }
}
