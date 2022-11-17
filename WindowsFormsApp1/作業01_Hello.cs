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
    public partial class 作業01_Hello : Form
    {
        public 作業01_Hello()
        {
            InitializeComponent();
        }

        //class TT
        //{
        //    string Name;
        //    string EngName;
        //    int Phone;
        //    string cons;
        //}

        string Name;
        string EngName;
        string Gender;
        string cons;

        private void btnHello_Click(object sender, EventArgs e)
        {
            Name = txtName.Text;
            EngName = txtEngName.Text;
            Gender = txtGender.Text;
            cons = txtCons.Text;

            MessageBox.Show($"Hello,我是{Name},\n英文名字是{EngName},\n性別是{Gender},\n星座是{cons},\n很高興認識你。");
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            Name = txtName.Text;
            EngName = txtEngName.Text;
            Gender = txtGender.Text;
            cons = txtCons.Text;

            MessageBox.Show($"Hi,我是{Name},\n英文名字是{EngName},\n性別是{Gender},\n星座是{cons},\n很高興認識你。");
        }
    }
}
