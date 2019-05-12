using System;

namespace CorvinsDay
{
    public class Item
    {
        public string name;

        public Item(string name)
        {
            this.name = name;
        }

        public static void SeedItems()
        {
            string[] itemNameList = {"Sword", "Knife", "Bat", "Shotgun"};
            foreach (var itemName in itemNameList)
            {
                Globals.Items.Add(new Item(itemName));
                Console.WriteLine(itemName);
            }
        }

    }
}