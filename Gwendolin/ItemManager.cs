using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//The Item Manager class is for managing the items the player will gather throughout the game
namespace Gwendolin
{
    internal class ItemManager
    {
        public Item CreateKnife()
        {
            return new Item("Knife", "A sturdy kitchen knife.");
        }
        public Item CreateMallet() 
        {
            return new Item("Big Mallet", "A strong Mallet, great for smashing!");
        }
        public Item CreateHeartObject() 
        {
            return new Item("Heart Shaped Object", "A small heart shape that fell out of a Violin.");
        }
        public Item CreateViolin() 
        {
            return new Item("Arthurs Violin", "A unique violin, made just for him.");
        }
    }
}
