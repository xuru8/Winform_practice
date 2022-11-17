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
    public partial class 作業06_StudentList : Form
    {
        public 作業06_StudentList()
        {
            InitializeComponent();
        }

        public struct studentInformation
        {
            public string Name;
            public int chineseScore;
            public int englishScore;
            public int mathScore;
            public string maxItem;
            public string minItem;
        }

        //int peopleNumber = 0;  //用集合.Count不用特別再拉一個count出來計算。

        List<studentInformation> students = new List<studentInformation>();

        //List<int> chiHigh_low = new List<int>();  //----------------------------------分別多拉國英數個別的集合去計算
        //List<int> mathHigh_low = new List<int>();  //--------------------------------用集合的Max跟Min方法就可以抓到單獨的最大最小，不用再另外拉集合。
        //List<int> engHigh_low = new List<int>();
        //int totalChiHigh = 0;
        //int totalChilow = 0;

        //int totalEngHigh = 0;
        //int totalEnglow = 0;

        //int totalMathHigh = 0;
        //int totalMathlow = 0;
        ////
        ////
        ////
        //int chiTotal = 0;
        //int mathTotal = 0;
        //int engTotal = 0;

        //double chiAvg = 0;
        //double mathAvg = 0;
        //double engAvg = 0;
        ////
        ////
        ////
        //List<int> chiHighandLow = new List<int>();   //用集合的Max跟Min方法配合if迴圈限縮就可以找到範圍內的國文最大最小，不用另外拉集合。

        void showInformation()
        {
            labelshowall.Text = "";
            foreach (studentInformation student in students)
            {
                int total = student.chineseScore + student.englishScore + student.mathScore;
                double avg = total / 3;
                labelshowall.Text += $"{student.Name,-25}{student.chineseScore,-10}{student.englishScore,-10}{student.mathScore,-10}{total,-10}{avg,-10}{student.minItem,-15}{student.maxItem}\n";
            }
        }

        void showTotal()   //利用集合的Max跟Min方法，從一個集合裡面去單獨抓出國英數來比大小跟統計。
        {
            int totalC = 0;
            int totalE = 0;
            int totalM = 0;

            double avgC = 0;
            double avgE = 0;
            double avgM = 0;

            int Cmax = 0;
            int Cmin = 0;
            int Emax = 0;
            int Emin = 0;
            int Mmax = 0;
            int Mmin = 0;
            label_high_low.Text = "";
            //for (int i = 0; i < students.Count; i++)
            //{
            //    totalC += students[i].chineseScore;

            //}

            foreach (studentInformation student in students)
            {
                totalC += student.chineseScore;
                totalE += student.englishScore;
                totalM += student.mathScore;

                avgC = totalC / students.Count;   //不用另外再多設一個count計算人數
                avgE = totalE / students.Count;
                avgM = totalM / students.Count;

                Cmax = students.Max(max => max.chineseScore);
                Cmin = students.Min(min => min.chineseScore);

                Emax = students.Max(max => max.englishScore);
                Emin = students.Min(min => min.englishScore);

                Mmax = students.Max(max => max.mathScore);
                Mmin = students.Min(min => min.mathScore);
            }
            label_high_low.Text = $"總分{totalC,30}{totalE,10}{totalM,10}\r\n平均{avgC,30}{avgE,10}{avgM,10}\r\n最高分{Cmax,26}{Emax,10}{Mmax,10}\r\n最低分{Cmin,26}{Emin,10}{Mmin,10}\r\n-----------------------------------\n學生人數{students.Count}";
        }



        studentInformation student;   //宣告類別使用裡面設定好的變數，struct不用new，放在外面讓他變成全域變數。
        void studentScore()
        {
            label_high_low.Text = "";
            btnAllTotal.Enabled = true;
            btnDeleteFirst.Enabled = true;
            //peopleNumber++;//計算輸入幾次就可以知道加入的人數有幾個。用集合.count就可以了。

            student.Name = txt_Name.Text;

            student.chineseScore = Convert.ToInt32(txt_Chinese.Text);
            //chiHigh_low.Add(student.chineseScore);   //分別拉集合的方法

            student.englishScore = Convert.ToInt32(txt_English.Text);
            //engHigh_low.Add(student.englishScore);   //分別拉集合的方法

            student.mathScore = Convert.ToInt32(txt_Math.Text);
            //mathHigh_low.Add(student.mathScore);   //分別拉集合的方法

            int[] score比較 = { student.chineseScore, student.englishScore, student.mathScore };
            Array.Sort(score比較);

            if (score比較[0] == student.mathScore)
            {
                student.minItem = $"數學 {student.mathScore}";
            }
            else if (score比較[0] == student.englishScore)
            {
                student.minItem = $"英文 {student.englishScore}";
            }
            else
            {
                student.minItem = $"國文 {student.chineseScore}";
            }

            if (score比較[2] == student.mathScore)
            {
                student.maxItem = $"數學 {student.mathScore}";
            }
            else if (score比較[2] == student.englishScore)
            {
                student.maxItem = $"英文 {student.englishScore}";
            }
            else
            {
                student.maxItem = $"國文 {student.chineseScore}";
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
            studentScore();
            students.Add(student);    //類別裡面的變數都要有給到值，才可以Add進集合。因為student是全域變數了所以可以Add進去集合。
            showInformation();
            }
            catch
            {
                //peopleNumber--; 
                if(students.Count==0)
                {
                btnAllTotal.Enabled = false;
                btnDeleteFirst.Enabled = false;
                }
                MessageBox.Show("請輸入學生資訊", "發生錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateFirst_Click(object sender, EventArgs e)
        {
            try
            {
                studentScore();
                students.Insert(0, student);  //把student  Insert到集合第一個位置
                showInformation();
            }
            catch
            {
                //peopleNumber--;
                if (students.Count == 0)
                {
                    btnAllTotal.Enabled = false;
                    btnDeleteFirst.Enabled = false;
                }
                MessageBox.Show("請輸入學生資訊", "發生錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFirst_Click(object sender, EventArgs e)
        {
            //peopleNumber--;//計算輸入幾次就可以知道加入的人數有幾個。
            label_high_low.Text = "";
            if (students.Count==0)
            {
                btnDeleteFirst.Enabled = false;
                btnAllTotal.Enabled = false;
            }
            students.RemoveAt(0);
            //chiHigh_low.RemoveAt(0);
            //engHigh_low.RemoveAt(0);
            //mathHigh_low.RemoveAt(0);
            showInformation();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //peopleNumber = 0;
            labelshowall.Text = "";
            label_high_low.Text = "";
            students.Clear();
            //chiHigh_low.Clear();
            //engHigh_low.Clear();
            //mathHigh_low.Clear();
            btnAllTotal.Enabled = false;
            btnDeleteFirst.Enabled = false;
            btnInsert.Enabled = true;
            btnUpdateFirst.Enabled = true;
        }

        private void btnAllTotal_Click(object sender, EventArgs e)
        {
            btnInsert.Enabled = false;
            btnUpdateFirst.Enabled = false;
            btnDeleteFirst.Enabled = false;
            showTotal();

            //chiTotal = chiHigh_low.Sum();     //加總------------------在多拉國英數分別的集合去計算
            //engTotal = engHigh_low.Sum();
            //mathTotal = mathHigh_low.Sum();

            //chiAvg = chiTotal / peopleNumber;
            //mathAvg = mathTotal / peopleNumber;
            //engAvg = engTotal / peopleNumber;

            //chiHigh_low.Sort();
            //engHigh_low.Sort();
            //mathHigh_low.Sort();

            //totalChiHigh = chiHigh_low[chiHigh_low.Count - 1];
            //totalChilow = chiHigh_low[0];

            //totalEngHigh = engHigh_low[engHigh_low.Count - 1];
            //totalEnglow = engHigh_low[0];

            //totalMathHigh = mathHigh_low[mathHigh_low.Count - 1];
            //totalMathlow = mathHigh_low[0];

            //label_high_low.Text = $"總分       {chiTotal}    {engTotal}    {mathTotal}\r\n平均         {chiAvg}    {engAvg}    {mathAvg}\r\n最高分     {totalChiHigh}    {totalEngHigh}    {totalMathHigh}\r\n最低分     {totalChilow}    {totalEnglow}    {totalMathlow}\r\n-----------------------------------\n學生人數{peopleNumber}";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int serMin = Convert.ToInt32(txtSerMin.Text);
                int serMax = Convert.ToInt32(txtSerMax.Text);

                int chitotal = 0;
                double chiavg = 0;
                int chiHigh = 0;
                int chiLow = 0;
                int chiSerPeople = 0;

                labelshowall.Text = "";
                foreach (studentInformation student in students) //找全部
                {
                    if ((student.chineseScore > serMin) && (student.chineseScore < serMax))  //排除顯示判斷式以外的，只顯示判斷式要求的範圍。
                    {
                        int total = student.chineseScore + student.englishScore + student.mathScore;
                        double avg = total / 3;
                        labelshowall.Text += $"{student.Name,-25}{student.chineseScore,-10}{student.englishScore,-10}{student.mathScore,-10}{total,-10}{avg,-10}{student.minItem,-15}{student.maxItem}\n";

                        chiSerPeople++;   //計算限縮後的國文有幾筆
                        chitotal += student.chineseScore;  //這邊只累加範圍限縮後的國文成績
                        chiavg = chitotal / chiSerPeople;
                        //chiavg = chitotal / students.Count;    //集合的範圍長度不變，只是這邊找得範圍被限縮。
                        chiHigh = students.Max(max => student.chineseScore);   //去比較限縮後的國文成績
                        chiLow = students.Min(min => student.chineseScore);

                        //chiHighandLow.Add(student.chineseScore); //竟然可以用迴圈增加集合，很方便

                        //chitotal += student.chineseScore;
                        //chiavg = chitotal / chiSerPeople;

                        //chiHighandLow.Sort();
                        //chiHigh = chiHighandLow[chiHighandLow.Count - 1];
                        //chiLow = chiHighandLow[0];
                        label_high_low.Text = $"國文總分{chitotal,22}\r\n國文平均{chiavg,22}\r\n最高分{chiHigh,26}\r\n最低分{chiLow,26}\r\n-----------------------------------\n範圍內學生人數      {chiSerPeople}";
                    }
                }
            }
            catch
            {
                MessageBox.Show("請輸入搜尋範圍","發生錯誤",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void 作業10_StudentList_Load(object sender, EventArgs e)
        {
            btnAllTotal.Enabled = false;
            btnDeleteFirst.Enabled = false;
        }
    }
}
