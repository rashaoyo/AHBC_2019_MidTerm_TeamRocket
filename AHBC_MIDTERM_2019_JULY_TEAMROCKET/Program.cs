using System;
using System.Collections.Generic;

namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreItem test = new StoreItem();
            List<string> tester = test.FileReader();

            //foreach (var line in tester)
            //{
            //    Console.WriteLine(line);
            //}
            //Console.WriteLine(test.ReturnItemName(tester));
            StoreItem testItem = new StoreItem();
            
            //testItem = test.ReturnStoreItem(tester);
            //Console.WriteLine($"{testItem.NameOfItem} {testItem.ItemQuantity} {testItem.ItemPrice} {testItem.ItemCategory}");

            StoreInventory testing = new StoreInventory();
            List<StoreItem> anotherTest = new List<StoreItem>();
            anotherTest = testing.GenerateStoreInventory();

            //for (int i = 0; i < anotherTest.Count; i++)
            //{
            //    Console.WriteLine(anotherTest[i]);
            //}
            foreach (var line in anotherTest)
            {
                Console.WriteLine($"{line.NameOfItem} {line.ItemQuantity} {line.ItemPrice}{line.ItemCategory}");
               
            }


        }
    }
}
