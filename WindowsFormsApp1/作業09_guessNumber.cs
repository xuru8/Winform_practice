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
    public partial class 作業09_guessNumber : Form
    {
        public 作業09_guessNumber()
        {
            InitializeComponent();
        }
        private void 作業09_guessNumber_Load(object sender, EventArgs e)
        {
            lblAnswer.Text = random.Next(1, 100).ToString();
        }


        Random random = new Random();

        public void btnGuess_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = random.Next(1, 100).ToString();
            作業09 report = new 作業09();
            report.ShowDialog(this);  //这个this必不可少（将窗体显示为具有指定所有者：窗体f2的所有者是Form1类当前的对象）
        }
        private void btnShowAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lblAnswer.Text);
        }
    }
}
