using System;
using System.Collections.Generic;
using System.Text;

namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
{
    public class Cash : IPaymentMethod
    {
        double cashGiven, change;
        public void Pay(double total)
        {
            

            Console.WriteLine($"Your total is: {total}, Please enter how much cash you will be giving: ");
            cashGiven = CashReceived();
            
            while (cashGiven < total)
            {
                Console.WriteLine("I apologize, however the funds provided are insufficient.");
            }
            if (cashGiven >= total)
            {
                change = cashGiven - total;
                Console.WriteLine($"Total Change: " + change);
                Console.ReadKey();
            }
        }

        private double CashReceived()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double cashResult))
                {
                    return cashResult;
                }
                Console.WriteLine("Input Error. Please try again: ");
            }
        }

        public void PrintCashInfo()
        {
            Console.WriteLine("Thank you for your cash payment");
            Console.WriteLine($"Cash given: {cashGiven}");
            Console.WriteLine($"Change: {change}");
        }


    }
}
    

    
    


