using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
{
    class CategorySelectionApp
    {

        StoreInventory loaclInventory = new StoreInventory();
        private int userMenuSelection { get; set; }
        public int itemSelection { get; set; }
        public int qtySelection { get; set; }


        string testSelection;
        string testQTY;

        bool isValid;

        List<StoreItem> currentInventory = new List<StoreItem>();
        List<StoreItem> tempList = new List<StoreItem>();


        public enum localCategory
        {
            Clothes = 1,
            Acccessories = 2,
            Shoes = 3,
            Outerwaer = 4
        }



        public CategorySelectionApp(int userSelection)
        {
            userMenuSelection = userSelection;
        }

        public void categorySelector()

        {
            localCategory localCategory;

            currentInventory = loaclInventory.GenerateStoreInventory();

            Console.WriteLine("Which item would you like to purchase? (Select from the folowing numbers)");
            if (userMenuSelection == 1)
            {
                int i = 1;
                foreach (var Categorey in currentInventory)
                {

                    if (Categorey.ItemCategory == "Clothes")
                    {

                        Console.WriteLine($"{i} {Categorey.NameOfItem}\tQTY: {Categorey.ItemQuantity}\tPrice: ${Categorey.ItemPrice}");
                        tempList.Add(Categorey);

                        i++;

                    }

                }


                testSelection = Console.ReadLine();


                do
                {
                    if (IntegerValidator.Validate(testSelection))
                    {

                        if (int.Parse(testSelection) > 0 && int.Parse(testSelection) < 6)
                        {
                            itemSelection = int.Parse(testSelection);
                            isValid = true;

                        }
                        else
                        {
                            Console.WriteLine("That is not a valid choice, please try again.");
                            testSelection = Console.ReadLine();
                            isValid = false;

                        }


                    }
                    else
                    {

                        Console.WriteLine("That is not a valid choice, please try again.");
                        testSelection = Console.ReadLine();
                        isValid = false;

                    }
                } while (!isValid);

                Console.Write($"How many {tempList[itemSelection].NameOfItem} would you like to purchase (QTY: {tempList[itemSelection].ItemQuantity}):");

                testQTY = Console.ReadLine();


                do
                {
                    if (IntegerValidator.Validate(testQTY))
                    {

                        if (int.Parse(testQTY) > 0 && int.Parse(testQTY) < 26)
                        {
                            qtySelection = int.Parse(testQTY);
                            isValid = true;

                        }
                        else
                        {
                            Console.WriteLine("That is not a valid choice, please try again.");
                            testQTY = Console.ReadLine();
                            isValid = false;

                        }


                    }
                    else
                    {

                        Console.WriteLine("That is not a valid choice, please try again.");
                        testQTY = Console.ReadLine();
                        isValid = false;


                    }
                } while (!isValid);

                Console.WriteLine($"Great! {qtySelection} {tempList[itemSelection].NameOfItem}s have been added to you shopping cart!");



            }













        }


    }
}
