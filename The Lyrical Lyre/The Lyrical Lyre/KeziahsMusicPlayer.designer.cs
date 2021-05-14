namespace Music_Player
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbCurrentSong = new System.Windows.Forms.Label();
            this.listboxSongFilePaths = new System.Windows.Forms.ListBox();
            this.listboxSongNames = new System.Windows.Forms.ListBox();
            this.txtSongFilePath = new System.Windows.Forms.TextBox();
            this.DialogPrompt = new System.Windows.Forms.OpenFileDialog();
            this.albumPic = new System.Windows.Forms.PictureBox();
            this.lbPlaylist = new System.Windows.Forms.Label();
            this.lbPlaylistName = new System.Windows.Forms.Label();
            this.txtPlaylistDescription = new System.Windows.Forms.TextBox();
            this.picStop = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.downloadMoreSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadMenuEnhypen = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadMenuLoona = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadMenuNCTU = new System.Windows.Forms.ToolStripMenuItem();
            this.musicPlayerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicMenuPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.musicMenuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.musicMenuReplay = new System.Windows.Forms.ToolStripMenuItem();
            this.musicMenuForward = new System.Windows.Forms.ToolStripMenuItem();
            this.musicMenuBackward = new System.Windows.Forms.ToolStripMenuItem();
            this.openOpeningFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.albumPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCurrentSong
            // 
            this.lbCurrentSong.AutoSize = true;
            this.lbCurrentSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbCurrentSong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCurrentSong.Location = new System.Drawing.Point(9, 38);
            this.lbCurrentSong.Name = "lbCurrentSong";
            this.lbCurrentSong.Size = new System.Drawing.Size(224, 39);
            this.lbCurrentSong.TabIndex = 4;
            this.lbCurrentSong.Text = "Music Player";
            // 
            // listboxSongFilePaths
            // 
            this.listboxSongFilePaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxSongFilePaths.FormattingEnabled = true;
            this.listboxSongFilePaths.ItemHeight = 16;
            this.listboxSongFilePaths.Location = new System.Drawing.Point(416, 96);
            this.listboxSongFilePaths.Name = "listboxSongFilePaths";
            this.listboxSongFilePaths.Size = new System.Drawing.Size(252, 148);
            this.listboxSongFilePaths.TabIndex = 7;
            this.listboxSongFilePaths.Visible = false;
            // 
            // listboxSongNames
            // 
            this.listboxSongNames.BackColor = System.Drawing.Color.Silver;
            this.listboxSongNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listboxSongNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxSongNames.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listboxSongNames.FormattingEnabled = true;
            this.listboxSongNames.ItemHeight = 25;
            this.listboxSongNames.Location = new System.Drawing.Point(0, 287);
            this.listboxSongNames.Name = "listboxSongNames";
            this.listboxSongNames.Size = new System.Drawing.Size(698, 225);
            this.listboxSongNames.TabIndex = 8;
            this.listboxSongNames.SelectedIndexChanged += new System.EventHandler(this.listboxSongNames_SelectedIndexChanged);
            // 
            // txtSongFilePath
            // 
            this.txtSongFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSongFilePath.Location = new System.Drawing.Point(16, 484);
            this.txtSongFilePath.Name = "txtSongFilePath";
            this.txtSongFilePath.Size = new System.Drawing.Size(641, 23);
            this.txtSongFilePath.TabIndex = 10;
            // 
            // DialogPrompt
            // 
            this.DialogPrompt.FileName = "Pick a Song!";
            // 
            // albumPic
            // 
            this.albumPic.Image = ((System.Drawing.Image)(resources.GetObject("albumPic.Image")));
            this.albumPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("albumPic.InitialImage")));
            this.albumPic.Location = new System.Drawing.Point(16, 81);
            this.albumPic.Name = "albumPic";
            this.albumPic.Size = new System.Drawing.Size(200, 200);
            this.albumPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.albumPic.TabIndex = 12;
            this.albumPic.TabStop = false;
            // 
            // lbPlaylist
            // 
            this.lbPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaylist.ForeColor = System.Drawing.SystemColors.Window;
            this.lbPlaylist.Location = new System.Drawing.Point(235, 96);
            this.lbPlaylist.Name = "lbPlaylist";
            this.lbPlaylist.Size = new System.Drawing.Size(101, 25);
            this.lbPlaylist.TabIndex = 13;
            this.lbPlaylist.Text = "PLAYLIST";
            // 
            // lbPlaylistName
            // 
            this.lbPlaylistName.AutoSize = true;
            this.lbPlaylistName.ForeColor = System.Drawing.Color.White;
            this.lbPlaylistName.Location = new System.Drawing.Point(232, 133);
            this.lbPlaylistName.Name = "lbPlaylistName";
            this.lbPlaylistName.Size = new System.Drawing.Size(164, 39);
            this.lbPlaylistName.TabIndex = 14;
            this.lbPlaylistName.Text = "Playlist 1";
            // 
            // txtPlaylistDescription
            // 
            this.txtPlaylistDescription.BackColor = System.Drawing.Color.Silver;
            this.txtPlaylistDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlaylistDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaylistDescription.ForeColor = System.Drawing.Color.White;
            this.txtPlaylistDescription.Location = new System.Drawing.Point(239, 190);
            this.txtPlaylistDescription.Name = "txtPlaylistDescription";
            this.txtPlaylistDescription.Size = new System.Drawing.Size(189, 23);
            this.txtPlaylistDescription.TabIndex = 15;
            this.txtPlaylistDescription.Text = "Description";
            // 
            // picStop
            // 
            this.picStop.Image = ((System.Drawing.Image)(resources.GetObject("picStop.Image")));
            this.picStop.Location = new System.Drawing.Point(225, 514);
            this.picStop.Name = "picStop";
            this.picStop.Size = new System.Drawing.Size(100, 100);
            this.picStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStop.TabIndex = 18;
            this.picStop.TabStop = false;
            this.picStop.Click += new System.EventHandler(this.picStop_Click);
            // 
            // picNext
            // 
            this.picNext.Image = ((System.Drawing.Image)(resources.GetObject("picNext.Image")));
            this.picNext.Location = new System.Drawing.Point(353, 514);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(100, 100);
            this.picNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNext.TabIndex = 19;
            this.picNext.TabStop = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            // 
            // picBack
            // 
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(96, 514);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(100, 100);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBack.TabIndex = 20;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(491, 514);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.picLoop_Click);
            // 
            // picPlay
            // 
            this.picPlay.Image = ((System.Drawing.Image)(resources.GetObject("picPlay.Image")));
            this.picPlay.Location = new System.Drawing.Point(225, 514);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(100, 100);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlay.TabIndex = 22;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadMoreSongsToolStripMenuItem,
            this.musicPlayerSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // downloadMoreSongsToolStripMenuItem
            // 
            this.downloadMoreSongsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadMenuEnhypen,
            this.downloadMenuLoona,
            this.downloadMenuNCTU});
            this.downloadMoreSongsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.downloadMoreSongsToolStripMenuItem.Name = "downloadMoreSongsToolStripMenuItem";
            this.downloadMoreSongsToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.downloadMoreSongsToolStripMenuItem.Text = "Download More Songs";
            // 
            // downloadMenuEnhypen
            // 
            this.downloadMenuEnhypen.Name = "downloadMenuEnhypen";
            this.downloadMenuEnhypen.Size = new System.Drawing.Size(285, 24);
            this.downloadMenuEnhypen.Text = "Enhypen - Let Me In";
            this.downloadMenuEnhypen.Click += new System.EventHandler(this.downloadMenuEnhypen_Click);
            // 
            // downloadMenuLoona
            // 
            this.downloadMenuLoona.Name = "downloadMenuLoona";
            this.downloadMenuLoona.Size = new System.Drawing.Size(285, 24);
            this.downloadMenuLoona.Text = "Loona - 1200";
            this.downloadMenuLoona.Click += new System.EventHandler(this.downloadMenuLoona_Click);
            // 
            // downloadMenuNCTU
            // 
            this.downloadMenuNCTU.Name = "downloadMenuNCTU";
            this.downloadMenuNCTU.Size = new System.Drawing.Size(285, 24);
            this.downloadMenuNCTU.Text = "NCT U - Neo Got My Back";
            this.downloadMenuNCTU.Click += new System.EventHandler(this.downloadMenuNCTU_Click);
            // 
            // musicPlayerSettingsToolStripMenuItem
            // 
            this.musicPlayerSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicMenuPlay,
            this.musicMenuStop,
            this.musicMenuReplay,
            this.musicMenuForward,
            this.musicMenuBackward,
            this.openOpeningFormToolStripMenuItem});
            this.musicPlayerSettingsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.musicPlayerSettingsToolStripMenuItem.Name = "musicPlayerSettingsToolStripMenuItem";
            this.musicPlayerSettingsToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.musicPlayerSettingsToolStripMenuItem.Text = "Music Player Settings";
            // 
            // musicMenuPlay
            // 
            this.musicMenuPlay.Name = "musicMenuPlay";
            this.musicMenuPlay.Size = new System.Drawing.Size(239, 24);
            this.musicMenuPlay.Text = "Play";
            this.musicMenuPlay.Click += new System.EventHandler(this.musicMenuPlay_Click);
            // 
            // musicMenuStop
            // 
            this.musicMenuStop.Name = "musicMenuStop";
            this.musicMenuStop.Size = new System.Drawing.Size(239, 24);
            this.musicMenuStop.Text = "Stop";
            this.musicMenuStop.Click += new System.EventHandler(this.musicMenuStop_Click);
            // 
            // musicMenuReplay
            // 
            this.musicMenuReplay.Name = "musicMenuReplay";
            this.musicMenuReplay.Size = new System.Drawing.Size(239, 24);
            this.musicMenuReplay.Text = "Replay";
            this.musicMenuReplay.Click += new System.EventHandler(this.musicMenuReplay_Click);
            // 
            // musicMenuForward
            // 
            this.musicMenuForward.Name = "musicMenuForward";
            this.musicMenuForward.Size = new System.Drawing.Size(239, 24);
            this.musicMenuForward.Text = "Forward";
            this.musicMenuForward.Click += new System.EventHandler(this.musicMenuForward_Click);
            // 
            // musicMenuBackward
            // 
            this.musicMenuBackward.Name = "musicMenuBackward";
            this.musicMenuBackward.Size = new System.Drawing.Size(239, 24);
            this.musicMenuBackward.Text = "Backward";
            this.musicMenuBackward.Click += new System.EventHandler(this.musicMenuBackward_Click);
            // 
            // openOpeningFormToolStripMenuItem
            // 
            this.openOpeningFormToolStripMenuItem.Name = "openOpeningFormToolStripMenuItem";
            this.openOpeningFormToolStripMenuItem.Size = new System.Drawing.Size(239, 24);
            this.openOpeningFormToolStripMenuItem.Text = "Open Opening Form";
            //this.openOpeningFormToolStripMenuItem.Click += new System.EventHandler(this.openOpeningFormToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(684, 640);
            this.Controls.Add(this.listboxSongFilePaths);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.picStop);
            this.Controls.Add(this.txtPlaylistDescription);
            this.Controls.Add(this.lbPlaylistName);
            this.Controls.Add(this.lbPlaylist);
            this.Controls.Add(this.albumPic);
            this.Controls.Add(this.txtSongFilePath);
            this.Controls.Add(this.listboxSongNames);
            this.Controls.Add(this.lbCurrentSong);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Form1";
            this.Text = "Keziah Vibieda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.albumPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCurrentSong;
        private System.Windows.Forms.ListBox listboxSongFilePaths;
        private System.Windows.Forms.ListBox listboxSongNames;
        private System.Windows.Forms.TextBox txtSongFilePath;
        private System.Windows.Forms.OpenFileDialog DialogPrompt;
        private System.Windows.Forms.PictureBox albumPic;
        private System.Windows.Forms.Label lbPlaylist;
        private System.Windows.Forms.Label lbPlaylistName;
        private System.Windows.Forms.TextBox txtPlaylistDescription;
        private System.Windows.Forms.PictureBox picStop;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem downloadMoreSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicPlayerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicMenuPlay;
        private System.Windows.Forms.ToolStripMenuItem musicMenuStop;
        private System.Windows.Forms.ToolStripMenuItem musicMenuReplay;
        private System.Windows.Forms.ToolStripMenuItem musicMenuForward;
        private System.Windows.Forms.ToolStripMenuItem musicMenuBackward;
        private System.Windows.Forms.ToolStripMenuItem downloadMenuEnhypen;
        private System.Windows.Forms.ToolStripMenuItem downloadMenuLoona;
        private System.Windows.Forms.ToolStripMenuItem downloadMenuNCTU;
        private System.Windows.Forms.ToolStripMenuItem openOpeningFormToolStripMenuItem;
    }
}

