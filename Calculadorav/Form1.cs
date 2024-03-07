using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operador = "";
        double num1 = 0;
        double num2 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //numero 0
            txtBox.Text = txtBox.Text + "0";
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            //numero 1
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text = txtBox.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //numero 2
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text = txtBox.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //numero 3
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text = txtBox.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //numero 4
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text = txtBox.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //numero 5
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text = txtBox.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //numero 6
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text = txtBox.Text + "6";
        }
        
        private void btn7_Click(object sender, EventArgs e)
        {
            //numero 7
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text = txtBox.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //numero 8
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text = txtBox.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //numero 9
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text = txtBox.Text + "9";
        }

        private void btns_Click(object sender, EventArgs e)
        {
            //suma
            operador = "+";
            num1 = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "0";

        }

        private void btnr_Click(object sender, EventArgs e)
        {
            //resta
            operador = "-";
            num1 = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "0";
        }

        private void btnm_Click(object sender, EventArgs e)
        {
            //multiplicacion
            operador = "*";
            num1 = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "0";
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            //division
            operador = "/";
            num1 = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "0";
        }

        private void btnp_Click(object sender, EventArgs e)
        {
            //decimal
            txtBox.Text = txtBox.Text + ",";
        }

        private void btni_Click(object sender, EventArgs e)
        {
            //resultado
            num2 = Convert.ToDouble(txtBox.Text);

            switch (operador)
            {
                case "+":
                    txtBox.Text = $"{num1 + num2}";
                    break;

                case "-":
                    txtBox.Text = $"{num1 - num2}";
                    break;

                case "*":
                    txtBox.Text = $"{num1 * num2}";
                    break;

                case "/":
                    txtBox.Text = $"{num1 / num2}";
                    break;
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            //borrar
            if (txtBox.TextLength == 1) txtBox.Text = "0";
            else txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1);
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            //borrar todo
            txtBox.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
