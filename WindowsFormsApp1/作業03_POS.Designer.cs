
namespace WindowsFormsApp1
{
    partial class 作業03_POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(作業03_POS));
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox總金額 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button信用卡付款 = new System.Windows.Forms.Button();
            this.button現金付款 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button泡芙 = new System.Windows.Forms.Button();
            this.button抹茶塔 = new System.Windows.Forms.Button();
            this.button杯子蛋糕 = new System.Windows.Forms.Button();
            this.button可麗露 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button清除 = new System.Windows.Forms.Button();
            this.textBox購物清單 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox總金額);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(263, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 151);
            this.panel2.TabIndex = 6;
            // 
            // textBox總金額
            // 
            this.textBox總金額.BackColor = System.Drawing.Color.Black;
            this.textBox總金額.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox總金額.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox總金額.ForeColor = System.Drawing.Color.White;
            this.textBox總金額.Location = new System.Drawing.Point(20, 78);
            this.textBox總金額.Name = "textBox總金額";
            this.textBox總金額.Size = new System.Drawing.Size(229, 35);
            this.textBox總金額.TabIndex = 1;
            this.textBox總金額.Text = "NT $ 0";
            this.textBox總金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(44, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "總金額  Total Price";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button信用卡付款);
            this.panel3.Controls.Add(this.button現金付款);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(263, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 154);
            this.panel3.TabIndex = 7;
            // 
            // button信用卡付款
            // 
            this.button信用卡付款.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button信用卡付款.Location = new System.Drawing.Point(147, 49);
            this.button信用卡付款.Name = "button信用卡付款";
            this.button信用卡付款.Size = new System.Drawing.Size(102, 46);
            this.button信用卡付款.TabIndex = 3;
            this.button信用卡付款.Text = "信用卡";
            this.button信用卡付款.UseVisualStyleBackColor = true;
            this.button信用卡付款.Click += new System.EventHandler(this.button信用卡付款_Click);
            // 
            // button現金付款
            // 
            this.button現金付款.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button現金付款.Location = new System.Drawing.Point(39, 49);
            this.button現金付款.Name = "button現金付款";
            this.button現金付款.Size = new System.Drawing.Size(102, 46);
            this.button現金付款.TabIndex = 2;
            this.button現金付款.Text = "現金";
            this.button現金付款.UseVisualStyleBackColor = true;
            this.button現金付款.Click += new System.EventHandler(this.button現金付款_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(144, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "信用卡打 9 折！";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(15, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "付款方式 : ";
            // 
            // button泡芙
            // 
            this.button泡芙.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button泡芙.BackgroundImage")));
            this.button泡芙.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button泡芙.Location = new System.Drawing.Point(3, 189);
            this.button泡芙.Name = "button泡芙";
            this.button泡芙.Size = new System.Drawing.Size(118, 111);
            this.button泡芙.TabIndex = 2;
            this.button泡芙.UseVisualStyleBackColor = true;
            this.button泡芙.Click += new System.EventHandler(this.button泡芙_Click);
            // 
            // button抹茶塔
            // 
            this.button抹茶塔.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button抹茶塔.BackgroundImage")));
            this.button抹茶塔.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button抹茶塔.Location = new System.Drawing.Point(127, 189);
            this.button抹茶塔.Name = "button抹茶塔";
            this.button抹茶塔.Size = new System.Drawing.Size(118, 111);
            this.button抹茶塔.TabIndex = 3;
            this.button抹茶塔.UseVisualStyleBackColor = true;
            this.button抹茶塔.Click += new System.EventHandler(this.button抹茶塔_Click);
            // 
            // button杯子蛋糕
            // 
            this.button杯子蛋糕.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button杯子蛋糕.BackgroundImage")));
            this.button杯子蛋糕.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button杯子蛋糕.Location = new System.Drawing.Point(3, 75);
            this.button杯子蛋糕.Name = "button杯子蛋糕";
            this.button杯子蛋糕.Size = new System.Drawing.Size(118, 110);
            this.button杯子蛋糕.TabIndex = 0;
            this.button杯子蛋糕.UseVisualStyleBackColor = true;
            this.button杯子蛋糕.Click += new System.EventHandler(this.button1_Click);
            // 
            // button可麗露
            // 
            this.button可麗露.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button可麗露.BackgroundImage")));
            this.button可麗露.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button可麗露.Location = new System.Drawing.Point(127, 75);
            this.button可麗露.Name = "button可麗露";
            this.button可麗露.Size = new System.Drawing.Size(120, 110);
            this.button可麗露.TabIndex = 1;
            this.button可麗露.UseVisualStyleBackColor = true;
            this.button可麗露.Click += new System.EventHandler(this.button可麗露_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(65, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "菜單  Menu";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button可麗露);
            this.panel1.Controls.Add(this.button杯子蛋糕);
            this.panel1.Controls.Add(this.button抹茶塔);
            this.panel1.Controls.Add(this.button泡芙);
            this.panel1.Location = new System.Drawing.Point(5, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 321);
            this.panel1.TabIndex = 5;
            // 
            // button清除
            // 
            this.button清除.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button清除.Location = new System.Drawing.Point(154, 283);
            this.button清除.Name = "button清除";
            this.button清除.Size = new System.Drawing.Size(96, 35);
            this.button清除.TabIndex = 8;
            this.button清除.Text = "清除清單";
            this.button清除.UseVisualStyleBackColor = true;
            this.button清除.Click += new System.EventHandler(this.button清除_Click);
            // 
            // textBox購物清單
            // 
            this.textBox購物清單.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox購物清單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox購物清單.Location = new System.Drawing.Point(4, 40);
            this.textBox購物清單.Multiline = true;
            this.textBox購物清單.Name = "textBox購物清單";
            this.textBox購物清單.Size = new System.Drawing.Size(251, 237);
            this.textBox購物清單.TabIndex = 9;
            this.textBox購物清單.Text = "尚未點餐";
            this.textBox購物清單.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox購物清單.TextChanged += new System.EventHandler(this.textBox購物清單_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox購物清單);
            this.panel4.Controls.Add(this.button清除);
            this.panel4.Location = new System.Drawing.Point(538, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 321);
            this.panel4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(4, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "購物清單 : ";
            // 
            // 作業POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "作業POS";
            this.Text = "作業POS";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button信用卡付款;
        private System.Windows.Forms.Button button現金付款;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button泡芙;
        private System.Windows.Forms.Button button抹茶塔;
        private System.Windows.Forms.Button button杯子蛋糕;
        private System.Windows.Forms.Button button可麗露;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox總金額;
        private System.Windows.Forms.Button button清除;
        private System.Windows.Forms.TextBox textBox購物清單;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
    }
}