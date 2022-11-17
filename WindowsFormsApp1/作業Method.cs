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
    public partial class 作業Method : Form
    {
        public 作業Method()
        {
            InitializeComponent();
        }

        int m = 1;
        //int[,] gogo = new int[10, 10];


        private void button6_Click(object sender, EventArgs e)
        {
            string result = "";

            int[,] gogo = new int[10, 10];
            for(int x = 0 ; x < gogo.GetLength(0) ; x++)
            {
                for (int y = 0 ; y < gogo.GetLength(1) ; y++)
                {
                    gogo[x, y] = 0;
                    gogo[0, y] = 1; // 用i沒反應
                    gogo[x, 0] = 1;
                    gogo[9, y] = 1;
                    gogo[x, 9] = 1;


                    result += $" {gogo[x, y]} ";
                }
                result += "\n";
            }

            //int[,] gogo1 = new int[10, 10]
            // {
            //    {0,0,0,0,0,0,0,0,0,0 },
            //    {0,0,0,0,0,0,0,0,0,0 },
            //    {0,0,0,0,0,0,0,0,0,0 },
            //    {0,0,0,0,0,0,0,0,0,0 },
            //    {0,0,0,0,0,0,0,0,0,0 },
            //    {0,0,0,0,0,0,0,0,0,0 },
            //    {0,0,0,0,0,0,0,0,0,0 },
            //    {0,0,0,0,0,0,0,0,0,0 },
            //    {0,0,0,0,0,0,0,0,0,0 },
            //    {0,0,0,0,0,0,0,0,0,0 }
            // };

            //for (int i = 0; i < gogo.GetLength(0); i++)
            //{
            //    for (int j = 0; j < gogo.GetLength(1); j++)
            //    {
            //        gogo[0, j] = m; // 用i沒反應
            //        gogo[i, 0] = m;
            //        gogo[9, i] = m;
            //        gogo[i, 9] = m;

            //        result += $" {gogo[i, j]} ";
            //    }
            //    result += "\n";
            //}
            MessageBox.Show(result);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string result = "";

            int[,] gogo1 = new int[10, 10]
             {
                {0,0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0,0 },
                {0,0,0,0,0,0,0,0,0,0 }
             };

            for (int i = 0; i < gogo1.GetLength(0); i++)
            {
                for (int j = 0; j < gogo1.GetLength(1); j++)
                {
                    gogo1[0, j] = m; // 用i沒反應
                    gogo1[i, 0] = m;
                    gogo1[9, i] = m;
                    gogo1[i, 9] = m;
                    if(gogo1[i, j] == 0)
                    {
                        gogo1[i, j] = 1;
                    }
                    else if (gogo1[i, j] == 1)
                    {
                        gogo1[i, j] = 0;
                    }

                    result += $" {gogo1[i, j]} ";
                }
                result += "\n";
            }
            MessageBox.Show(result);
        }
    }
}
