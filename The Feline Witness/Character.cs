using System;
using System.Collections.Generic;
using System.Threading;

namespace The_Feline_Witness    
{
    internal class Character
    {
        private string name;
        private HouseSpace currentLocation;
        private List<HouseSpace> houseSpaceList = new List<HouseSpace>();

        public string Name { get; set; }
        public HouseSpace CurrentLocation { get; set; }
        public List<HouseSpace> HouseSpaceList { get; set; }

        // Constructor
        public Character(string givenName, HouseSpace givenLocation)
        {
            Name = givenName;
            CurrentLocation = givenLocation;
        }

        // Methods
        public void DisplayDialogue(string text, int speed, string textColor, string resetColor)
        {
            Console.WriteLine();
            Console.Write(textColor);

            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }

            Console.Write($"{Name}: ");

            bool skipDelay = false;

            foreach (char c in text)
            {
                Console.Write(c);

                if (!skipDelay)
                {
                    // CHECK: If player presses any key
                    if (Console.KeyAvailable)
                    {
                        skipDelay = true; // Cut the delay
                        Console.ReadKey(true); // Discard the key press used to skip the delay
                    }
                    else
                    {
                        Thread.Sleep(speed);
                    }
                }
            }

            // Reset the console text color to default 
            Console.Write(resetColor);
            Console.WriteLine();
        }

        public Item ExploreHouse(List<HouseSpace> allRooms)
        {
            HouseSpace space = CurrentLocation;
            Console.WriteLine($"\nCURRENT LOCATION: {space.Name}");
            Console.Write("Press 'M' for Map, 'E' to Examine items, or 'C' to Change location: ");

            try
            {
                char input = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (input == 'M')
                {
                    Console.WriteLine("===========================================================================");
                    Console.WriteLine("\nHOUSE MAP:");
                    space.displayHouseMap(); 
                    Console.WriteLine("===========================================================================");
                }
                else if (input == 'E')
                {
                    Console.WriteLine($"\nAvailable items/furniture in {space.Name}:\n");
                    space.displayItems(); 

                    Console.Write("\nSelect item number to check: ");
                    if (int.TryParse(Console.ReadLine(), out int itemChoice) && itemChoice >= 1 && itemChoice <= space.ItemsAvailable.Count)
                    {
                        Item selectedItem = space.ItemsAvailable[itemChoice - 1];
                        selectedItem.goTo(); 
                        return selectedItem;
                    }
                    else
                    {
                        Console.WriteLine("Invalid item selection.");
                    }
                }
                else if (input == 'C')
                {
                    Console.WriteLine($"\n[Current Location: {CurrentLocation.Name}]\n");
                    Console.WriteLine("Available locations in the house:\n");

                    for (int i = 0; i < allRooms.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {allRooms[i].Name}");
                    }

                    Console.Write("\nSelect room number to go to: ");
                    if (int.TryParse(Console.ReadLine(), out int roomChoice) && roomChoice >= 1 && roomChoice <= allRooms.Count)
                    {
                        HouseSpace selectedRoom = allRooms[roomChoice - 1];
                        Console.WriteLine($"\nGoing to {selectedRoom.Name}.");
                        CurrentLocation = selectedRoom;
                    }
                    else
                    {
                        Console.WriteLine("Invalid room selection.");
                    }
                    return null;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return null;
        }
    }

    internal class Cat : Character
    {
        // Public enums 
        public enum ActionType
        {
            Observe,
            Grab,
            Bury,
            Claw,
            Shove,
            Scatter
        }

        public enum FightingOptions
        {
            Claw,
            Kick,
            Bite
        }

        // Properties
        public ActionType CatAction { get; set; }
        public FightingOptions CatFightingStyle { get; set; }

        // Constructor
        public Cat(string givenName, HouseSpace givenLocation) : base(givenName, givenLocation)
        {
        }
    }

    internal class MainCharacter : Cat
    {
        // Constructor
        public MainCharacter(string givenName, HouseSpace givenLocation) : base(givenName, givenLocation)
        {

        }
    }
}