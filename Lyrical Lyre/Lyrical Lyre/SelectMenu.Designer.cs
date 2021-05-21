
namespace Lyrical_Lyre
{
    partial class SelectMenu
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
            this.btnSong1 = new System.Windows.Forms.Button();
            this.btnSong2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.lbSong = new System.Windows.Forms.Label();
            this.timerAnimateDifficulty = new System.Windows.Forms.Timer(this.components);
            this.timerAnimateSongs = new System.Windows.Forms.Timer(this.components);
            this.lbDifficulty = new System.Windows.Forms.Label();
            this.timerDetectBool = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSong1
            // 
            this.btnSong1.Location = new System.Drawing.Point(662, 94);
            this.btnSong1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnSong1.Name = "btnSong1";
            this.btnSong1.Size = new System.Drawing.Size(126, 55);
            this.btnSong1.TabIndex = 0;
            this.btnSong1.Text = "button1";
            this.btnSong1.UseVisualStyleBackColor = true;
            // 
            // btnSong2
            // 
            this.btnSong2.Location = new System.Drawing.Point(661, 178);
            this.btnSong2.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnSong2.Name = "btnSong2";
            this.btnSong2.Size = new System.Drawing.Size(127, 55);
            this.btnSong2.TabIndex = 1;
            this.btnSong2.Text = "button2";
            this.btnSong2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 261);
            this.button1.Margin = new System.Windows.Forms.Padding(7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "button2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(661, 339);
            this.button2.Margin = new System.Windows.Forms.Padding(7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(16, 94);
            this.btnEasy.Margin = new System.Windows.Forms.Padding(7);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(126, 55);
            this.btnEasy.TabIndex = 4;
            this.btnEasy.Text = "button1";
            this.btnEasy.UseVisualStyleBackColor = true;
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(16, 178);
            this.btnMedium.Margin = new System.Windows.Forms.Padding(7);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(126, 55);
            this.btnMedium.TabIndex = 5;
            this.btnMedium.Text = "button1";
            this.btnMedium.UseVisualStyleBackColor = true;
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(16, 261);
            this.btnHard.Margin = new System.Windows.Forms.Padding(7);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(126, 55);
            this.btnHard.TabIndex = 6;
            this.btnHard.Text = "button1";
            this.btnHard.UseVisualStyleBackColor = true;
            // 
            // lbSong
            // 
            this.lbSong.AutoSize = true;
            this.lbSong.Location = new System.Drawing.Point(687, 26);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(73, 31);
            this.lbSong.TabIndex = 7;
            this.lbSong.Text = "label1";
            // 
            // timerAnimateDifficulty
            // 
            this.timerAnimateDifficulty.Tick += new System.EventHandler(this.timerAnimateDifficulty_Tick);
            // 
            // lbDifficulty
            // 
            this.lbDifficulty.AutoSize = true;
            this.lbDifficulty.Location = new System.Drawing.Point(40, 26);
            this.lbDifficulty.Name = "lbDifficulty";
            this.lbDifficulty.Size = new System.Drawing.Size(73, 31);
            this.lbDifficulty.TabIndex = 8;
            this.lbDifficulty.Text = "label1";
            // 
            // SelectMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 431);
            this.Controls.Add(this.lbDifficulty);
            this.Controls.Add(this.lbSong);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSong2);
            this.Controls.Add(this.btnSong1);
            this.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "SelectMenu";
            this.Text = "SelectMenu";
            this.Load += new System.EventHandler(this.SelectMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSong1;
        private System.Windows.Forms.Button btnSong2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Label lbSong;
        private System.Windows.Forms.Timer timerAnimateDifficulty;
        private System.Windows.Forms.Timer timerAnimateSongs;
        private System.Windows.Forms.Label lbDifficulty;
        private System.Windows.Forms.Timer timerDetectBool;
    }
}