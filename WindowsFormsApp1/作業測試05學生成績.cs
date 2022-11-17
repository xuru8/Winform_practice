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
    public partial class 作業05學生成績 : Form
    {
        public 作業05學生成績()
        {
            InitializeComponent();
        }

        int totalOnlyone = 0;
        int avgOnlyone = 0;

        int lowOnlyone = 0;
        int highOnlyone = 0;

        List<student> studentScore = new List<student>();


        public struct student
        {
            public string Name;
            public int chineseScore;
            public int mathScore;
            public int englishScore;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student enTer;
            enTer.Name = textBox_Name.Text;
            enTer.chineseScore = Convert.ToInt32(textBox_Chinese.Text);
            enTer.englishScore = Convert.ToInt32(textBox_English.Text);
            enTer.mathScore = Convert.ToInt32(textBox_Math.Text);
            studentScore.Add(enTer);

            //studentScore.Sort();

            showenTer();
        }

        void showenTer()
        {
            labelshowall.Text = $"姓名                     國文     英文     數學     總分     平均     最低     最高     \r\n";

            //foreach (student enTer in studentScore)
            //{
            //    totalOnlyone = enTer.chineseScore + enTer.englishScore + enTer.mathScore;
            //    avgOnlyone = totalOnlyone / 3;

            //    studentScore.Sort();
            //    //
            //    //lowOnlyone = studentScore[0]; 集合裡面有4個項目，如何只找4個中其中一個出來??
            //    //
            //    labelshowall.Text += $"{enTer.Name}        {enTer.chineseScore}   {enTer.englishScore}   {enTer.mathScore}    {totalOnlyone}    {avgOnlyone}\r\n";
            //}
        }
    }
}
