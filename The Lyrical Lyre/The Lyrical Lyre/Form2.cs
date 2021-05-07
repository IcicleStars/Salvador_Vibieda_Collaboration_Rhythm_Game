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

namespace The_Lyrical_Lyre
{

    // REMEMBER TO CHANGE THE NAME OF "Song1", "Song2" etc. TO THE ACTUAL SONG!!!

    public partial class FormSelect : Form
    {

        // Create Global Variables
        bool song1 = false, song2 = false, song3 = false, song4 = false, difficultyIn;
        int tick = 0;

        private void btnSong1_Click(object sender, EventArgs e)
        {
            song1 = true;
            song2 = false;
            song3 = false;
            song4 = false;
        }

        private void btnSong2_Click(object sender, EventArgs e)
        {
            song1 = false;
            song2 = true;
            song3 = false;
            song4 = false;
        }

        private void btnSong3_Click(object sender, EventArgs e)
        {
            song1 = false;
            song2 = false;
            song3 = true;
            song4 = false;
        }

        private void btnSong4_Click(object sender, EventArgs e)
        {
            song1 = false;
            song2 = false;
            song3 = false;
            song4 = true;
            animateDifficultyIn();
        }

        private void timerAnimateDifficulty_Tick(object sender, EventArgs e)
        {
            tick += 1;
            lbDifficulty.Left = lbDifficulty.Left + 10;

            if (tick == 33)
            {
                timerAnimateDifficulty.Stop();
            }
            
        }

        SoundPlayer Music; // Plays selected song

        public FormSelect()
        {
            InitializeComponent();
        }

        private void FormSelect_Load(object sender, EventArgs e)
        {
            // Hide Difficulties
            lbDifficulty.Visible = false;
            btnEasy.Visible = false;
            btnMedium.Visible = false;
            btnHard.Visible = false;

            // Start Detection Timer
            timerDetectBool.Start();
        }

        // METHODS BELOW HERE
        private void animateDifficultyIn()
        {
            lbDifficulty.Visible = true;
            btnEasy.Visible = true;
            btnMedium.Visible = true;
            btnHard.Visible = true;
            difficultyIn = true;
            timerAnimateDifficulty.Start();
        }
    }
}
