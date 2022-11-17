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
    public partial class 作業07_螢幕保護 : Form
    {
        public 作業07_螢幕保護()
        {
            InitializeComponent();
            //MessageBox.Show("偵測到嚴重程式錯誤!繼續執行將會導致記憶體損毀!","警告");
        }

        Random R = new Random();


        void buttonmove()
        {

        }

        private void 作業07_螢幕保護_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;     //設定窗體為無邊框樣式
            this.WindowState = FormWindowState.Maximized;    //最大化窗體 
            //Cursor.Hide();  //隱藏滑鼠游標
            //Application.Exit();    //用滑鼠點一下全部表單就會自動結束

            //timer1.Start();
            //            int ixStart = 0;
            //            int iyStart = 0;
            //            if (ixStart == 0 && iyStart == 0 )
            //{
            //                ixStart = e.X;
            //                iyStart = e.Y;
            //                return;
            //            }
            //            else if (e.X != ixStart || e.Y != iyStart)
            //            {
            //                Cursor.Show();
            //                timerSaver.Enabled = false;
            //                Application.Exit();
            //            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Left -= 100;
            button1.Top -= 60;
            //button1.BackColor = Color.AliceBlue;
            button1.ForeColor = Color.Yellow;
            //timer2.Start();

            if (button1.Right < 0 && button1.Bottom < 0)
            {
                button1.Left = R.Next(this.Width - button1.Width);
                button1.Top = R.Next(this.Height - button1.Height);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }

        private void 作業07_螢幕保護_MouseCaptureChanged(object sender, EventArgs e)
        {
            //this.Close();
        }

    }
}
