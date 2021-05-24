
namespace The_Lyrical_Lyre
{
    partial class FormMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::The_Lyrical_Lyre.Properties.Resources.Title;
            this.pictureBox1.Location = new System.Drawing.Point(50, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 88);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.Image = global::The_Lyrical_Lyre.Properties.Resources.start;
            this.startBtn.Location = new System.Drawing.Point(61, 305);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(162, 57);
            this.startBtn.TabIndex = 2;
            this.startBtn.TabStop = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::The_Lyrical_Lyre.Properties.Resources.Genshin_Impact_Venti;
            this.pictureBox2.Location = new System.Drawing.Point(250, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(630, 427);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Lyrical_Lyre.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 537);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(751, 576);
            this.MinimumSize = new System.Drawing.Size(751, 576);
            this.Name = "FormMain";
            this.Text = "Reykjavik Salvador & Keziah Vibieda";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox startBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

