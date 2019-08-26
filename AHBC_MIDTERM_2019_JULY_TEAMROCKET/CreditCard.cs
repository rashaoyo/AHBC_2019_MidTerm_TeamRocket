using System;
using System.Collections.Generic;
using System.Text;

namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
{
    class CreditCard : Payment
    {
        // Credit Card # - should be 16 digits
        // Expiration Date - should be 00/00
        // CVV - typically a 3 digit code
        private void PayCreditCard()
        {
            bool isMonthValid, isYearValid, isCvvValid;

            // add in the regex 
            while ()
            {
                // add this into the validation class that victoria is adding in later.
                string patternForCard = @"^([0-9]{4}[\s-]?){3}([0-9]{4})$";
                Regex rg = new Regex(patternForCard);


            }



        }


    }
}
