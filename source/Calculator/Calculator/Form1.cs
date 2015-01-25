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
    }
}
