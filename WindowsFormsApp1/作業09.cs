using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Class;

namespace WindowsFormsApp1
{
    public partial class 作業09 : Form
    {

        public 作業09()
        {
            InitializeComponent();
        }

        int ansWer;
        int enTer;
        int min =0;
        int max=100;
        

        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            作業09_guessNumber f1 = (作業09_guessNumber)this.Owner;  //将本窗体的拥有者强制设为Form1类的实例f1
            //f1.Controls["lblshow"].Text = txtEnter.Text;
            ansWer = Convert.ToInt32(f1.Controls["lblAnswer"].Text);
            try
            {
                enTer = Convert.ToInt32(txtEnter.Text);
                if (enTer < 100 && enTer > 0)
                {
                    if (enTer > ansWer)
                    {
                        if (enTer >= max)
                        {
                            MessageBox.Show($"不想死請輸入{min}~{max}之間的數字", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                        max = enTer;
                        f1.Controls["lblshow"].Text = $"太大了，答案介於{min}~{max}之間";    //感覺要用集合去收集每次的enter?
                        }
                    }
                    else if (enTer < ansWer)
                    {
                        if (enTer <= min)
                        {
                            MessageBox.Show($"不想死請輸入{min}~{max}之間的數字", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                        min = enTer;
                        f1.Controls["lblshow"].Text = $"太小了，答案介於{min}~{max}之間";
                        }
                    }
                    else if (enTer == ansWer)
                    {
                        f1.Controls["lblshow"].Text = $"恭喜你存活下來了";
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show($"不想死請輸入{min}~{max}之間的數字", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show($"不想死請輸入{min}~{max}之間的數字","輸入錯誤",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }






        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 作業09_Load(object sender, EventArgs e)
        {
            
        }

    }
}
