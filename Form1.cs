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
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            if (Result.Text == "0")
            { 
                Result.Clear();
            }
            Result.Text = Result.Text + "1";
        }
        private void num2_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            { 
                Result.Clear();
            }
            Result.Text = Result.Text + "2";
        }
        private void num3_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            { 
                Result.Clear();
            }
            Result.Text = Result.Text + "3";
        }
        private void num4_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            { 
                Result.Clear();
            }
            Result.Text = Result.Text + "4";
        }
        private void num5_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            { 
                Result.Clear();
            }
            Result.Text = Result.Text + "5";
        }
        private void num6_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            { 
                Result.Clear();
            }
            Result.Text = Result.Text + "6";
        }
        private void num7_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            { 
                Result.Clear();
            }
            Result.Text = Result.Text + "7";
        }
        private void num8_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            { 
                Result.Clear();
            }
            Result.Text = Result.Text + "8";
        }
        private void num9_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            { 
                Result.Clear();
            }
            Result.Text = Result.Text + "9";
        }
        private void num0_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                Result.Clear();
            }
            Result.Text = Result.Text + "0";
        }        
        private void dott_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                Result.Clear();
            }
            Result.Text = Result.Text + ".";
        }        
        private void divide_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                Result.Clear();
            }
            Result.Text = Result.Text + "/";
        }        
        private void minus_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                Result.Clear();
            }
            Result.Text = Result.Text + "-";
        }        
        private void multiply_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                Result.Clear();
            }
            Result.Text = Result.Text + "*";
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                Result.Clear();
            }
            Result.Text = Result.Text + "+";
        }
        
        private void clear_Click(object sender, EventArgs e)
        {
            Result.Text = Result.Text + "0";
            CombinedResult = 0;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            switch (Plus_Click, multiply_Click, minus_Click, divide_Click)
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
                
                    default:break;
            }
        }
    }
}
