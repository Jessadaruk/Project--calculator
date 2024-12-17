using System;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            double iNum1 = double.Parse(inputNum1);
            double iNum2 = double.Parse(inputNum2);
            double iResult = iNum1 + iNum2;
            result.Text = iResult.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            double iNum1 = double.Parse(inputNum1);
            double iNum2 = double.Parse(inputNum2);
            double iResult = iNum1 - iNum2;
            result.Text = iResult.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            double iNum1 = double.Parse(inputNum1);
            double iNum2 = double.Parse(inputNum2);
            double iResult = iNum1 * iNum2;
            result.Text = iResult.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inputNum1 = num1.Text;
            string inputNum2 = num2.Text;
            double iNum1 = double.Parse(inputNum1);
            double iNum2 = double.Parse(inputNum2);
            double iResult = iNum1 / iNum2; ;
            result.Text = iResult.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result.Clear();
            num1.Clear();
            num2.Clear();
        }
    }
}
