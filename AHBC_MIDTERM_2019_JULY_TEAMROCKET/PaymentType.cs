using System;
using System.Collections.Generic;
using System.Text;

namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
{
    class PaymentType: ICash, ICard, ICheck
    {
       
       
        public void PayWithCash(double total)     //assuming we already have the total amount listed. p
        {
            Console.WriteLine("***CASH TRANSACTION***\n");
            Console.WriteLine($"Total: {total}\n");
            Console.WriteLine($"Cash: ");
            double moneyGiven = double.Parse(Console.ReadLine());       //user validation
            double change = moneyGiven - total;


            Console.WriteLine($"Change: {change}");

            Console.WriteLine("Your transaction has been processed.");

        }

        public void PayWithCard(double total)
        {
            Console.WriteLine("***CARD TRANSACTION***\n");

            Console.WriteLine($"Total: {total}\n");

            Console.WriteLine("Card Type (VISA/ Mastercard/ Discover):");
            string cardType = Console.ReadLine();           // USER VALIDATION, possibly use TryCatch if transaction doesnt go through 

            Console.WriteLine("\nCard:");
            string cardNum = Console.ReadLine();

            Console.WriteLine("\nExpiration Date (MM/YY):");
            string exDate = Console.ReadLine();

            Console.WriteLine("\nCVV:");
            string cvvNum = Console.ReadLine();

            Console.WriteLine("\n.");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".\n");

            Console.WriteLine("Your transaction has been processed.");

        }

        public void PayWithCheck(double total)
        {
            Console.WriteLine("***CHECK TRANSACTION***\n");
            Console.WriteLine($"Total: {total}\n");

            Console.WriteLine("Check Number:\n");     //validation
            string checkNum = Console.ReadLine();

            Console.WriteLine("Routing Number:\n");     //validation
            string routeNum = Console.ReadLine();

            Console.WriteLine("\n.");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".\n");

            Console.WriteLine("Your transaction has been processed.");


        }
    }
}
