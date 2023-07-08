using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame.PrimaryAttributes
{
    internal class PrimaryAttribute
    {
        public PrimaryAttribute(int strength, int dexterity, int intelligence) {
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
        }

        int strength;
        int dexterity;
        int intelligence;

        public void setPrimaryAttributes(int strenght, int dexterity, int intelligence)
        {
            this.strength = strenght;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
        }

        public int getStrength()
        {
            return strength;
        }

        public int getDexterity()
        {
            return dexterity;
        }

        public int getIntelligence()
        {
            return intelligence;
        }

  
    }
}
