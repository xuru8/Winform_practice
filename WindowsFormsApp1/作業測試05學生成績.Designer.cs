
namespace WindowsFormsApp1
{
    partial class 作業05學生成績
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
            this.label_high_low = new System.Windows.Forms.Label();
            this.labelshowall = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Math = new System.Windows.Forms.TextBox();
            this.textBox_English = new System.Windows.Forms.TextBox();
            this.textBox_Chinese = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_high_low
            // 
            this.label_high_low.BackColor = System.Drawing.Color.Transparent;
            this.label_high_low.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_high_low.Location = new System.Drawing.Point(202, 311);
            this.label_high_low.Name = "label_high_low";
            this.label_high_low.Size = new System.Drawing.Size(579, 110);
            this.label_high_low.TabIndex = 29;
            // 
            // labelshowall
            // 
            this.labelshowall.BackColor = System.Drawing.Color.Transparent;
            this.labelshowall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelshowall.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelshowall.Location = new System.Drawing.Point(202, 30);
            this.labelshowall.Name = "labelshowall";
            this.labelshowall.Size = new System.Drawing.Size(579, 274);
            this.labelshowall.TabIndex = 28;
            this.labelshowall.Text = "姓名                     國文     英文     數學        總分     平均       最低           最高   " +
    "  ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(49, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "隨機加入20筆";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(49, 352);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "重設所有資料";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(65, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "各科統計";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "隨機加入資料";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "加入學生資料";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Math
            // 
            this.textBox_Math.Location = new System.Drawing.Point(71, 161);
            this.textBox_Math.Name = "textBox_Math";
            this.textBox_Math.Size = new System.Drawing.Size(100, 22);
            this.textBox_Math.TabIndex = 22;
            // 
            // textBox_English
            // 
            this.textBox_English.Location = new System.Drawing.Point(71, 133);
            this.textBox_English.Name = "textBox_English";
            this.textBox_English.Size = new System.Drawing.Size(100, 22);
            this.textBox_English.TabIndex = 21;
            // 
            // textBox_Chinese
            // 
            this.textBox_Chinese.Location = new System.Drawing.Point(71, 105);
            this.textBox_Chinese.Name = "textBox_Chinese";
            this.textBox_Chinese.Size = new System.Drawing.Size(100, 22);
            this.textBox_Chinese.TabIndex = 20;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(71, 77);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox_Name.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "數學:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "英文:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "國文:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "姓名:";
            // 
            // 作業05學生成績
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_high_low);
            this.Controls.Add(this.labelshowall);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Math);
            this.Controls.Add(this.textBox_English);
            this.Controls.Add(this.textBox_Chinese);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "作業05學生成績";
            this.Text = "作業05學生成績";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_high_low;
        private System.Windows.Forms.Label labelshowall;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Math;
        private System.Windows.Forms.TextBox textBox_English;
        private System.Windows.Forms.TextBox textBox_Chinese;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}