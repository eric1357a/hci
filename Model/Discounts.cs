using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI.Model
{
    public class Discounts
    {
        private static int Discount = 10;
        private static int GoldDiscount = 20;
        private static int Profit = 40;
        private static int CreditCardDiscount = 5;

        public static int getDiscount()
        {
            return Discount;
        }
        public static void setDiscount(int v)
        {
            Discount = v;
        }
        public static int getProfit()
        {
            return Profit;
        }
        public static void setProfit(int v)
        {
            Profit = v;
        }
        public static int getCCDiscount()
        {
            return CreditCardDiscount;
        }
        public static void setCCDiscount(int v)
        {
            CreditCardDiscount = v;
        }
    }
}
