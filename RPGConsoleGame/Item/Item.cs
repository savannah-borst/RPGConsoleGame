using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGConsoleGame.Item
{
    abstract class Item
    {
        string _name;
        int _equipLevel;
        string _itemSlot;

        public Item() { }
    }
}
