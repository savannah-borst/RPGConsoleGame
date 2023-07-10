using RPGConsoleGame.PrimaryAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame.Character
{
    abstract class Character
    {

        //Fields
        string _name { get; set; }
        int _level { get; set; }
        PrimaryAttribute _basePrimaryAttribute { get; set; }
        PrimaryAttribute _totalPrimaryAttribute { get; set; }

        //Constructer
        public Character(string name, int str, int dex, int intell) 
        {
            _name = name;    
            _level = 1;
            _basePrimaryAttribute = new PrimaryAttribute(str, dex, intell);
            _totalPrimaryAttribute = new PrimaryAttribute(str, dex, intell);
        }


        protected int getLevel()
        {
            return _level;
        }

        protected void LevelUp(int str, int dex, int intell)
        {
            _level++;

            Console.WriteLine("!! Level {0} !! \nstr +{1} dex +{2} int +{3}", _level, str, dex, intell);

            str = _basePrimaryAttribute.getStrength() + str;
            dex = _basePrimaryAttribute.getDexterity() + dex;
            intell = _basePrimaryAttribute.getIntelligence() + intell;

            _basePrimaryAttribute.setPrimaryAttributes(str, dex, intell);
        }

        public void getBasePrimaryAttributes()
        {
            int str = _basePrimaryAttribute.getStrength();
            int dex = _basePrimaryAttribute.getDexterity();
            int intell = _basePrimaryAttribute.getIntelligence();
            
            Console.WriteLine("Your base stats: str = {0} | dex = {1} | int = {2}", str, dex, intell);
        }

        public void getTotalPrimaryAttributes()
        {
            int str = _totalPrimaryAttribute.getStrength();
            int dex = _totalPrimaryAttribute.getDexterity();
            int intell = _totalPrimaryAttribute.getIntelligence();
            Console.WriteLine("Your total stats: str = {0} | dex = {1} | int = {2}", str, dex, intell);
        }


    }
}
