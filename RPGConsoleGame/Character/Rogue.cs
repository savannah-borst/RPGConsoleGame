using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame.Character
{
    internal class Rogue : Character
    {
        public Rogue(string name) : base(name, 2, 6, 1) 
        {
            Console.WriteLine("Rogue: {0} has been created. \nYou are level {1}", name, getLevel());
        }

        public void levelUp()
        {
            LevelUp(1, 4, 1);
        }



    }
}
