using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Int32.Parse(textBox1.Text);
            double num2 = Int32.Parse(textBox2.Text);
            
            label3.Text = $"Result: {CalculatorModel.CalculateSum(num1, num2)}";
            label3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = Int32.Parse(textBox1.Text);
            double num2 = Int32.Parse(textBox2.Text);

            label3.Text = $"Result: {CalculatorModel.CalculateSubtraction(num1, num2)}";
            label3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = Int32.Parse(textBox1.Text);
            double num2 = Int32.Parse(textBox2.Text);

            label3.Text = $"Result: {CalculatorModel.CalculateMultiplication(num1, num2)}";
            label3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = Int32.Parse(textBox1.Text);
            double num2 = Int32.Parse(textBox2.Text);

            label3.Text = $"Result: {CalculatorModel.CalculateDivision(num1, num2)}";
            label3.Visible = true;
        }
    }
}
