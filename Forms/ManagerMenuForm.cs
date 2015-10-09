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
        private Discounts data = new Discounts();
        public ManagerMenuForm()
        {
            InitializeComponent();
        }

        private void ManagerMenuForm_Load(object sender, EventArgs e)
        {
            tbdiscount.Text = (data.getDiscount()).ToString();
            discountBar.Value = data.getDiscount();
            tbprofit.Text = (data.getProfit()).ToString();
            profitBar.Value = data.getProfit();
            Creditbar.Value = data.getCCDiscount();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(data.getDiscount() < 0 || (data.getDiscount()) > 99))
            {
                data.setDiscount(data.getDiscount() + 1);
                tbdiscount.Text = (data.getDiscount()).ToString();
                discountBar.Value = data.getDiscount();
            }
            else { MessageBox.Show("Reach minimum/maximum of the discount."); }
        }



        private void button6_Click(object sender, EventArgs e)
        {
            if (!(data.getProfit() < 1 || (data.getProfit()) > 100))
            {
                data.setProfit(data.getProfit() - 1);
                tbprofit.Text = (data.getProfit()).ToString();
                profitBar.Value = data.getProfit();
            }
            else { MessageBox.Show("Reach minimum/maximum of the profit margin."); }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (!(data.getProfit() < 0 || (data.getProfit()) > 99))
            {
                data.setProfit(data.getProfit() + 1);
                tbprofit.Text = (data.getProfit()).ToString();
                profitBar.Value = data.getProfit();
            }
            else { MessageBox.Show("Reach minimum/maximum of the profit margin."); }
        }

        private void discountBar_ValueChanged(object sender, EventArgs e)
        {
            tbdiscount.Text = (discountBar.Value).ToString();
        }


        private void discountBar_MouseUp(object sender, MouseEventArgs e)
        {
            data.setDiscount(discountBar.Value);
        }


        private void discountBar_KeyDown(object sender, KeyEventArgs e)
        {
            data.setDiscount(discountBar.Value);
        }


        private void tbdiscount_TextChanged(object sender, EventArgs e)
        {
            int discount;
            
                if (Int32.TryParse(tbdiscount.Text, out discount))
                {
                    if (discount <= 100)
                    {
                        discountBar.Value = discount;
                        data.setDiscount(discount);
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
                    data.setProfit(profit);
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
            data.setProfit(profitBar.Value);
        }

        private void profitBar_MouseUp(object sender, MouseEventArgs e)
        {
            data.setProfit(profitBar.Value);
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
                    data.setCCDiscount(CCdiscount);
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
            data.setCCDiscount(Creditbar.Value);
        }

        private void Creditbar_KeyDown(object sender, KeyEventArgs e)
        {
            data.setCCDiscount(Creditbar.Value);
        }

        private void memberdown_Click(object sender, EventArgs e)
        {
            {
                if (!(data.getDiscount() < 1 || (data.getDiscount()) > 100))
                {
                    data.setDiscount(data.getDiscount() - 1);
                    tbdiscount.Text = (data.getDiscount()).ToString();
                    discountBar.Value = data.getDiscount();
                }
                else { MessageBox.Show("Reach minimum/maximum of the discount."); }
            }
        }

        private void CCUp_Click(object sender, EventArgs e)
        {
            {
                if (!(data.getCCDiscount() < 0 || (data.getCCDiscount()) > 99))
                {
                    data.setCCDiscount(data.getCCDiscount() + 1);
                    tbCCDiscount.Text = (data.getCCDiscount()).ToString();
                    Creditbar.Value = data.getCCDiscount();
                }
                else { MessageBox.Show("Reach minimum/maximum of the credit discount."); }
            }
        }

        private void CCDown_Click(object sender, EventArgs e)
        {
            {
                if (!(data.getCCDiscount() < 1 || (data.getCCDiscount()) > 100))
                {
                    data.setCCDiscount(data.getCCDiscount() - 1);
                    tbCCDiscount.Text = (data.getCCDiscount()).ToString();
                    Creditbar.Value = data.getCCDiscount();
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