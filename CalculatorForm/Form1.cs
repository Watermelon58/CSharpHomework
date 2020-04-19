using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2;
            if(!double.TryParse(textBox1.Text,out num1)||!double.TryParse(textBox2.Text,out num2))
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                {
                    label1.Text = "Don't forget to give numbers~";
                }
                else
                {
                    label1.Text = "the number is out of control:(";
                }
            }
            else
            {
                label1.Text = "";
                switch(comboBox1.Text)
                {
                    case "+":
                        textBox3.Text = Convert.ToString(num1 + num2);
                        break;
                    case "-":
                        textBox3.Text = Convert.ToString(num1 - num2);
                        break;
                    case "*":
                        textBox3.Text = Convert.ToString(num1 * num2);
                        break;
                    case "/":
                        textBox3.Text = Convert.ToString(num1 / num2);
                        break;
                    default:
                        textBox3.Text = "The operator is not in the list!";
                        break;
                }
            }
        }


    }
}
