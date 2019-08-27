using System;
using System.Collections.Generic;
using System.Text;

namespace Payments
{
    public abstract class Payment : IPayment
    {
        //public double SubTotal { get; set; }
        //public double SalesTaxTotal { get; set; }
        //public double GrandTotal { get; set; }
        //public object PaymentType { get; private set; }
        public string Total { get; set; }

        //public const double taxRate = 0.06;


        public void Pay (string total)
        {

        }

        //public Payment()
        //{
        //    //SubTotal = subTotal;
        //    SalesTaxTotal = salesTaxTotal;
        //    GrandTotal = grandTotal;
        //    PaymentType = paymentType;
        //}

        //private double SubTotal()
        //{
        //    // subtotal = item price * the qty of items
        //    subTotal = itemPrice * itemQuantity;
        //    // you would want this to return the subtotal

        //    return subTotal;
        //}

        //private double SalesTaxTotal()
        //{
        //    //sales tax total = subtotal * the taxrate of 6%
        //    salesTaxTotal = subTotal * taxRate;
        //    return salesTaxTotal;
        //}

        //private double GrandTotal()
        //{
        //    // grand total = subtotal + tax total
        //    grandTotal = subTotal + salesTaxTotal;
        //    return grandTotal;
        //}

        public void MethodOfPayment(string total)
        {
            while (true)
            {
                PaymentType = paymentType;
                switch (paymentType)
                {
                    case 1:
                        PayWithCash();
                        return;

                    case 2:
                        PayWithCheck();
                        return;

                    case 3:
                        PayWithCreditCard();
                        return;

                    default:
                        Console.WriteLine("I'm sorry but we do not accept this form of payment.");
                        break;
                }

            }
        }

        //public double AddingTaxRate()
        //{
        //** if we decide to do non-taxable items.. maybe rename this method??
        //}
    }

    public interface IPayment
    {

    }
}
