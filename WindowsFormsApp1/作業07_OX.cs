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
    public partial class 作業07_OX : Form
    {
        public 作業07_OX()
        {
            InitializeComponent();
        }

        int count = 0;
        private void winLose()
        {
            //if (count<=9 )
            //{
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")   //串聯式會依序(上到下)跑判斷
            {
                MessageBox.Show("X" + "獲勝");
                restart();
            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                MessageBox.Show("X" + "獲勝");
                restart();
            }
            else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X" + "獲勝");
                restart();
            }
            else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X" + "獲勝");
                restart();
            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                MessageBox.Show("X" + "獲勝");
                restart();
            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X" + "獲勝");
                restart();
            }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                MessageBox.Show("X" + "獲勝");
                restart();
            }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                MessageBox.Show("X" + "獲勝");
                restart();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                MessageBox.Show("O" + "獲勝");
                restart();
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                MessageBox.Show("O" + "獲勝");
                restart();
            }
            else if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O" + "獲勝");
                restart();
            }
            else if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O" + "獲勝");
                restart();
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                MessageBox.Show("O" + "獲勝");
                restart();
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O" + "獲勝");
                restart();
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                MessageBox.Show("O" + "獲勝");
                restart();
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                MessageBox.Show("O" + "獲勝");
                restart();
            }
            else if(count ==9)
            {
                MessageBox.Show("平局！重新再戰！");
                restart();
            }
            //else
            //{
            //    MessageBox.Show("平局！重新再戰！");
            //    restart();
            //}








        }

        private void restart()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            count = 0;
        }

        private void OXbutton(Button button)
        {
            if (count % 2 == 0)
            {
                button.Text = "O";
            }
            else
            {
                button.Text = "X";
            }
            button.Enabled = false;
            count++;
            winLose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OXbutton(button1);
            //if (count % 2 == 0)
            //{
            //    button1.Text = "O";
            //}
            //else
            //{
            //    button1.Text = "X";
            //}
            //button1.Enabled = false;
            //count++;
            //winLose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OXbutton(button2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OXbutton(button8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OXbutton(button7);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OXbutton(button6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OXbutton(button5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OXbutton(button4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OXbutton(button3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OXbutton(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            restart();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
