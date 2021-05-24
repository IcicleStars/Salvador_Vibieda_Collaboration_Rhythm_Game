using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
//using System.Runtime.InteropServices;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        // Create Instance
        SoundPlayer myPlayer = new SoundPlayer();
        List<String> songs = new List<String>();
        List<String> songFilePaths = new List<String>();

        // Set prefixes and extensions for FilePaths
        string wavExtension = ".wav";
        //string filePathPrefix = "F:\\Coding Projects\\Music Player\\0-Original\\Music Player\\bin\\Debug\\songs\\";
        string filePathPrefix = "songs\\";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set Defaults
            this.KeyPreview = true;
            listboxSongFilePaths.Visible = false;
            albumPic.SizeMode = PictureBoxSizeMode.StretchImage;
            txtPlaylistDescription.ReadOnly = false;
            txtSongFilePath.Visible = false;

            // Populate the SongNames List
            songs.Add("BTS - Dynamite");
            songs.Add("Enhypen - 10 Months");
            songs.Add("Bensound - Ukelele");

            // Transfer Data to a Listbox for display
            for (int i = 0; i < songs.Count; i++)
            {
                listboxSongNames.Items.Add(songs[i]);
            }

            // Populate the songFilePaths list
            songFilePaths.Add(filePathPrefix + "BTS - Dynamite" + wavExtension);
            songFilePaths.Add(filePathPrefix + "Enhypen - 10 Months" + wavExtension);
            songFilePaths.Add(filePathPrefix + "Bensound - Ukulele" + wavExtension);

            // Transfer Data to a Listbox for easy correlation between song names and its file paths
            for (int i = 0; i < songFilePaths.Count; i++)
            {
                listboxSongFilePaths.Items.Add(filePathPrefix + songs[i] + wavExtension);
            }
            
            // Set the First Song Ready to Play
            txtSongFilePath.Text = filePathPrefix + songFilePaths[0] + wavExtension;
            listboxSongNames.SelectedIndex = 0;
            stopSong();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // When User presses Escape, form closes
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void listboxSongNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When a song plays, display on label
            lbCurrentSong.Text = listboxSongNames.SelectedItem.ToString();

            // whenever the user presses a song from the song name listbox, have it correlate with its file path
            listboxSongFilePaths.SelectedIndex = listboxSongNames.SelectedIndex;

            // Whenever the user presses a song, set the file path
            txtSongFilePath.Text = songFilePaths[listboxSongNames.SelectedIndex].ToString();

            // play song
            playSong();
        }

       
        private void openSong()
        {
            // Filter Dialog Prompt to only show Audio Files
            DialogPrompt.Filter = "All Media Files|*.wav;*.acc;*.wma;*.av;*.mpg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;";

            // Prompt User
            DialogPrompt.ShowDialog();

            // List File Path in Textbox
            txtSongFilePath.Text = DialogPrompt.FileName;

            listboxSongFilePaths.Items.Add(DialogPrompt.FileName);
        }

        private void playSong()
        {
            // Set Song
             myPlayer.SoundLocation = txtSongFilePath.Text;

             // Play
             //myPlayer.Play();
        }

     
        private void nextSong()
        {
           
            // find the index of any txtSongFile.Text
            int nextSongIndex = listboxSongNames.SelectedIndex + 1;

            if (nextSongIndex >= listboxSongNames.Items.Count)
            {
                nextSongIndex = 0;
            }

            txtSongFilePath.Text = songFilePaths[nextSongIndex];
            listboxSongNames.SelectedIndex = nextSongIndex;

            //playSong();
        }

        private void stopSong()
        {
            myPlayer.Stop();
        }

        private void loopSong()
        {
            // Set Song
            myPlayer.SoundLocation = txtSongFilePath.Text;

            myPlayer.PlayLooping();

        }

        private void previousSong()
        {
            int previousSongIndex = listboxSongNames.SelectedIndex - 1;

            if (previousSongIndex < 0)
            {
                previousSongIndex = listboxSongNames.Items.Count - 1;
            }

            txtSongFilePath.Text = songFilePaths[previousSongIndex];
            listboxSongNames.SelectedIndex = previousSongIndex;
        }
        private void picPlay_Click(object sender, EventArgs e)
        {
            playSong();
            picPlay.Visible = false;
            picPlay.Enabled = false;
            picStop.Visible = true;
            picStop.Enabled = true;
        }

        private void picStop_Click(object sender, EventArgs e)
        {
            stopSong();
            picStop.Visible = false;
            picStop.Enabled = false;
            picPlay.Visible = true;
            picPlay.Enabled = true;
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            nextSong();
        }

        private void picLoop_Click(object sender, EventArgs e)
        {
            loopSong();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            previousSong();
        }

        private void musicMenuPlay_Click(object sender, EventArgs e)
        {
            playSong();
        }

        private void musicMenuStop_Click(object sender, EventArgs e)
        {
            stopSong();
        }

        private void musicMenuReplay_Click(object sender, EventArgs e)
        {
            loopSong();
        }

        private void musicMenuForward_Click(object sender, EventArgs e)
        {
            nextSong();
        }

        private void musicMenuBackward_Click(object sender, EventArgs e)
        {
            previousSong();
        }

        private void picDownload_Click(object sender, EventArgs e)
        {
            openSong();
            // Filter Dialog Prompt to only show Audio Files
            DialogPrompt.Filter = "All Media Files|*.wav;*.acc;*.wma;*.av;*.mpg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;";

            // Prompt User
            DialogPrompt.ShowDialog();

            // List File Path in Textbox
            txtSongFilePath.Text = filePathPrefix + DialogPrompt.FileName;
        }

        private void downloadSong(ToolStripMenuItem song)
        {
            // Create Variables
            string requestedSong = song.Text;
            string filePath; 

            // Filter Dialog Prompt to only show Audio Files
            /*DialogPrompt.Filter = "All Media Files|*.wav;*.acc;*.wma;*.av;*.mpg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;";

            DialogPrompt.FileName = requestedSong;

            // Prompt User
            DialogPrompt.ShowDialog();*/

            // Assign
            filePath = filePathPrefix + requestedSong + wavExtension;

            // List File Path in Textbox
            txtSongFilePath.Text = filePath;

            // Add to list and listboxes
            listboxSongNames.Items.Add(requestedSong);
            listboxSongFilePaths.Items.Add(filePath);
            songFilePaths.Add(filePath);
        }
        private void downloadMenuEnhypen_Click(object sender, EventArgs e)
        {
            downloadSong(downloadMenuEnhypen);
        }

        private void downloadMenuLoona_Click(object sender, EventArgs e)
        {
            downloadSong(downloadMenuLoona);
        }

        private void downloadMenuNCTU_Click(object sender, EventArgs e)
        {
            downloadSong(downloadMenuNCTU);
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < listboxSongNames.Items.Count; index++)
            {
                nextSong();
            }
        }

        // Create form variable
        The_Lyrical_Lyre.FormMain open;
        private void openOpeningFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open = new The_Lyrical_Lyre.FormMain();
            open.Show();
        }
    }
}

