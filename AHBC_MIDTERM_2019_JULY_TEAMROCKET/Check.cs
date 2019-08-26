using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
{
    class Check : Payment
    {
        // Check #
        // checking # consists of the following
        // routing number: 9 digits
        // checking number: 10-12 digits

        private void PayCheck()
        {
            bool isNumberValid;
            double routingNumber;
            double checkingAccountNumber;

            while ()
            {
                // add this into the validation class that victoria is adding in later.
                Console.WriteLine(/*"maybe here we would ask them whether "*/);
                string verifyRoutingNumber
                    = @"^whatever the regex is for checking the routing number";
                Regex rg = new Regex(verifyRoutingNumber);

                string verifyAccountNumber
                    = @"^whatever the regex is for checking the routing number";
                Regex rg = new Regex(verifyAccountNumber);

                routingNumber = 0;


            }


        }

    }
}
