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
    public partial class 作業_入口表單 : Form
    {
        public 作業_入口表單()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;    //最大化窗體
        }

        private void btnHW01_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            作業01_Hello formHW00 = new 作業01_Hello();
            formHW00.TopLevel = false;
            formHW00.Show();
            this.splitContainer2.Panel2.Controls.Add(formHW00);
        }

        private void btnHW02_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            作業02_貸款試算 formHW02 = new 作業02_貸款試算();
            //Form MdiParent = this; //指定當前窗體為頂級Mdi窗體--->有改子視窗這個不用特別改
            formHW02.TopLevel = false; //指示子窗體非頂級窗體
            //formHW01.Parent = this.splitContainer2.Panel2; //指定子窗體的父容器為--->方法1
            //formHW01.FormBorderStyle = FormBorderStyle.None;//隱藏子窗體邊框，當然也可以在子窗體的窗體載入事件中實現
            formHW02.Show();
            this.splitContainer2.Panel2.Controls.Add(formHW02);  //方法2
        }

        private void btnHW03_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            作業03_POS formHW03 = new 作業03_POS();
            formHW03.TopLevel = false;
            formHW03.Show();
            this.splitContainer2.Panel2.Controls.Add(formHW03);
        }

        private void btnHW04_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            作業04StudentStructForm formHW04 = new 作業04StudentStructForm();
            formHW04.TopLevel = false;
            formHW04.Show();
            this.splitContainer2.Panel2.Controls.Add(formHW04);
        }

        private void btnHW05_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            作業05_studentGrade_List formHW05 = new 作業05_studentGrade_List();
            formHW05.TopLevel = false;
            formHW05.Show();
            this.splitContainer2.Panel2.Controls.Add(formHW05);
        }

        private void btnHW06_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            作業07_OX formHW06 = new 作業07_OX();
            formHW06.TopLevel = false;
            formHW06.Show();
            this.splitContainer2.Panel2.Controls.Add(formHW06);
        }

        private void btnHW07_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            作業08MyClac formHW07 = new 作業08MyClac();
            formHW07.TopLevel = false;
            formHW07.Show();
            this.splitContainer2.Panel2.Controls.Add(formHW07);
        }

        private void btnProtect_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            作業07_螢幕保護 formHW000 = new 作業07_螢幕保護();
            formHW000.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            作業pictureView formPicture = new 作業pictureView();
            formPicture.TopLevel = false;
            formPicture.Show();
            this.splitContainer2.Panel2.Controls.Add(formPicture);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            作業09_guessNumber formGuess = new 作業09_guessNumber();
            //formGuess.TopLevel = false;
            formGuess.Show();
            //this.splitContainer2.Panel2.Controls.Add(formGuess);
        }

        private void btnStudentGL_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            作業06_StudentList formHW08 = new 作業06_StudentList();
            formHW08.TopLevel = false;
            formHW08.Show();
            this.splitContainer2.Panel2.Controls.Add(formHW08);
        }

        private void 作業_入口表單_Load(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            System.Media.SystemSounds.Beep.Play();
            System.Media.SystemSounds.Exclamation.Play();
            System.Media.SystemSounds.Hand.Play();
            System.Media.SystemSounds.Question.Play();
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            作業Time formAlarm = new 作業Time();
            formAlarm.TopLevel = false;
            formAlarm.Show();
            this.splitContainer2.Panel2.Controls.Add(formAlarm);

        }
    }
}
