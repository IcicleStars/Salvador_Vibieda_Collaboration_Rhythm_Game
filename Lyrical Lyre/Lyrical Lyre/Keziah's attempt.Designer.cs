
namespace Lyrical_Lyre
{
    partial class keziahsAttempt
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
            this.blueClick = new System.Windows.Forms.PictureBox();
            this.redClick = new System.Windows.Forms.PictureBox();
            this.tileMover = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.blueClick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redClick)).BeginInit();
            this.SuspendLayout();
            // 
            // blueClick
            // 
            this.blueClick.Image = global::Lyrical_Lyre.Properties.Resources.blue;
            this.blueClick.Location = new System.Drawing.Point(482, 44);
            this.blueClick.Name = "blueClick";
            this.blueClick.Size = new System.Drawing.Size(109, 93);
            this.blueClick.TabIndex = 1;
            this.blueClick.TabStop = false;
            // 
            // redClick
            // 
            this.redClick.Image = global::Lyrical_Lyre.Properties.Resources.red;
            this.redClick.Location = new System.Drawing.Point(164, 44);
            this.redClick.Name = "redClick";
            this.redClick.Size = new System.Drawing.Size(109, 93);
            this.redClick.TabIndex = 0;
            this.redClick.TabStop = false;
            // 
            // tileMover
            // 
            this.tileMover.Tick += new System.EventHandler(this.tileMover_Tick);
            // 
            // keziahsAttempt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.blueClick);
            this.Controls.Add(this.redClick);
            this.Name = "keziahsAttempt";
            this.Text = "keziahForm";
            this.Load += new System.EventHandler(this.keziahsAttempt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blueClick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redClick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox redClick;
        private System.Windows.Forms.PictureBox blueClick;
        private System.Windows.Forms.Timer tileMover;
    }
}