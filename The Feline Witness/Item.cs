using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Feline_Witness
{
    internal class Item
    {
        //Private fields
        private string name;
        private HouseSpace location;

        //Public properties
        public string Name { get; set; }
        public HouseSpace Location { get; set; }

        //Constructor
        public Item(string givenName, HouseSpace givenLocation)
        {
            Name = givenName;
            Location = givenLocation;
        }

        //Methods
        public string displayItemName() 
        {
            return Name;
        }

        public void goTo()
        {
            Console.WriteLine($"Going to {Name}....\n");
        }
    }
}