
namespace The_Lyrical_Lyre
{
    partial class FormSelect
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSong1 = new System.Windows.Forms.Button();
            this.btnSong2 = new System.Windows.Forms.Button();
            this.btnSong3 = new System.Windows.Forms.Button();
            this.btnSong4 = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.lbSong = new System.Windows.Forms.Label();
            this.lbDifficulty = new System.Windows.Forms.Label();
            this.timerDetectBool = new System.Windows.Forms.Timer(this.components);
            this.timerAnimateDifficulty = new System.Windows.Forms.Timer(this.components);
            this.timerAnimateSong = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1922, 189);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(428, 132);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSong1
            // 
            this.btnSong1.Location = new System.Drawing.Point(459, 136);
            this.btnSong1.Name = "btnSong1";
            this.btnSong1.Size = new System.Drawing.Size(153, 56);
            this.btnSong1.TabIndex = 1;
            this.btnSong1.Text = "Song 1";
            this.btnSong1.UseVisualStyleBackColor = true;
            this.btnSong1.Click += new System.EventHandler(this.btnSong1_Click);
            // 
            // btnSong2
            // 
            this.btnSong2.Location = new System.Drawing.Point(459, 213);
            this.btnSong2.Name = "btnSong2";
            this.btnSong2.Size = new System.Drawing.Size(153, 56);
            this.btnSong2.TabIndex = 2;
            this.btnSong2.Text = "Song 2";
            this.btnSong2.UseVisualStyleBackColor = true;
            this.btnSong2.Click += new System.EventHandler(this.btnSong2_Click);
            // 
            // btnSong3
            // 
            this.btnSong3.Location = new System.Drawing.Point(459, 285);
            this.btnSong3.Name = "btnSong3";
            this.btnSong3.Size = new System.Drawing.Size(153, 56);
            this.btnSong3.TabIndex = 3;
            this.btnSong3.Text = "Song 3";
            this.btnSong3.UseVisualStyleBackColor = true;
            this.btnSong3.Click += new System.EventHandler(this.btnSong3_Click);
            // 
            // btnSong4
            // 
            this.btnSong4.Location = new System.Drawing.Point(459, 362);
            this.btnSong4.Name = "btnSong4";
            this.btnSong4.Size = new System.Drawing.Size(153, 56);
            this.btnSong4.TabIndex = 4;
            this.btnSong4.Text = "Song 4";
            this.btnSong4.UseVisualStyleBackColor = true;
            this.btnSong4.Click += new System.EventHandler(this.btnSong4_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(21, 140);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(145, 59);
            this.btnEasy.TabIndex = 5;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(21, 218);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(145, 59);
            this.btnMedium.TabIndex = 6;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(21, 295);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(145, 59);
            this.btnHard.TabIndex = 7;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // lbSong
            // 
            this.lbSong.AutoSize = true;
            this.lbSong.Location = new System.Drawing.Point(440, 9);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(242, 104);
            this.lbSong.TabIndex = 8;
            this.lbSong.Text = "Select Your\r\nSong";
            this.lbSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDifficulty
            // 
            this.lbDifficulty.AutoSize = true;
            this.lbDifficulty.Location = new System.Drawing.Point(14, 9);
            this.lbDifficulty.Name = "lbDifficulty";
            this.lbDifficulty.Size = new System.Drawing.Size(194, 104);
            this.lbDifficulty.TabIndex = 9;
            this.lbDifficulty.Text = "Select\r\nDifficulty";
            this.lbDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerDetectBool
            // 
            this.timerDetectBool.Interval = 5;
            this.timerDetectBool.Tick += new System.EventHandler(this.timerDetectBool_Tick);
            // 
            // timerAnimateDifficulty
            // 
            this.timerAnimateDifficulty.Interval = 33;
            this.timerAnimateDifficulty.Tick += new System.EventHandler(this.timerAnimateDifficulty_Tick);
            // 
            // timerAnimateSong
            // 
            this.timerAnimateSong.Interval = 33;
            this.timerAnimateSong.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 52F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 455);
            this.Controls.Add(this.lbDifficulty);
            this.Controls.Add(this.lbSong);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.btnSong4);
            this.Controls.Add(this.btnSong3);
            this.Controls.Add(this.btnSong2);
            this.Controls.Add(this.btnSong1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "FormSelect";
            this.Text = "Select Song!";
            this.Load += new System.EventHandler(this.FormSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSong1;
        private System.Windows.Forms.Button btnSong2;
        private System.Windows.Forms.Button btnSong3;
        private System.Windows.Forms.Button btnSong4;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Label lbSong;
        private System.Windows.Forms.Label lbDifficulty;
        private System.Windows.Forms.Timer timerDetectBool;
        private System.Windows.Forms.Timer timerAnimateDifficulty;
        private System.Windows.Forms.Timer timerAnimateSong;
    }
}