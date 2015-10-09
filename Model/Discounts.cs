using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI.Model
{
    public class Discounts
    {
        public int Discount;
        public int Profit;
        public int CreditCardDiscount;
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
