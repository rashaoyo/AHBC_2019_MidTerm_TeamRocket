using System;
using System.Collections.Generic;
using System.Text;

namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
{
    public abstract class PaymentTypeBase : ICard, ICheck, ICash
    {
        public string Total { get; set; }

        public abstract void MakeAPayment();

        public void PayWithCard(string total)
        {
        }

        public void PayWithCash(string total)
        {
        }

        public void PayWithCheck(string total)
        {
        }


    }
}
