using Client.CalculatorServiceRef;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class CalculatorPage : Form
    {
        string oldval = null;
        User LogienUser;
        bool firstoperFlag = true;
        string LastOper = "";
        CalculatorServiceClient CalcCLient;
        public CalculatorPage(User _user, CalculatorServiceClient _CalcCLient)
        {
            InitializeComponent();
            LogienUser = _user;
            CalcCLient = _CalcCLient;
            AuthurizedOperations();
            rsltxt.Text = "0";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0";
        }

        private async void btnsum_Click(object sender, EventArgs e)
        {
            string current = richTextBox1.Text;

           
            if (!firstoperFlag)

            {
                
                double result = handleOperation(LastOper);

                rsltxt.Text = $"{result}";
                oldval = $"{result}";
                richTextBox1.Text = "";

            }
            else { 
            oldval= richTextBox1.Text;
            richTextBox1.Text = "";
                firstoperFlag = false;
                

            }
            LastOper = "+";

        }

        private async void btnsubtract_Click(object sender, EventArgs e)
        {
            string current = richTextBox1.Text;

            if (!firstoperFlag)

            {

                double result = handleOperation(LastOper);

                rsltxt.Text = $"{result}";
                oldval = $"{result}";
                richTextBox1.Text = "";


            }
            else
            {
                oldval = richTextBox1.Text;
                richTextBox1.Text = "";
                firstoperFlag = false;

            }
            LastOper = "-";

        }

        private async void btnmulti_Click(object sender, EventArgs e)
        {
            string current = richTextBox1.Text;

            if (!firstoperFlag)

            {


                double result = handleOperation(LastOper);

                rsltxt.Text = $"{result}";
                oldval = $"{result}";
                richTextBox1.Text = "";
                


            }
            else
            {
                oldval = richTextBox1.Text;
                richTextBox1.Text = "";
                firstoperFlag = false;

            }
            LastOper = "*";
        }

        private async void btndivide_Click(object sender, EventArgs e)
        {
            string current = richTextBox1.Text;

            if (!firstoperFlag)

            {


                double result = handleOperation(LastOper);

                rsltxt.Text = $"{result}";
                oldval = $"{result}";
                richTextBox1.Text = "";


            }
            else
            {
                oldval = richTextBox1.Text;
                richTextBox1.Text = "";
                firstoperFlag = false;

            }
            LastOper = "/";
        }


        double handleOperation(string operationStr)
        {
            switch (operationStr)
            {
                case "+":
                    return CalcCLient.ADD(LogienUser.userID, double.Parse(oldval), double.Parse(richTextBox1.Text));
                case "-":
                    return CalcCLient.Subtract(LogienUser.userID, double.Parse(oldval), double.Parse(richTextBox1.Text));
                case "*":
                    return CalcCLient.Multiplay(LogienUser.userID, double.Parse(oldval), double.Parse(richTextBox1.Text));
                case "/":
                    return CalcCLient.Divided(LogienUser.userID, double.Parse(oldval), double.Parse(richTextBox1.Text));
                default:
                    return 0;

            }
        }
        void AuthurizedOperations()
        {
            if(!LogienUser.addAuth)
                btnsum.Hide();
            if (!LogienUser.subAuth)
                btnsubtract.Hide();
            if (!LogienUser.multiAuth)
                btnmulti.Hide();
            if (!LogienUser.divAuth)
                btndivide.Hide();
        }
    }
}
