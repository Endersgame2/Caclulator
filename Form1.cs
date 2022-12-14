using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caclulator
{

    public partial class Form1 : Form
    {
        double CombinedResult = 0;
        string Operation = "";
        bool isTrue = false;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                num1_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                num2_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                num3_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                num4_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                num5_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                num6_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                num7_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                num8_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                num9_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                num0_Click(null, null);
            }
            if (e.KeyCode == Keys.OemPeriod)
            {
                Dott(null, null);
            }
            if (e.KeyCode == Keys.Back)
            {
                try
                {
                    Result.Text = Result.Text.Remove(Result.Text.Length - 1, 1);
                }
                catch (Exception ex)
                {
                    //no logging needed..
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" || isTrue)
                Result.Clear();
            isTrue = false;
            Result.Text = Result.Text + "1";
        }
        private void num2_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" || isTrue)
                Result.Clear();
            isTrue = false;
            Result.Text = Result.Text + "2";
        }
        private void num3_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" || isTrue)
                Result.Clear();
            isTrue = false;
            Result.Text = Result.Text + "3";
        }
        private void num4_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" || isTrue)
                Result.Clear();
            isTrue = false;
            Result.Text = Result.Text + "4";
        }
        private void num5_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" || isTrue)
                Result.Clear();
            isTrue = false;
            Result.Text = Result.Text + "5";
        }
        private void num6_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" || isTrue)
                Result.Clear();
            isTrue = false;
            Result.Text = Result.Text + "6";
        }
        private void num7_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" || isTrue)
                Result.Clear();
            isTrue = false;
            Result.Text = Result.Text + "7";
        }
        private void num8_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" || isTrue)
                Result.Clear();
            isTrue = false;
            Result.Text = Result.Text + "8";
        }
        private void num9_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" || isTrue)
                Result.Clear();
            isTrue = false;
            Result.Text = Result.Text + "9";
        }
        private void num0_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0" || isTrue)
                Result.Clear();
            isTrue = false;
            Result.Text = Result.Text + "0";
        }

        private void Dott(object sender, EventArgs e)
        {
            if (Result.Text == "0" || isTrue)
                Result.Clear();
            isTrue = false;
            if (!Result.Text.Contains("."))
            {
                Result.Text = Result.Text + ".";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Result.Text = "0";
            CombinedResult = 0;
        }
        private void Operations(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            Operation = x.Text;
            isTrue = true;
            CombinedResult = Double.Parse(Result.Text);
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch (Operation)
            {
                case "+":
                    Result.Text = (CombinedResult + double.Parse(Result.Text)).ToString();
                    break;

                case "-":
                    Result.Text = (CombinedResult - double.Parse(Result.Text)).ToString();
                    break;

                case "/":
                    Result.Text = (CombinedResult / double.Parse(Result.Text)).ToString();
                    break;

                case "*":
                    Result.Text = (CombinedResult * double.Parse(Result.Text)).ToString();
                    break;
                case "BIN":
                    int input = int.Parse(Result.Text);
                    Result.Text = ConvertToBinary(input);
                    break;
                //case "DEC":
                //Result.Text = (CombinedResult * double.Parse(Result.Text)).ToString();
                //break;


                default: break;
            }
        }
        public string ConvertToBinary(int input)
        {
            string binaryResult = "";
            while (input >= 1)
            {
                double remainder = input % 2;
                binaryResult = remainder + binaryResult;
                input = input / 2;
            }
            return binaryResult;
        }
    }
}
