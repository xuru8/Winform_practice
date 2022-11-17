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
    public partial class 作業02_貸款試算 : Form
    {
        public 作業02_貸款試算()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
            double money貸款金額 = Convert.ToDouble(textBox1.Text);
            double year期限 = Convert.ToDouble(textBox2.Text);
            double percent利率 = Convert.ToDouble(textBox3.Text);
            double firstpay頭期款 = Convert.ToDouble(textBox4.Text);
            double a;
            a = (Math.Pow((1 + percent利率 / 1200), year期限 * 12) * percent利率 / 1200);
            double b;
            b = (Math.Pow((1 + percent利率 / 1200), year期限 * 12) - 1);
            double avg每月平均攤還率 = a / b;
            double final每月 = (money貸款金額 - firstpay頭期款) * avg每月平均攤還率;
            int final1 = Convert.ToInt32(final每月);
            MessageBox.Show("月付額 : " + final1 + " 元");
            }
            catch
            {
                MessageBox.Show("請輸入正確資訊");
            }
        }

        //    public void dou1(double iii)
        //    {
        //        double money貸款金額 = Convert.ToDouble(textBox1.Text);
        //    double year期限 = Convert.ToDouble(textBox2.Text);
        //    double percent利率 = Convert.ToDouble(textBox3.Text);
        //    double firstpay頭期款 = Convert.ToDouble(textBox4.Text);
        //    double a;
        //    a = (Math.Pow((1 + percent利率 / 1200), year期限* 12) * percent利率 / 1200);
        //    double b;
        //    b = (Math.Pow((1 + percent利率 / 1200), year期限* 12) - 1);
        //    double avg每月平均攤還率 = a / b;
        //    double total總付 = ((money貸款金額 - firstpay頭期款) * avg每月平均攤還率) * year期限 * 12 + firstpay頭期款;
        //    int total1 = (int)total總付;
        //}

        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
            double money貸款金額 = Convert.ToDouble(textBox1.Text);
            double year期限 = Convert.ToDouble(textBox2.Text);
            double percent利率 = Convert.ToDouble(textBox3.Text);
            double firstpay頭期款 = Convert.ToDouble(textBox4.Text);
            double a;
            a = (Math.Pow((1 + percent利率 / 1200), year期限 * 12) * percent利率 / 1200);
            double b;
            b = (Math.Pow((1 + percent利率 / 1200), year期限 * 12) - 1);
            double avg每月平均攤還率 = a / b;
            //double total總付 = ((money貸款金額 - firstpay頭期款) * avg每月平均攤還率) * year期限 * 12 + firstpay頭期款;
            //int total1 = (int)total總付;

            double final每月 = (money貸款金額 - firstpay頭期款) * avg每月平均攤還率;
            double total總付 = Convert.ToInt32(final每月) * year期限 * 12 + firstpay頭期款;
            MessageBox.Show("總付額 : " + total總付 + " 元");
            }
            catch
            {
                MessageBox.Show("請輸入正確資訊");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
            作業02_report貸款試算 report = new 作業02_report貸款試算();
            report.Show();
            double money貸款金額 = Convert.ToDouble(textBox1.Text);
            double year期限 = Convert.ToDouble(textBox2.Text);
            double percent利率 = Convert.ToDouble(textBox3.Text);
            double firstpay頭期款 = Convert.ToDouble(textBox4.Text);
            double a;
            a = (Math.Pow((1 + percent利率 / 1200), year期限 * 12) * percent利率 / 1200);
            double b;
            b = (Math.Pow((1 + percent利率 / 1200), year期限 * 12) - 1);
            double avg每月平均攤還率 = a / b;
            double final每月 = (money貸款金額 - firstpay頭期款) * avg每月平均攤還率;
            int final每月1 = Convert.ToInt32(final每月);
            double total總付 = Convert.ToInt32(final每月) * year期限 * 12 + firstpay頭期款;

            report.textBox1.Text = money貸款金額.ToString();
            report.textBox2.Text = year期限.ToString();
            report.textBox3.Text = percent利率.ToString();
            report.textBox4.Text = final每月1.ToString();
            report.textBox5.Text = total總付.ToString();
            }
            catch
            {
                MessageBox.Show("請輸入正確資訊");
            }
        }

    }
}    
