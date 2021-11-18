using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {
        double nho;
        String dau;
        Boolean dec;
        bool nhapmoi;
        public Form1()
        {
            InitializeComponent();
            nho = 0;
            dau = "";
            dec = false;
            nhapmoi = false;
        }
        void tinhToan()
        {
            switch (dau)
            {
                case "+": nho += double.Parse(txtResult.Text); break;
                case "-": nho -= double.Parse(txtResult.Text); break;
                case "*": nho *= double.Parse(txtResult.Text); break;
                case "/": nho /= double.Parse(txtResult.Text); break;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            tinhToan();
            txtResult.Text = nho.ToString();
            nho = 0;
            dau = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            if (dau == "") nho = double.Parse(txtResult.Text);
            else tinhToan();
            txtResult.Text = nho.ToString();
            dau = x.Text;
            txtResult.Focus();
            nhapmoi = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            nho = 0;
            dau = "";
            dec = false;
            nhapmoi = false;
            txtResult.Focus();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(dec==false)
            {
                txtResult.Text += ".";
                dec = true;
            }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender;
            if (txtResult.Text == "0" || nhapmoi == true)
            {
                txtResult.Text = x.Text;
                nhapmoi = false;
            }
            else txtResult.Text += x.Text;
        }
    }
}
