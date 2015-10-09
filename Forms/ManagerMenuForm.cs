using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HCI.Foundation;
using HCI.Model;

namespace HCI.Forms
{
    public partial class ManagerMenuForm : LoggedInForm
    {
        public ManagerMenuForm()
        {
            InitializeComponent();
        }

        private void ManagerMenuForm_Load(object sender, EventArgs e)
        {
            tbdiscount.Text = (Discounts.getDiscount()).ToString();
            discountBar.Value = Discounts.getDiscount();
            tbprofit.Text = (Discounts.getProfit()).ToString();
            profitBar.Value = Discounts.getProfit();
            tbCCDiscount.Text = Discounts.getCCDiscount().ToString();
            Creditbar.Value = Discounts.getCCDiscount();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(Discounts.getDiscount() < 0 || (Discounts.getDiscount()) > 99))
            {
                Discounts.setDiscount(Discounts.getDiscount() + 1);
                tbdiscount.Text = (Discounts.getDiscount()).ToString();
                discountBar.Value = Discounts.getDiscount();
            }
            else { MessageBox.Show("Reach minimum/maximum of the discount."); }
        }



        private void button6_Click(object sender, EventArgs e)
        {
            if (!(Discounts.getProfit() < 1 || (Discounts.getProfit()) > 100))
            {
                Discounts.setProfit(Discounts.getProfit() - 1);
                tbprofit.Text = (Discounts.getProfit()).ToString();
                profitBar.Value = Discounts.getProfit();
            }
            else { MessageBox.Show("Reach minimum/maximum of the profit margin."); }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (!(Discounts.getProfit() < 0 || (Discounts.getProfit()) > 99))
            {
                Discounts.setProfit(Discounts.getProfit() + 1);
                tbprofit.Text = (Discounts.getProfit()).ToString();
                profitBar.Value = Discounts.getProfit();
            }
            else { MessageBox.Show("Reach minimum/maximum of the profit margin."); }
        }

        private void discountBar_ValueChanged(object sender, EventArgs e)
        {
            tbdiscount.Text = (discountBar.Value).ToString();
        }


        private void discountBar_MouseUp(object sender, MouseEventArgs e)
        {
            Discounts.setDiscount(discountBar.Value);
        }


        private void discountBar_KeyDown(object sender, KeyEventArgs e)
        {
            Discounts.setDiscount(discountBar.Value);
        }


        private void tbdiscount_TextChanged(object sender, EventArgs e)
        {
            int discount;
            
                if (Int32.TryParse(tbdiscount.Text, out discount))
                {
                    if (discount <= 100)
                    {
                        discountBar.Value = discount;
                        Discounts.setDiscount(discount);
                    }
                    else {
                        tbdiscount.Text = "100";
                        MessageBox.Show("Please input numbers under 100");
                    }
                }
                else
                {
                    tbdiscount.Text = "0";
                    MessageBox.Show("Please input number only");
                }
            }
          
      

        private void tbprofit_TextChanged(object sender, EventArgs e)
        {
            int profit;

            if (Int32.TryParse(tbprofit.Text, out profit))
            {
                if (profit <= 100)
                {
                    profitBar.Value = profit;
                    Discounts.setProfit(profit);
                }
                else
                {
                    tbprofit.Text = "100";
                    MessageBox.Show("Please input numbers under 100");
                }
            }
            else
            {
                tbprofit.Text = "0";
                MessageBox.Show("Please input number only");
            }
        }

        private void profitBar_ValueChanged(object sender, EventArgs e)
        {
            tbprofit.Text = (profitBar.Value).ToString();
        }

        private void profitBar_KeyDown(object sender, KeyEventArgs e)
        {
            Discounts.setProfit(profitBar.Value);
        }

        private void profitBar_MouseUp(object sender, MouseEventArgs e)
        {
            Discounts.setProfit(profitBar.Value);
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            new CourseSelection() { Prev = this }.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int CCdiscount;

            if (Int32.TryParse(tbCCDiscount.Text, out CCdiscount))
            {
                if (CCdiscount <= 100)
                {
                    Creditbar.Value = CCdiscount;
                    Discounts.setCCDiscount(CCdiscount);
                }
                else
                {
                    tbCCDiscount.Text = "100";
                    MessageBox.Show("Please input numbers under 100");
                }
            }
            else
            {
                tbCCDiscount.Text = "0";
                MessageBox.Show("Please input number only");
            }
        }

        private void Creditbar_ValueChanged(object sender, EventArgs e)
        {
            tbCCDiscount.Text = (Creditbar.Value).ToString();
        }

        private void Creditbar_MouseUp(object sender, MouseEventArgs e)
        {
            Discounts.setCCDiscount(Creditbar.Value);
        }

        private void Creditbar_KeyDown(object sender, KeyEventArgs e)
        {
            Discounts.setCCDiscount(Creditbar.Value);
        }

        private void memberdown_Click(object sender, EventArgs e)
        {
            {
                if (!(Discounts.getDiscount() < 1 || (Discounts.getDiscount()) > 100))
                {
                    Discounts.setDiscount(Discounts.getDiscount() - 1);
                    tbdiscount.Text = (Discounts.getDiscount()).ToString();
                    discountBar.Value = Discounts.getDiscount();
                }
                else { MessageBox.Show("Reach minimum/maximum of the discount."); }
            }
        }

        private void CCUp_Click(object sender, EventArgs e)
        {
            {
                if (!(Discounts.getCCDiscount() < 0 || (Discounts.getCCDiscount()) > 99))
                {
                    Discounts.setCCDiscount(Discounts.getCCDiscount() + 1);
                    tbCCDiscount.Text = (Discounts.getCCDiscount()).ToString();
                    Creditbar.Value = Discounts.getCCDiscount();
                }
                else { MessageBox.Show("Reach minimum/maximum of the credit discount."); }
            }
        }

        private void CCDown_Click(object sender, EventArgs e)
        {
            {
                if (!(Discounts.getCCDiscount() < 1 || (Discounts.getCCDiscount()) > 100))
                {
                    Discounts.setCCDiscount(Discounts.getCCDiscount() - 1);
                    tbCCDiscount.Text = (Discounts.getCCDiscount()).ToString();
                    Creditbar.Value = Discounts.getCCDiscount();
                }
                else { MessageBox.Show("Reach minimum/maximum of the credit discount."); }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Wait for K
        }
    }
}