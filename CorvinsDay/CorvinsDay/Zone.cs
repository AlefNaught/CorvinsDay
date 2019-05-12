using System;
using System.Security.Cryptography;

namespace CorvinsDay
{
    public class Zone
    {
        public string name;
        public Item item;

        public Zone(string name, Item item)
        {
            this.name = name;
            this.item = item;
        }

        public static void SeedZones()
        {
            string[] zoneNameList = {"Lobby", "Hallway", "Parking Garage", "Street", "Downtown"};
            int rndItemIndex = Globals.rng.Next(Globals.Items.Count);
            Item rndItem = Globals.Items[rndItemIndex];

            foreach (var zoneName in zoneNameList)
            {
                Globals.Zones.Add(new Zone(rndItem, zoneName)); //Fix
                Console.WriteLine(zoneName);
            }
        }
    }
}