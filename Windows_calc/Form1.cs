using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_calc
{
    public partial class Form1 : Form
    {
        Double value;
        String operation;
        bool operationPressed;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operationPressed))
                result.Clear();
            operationPressed = false;
            Button b = (Button)sender;
            if(b.Text == ".")
            {
                if(!result.Text.Contains("."))
                {
                result.Text += b.Text;
                }
            }
            else
            {
                result.Text += b.Text;
            }
            
            
        }

        private void ButtonClearEntry(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void ButtonClear(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
            Equation.Text = "";
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
           
            if(value != 0)
            {
                if(operationPressed == true)
                {
                    operation = b.Text;
                    Equation.Text = value + " " + operation;
                }
                else
                {
                    equal.PerformClick();
                    operationPressed = true;
                    operation = b.Text;
                    Equation.Text = value + " " + operation;
                }
                
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                operationPressed = true;
                Equation.Text = value + " " + operation;
            }
            
        }

        private void EqualsClick(object sender, EventArgs e)
        {
            Equation.Text = null;
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString(); ;
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString(); ;
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString(); ;
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString(); ;
                    break;
                default:
                    break;
            }
            value = Double.Parse(result.Text);
            operation = "";
            operationPressed = true;

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            equal.Focus();
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case ".":
                    dec.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "*":
                    multi.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
            }
        }
    }
}
