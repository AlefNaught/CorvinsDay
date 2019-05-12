using System;
using System.Collections.Generic;

namespace CorvinsDay
{
    public class Globals
    {
        public static Random rng;
        public static List<Item> Items;
        public static List<Item> Inv;
        public static List<Zone> Zones;

        public static void Init()
        {
            rng = new Random();
            Items = new List<Item>();
            Inv = new List<Item>();
            Zones = new List<Zone>();
            
            Zone.SeedZones();
            Item.SeedItems();
        }

    }
}