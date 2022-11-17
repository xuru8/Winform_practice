using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class 作業08MyClac : Form
    {
        public 作業08MyClac()
        {
            InitializeComponent();
        }

        class NumNum
        {
            public int total;
            //public int ans;
        }

        NumNum a = new NumNum();

        void usethis()
        {
            //a.text1 = Convert.ToInt32(txtNum1.Text);
            //a.text2 = Convert.ToInt32(txtNum2.Text);
            //a.ans = Convert.ToInt32(lblAnsBox.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
            a.total = Convert.ToInt32(txtNum1.Text)+Convert.ToInt32(txtNum2.Text);
            lblAnsBox.Text = Convert.ToString(a.total);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
            }

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
            a.total = Convert.ToInt32(txtNum1.Text) - Convert.ToInt32(txtNum2.Text);
            lblAnsBox.Text = Convert.ToString(a.total);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            try
            {
            a.total = Convert.ToInt32(txtNum1.Text) * Convert.ToInt32(txtNum2.Text);
            lblAnsBox.Text = Convert.ToString(a.total);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
            a.total = Convert.ToInt32(txtNum1.Text) / Convert.ToInt32(txtNum2.Text);
            lblAnsBox.Text = Convert.ToString(a.total);
            }
            catch
            {
                MessageBox.Show("請輸入數字");
            }
        }
    }
}
