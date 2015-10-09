using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI.Model
{
    public class Discounts
    {
        public int Discount = 50;
        public int Profit = 40;
        public int CreditCardDiscount = 5;
        public int getDiscount()
        {
            return Discount;
        }
        public void setDiscount(int v)
        {
            Discount = v;
        }
        public int getProfit()
        {
            return Profit;
        }
        public void setProfit(int v)
        {
            Profit = v;
        }
        public int getCCDiscount()
        {
            return CreditCardDiscount;
        }
        public void setCCDiscount(int v)
        {
            CreditCardDiscount = v;
        }
    }
}
