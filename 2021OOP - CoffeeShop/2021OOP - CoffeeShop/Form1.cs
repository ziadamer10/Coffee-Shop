using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021OOP___CoffeeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (drinkcombo.SelectedItem.ToString() == "Tea")
            {
                if (sizecombo.SelectedItem.ToString() == "S")
                {
                    costtext.Text = (float.Parse(quantitycombo.Text) * 5 + "  EGP").ToString();
                }
                if (sizecombo.SelectedItem.ToString() == "M")
                {
                    costtext.Text = (float.Parse(quantitycombo.Text) * 7 + "  EGP").ToString();
                }
                if (sizecombo.SelectedItem.ToString() == "L")
                {
                    costtext.Text = (float.Parse(quantitycombo.Text) * 10 + "  EGP").ToString();
                }
                dataGridView1.Rows.Add(tablenumtext.Text, drinkcombo.Text, sizecombo.Text, quantitycombo.Text, costtext.Text);
            }
            else if (drinkcombo.SelectedItem.ToString() == "Espresso")
            {
                if (sizecombo.SelectedItem.ToString() == "S")
                {
                    costtext.Text = (float.Parse(quantitycombo.Text) * 10 + "  EGP").ToString();
                }
                if (sizecombo.SelectedItem.ToString() == "M")
                {
                    costtext.Text = (float.Parse(quantitycombo.Text) * 13 + "  EGP").ToString();
                }
                if (sizecombo.SelectedItem.ToString() == "L")
                {
                    costtext.Text = (float.Parse(quantitycombo.Text) * 17 + "  EGP").ToString();
                }
                dataGridView1.Rows.Add(tablenumtext.Text, drinkcombo.Text, sizecombo.Text, quantitycombo.Text, costtext.Text);
            }
            else if(drinkcombo.SelectedItem.ToString() == "Hot Chocolate")
            {
                if (sizecombo.SelectedItem.ToString() == "S")
                {
                    costtext.Text = (float.Parse(quantitycombo.Text) * 10 + "  EGP").ToString();
                }
                if (sizecombo.SelectedItem.ToString() == "M")
                {
                    costtext.Text = (float.Parse(quantitycombo.Text) * 13 + "  EGP").ToString();
                }
                if (sizecombo.SelectedItem.ToString() == "L")
                {
                    costtext.Text = (float.Parse(quantitycombo.Text) * 17 + "  EGP").ToString();
                }
                dataGridView1.Rows.Add(tablenumtext.Text, drinkcombo.Text, sizecombo.Text, quantitycombo.Text, costtext.Text);
            }
            else if (drinkcombo.SelectedItem.ToString() == "Mango")
            {
                if (sizecombo.SelectedItem.ToString() == "S")
                {
                    costtext.Text = (float.Parse(quantitycombo.Text) * 20 + "  EGP").ToString();
                }
                if (sizecombo.SelectedItem.ToString() == "M")
                {
                    costtext.Text = (float.Parse(quantitycombo.Text) * 25 + "  EGP").ToString();
                }
                if (sizecombo.SelectedItem.ToString() == "L")
                {
                    costtext.Text = (float.Parse(quantitycombo.Text) * 30 + "  EGP").ToString();
                }
                dataGridView1.Rows.Add(tablenumtext.Text, drinkcombo.Text, sizecombo.Text, quantitycombo.Text, costtext.Text);
            }
            else if (drinkcombo.SelectedItem.ToString() == "Lemonade")
            {
                if (sizecombo.SelectedItem.ToString() == "S")
                {
                    costtext.Text = (float.Parse(quantitycombo.Text) * 20 + "  EGP").ToString();
                }
                if (sizecombo.SelectedItem.ToString() == "M")
                {
                    costtext.Text = (float.Parse(quantitycombo.Text) * 25 + "  EGP").ToString();
                }
                if (sizecombo.SelectedItem.ToString() == "L")
                {
                    costtext.Text = (float.Parse(quantitycombo.Text) * 30 + "  EGP").ToString();
                }
                dataGridView1.Rows.Add(tablenumtext.Text, drinkcombo.Text, sizecombo.Text, quantitycombo.Text, costtext.Text);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tablenumtext.Text = "";
            drinkcombo.Text = "";
            sizecombo.Text = "";
            quantitycombo.Text = "";
            costtext.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
