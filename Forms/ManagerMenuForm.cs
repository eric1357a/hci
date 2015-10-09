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
    //TODO List: Registration function
    //            Change the amount of the discounts
    //            Set the profit margin
    public partial class ManagerMenuForm : BaseForm
    {
        private MenuData data = new MenuData();
        public ManagerMenuForm()
        {
            InitializeComponent();
        }

        private void ManagerMenuForm_Load(object sender, EventArgs e)
        {
            discount.Text = (data.getDiscount()).ToString()+"%";
            profitMar.Text = (data.getProfit()).ToString() + "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(data.getDiscount() < 0 || (data.getDiscount()) > 90))
            {
                data.setDiscount(data.getDiscount() + 10);
                discount.Text = (data.getDiscount()).ToString()+"%";
            }
            else { MessageBox.Show("Reach minimum/maximum of the discount."); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(data.getDiscount() < 0 || (data.getDiscount()) > 99))
            {
                data.setDiscount(data.getDiscount() + 1);
                discount.Text = (data.getDiscount()).ToString() + "%";
            }
            else { MessageBox.Show("Reach minimum/maximum of the discount."); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(data.getDiscount() < 1 || (data.getDiscount()) > 100))
            {
                data.setDiscount(data.getDiscount() - 1);
                discount.Text = (data.getDiscount()).ToString() + "%";
            }
            else { MessageBox.Show("Reach minimum/maximum of the discount."); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!(data.getDiscount() < 10 || (data.getDiscount()) > 100))
            {
                data.setDiscount(data.getDiscount() - 10);
                discount.Text = (data.getDiscount()).ToString() + "%";
            }
            else { MessageBox.Show("Reach minimum/maximum of the discount."); }
        }

        private void discount_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!(data.getProfit() < 1 || (data.getProfit()) > 100))
            {
                data.setProfit(data.getProfit() - 1);
                profitMar.Text = (data.getProfit()).ToString() + "%";
            }
            else { MessageBox.Show("Reach minimum/maximum of the profit margin."); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!(data.getProfit() < 10 || (data.getProfit()) > 100))
            {
                data.setProfit(data.getProfit() - 10);
                profitMar.Text = (data.getProfit()).ToString() + "%";
            }
            else { MessageBox.Show("Reach minimum/maximum of the profit margin."); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!(data.getProfit() < 0 || (data.getProfit()) > 99))
            {
                data.setProfit(data.getProfit() + 1);
                profitMar.Text = (data.getProfit()).ToString() + "%";
            }
            else { MessageBox.Show("Reach minimum/maximum of the profit margin."); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!(data.getProfit() < 0 || (data.getProfit()) > 90))
            {
                data.setProfit(data.getProfit() + 10);
                profitMar.Text = (data.getProfit()).ToString() + "%";
            }
            else { MessageBox.Show("Reach minimum/maximum of the profit margin."); }
        }
    }
}