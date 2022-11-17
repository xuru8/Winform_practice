
namespace WindowsFormsApp1
{
    partial class 作業05_studentGrade_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Chinese = new System.Windows.Forms.TextBox();
            this.textBox_English = new System.Windows.Forms.TextBox();
            this.textBox_Math = new System.Windows.Forms.TextBox();
            this.button加入 = new System.Windows.Forms.Button();
            this.button隨機加入 = new System.Windows.Forms.Button();
            this.button各科統計 = new System.Windows.Forms.Button();
            this.button重設 = new System.Windows.Forms.Button();
            this.button隨機20 = new System.Windows.Forms.Button();
            this.labelshowall = new System.Windows.Forms.Label();
            this.label_high_low = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "國文:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "英文:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "數學:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(78, 56);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox_Name.TabIndex = 4;
            // 
            // textBox_Chinese
            // 
            this.textBox_Chinese.Location = new System.Drawing.Point(78, 84);
            this.textBox_Chinese.Name = "textBox_Chinese";
            this.textBox_Chinese.Size = new System.Drawing.Size(100, 22);
            this.textBox_Chinese.TabIndex = 5;
            // 
            // textBox_English
            // 
            this.textBox_English.Location = new System.Drawing.Point(78, 112);
            this.textBox_English.Name = "textBox_English";
            this.textBox_English.Size = new System.Drawing.Size(100, 22);
            this.textBox_English.TabIndex = 6;
            // 
            // textBox_Math
            // 
            this.textBox_Math.Location = new System.Drawing.Point(78, 140);
            this.textBox_Math.Name = "textBox_Math";
            this.textBox_Math.Size = new System.Drawing.Size(100, 22);
            this.textBox_Math.TabIndex = 7;
            // 
            // button加入
            // 
            this.button加入.Location = new System.Drawing.Point(56, 185);
            this.button加入.Name = "button加入";
            this.button加入.Size = new System.Drawing.Size(100, 23);
            this.button加入.TabIndex = 8;
            this.button加入.Text = "加入學生資料";
            this.button加入.UseVisualStyleBackColor = true;
            this.button加入.Click += new System.EventHandler(this.button1_Click);
            // 
            // button隨機加入
            // 
            this.button隨機加入.Location = new System.Drawing.Point(56, 214);
            this.button隨機加入.Name = "button隨機加入";
            this.button隨機加入.Size = new System.Drawing.Size(100, 23);
            this.button隨機加入.TabIndex = 9;
            this.button隨機加入.Text = "隨機加入資料";
            this.button隨機加入.UseVisualStyleBackColor = true;
            this.button隨機加入.Click += new System.EventHandler(this.button2_Click);
            // 
            // button各科統計
            // 
            this.button各科統計.Location = new System.Drawing.Point(72, 243);
            this.button各科統計.Name = "button各科統計";
            this.button各科統計.Size = new System.Drawing.Size(75, 23);
            this.button各科統計.TabIndex = 10;
            this.button各科統計.Text = "各科統計";
            this.button各科統計.UseVisualStyleBackColor = true;
            this.button各科統計.Click += new System.EventHandler(this.button3_Click);
            // 
            // button重設
            // 
            this.button重設.Location = new System.Drawing.Point(56, 331);
            this.button重設.Name = "button重設";
            this.button重設.Size = new System.Drawing.Size(100, 23);
            this.button重設.TabIndex = 11;
            this.button重設.Text = "重設所有資料";
            this.button重設.UseVisualStyleBackColor = true;
            this.button重設.Click += new System.EventHandler(this.button重設_Click);
            // 
            // button隨機20
            // 
            this.button隨機20.Location = new System.Drawing.Point(56, 360);
            this.button隨機20.Name = "button隨機20";
            this.button隨機20.Size = new System.Drawing.Size(100, 23);
            this.button隨機20.TabIndex = 12;
            this.button隨機20.Text = "隨機加入20筆";
            this.button隨機20.UseVisualStyleBackColor = true;
            this.button隨機20.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelshowall
            // 
            this.labelshowall.AutoSize = true;
            this.labelshowall.BackColor = System.Drawing.Color.Transparent;
            this.labelshowall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelshowall.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelshowall.Location = new System.Drawing.Point(8, 30);
            this.labelshowall.Name = "labelshowall";
            this.labelshowall.Size = new System.Drawing.Size(2, 19);
            this.labelshowall.TabIndex = 13;
            // 
            // label_high_low
            // 
            this.label_high_low.BackColor = System.Drawing.Color.Transparent;
            this.label_high_low.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_high_low.Location = new System.Drawing.Point(209, 287);
            this.label_high_low.Name = "label_high_low";
            this.label_high_low.Size = new System.Drawing.Size(579, 110);
            this.label_high_low.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelshowall);
            this.panel1.Location = new System.Drawing.Point(209, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 274);
            this.panel1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(559, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "    姓名                     國文     英文     數學        總分     平均       最低           最" +
    "高     ";
            // 
            // 作業05_studentGrade_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_high_low);
            this.Controls.Add(this.button隨機20);
            this.Controls.Add(this.button重設);
            this.Controls.Add(this.button各科統計);
            this.Controls.Add(this.button隨機加入);
            this.Controls.Add(this.button加入);
            this.Controls.Add(this.textBox_Math);
            this.Controls.Add(this.textBox_English);
            this.Controls.Add(this.textBox_Chinese);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "作業05_studentGrade_List";
            this.Text = "作業05_studentGrade_List";
            this.Load += new System.EventHandler(this.作業05_studentGrade_List_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Chinese;
        private System.Windows.Forms.TextBox textBox_English;
        private System.Windows.Forms.TextBox textBox_Math;
        private System.Windows.Forms.Button button加入;
        private System.Windows.Forms.Button button隨機加入;
        private System.Windows.Forms.Button button各科統計;
        private System.Windows.Forms.Button button重設;
        private System.Windows.Forms.Button button隨機20;
        private System.Windows.Forms.Label labelshowall;
        private System.Windows.Forms.Label label_high_low;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}