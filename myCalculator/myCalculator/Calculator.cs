using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCalculator
{
    public partial class Calculator : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void numButtonClick(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || operation_pressed)
                resultBox.Clear();
            operation_pressed = false;
            Button tempButton = (Button)sender;
            resultBox.Text += tempButton.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            value = 0;
        }

        private void opClick(object sender, EventArgs e)
        {
            value = Double.Parse(resultBox.Text);
            Button opButton = (Button)sender;
            operation = opButton.Text;
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    resultBox.Text = (value + Double.Parse(resultBox.Text)).ToString() ;
                    break;
                case "-":
                    resultBox.Text = (value - Double.Parse(resultBox.Text)).ToString();
                    break;
                case "*":
                    resultBox.Text = (value * Double.Parse(resultBox.Text)).ToString();
                    break;
                case "/":
                    resultBox.Text = (value / Double.Parse(resultBox.Text)).ToString();
                    break;
                default:
                    break;
            }
 
        }

        private void button16_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
        }
    }
}
