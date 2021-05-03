using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaParlour
{
    public partial class Form1 : Form
    {

        double pizzaBaseCost = 7;
        double toppingCost = 1.25;
        double numOfToppings;
        double totalPrice;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                numOfToppings = Convert.ToDouble(inputToppingsBox.Text);
                totalPrice = pizzaBaseCost + toppingCost * numOfToppings;
                outputText.Text = $"The pricing of a pizza with {numOfToppings} toppings is\n{totalPrice.ToString("C")}";
            }
            catch
            {
                outputText.Text = "Invalid value of toppings!";
                return;
            }
        }
    }
}
