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
    public partial class 作業05_studentGrade_List : Form
    {
        public 作業05_studentGrade_List()
        {
            InitializeComponent();
        }

        string Name;
        int chinese = 0;
        int english = 0;
        int math = 0;
        int total = 0;
        double avg = 0;
        string highscore;
        string lowscore;

        int peopleNumber = 0;

        List<int> chiHigh_low = new List<int>();
        List<int> mathHigh_low = new List<int>();
        List<int> engHigh_low = new List<int>();

        void score比較()
        {
            int[] score比較 = { chinese, english, math };
            Array.Sort(score比較);

            if (score比較[0] == math)
            {
                lowscore = $"數學 {math}";
            }
            else if (score比較[0] == english)
            {
                lowscore = $"英文 {english}";
            }
            else
            {
                lowscore = $"國文 {chinese}";
            }

            if (score比較[2] == math)
            {
                highscore = $"數學 {math}";
            }
            else if (score比較[2] == english)
            {
                highscore = $"英文 {english}";
            }
            else
            {
                highscore = $"國文 {chinese}";
            }

            labelshowall.Text += $"{Name}                            {chinese}         {english}         {math}         {total}        {avg}       {lowscore}        {highscore}\n";
        }

        void random隨機()
        {
            Name = Convert.ToString(peopleNumber);

            Random random = new Random();

            chinese = random.Next(0, 100);
            //chiTotal += chinese;
            chiHigh_low.Add(chinese);


            english = random.Next(0, 100);
            //engTotal += english;
            engHigh_low.Add(english);


            math = random.Next(0, 100);
            //mathTotal += math;
            mathHigh_low.Add(math);


            total = chinese + english + math;
            avg = total / 3;

            score比較();
        }

        //
        //
        //
        int totalChiHigh = 0;
        int totalChilow = 0;

        int totalEngHigh = 0;
        int totalEnglow = 0;

        int totalMathHigh = 0;
        int totalMathlow = 0;
        //
        //
        //
        int chiTotal = 0;
        int mathTotal = 0;
        int engTotal = 0;

        double chiAvg = 0;
        double mathAvg = 0;
        double engAvg = 0;
        //
        //
        //
        private void button1_Click(object sender, EventArgs e)
        {
            peopleNumber++;//計算輸入幾次就可以知道加入的人數有幾個。
            button各科統計.Enabled = true;
            labelshowall.Visible = true;


            if (textBox_Name.Text == "")
            {
                MessageBox.Show("不要瞎掰好嗎", "請輸入正確資訊", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(textBox_Chinese.Text =="")
            {
                MessageBox.Show("不要瞎掰好嗎", "請輸入正確資訊", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(textBox_English.Text =="")
            {
                MessageBox.Show("不要瞎掰好嗎", "請輸入正確資訊", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(textBox_Math.Text=="")
            {
                MessageBox.Show("不要瞎掰好嗎", "請輸入正確資訊", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Name = textBox_Name.Text;

                chinese = Convert.ToInt32(textBox_Chinese.Text);
                //chiTotal += Convert.ToInt32(textBox_Chinese.Text);
                chiHigh_low.Add(chinese);

                english = Convert.ToInt32(textBox_English.Text);
                //engTotal += Convert.ToInt32(textBox_English.Text);
                engHigh_low.Add(english);

                math = Convert.ToInt32(textBox_Math.Text);
                //mathTotal += Convert.ToInt32(textBox_Math.Text);
                mathHigh_low.Add(math);

                total = chinese + english + math;
                avg = total / 3;

                score比較();
            }
        }
        //
        //
        //
        //
        //
        private void button2_Click(object sender, EventArgs e)
        {
            peopleNumber++;//計算輸入幾次就可以知道加入的人數有幾個。
            button各科統計.Enabled = true;
            labelshowall.Visible = true;


            random隨機();
        }   
        
        Random random = new Random();//要放在外面(疑似假隨機)

        private void button5_Click(object sender, EventArgs e)
        {
            peopleNumber++;//計算輸入幾次就可以知道加入的人數有幾個。
            button各科統計.Enabled = true;
            labelshowall.Visible = true;

            for (int i = 0; i < 20; i++)
            {
                Name = Convert.ToString(peopleNumber);
                peopleNumber++;
                

                chinese = random.Next(0, 100);
                //chiTotal += chinese;
                chiHigh_low.Add(random.Next(0, 100));


                english = random.Next(0, 100);
                //engTotal += english;
                engHigh_low.Add(random.Next(0, 100));


                math = random.Next(0, 100);
                //mathTotal += math;
                mathHigh_low.Add(random.Next(0, 100));


                total = chinese + english + math;
                avg = total / 3;

                score比較();
            }
        }

        //
        //
        //
        //
        //
        private void button3_Click(object sender, EventArgs e)
        {
            button加入.Enabled = false;
            button隨機加入.Enabled = false;
            button各科統計.Enabled = false;
            button隨機20.Enabled = false;

            chiTotal = chiHigh_low.Sum();     //加總
            engTotal = engHigh_low.Sum();
            mathTotal = mathHigh_low.Sum();

            chiAvg = chiTotal / peopleNumber;
            mathAvg = mathTotal / peopleNumber;
            engAvg = engTotal / peopleNumber;

            chiHigh_low.Sort();
            engHigh_low.Sort();
            mathHigh_low.Sort();

            totalChiHigh = chiHigh_low[chiHigh_low.Count - 1];
            totalChilow = chiHigh_low[0];

            totalEngHigh = engHigh_low[engHigh_low.Count - 1];
            totalEnglow = engHigh_low[0];

            totalMathHigh = mathHigh_low[mathHigh_low.Count - 1];
            totalMathlow = mathHigh_low[0];

            label_high_low.Text = $"總分       {chiTotal}    {engTotal}    {mathTotal}\r\n平均         {chiAvg}    {engAvg}    {mathAvg}\r\n最高分     {totalChiHigh}    {totalEngHigh}    {totalMathHigh}\r\n最低分     {totalChilow}    {totalEnglow}    {totalMathlow}";
        }      
        


        private void 作業05_studentGrade_List_Load(object sender, EventArgs e)
        {
            button各科統計.Enabled = false;
            labelshowall.Visible = false;
        }

        private void button重設_Click(object sender, EventArgs e)
        {
            Name = "";
            chinese = 0;
            english = 0;
            math = 0;
            total = 0;
            avg = 0;
            highscore = "";
            lowscore="";

            peopleNumber = 0;

            chiHigh_low.Clear();
            engHigh_low.Clear();
            mathHigh_low.Clear();

            labelshowall.Text = "";
            label_high_low.Text= "";

            button加入.Enabled = true;
            button隨機加入.Enabled = true;
            button隨機20.Enabled = true;
            button各科統計.Enabled = false;
            labelshowall.Visible = false;
        }
    }
}
