using System;
using System.Collections.Generic;
using System.Text;

namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
{
    class ShoppingCart
    {
        public List<StoreItem> ItemstoPurchase { get; set; }
        public double cartValue { get; set; }
        private bool isAddable { get; set; }


        public void addToCart(StoreItem item)
        {


            foreach (var cartitem in ItemstoPurchase)
            {

                if (cartitem.NameOfItem == item.NameOfItem)
                {
                    cartitem.ItemQuantity += item.ItemQuantity;
                    isAddable = false;

                }

            }

            if (isAddable)
            {
                ItemstoPurchase.Add(item);
            }

            isAddable = true;

            cartValue = 0;
            calculateSubtotal(ItemstoPurchase);

        }


        private void calculateSubtotal(List<StoreItem> cartList)
        {

            foreach (var item in cartList)
            {

                cartValue += item.ItemPrice * item.ItemQuantity;


            }

        }


    }
}
