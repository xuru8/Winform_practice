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
    public partial class 作業04StudentStructForm : Form
    {
        public 作業04StudentStructForm()
        {
            InitializeComponent();
        }

        //public struct Fraction
        //{
        //    public Fraction(string textboxName,int textboxChinese,int textboxEnglish,int textboxMath)
        //    {
        //        Name = textboxName;
        //        scoreChinese = textboxChinese;
        //        scoreEnglish = textboxEnglish;
        //        scoreMath = textboxMath;
        //    }
        //}
        //string scoreShow;
        //int count = 0;
        //int total = 0;

        string Name;
        int chinese = 0;
        int english = 0;
        int math = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            //int scoreC = 0;
            //int scoreE = 0;
            //int scoreM = 0;
            //bool isscoreC = int.TryParse(textBox2.Text, out scoreC);
            //if(isscoreC)
            //{
            //    Fraction 
            //}

            Name =  textBox1.Text;
            chinese = Convert.ToInt32(textBox2.Text);
            english= Convert.ToInt32(textBox3.Text);
            math = Convert.ToInt32(textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = $"姓名 :{Name}\r\n國文 :{chinese} 分\r\n英文 :{english} 分\r\n數學: {math} 分";
        }






    //    public class Score : IComparable<Score>
    //    {
    //        public int Number { get; set; }
    //        public string Name { get; set; }
    //        public Score(string name, int count)
    //        {
    //            this.Name = name;
    //            this.Number = count;
    //        }
    //        public override string ToString()
    //        {
    //            string result = "";
    //            result = "[" + this.Name + "," + this.Number.ToString() + "]";
    //            return result;
    //        }
    //        // list.Sort()時會根據該CompareTo()進行自定義比較
    //        public int CompareTo(Score other)
    //        {
    //            int x = this.Name.CompareTo(other.Name);
    //            if (x == 0)
    //            {
    //                if (this.Number > other.Number)
    //                    x = 1;
    //                else if (this.Number == other.Number)
    //                    x = 0;
    //                else
    //                    x = -1;
    //            }
    //            return x;
    //        }
    //    }

    ////    List<Score> studentList = new List<Score>();
    ////    studentList.Add(new Score("國文", chinese));
    ////        studentList.Add(new Score("數學", math));
    ////        studentList.Add(new Score("英文", engilish));
 
    ////        studentList.Sort();

    ////        foreach (Score myintList in studentList)
    ////        {
    ////            Console.WriteLine(myintList.Name+","+ myintList.Number);
    ////        }
    ////Console.ReadLine();





        private void button3_Click(object sender, EventArgs e)
        {
            int[] max = { chinese, english, math };
            Array.Sort(max);
            //Array.Reverse(max);
            //maxvalue = max[0];
            if (max[2] == math)
            {
                textBox6.Text = $"最高科目成績為:數學 {math} 分\r\n";
            }
            else if(max[2] ==english)
            {
                textBox6.Text = $"最高科目成績為:英文 {english} 分\r\n";
            }
            else
            {
                textBox6.Text = $"最高科目成績為:國文 {chinese} 分\r\n";
            }
            
            int[] min = { chinese, english, math };
            Array.Sort(min);
            //minvalue = min[0];

            if (min[0] == math)
            {
                textBox6.Text += $"最低科目成績為:數學 {math} 分";
            }
            else if (min[0] == english)
            {
                textBox6.Text += $"最低科目成績為:英文 {english} 分";
            }
            else
            {
                textBox6.Text += $"最低科目成績為:國文 {chinese} 分";
            }

            //textBox6.Text = $"最高科目成績為 : {maxvalue}\r\n最低科目成績為 : {minvalue}";



        }
    }
}
