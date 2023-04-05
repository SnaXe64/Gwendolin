using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//The item class holds the name and descriptions of Items, originally this is where the items were going to be stored, but it was easier to make an Item Manager for what I was going for
namespace Gwendolin
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }

    }
}
