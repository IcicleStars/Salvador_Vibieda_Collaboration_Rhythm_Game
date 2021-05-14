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
        bool song1 = false, song2 = false, song3 = false, song4 = false, difficultyIn, selected = false;
        int tick = 0, tick2 = 0;

        private void btnSong1_Click(object sender, EventArgs e)
        {
            song1 = true;
            song2 = false;
            song3 = false;
            song4 = false;
            animateDifficultyIn();
            animateSongsOut();
        }

        private void btnSong2_Click(object sender, EventArgs e)
        {
            song1 = false;
            song2 = true;
            song3 = false;
            song4 = false;
            animateDifficultyIn();
            animateSongsOut();
        }

        private void btnSong3_Click(object sender, EventArgs e)
        {
            song1 = false;
            song2 = false;
            song3 = true;
            song4 = false;
            animateDifficultyIn();
            animateSongsOut();
        }

        private void btnSong4_Click(object sender, EventArgs e)
        {
            song1 = false;
            song2 = false;
            song3 = false;
            song4 = true;
            animateDifficultyIn();
            animateSongsOut();
        }

        private void timerAnimateDifficulty_Tick(object sender, EventArgs e)
        {
            if (selected == false)
            {
                tick += 1;
                lbDifficulty.Left = lbDifficulty.Left + 10;
                btnEasy.Left += 10;
                btnMedium.Left += 10;
                btnHard.Left += 10;

                if (tick == 20)
                {
                    timerAnimateDifficulty.Stop();
                    tick = 0;
                }
            }
            
        }

        SoundPlayer Music; // Plays selected song

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (selected == false)
            {
                tick2 += 1;
                lbSong.Left += 6;

                if (song1)
                {
                    btnSong2.Left += 10;
                    btnSong3.Left += 10;
                    btnSong4.Left += 10;
                }
                else if (song2)
                {
                    btnSong1.Left += 10;
                    btnSong3.Left += 10;
                    btnSong4.Left += 10;
                }
                else if (song3)
                {
                    btnSong2.Left += 10;
                    btnSong1.Left += 10;
                    btnSong4.Left += 10;
                }
                else if (song4) 
                {
                    btnSong2.Left += 10;
                    btnSong3.Left += 10;
                    btnSong1.Left += 10;
                }


                if (tick2 == 20)
                {
                    timerAnimateSong.Stop();
                    tick2 = 0;
                    selected = true;
                }
            }
            else if (selected)
            {
                tick2 += 1;

                if (song1)
                {
                    btnSong1.Left -= 10;

                    if (btnSong4.Left != 659)
                    {
                        btnSong4.Left += 10;
                    }
                    else if (btnSong2.Left != 659)
                    {
                        btnSong2.Left += 10;
                    }
                    else if (btnSong3.Left != 659)
                    {
                        btnSong3.Left += 10;
                    }
                }
                else if (song2)
                {
                    btnSong2.Left -= 10;

                    if (btnSong1.Left != 659)
                    {
                        btnSong1.Left += 10;
                    }
                    else if (btnSong4.Left != 659)
                    {
                        btnSong4.Left += 10;
                    }
                    else if (btnSong3.Left != 659)
                    {
                        btnSong3.Left += 10;
                    }
                }
                else if (song3)
                {
                    btnSong3.Left -= 10;

                    if (btnSong1.Left != 659)
                    {
                        btnSong1.Left += 10;
                    }
                    else if (btnSong2.Left != 659)
                    {
                        btnSong2.Left += 10;
                    }
                    else if (btnSong4.Left != 659)
                    {
                        btnSong4.Left += 10;
                    }
                }
                else if (song4)
                {
                    btnSong4.Left -= 10;

                    if (btnSong1.Left != 659)
                    {
                        btnSong1.Left += 10;
                    }
                    else if (btnSong2.Left != 659)
                    {
                        btnSong2.Left += 10;
                    }
                    else if (btnSong3.Left != 659)
                    {
                        btnSong3.Left += 10;
                    }
                }
                if (tick2 == 20)
                {
                    timerAnimateSong.Stop();
                    tick2 = 0;
                }

            }

        }

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

        private void animateSongsOut()
        {
            timerAnimateSong.Start();
        }
    }
}
