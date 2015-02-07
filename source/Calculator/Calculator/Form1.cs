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
    public partial class formmain : Form
    {
        public formmain()
        {
            InitializeComponent();


            initiate();
        }

        private void initiate()
        {

            /*
             * give proper names for objects
             */

            
            txtbinput.Text = "0";
            btn0.Text = "0";
            btn1.Text = "1";
            btn2.Text = "2";
            btn3.Text = "3";
            btn4.Text = "4";
            btn5.Text = "5";
            btn6.Text = "6";
            btn7.Text = "7";
            btn8.Text = "8";
            btn9.Text = "9";
            btnequal.Text = "=";
            btnminus.Text = "-";
            btnplus.Text = "+";
            btntimes.Text = "*";
            btndivide.Text = "/";
            btnbckspace.Text = "";
            btnce.Text = "CE";
            btnc.Text = "C";
            btnsign.Text = "+-";
            btnpercent.Text = "%";
            btndot.Text = ".";
        }

        public void onglobal_buttonclick(string input)
        {
            if (txtbinput.Text.Equals("0"))
            {
                txtbinput.Text = input;
            }
            else
            {
                txtbinput.Text += input;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            onglobal_buttonclick("0");
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            onglobal_buttonclick(".");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            onglobal_buttonclick("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            onglobal_buttonclick("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            onglobal_buttonclick("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            onglobal_buttonclick("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            onglobal_buttonclick("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            onglobal_buttonclick("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            onglobal_buttonclick("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            onglobal_buttonclick("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            onglobal_buttonclick("9");
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtbinput.Text = "0";
        }

        private void btnsign_Click(object sender, EventArgs e)
        {

        }

        private void txtbinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void formmain_Load(object sender, EventArgs e)
        {

        }
    }
}
