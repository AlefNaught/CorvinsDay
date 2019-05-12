using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CorvinsDay
{
    /* ITEMS AND INVENTORY.
     *  All items will be listed here.
     *  Inventory will be created here.
     */
    public class Items
    {
        public string ItemName { get; set; }
        public bool IsHeld { get; set; }
        public override string ToString()
        {
            return string.Join(",", IsHeld, ItemName);
        }

        public List<Items> itemList = new List<Items>(); // The list of items in the game.

        public void iList() //Items name.
        {
            itemList.Add(new Items {ItemName = "Test"});
            itemList.Add(new Items {ItemName = "Test2"});
            itemList.Add(new Items {ItemName = "Test3"});
            itemList.Add(new Items {ItemName = "Test4"});
        }

        public void UpdateItem()
        {
         
        }
    }
}