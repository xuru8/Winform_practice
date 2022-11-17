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
    public partial class 作業Time : Form
    {
        public 作業Time()
        {
            InitializeComponent();
        }

        string Hour, Minute, Second;
        int i = 0;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox1.Checked == true) && (txtHour.Text != "") && (txtMinute.Text != "") && (txtSecond.Text != ""))
            {
                timer2.Start();
            }
            else
            {
                timer2.Stop();
                MessageBox.Show("請輸入正確時間");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if ((checkBox1.Checked == true) && (txtHour.Text == Hour) && (txtMinute.Text == Minute) && (txtSecond.Text == Second))
                {
                    this.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(txtSecond.Text) == Convert.ToInt32(Second) - 3)
                {
                    this.BackColor = Color.Black;
                    btnReStart.Visible = true;
                    timer2.Stop();
                    txtHour.Enabled = false;
                    txtMinute.Enabled = false;
                    txtSecond.Enabled = false;
                }
                else if (this.BackColor == Color.Red)
                {
                    this.BackColor = Color.Yellow;
                }
                else if (this.BackColor == Color.Yellow)
                {
                    this.BackColor = Color.Red;
                }
                //else if (this.BackColor == Color.Red)
                //{
                //    this.BackColor = Color.Yellow;
                //}
                //}
            }
            catch
            {
                //this.Close();
                timer2.Stop();
            }

        }

        private void btnReStart_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            btnReStart.Visible = false;
            txtHour.Text = "";
            txtMinute.Text = "";
            txtSecond.Text = "";
            checkBox1.Checked = false;
            txtHour.Enabled = true;
            txtMinute.Enabled = true;
            txtSecond.Enabled = true;
        }

        private void 作業Time_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //label1.Text = DateTime.Now.ToString("hh:mm:ss");

            //string time = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm");//24小时
            //string time = Convert.ToDateTime(date).ToString("yyyy-MM-dd hh:mm");//12小时

            Hour = DateTime.Now.ToString("hh");
            Minute = DateTime.Now.ToString("mm");
            Second = DateTime.Now.ToString("ss");
            label1.Text = Hour + " : " + Minute + " : " + Second;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hour = DateTime.Now.ToString("hh");
            Minute = DateTime.Now.ToString("mm");
            Second = DateTime.Now.ToString("ss");
            label1.Text = Hour + " : " + Minute + " : " + Second;
            //var dt = Convert.ToDateTime("hh:mm:ss");
            //label1.Text = dt.ToString();
        }
    }
}
