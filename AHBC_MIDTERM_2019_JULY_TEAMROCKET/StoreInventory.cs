using System;
using System.Collections.Generic;
using System.Text;

namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
{
    public class StoreInventory 
    {
        public List<StoreItem> TotalStoreInventory { get; set; }
        public List<StoreItem> GenerateStoreInventory()
        {
            List<StoreItem> StoreInventory = new List<StoreItem>();  //creating list to store and return the store inventory
            StoreItem testItem = new StoreItem(); //Store item creator
            List<string> storeFromTextFile = new List<string>();  //list to grab the store inventory from text file
            storeFromTextFile = testItem.FileReader(); //storing text file

            foreach (var line in storeFromTextFile)  //looping through each line of the list to create store items from each line
            {
                if (line != "") //if the line is not null continue to add store items to the list
                {
                    StoreInventory.Add(testItem.ReturnStoreItem(line));  //adding store items into the store inventory
                }
                else //end of the list
                {
                    break;
                }
            }
            return StoreInventory; //return the store inventory
        }


    }
}
