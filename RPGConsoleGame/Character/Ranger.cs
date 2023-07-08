using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame.Character
{
    internal class Ranger : Character
    {
        public Ranger(string name) : base(name, 1, 7, 1) 
        {
            Console.WriteLine("Ranger: {0} has been created. \nYou are level {1}", name, getLevel());
        }

        public void levelUp()
        {
            LevelUp(1, 5, 1);
        }

    }
}
