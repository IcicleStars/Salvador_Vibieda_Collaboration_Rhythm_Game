using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyrical_Lyre
{
    public partial class SelectMenu : Form
    {
        public SelectMenu()
        {
            InitializeComponent();
        }

        // Create Global Variables
        bool song1 = false, song2 = false, song3 = false, song4 = false, difficultyIn, selected = false;
        int tick = 0, tick2 = 0;

        private void SelectMenu_Load(object sender, EventArgs e)
        {
            // Hide Difficulties
            lbDifficulty.Visible = false;
            btnEasy.Visible = false;
            btnMedium.Visible = false;
            btnHard.Visible = false;

            // Start Detection Timer
            timerDetectBool.Start();
        }

        private void timerAnimateDifficulty_Tick(object sender, EventArgs e)
        {

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

        private void animateSongsOut()
        {
            timerAnimateSong.Start();
        }
    }
}
