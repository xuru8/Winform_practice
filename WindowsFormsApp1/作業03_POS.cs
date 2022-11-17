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
    public partial class 作業03_POS : Form
    {
        public 作業03_POS()
        {
            InitializeComponent();
        }

        int money杯子蛋糕金額  =  0;
        int money可麗露金額 = 0;
        int money泡芙金額 = 0;
        int money抹茶塔金額 = 0;

        int count杯子蛋糕數量 = 0;
        int count可麗露數量 = 0;
        int count泡芙數量 = 0;
        int count抹茶塔數量 = 0;

        string show杯子蛋糕;
        string show可麗露;
        string show泡芙;
        string show抹茶塔;

        int total金額 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            total金額 += 50;
            count杯子蛋糕數量 += 1;
            money杯子蛋糕金額 += 50;
            //total數量 += 1;
            //total金額 += 50;
            //string cupcake = "杯子蛋糕";

            textBox總金額.Text = "NT $ " + total金額;
            show杯子蛋糕 = "杯子蛋糕  x" + count杯子蛋糕數量 + "， 共 " + money杯子蛋糕金額 + " 元\r\n";
            //show杯子蛋糕 = "杯子蛋糕  x" + count杯子蛋糕數量 + "， 共 " + money杯子蛋糕金額 + " 元";

            //textBox購物清單.AppendText(show杯子蛋糕);
            //if(textBox購物清單.Text =="尚未點餐")
            //{
            //    textBox購物清單.Text = show杯子蛋糕 + "\r\n";
            //}
            //else
            //{
            //    textBox購物清單.Text = show杯子蛋糕 + "\r\n" + show可麗露 + "\r\n" + show泡芙 + "\r\n" + show抹茶塔;
            //}

            textBox購物清單.Text = show杯子蛋糕 + show可麗露 + show泡芙 + show抹茶塔;
            //textBox購物清單.AppendText(show杯子蛋糕 + Environment.NewLine);
            //textBox購物清單.Text += show杯子蛋糕 + "\r\n";
            //textBox購物清單.Text = show杯子蛋糕 + "\r\n" + show可麗露 + "\r\n" + show泡芙 + "\r\n" + show抹茶塔;
            //textBox購物清單.Text = show杯子蛋糕 + Environment.NewLine + show可麗露 + Environment.NewLine + show泡芙 + Environment.NewLine + show抹茶塔;
        }

        private void button可麗露_Click(object sender, EventArgs e)
        {
            total金額 += 60;
            count可麗露數量 += 1;
            money可麗露金額 += 60;

            textBox總金額.Text = "NT $ " + total金額;
            show可麗露 = "可麗露  x" + count可麗露數量 + "， 共 " + money可麗露金額 + " 元\r\n";

            //textBox購物清單.AppendText(show可麗露);
            //if (textBox購物清單.Text == "尚未點餐")
            //{
            //    textBox購物清單.Text = show可麗露 + "\r\n";
            //}
            //else
            //{
            //    textBox購物清單.Text = show杯子蛋糕 + "\r\n" + show可麗露 + "\r\n" + show泡芙 + "\r\n" + show抹茶塔;
            //}
            //textBox購物清單.AppendText(show可麗露 + Environment.NewLine);
            textBox購物清單.Text = show杯子蛋糕 + show可麗露 + show泡芙 + show抹茶塔;
            //textBox購物清單.Text = show杯子蛋糕 + Environment.NewLine + show可麗露 + Environment.NewLine + show泡芙 + Environment.NewLine + show抹茶塔;
        }

        private void button泡芙_Click(object sender, EventArgs e)
        {
            total金額 += 50;
            count泡芙數量 += 1;
            money泡芙金額 += 50;

            textBox總金額.Text = "NT $ " + total金額;
            show泡芙 = "泡芙  x" + count泡芙數量 + "， 共 " + money泡芙金額 + " 元\r\n";

            textBox購物清單.Text = show杯子蛋糕 + show可麗露 + show泡芙 + show抹茶塔;
            //textBox購物清單.Text = show杯子蛋糕 + Environment.NewLine + show可麗露 + Environment.NewLine + show泡芙 + Environment.NewLine + show抹茶塔;
        }

        private void button抹茶塔_Click(object sender, EventArgs e)
        {
            total金額 += 35;
            count抹茶塔數量 += 1;
            money抹茶塔金額 += 35;

            textBox總金額.Text = "NT $ " + total金額;
            show抹茶塔 = "抹茶塔  x" + count抹茶塔數量 + "， 共 " + money抹茶塔金額 + " 元\r\n";

            textBox購物清單.Text = show杯子蛋糕 + show可麗露 + show泡芙 + show抹茶塔;
            //textBox購物清單.Text = show杯子蛋糕 + Environment.NewLine + show可麗露 + Environment.NewLine + show泡芙 + Environment.NewLine + show抹茶塔;
        }

        private void button現金付款_Click(object sender, EventArgs e)
        {
            if (total金額 == 0)
            {
                MessageBox.Show("尚未點餐！", "確認現金付款金額", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額 NT$ :" + total金額 + " 元","確認現金付款金額");
            }
        }

        private void button信用卡付款_Click(object sender, EventArgs e)
        {
            double total折扣 = total金額 * 0.9;
            int total折扣金額 = Convert.ToInt32(total折扣);
            if (total金額 == 0)
            {
                MessageBox.Show("尚未點餐！", "確認信用卡付款金額", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額 NT$ :" + total金額 + " 元" + "\n" + "折扣後金額 NT$ :" + total折扣金額 + " 元","確認信用卡付款金額");
            }
        }

        private void button清除_Click(object sender, EventArgs e)
        {
            textBox總金額.Text = "NT $ 0";
            textBox購物清單.Text = "尚未點餐";
            show杯子蛋糕 = "";
            show可麗露 = "";
            show泡芙 = "";
            show抹茶塔 = "";
            money杯子蛋糕金額 = 0;
            money可麗露金額 = 0;
            money泡芙金額 = 0;
            money抹茶塔金額 = 0;
            count杯子蛋糕數量 = 0;
            count可麗露數量 = 0;
            count泡芙數量 = 0;
            count抹茶塔數量 = 0;
            total金額 = 0;
        }

        private void textBox購物清單_TextChanged(object sender, EventArgs e)
        {
            textBox購物清單.Multiline = true; //可擴展成一行以上
            textBox購物清單.ScrollBars = System.Windows.Forms.ScrollBars.Both;  //兩種 卷軸都會出現
        }
    }
}
