
namespace WindowsFormsApp1
{
    partial class 作業09_guessNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(作業09_guessNumber));
            this.lblshow = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnShowAns = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblshow
            // 
            this.lblshow.AutoSize = true;
            this.lblshow.BackColor = System.Drawing.Color.Transparent;
            this.lblshow.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblshow.ForeColor = System.Drawing.Color.Red;
            this.lblshow.Location = new System.Drawing.Point(533, 557);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(469, 37);
            this.lblshow.TabIndex = 0;
            this.lblshow.Text = "請任意輸入一個0~100之間的數字!";
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.DimGray;
            this.btnGuess.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGuess.Location = new System.Drawing.Point(845, 429);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(105, 55);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnShowAns
            // 
            this.btnShowAns.BackColor = System.Drawing.Color.Gray;
            this.btnShowAns.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowAns.Location = new System.Drawing.Point(817, 490);
            this.btnShowAns.Name = "btnShowAns";
            this.btnShowAns.Size = new System.Drawing.Size(159, 55);
            this.btnShowAns.TabIndex = 2;
            this.btnShowAns.Text = "Show Answer";
            this.btnShowAns.UseVisualStyleBackColor = false;
            this.btnShowAns.Click += new System.EventHandler(this.btnShowAns_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAnswer.Location = new System.Drawing.Point(852, 24);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(34, 37);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "0";
            this.lblAnswer.Visible = false;
            // 
            // 作業09_guessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 603);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnShowAns);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblshow);
            this.Name = "作業09_guessNumber";
            this.Text = "作業09_guessNumber";
            this.Load += new System.EventHandler(this.作業09_guessNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblshow;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnShowAns;
        public System.Windows.Forms.Label lblAnswer;
    }
}