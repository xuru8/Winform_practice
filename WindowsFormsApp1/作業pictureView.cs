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
    public partial class 作業pictureView : Form
    {
        public 作業pictureView()
        {
            InitializeComponent();
        }

        private void Showpicture(Button pictureBotton)
        {
            picture picture = new picture();
            picture.Show();
            picture.pictureBox1.Image = pictureBotton.BackgroundImage;
            picture.TopMost = true;
            //picture.BackgroundImage = pictureBotton.BackgroundImage;
        }

        private void btnThunder_Click(object sender, EventArgs e)
        {
            //作業_入口表單 entrance = new 作業_入口表單();
            //entrance.TopMost = true;
            Showpicture(btnThunder);
        }

        private void btnDR_Click(object sender, EventArgs e)
        {
            //作業_入口表單 entrance = new 作業_入口表單();
            //entrance.TopMost = true;
            Showpicture(btnDR);
        }

        private void btnATL_Click(object sender, EventArgs e)
        {
            Showpicture(btnATL);
        }

        private void btnIronMan_Click(object sender, EventArgs e)
        {
            Showpicture(btnIronMan);
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            Showpicture(btnBlack);
        }

        private void btnWitch_Click(object sender, EventArgs e)
        {
            Showpicture(btnWitch);
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            Showpicture(btnGood);
        }

        private void btnHW_Click(object sender, EventArgs e)
        {
            Showpicture(btnHW);
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            Showpicture(btnKill);
        }
    }
}
