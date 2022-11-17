
namespace WindowsFormsApp1
{
    partial class 作業06_StudentList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.labelshowall = new System.Windows.Forms.Label();
            this.label_high_low = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAllTotal = new System.Windows.Forms.Button();
            this.btnUpdateFirst = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txt_Math = new System.Windows.Forms.TextBox();
            this.txt_English = new System.Windows.Forms.TextBox();
            this.txt_Chinese = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteFirst = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSerMin = new System.Windows.Forms.TextBox();
            this.txtSerMax = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelshowall);
            this.panel1.Location = new System.Drawing.Point(202, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 274);
            this.panel1.TabIndex = 31;
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
            this.label_high_low.Location = new System.Drawing.Point(202, 289);
            this.label_high_low.Name = "label_high_low";
            this.label_high_low.Size = new System.Drawing.Size(549, 110);
            this.label_high_low.TabIndex = 30;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(54, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "清除所有資料";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAllTotal
            // 
            this.btnAllTotal.Location = new System.Drawing.Point(443, 402);
            this.btnAllTotal.Name = "btnAllTotal";
            this.btnAllTotal.Size = new System.Drawing.Size(75, 23);
            this.btnAllTotal.TabIndex = 27;
            this.btnAllTotal.Text = "各科統計";
            this.btnAllTotal.UseVisualStyleBackColor = true;
            this.btnAllTotal.Click += new System.EventHandler(this.btnAllTotal_Click);
            // 
            // btnUpdateFirst
            // 
            this.btnUpdateFirst.Location = new System.Drawing.Point(54, 182);
            this.btnUpdateFirst.Name = "btnUpdateFirst";
            this.btnUpdateFirst.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateFirst.TabIndex = 26;
            this.btnUpdateFirst.Text = "插入儲存資料";
            this.btnUpdateFirst.UseVisualStyleBackColor = true;
            this.btnUpdateFirst.Click += new System.EventHandler(this.btnUpdateFirst_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(54, 153);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 23);
            this.btnInsert.TabIndex = 25;
            this.btnInsert.Text = "加入學生資料";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txt_Math
            // 
            this.txt_Math.Location = new System.Drawing.Point(75, 125);
            this.txt_Math.Name = "txt_Math";
            this.txt_Math.Size = new System.Drawing.Size(100, 22);
            this.txt_Math.TabIndex = 24;
            // 
            // txt_English
            // 
            this.txt_English.Location = new System.Drawing.Point(75, 97);
            this.txt_English.Name = "txt_English";
            this.txt_English.Size = new System.Drawing.Size(100, 22);
            this.txt_English.TabIndex = 23;
            // 
            // txt_Chinese
            // 
            this.txt_Chinese.Location = new System.Drawing.Point(75, 69);
            this.txt_Chinese.Name = "txt_Chinese";
            this.txt_Chinese.Size = new System.Drawing.Size(100, 22);
            this.txt_Chinese.TabIndex = 22;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(75, 41);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 22);
            this.txt_Name.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "數學:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "英文:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "國文:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "姓名:";
            // 
            // btnDeleteFirst
            // 
            this.btnDeleteFirst.Location = new System.Drawing.Point(54, 211);
            this.btnDeleteFirst.Name = "btnDeleteFirst";
            this.btnDeleteFirst.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteFirst.TabIndex = 29;
            this.btnDeleteFirst.Text = "移除資料";
            this.btnDeleteFirst.UseVisualStyleBackColor = true;
            this.btnDeleteFirst.Click += new System.EventHandler(this.btnDeleteFirst_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(65, 360);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(33, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "搜尋國文成績範圍:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(91, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 26);
            this.label7.TabIndex = 34;
            this.label7.Text = "-";
            // 
            // txtSerMin
            // 
            this.txtSerMin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSerMin.Location = new System.Drawing.Point(26, 315);
            this.txtSerMin.Multiline = true;
            this.txtSerMin.Name = "txtSerMin";
            this.txtSerMin.Size = new System.Drawing.Size(58, 26);
            this.txtSerMin.TabIndex = 35;
            this.txtSerMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSerMax
            // 
            this.txtSerMax.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSerMax.Location = new System.Drawing.Point(117, 315);
            this.txtSerMax.Multiline = true;
            this.txtSerMax.Name = "txtSerMax";
            this.txtSerMax.Size = new System.Drawing.Size(58, 26);
            this.txtSerMax.TabIndex = 36;
            this.txtSerMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 作業06_StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSerMax);
            this.Controls.Add(this.txtSerMin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_high_low);
            this.Controls.Add(this.btnDeleteFirst);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAllTotal);
            this.Controls.Add(this.btnUpdateFirst);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txt_Math);
            this.Controls.Add(this.txt_English);
            this.Controls.Add(this.txt_Chinese);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "作業06_StudentList";
            this.Text = "作業06_StudentList";
            this.Load += new System.EventHandler(this.作業10_StudentList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelshowall;
        private System.Windows.Forms.Label label_high_low;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAllTotal;
        private System.Windows.Forms.Button btnUpdateFirst;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txt_Math;
        private System.Windows.Forms.TextBox txt_English;
        private System.Windows.Forms.TextBox txt_Chinese;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteFirst;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSerMin;
        private System.Windows.Forms.TextBox txtSerMax;
    }
}