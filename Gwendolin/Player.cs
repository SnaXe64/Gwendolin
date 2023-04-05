using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//Player class, holds the inventory and methodds for adding items and for checking if the player has an item
namespace Gwendolin
{
    public class Player
    {
        public List<Item> inventory;
        public Player()
        {
            inventory = new List<Item>();
        }

        public void AddItem(Item item)
        {
            inventory.Add(item);
        }
        //Friend helped me with this, I had a big issue with how I wanted to handle items and he helped me solve that, the big fixes are in the room class.
        public bool HasItem(string item)
        {
            foreach (Item i in inventory) 
            { 
                if (i.Name == item) return true;
            }

            return false;
        }

        
    }
}
