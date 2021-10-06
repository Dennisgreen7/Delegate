using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void NumberValue(object sender)
        {
            var NumberButton = sender as Button;
            if (ScreenBox.Text == "0" && ScreenBox.Text != null)
            {
                ScreenBox.Text = NumberButton.Text;
            }
            else
            {
                ScreenBox.Text = ScreenBox.Text + NumberButton.Text;
            }
        }
        public void OperationValue(object sender)
        {
            var OperatioButton = sender as Button;
            FirstNumber = Convert.ToDouble(ScreenBox.Text);
            Operation = OperatioButton.Text;
            ScreenBox.Text = string.Empty;
        }
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Sub(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Div(double num1, double num2)
        {
            return num1 / num2;
        }
        public double Mult(double num1, double num2)
        {
            return num1 * num2;
        }
        private void n1_Click(object sender, EventArgs e)
        {
            NumberValue(sender);
        }

        private void n2_Click(object sender, EventArgs e)
        {
            NumberValue(sender);
        }

        private void n3_Click(object sender, EventArgs e)
        {
            NumberValue(sender);
        }

        private void n4_Click(object sender, EventArgs e)
        {
            NumberValue(sender);
        }

        private void n5_Click(object sender, EventArgs e)
        {
            NumberValue(sender);
        }

        private void n6_Click(object sender, EventArgs e)
        {
            NumberValue(sender);
        }

        private void n7_Click(object sender, EventArgs e)
        {
            NumberValue(sender);
        }

        private void n8_Click(object sender, EventArgs e)
        {
            NumberValue(sender);
        }

        private void n9_Click(object sender, EventArgs e)
        {
            NumberValue(sender);
        }

        private void n0_Click(object sender, EventArgs e)
        {
            NumberValue(sender);
        }

        private void badd_Click(object sender, EventArgs e)
        {
            OperationValue(sender);
        }

        private void bsub_Click(object sender, EventArgs e)
        {

            OperationValue(sender);
        }

        private void bmult_Click(object sender, EventArgs e)
        {

            OperationValue(sender);
        }

        private void bdiv_Click(object sender, EventArgs e)
        {

            OperationValue(sender);
        }

        private void bequal_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(ScreenBox.Text);
            ScreenBox.Text = SecondNumber.ToString();

            if (Operation == "+")
            {
                MathDelegate AddDelegate = Add;
                Result = AddDelegate(FirstNumber, SecondNumber);
                ScreenBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                MathDelegate SubbDelegate = Sub;
                Result = SubbDelegate(FirstNumber, SecondNumber);
                ScreenBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                MathDelegate MultDelegate = Mult;
                Result = MultDelegate(FirstNumber, SecondNumber);
                ScreenBox.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                MathDelegate DivDelegate = Div;
                Result = DivDelegate(FirstNumber, SecondNumber);
                if (SecondNumber == 0)
                {
                    ScreenBox.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    ScreenBox.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ScreenBox.Text = string.Empty;

        }
    }
}
